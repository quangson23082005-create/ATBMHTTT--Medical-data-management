using System.Data;

namespace QLBV.DAO
{
    public class BacSiDAO
    {
        private static BacSiDAO instance;
        public static BacSiDAO Instance
        {
            get { if (instance == null) instance = new BacSiDAO(); return instance; }
            private set { instance = value; }
        }
        private BacSiDAO() { }

        // ── HSBA của bác sĩ đang login ─────────────────────────────
        // VPD FN_DR_ON_HSBA (policy DPV_TB_HSBA2) áp SELECT trên ADMIN.HSBA,
        // tự động lọc MABS = SESSION_USER → không cần WHERE thủ công.
        // sec_relevant_cols: CHANDOAN, DIEUTRI, KETLUAN — các cột này chỉ hiện
        // khi predicate khớp (mabs = current user), nên SELECT * an toàn.
        public DataTable GetHSBACuaToi()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, MABN, TO_CHAR(NGAY,'DD/MM/YYYY') AS NGAY, " +
                "CHANDOAN, DIEUTRI, MABS, MAKHOA, KETLUAN " +
                "FROM ADMIN.HSBA ORDER BY NGAY DESC");
        }

        // Cập nhật CHANDOAN, DIEUTRI, KETLUAN —
        // VPD FN_DR_ON_HSBA (DPV_TB_HSBA2, UPDATE) + update_check=TRUE đảm bảo
        // chỉ cập nhật được HSBA của chính bác sĩ đang login.
        // R_BACSI có: GRANT UPDATE (CHANDOAN, DIEUTRI, KETLUAN) ON admin.HSBA
        public int CapNhatHSBA(string mahsba, string chandoan, string dieutri, string ketluan)
        {
            string sql = $@"UPDATE ADMIN.HSBA SET
                CHANDOAN = '{chandoan.Replace("'", "''")}',
                DIEUTRI  = '{dieutri.Replace("'", "''")}',
                KETLUAN  = '{ketluan.Replace("'", "''")}' WHERE MAHSBA = '{mahsba}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── HSBA_DV ────────────────────────────────────────────────
        // VPD FN_DR_ON_HSBADV (policy DPV_TB_HSBADV2) áp SELECT, INSERT, DELETE
        // → tự động giới hạn theo MAHSBA thuộc HSBA của bác sĩ đang login.
        // R_BACSI có: GRANT SELECT, INSERT, DELETE ON admin.HSBA_DV
        public DataTable GetHSBA_DV(string mahsba)
        {
            return DataProvider.Instance.ExecuteQuery(
                $"SELECT MAHSBA, LOAIDV, TO_CHAR(NGAYDV,'DD/MM/YYYY') AS NGAYDV, " +
                $"MAKTV, KETQUA FROM ADMIN.HSBA_DV " +
                $"WHERE MAHSBA = '{mahsba}' ORDER BY NGAYDV DESC");
        }

        public int ThemHSBA_DV(string mahsba, string loaidv, string ngaydv, string maktv)
        {
            string sql = $@"INSERT INTO ADMIN.HSBA_DV(MAHSBA, LOAIDV, NGAYDV, MAKTV, KETQUA)
                VALUES('{mahsba}', '{loaidv}',
                       TO_DATE('{ngaydv}', 'DD/MM/YYYY'),
                       '{maktv}', 'Chua co ket qua')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public int XoaHSBA_DV(string mahsba, string loaidv, string ngaydv)
        {
            string sql = $@"DELETE FROM ADMIN.HSBA_DV
                WHERE MAHSBA  = '{mahsba}'
                  AND LOAIDV  = '{loaidv}'
                  AND NGAYDV  = TO_DATE('{ngaydv}', 'DD/MM/YYYY')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── BỆNH NHÂN (chỉ 3 trường theo TC#3d) ───────────────────
        // R_BACSI có: GRANT SELECT ON admin.V_BENHNHAN_EDIT
        // View V_BENHNHAN_EDIT = SELECT MABN, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC FROM BENHNHAN
        // VPD FN_DR_ON_VIEW_BENHNHAN (policy DPV_TB_BN3, SELECT) lọc chỉ những
        // bệnh nhân liên quan HSBA của bác sĩ đang login.
        // → Phải SELECT từ V_BENHNHAN_EDIT, KHÔNG SELECT trực tiếp ADMIN.BENHNHAN.
        public DataTable GetBenhNhanCuaToi()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MABN, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC " +
                "FROM ADMIN.V_BENHNHAN_EDIT ORDER BY MABN");
        }

        // R_BACSI có: GRANT UPDATE (TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC) ON admin.BENHNHAN
        // VPD FN_DR_ON_VIEW_BENHNHAN (policy DPV_TB_BN3, UPDATE) + update_check=TRUE
        // → chỉ cập nhật được bệnh nhân thuộc HSBA của bác sĩ đang login.
        public int CapNhatBenhNhan(string mabn, string tiensu, string tiensuGD, string diung)
        {
            string sql = $@"UPDATE ADMIN.BENHNHAN SET
                TIENSUBENH    = '{tiensu.Replace("'", "''")}',
                TIENSUBENHGD  = '{tiensuGD.Replace("'", "''")}',
                DIUNGTHUOC    = '{diung.Replace("'", "''")}' WHERE MABN = '{mabn}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── ĐƠN THUỐC ─────────────────────────────────────────────
        // VPD FN_DR_ON_DONTHUOC (policy DPV_TB_DONTHUOC1) áp SELECT, INSERT,
        // UPDATE, DELETE với sec_relevant_cols: TENTHUOC, LIEUDUNG.
        // R_BACSI có: GRANT SELECT, INSERT, DELETE ON admin.DONTHUOC
        //             GRANT UPDATE (TENTHUOC, LIEUDUNG) ON admin.DONTHUOC
        // Predicate tự động lọc MAHSBA ∈ HSBA của bác sĩ đang login.
        public DataTable GetDonThuoc(string mahsba)
        {
            return DataProvider.Instance.ExecuteQuery(
                $"SELECT MAHSBA, TO_CHAR(NGAYDT,'DD/MM/YYYY') AS NGAYDT, " +
                $"TENTHUOC, LIEUDUNG FROM ADMIN.DONTHUOC " +
                $"WHERE MAHSBA = '{mahsba}' ORDER BY NGAYDT");
        }

        public int ThemDonThuoc(string mahsba, string ngaydt, string tenthuoc, string lieudung)
        {
            string sql = $@"INSERT INTO ADMIN.DONTHUOC(MAHSBA, NGAYDT, TENTHUOC, LIEUDUNG)
                VALUES('{mahsba}',
                       TO_DATE('{ngaydt}', 'DD/MM/YYYY'),
                       '{tenthuoc.Replace("'", "''")}',
                       '{lieudung.Replace("'", "''")}')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public int XoaDonThuoc(string mahsba, string tenthuoc)
        {
            string sql = $"DELETE FROM ADMIN.DONTHUOC " +
                         $"WHERE MAHSBA = '{mahsba}' " +
                         $"AND TENTHUOC = '{tenthuoc.Replace("'", "''")}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // UPDATE chỉ được trên cột TENTHUOC, LIEUDUNG (column-level grant + VPD).
        public int CapNhatDonThuoc(string mahsba, string tenthuocCu, string tenthuocMoi, string lieudung)
        {
            string sql = $@"UPDATE ADMIN.DONTHUOC SET
                TENTHUOC = '{tenthuocMoi.Replace("'", "''")}',
                LIEUDUNG = '{lieudung.Replace("'", "''")}' WHERE MAHSBA = '{mahsba}'
                AND TENTHUOC = '{tenthuocCu.Replace("'", "''")}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}