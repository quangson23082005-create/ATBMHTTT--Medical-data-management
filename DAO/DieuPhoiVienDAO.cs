using System.Data;

namespace QLBV.DAO
{
    public class DieuPhoiVienDAO
    {
        private static DieuPhoiVienDAO instance;
        public static DieuPhoiVienDAO Instance
        {
            get { if (instance == null) instance = new DieuPhoiVienDAO(); return instance; }
            private set { instance = value; }
        }
        private DieuPhoiVienDAO() { }

        // ── BỆNH NHÂN ─────────────────────────────────────────────
        // R_DIEUPHOIVIEN có: GRANT SELECT, INSERT, UPDATE ON admin.BENHNHAN
        // VPD FN_DPV_DR_ON_VIEW_BENHNHAN (policy DPV_TB_BN1, SELECT) → DPV
        //   nhận predicate '1=1' → thấy toàn bộ bệnh nhân.
        // VPD FN_DPV_ON_MODIFYBENHNHAN (policy DPV_TB_BN2, INSERT) → chỉ DPV
        //   mới INSERT được (predicate '1=1'), vai trò khác bị chặn (NULL).
        public DataTable GetAllBenhNhan(string search = "")
        {
            string where = string.IsNullOrWhiteSpace(search)
                ? ""
                : $" WHERE UPPER(MABN)  LIKE '%{search.ToUpper().Replace("'", "''")}%'" +
                  $"    OR UPPER(TENBN) LIKE '%{search.ToUpper().Replace("'", "''")}%'";
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MABN, TENBN, PHAI, " +
                "TO_CHAR(NGAYSINH,'DD/MM/YYYY') AS NGAYSINH, " +
                "CCCD, SONHA, TENDUONG, QUANHUYEN, TINHTP " +
                $"FROM ADMIN.BENHNHAN{where} ORDER BY MABN");
        }

        public int ThemBenhNhan(string mabn, string tenbn, string phai, string ngaysinh,
                                string cccd, string sonha, string tenduong, string quanhuyen,
                                string tinhtp, string tiensu, string tiensuGD, string diung)
        {
            string sql = $@"INSERT INTO ADMIN.BENHNHAN
                (MABN, TENBN, PHAI, NGAYSINH, CCCD,
                 SONHA, TENDUONG, QUANHUYEN, TINHTP,
                 TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC)
                VALUES('{mabn}', '{tenbn}', '{phai}',
                       TO_DATE('{ngaysinh}', 'DD/MM/YYYY'),
                       '{cccd}', '{sonha}', '{tenduong}',
                       '{quanhuyen}', '{tinhtp}',
                       '{tiensu}', '{tiensuGD}', '{diung}')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public int SuaBenhNhan(string mabn, string tenbn, string phai, string ngaysinh,
                               string cccd, string sonha, string tenduong, string quanhuyen,
                               string tinhtp, string tiensu, string tiensuGD, string diung)
        {
            // UPDATE trực tiếp ADMIN.BENHNHAN — DPV có toàn quyền UPDATE.
            // VPD DPV_TB_BN1 (SELECT) + DPV_TB_BN3 (UPDATE, sec_relevant_cols)
            // không chặn DPV vì FN_DPV_DR_ON_VIEW_BENHNHAN trả '1=1' cho DPV.
            string sql = $@"UPDATE ADMIN.BENHNHAN SET
                TENBN       = '{tenbn}',
                PHAI        = '{phai}',
                NGAYSINH    = TO_DATE('{ngaysinh}', 'DD/MM/YYYY'),
                CCCD        = '{cccd}',
                SONHA       = '{sonha}',
                TENDUONG    = '{tenduong}',
                QUANHUYEN   = '{quanhuyen}',
                TINHTP      = '{tinhtp}',
                TIENSUBENH  = '{tiensu}',
                TIENSUBENHGD= '{tiensuGD}',
                DIUNGTHUOC  = '{diung}'
                WHERE MABN  = '{mabn}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── HỒ SƠ BỆNH ÁN ────────────────────────────────────────
        // R_DIEUPHOIVIEN bị REVOKE SELECT, UPDATE ON admin.HSBA (xem vpd.sql).
        // → KHÔNG được SELECT trực tiếp ADMIN.HSBA.
        // DPV chỉ có: GRANT SELECT ON admin.V_HSBA_EDIT (MAHSBA, MABS, MAKHOA)
        //             GRANT UPDATE (MABS, MAKHOA) ON admin.V_HSBA_EDIT
        //             GRANT INSERT ON admin.HSBA
        // VPD FN_DPV_ON_HSBA (policy DPV_TB_HSBA1, SELECT+INSERT+UPDATE) trả
        //   '1=1' cho DPV → DPV thấy / thêm / sửa toàn bộ qua view.
        //
        // GetAllHSBA trả về các cột đủ để DPV thực hiện phân công.
        // Các cột CHANDOAN, DIEUTRI, KETLUAN không nằm trong V_HSBA_EDIT →
        // nếu cần hiển thị thêm, cần bổ sung view hoặc join riêng (xem ghi chú).
        public DataTable GetAllHSBA()
        {
            // V_HSBA_EDIT chỉ gồm MAHSBA, MABS, MAKHOA — đủ cho nghiệp vụ phân công.
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, MABS, MAKHOA FROM ADMIN.V_HSBA_EDIT ORDER BY MAHSBA");
        }

        // INSERT vào ADMIN.HSBA — DPV có GRANT INSERT ON admin.HSBA.
        // VPD DPV_TB_HSBA1 (INSERT) với FN_DPV_ON_HSBA trả '1=1' → cho phép.
        public int ThemHSBA(string mahsba, string mabn, string ngay, string chandoan,
                            string dieutri, string mabs, string makhoa, string ketluan)
        {
            string sql = $@"INSERT INTO ADMIN.HSBA
                (MAHSBA, MABN, NGAY, CHANDOAN, DIEUTRI, MABS, MAKHOA, KETLUAN)
                VALUES('{mahsba}', '{mabn}',
                       TO_DATE('{ngay}', 'DD/MM/YYYY'),
                       '{chandoan}', '{dieutri}',
                       '{mabs}', '{makhoa}', '{ketluan}')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // Cập nhật MABS và MAKHOA (phân công bác sĩ/khoa) qua V_HSBA_EDIT.
        // R_DIEUPHOIVIEN có: GRANT UPDATE (MABS, MAKHOA) ON admin.V_HSBA_EDIT
        // VPD DPV_TB_HSBA1 (UPDATE, sec_relevant_cols: MABS, MAKHOA) → DPV
        //   được phép vì FN_DPV_ON_HSBA trả '1=1'.
        public int CapNhatPhanCong(string mahsba, string mabs, string makhoa)
        {
            string sql = $@"UPDATE ADMIN.V_HSBA_EDIT
                SET MABS   = '{mabs}',
                    MAKHOA = '{makhoa}'
                WHERE MAHSBA = '{mahsba}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── HSBA_DV — điều phối KTV ───────────────────────────────
        // R_DIEUPHOIVIEN có: GRANT UPDATE (MAKTV) ON admin.HSBA_DV
        //                    GRANT SELECT ON admin.V_HSBADV_EDIT (MAHSBA, MAKTV)
        // VPD FN_DPV_ON_HSBADV (policy DPV_TB_HSBADV1, UPDATE,
        //   sec_relevant_cols: MAKTV) → DPV được phép ('1=1').
        //
        // GetHSBA_DV dùng để DPV xem danh sách dịch vụ cần điều phối KTV.
        // Vì DPV không có SELECT trực tiếp HSBA_DV, dùng V_HSBADV_EDIT.
        public DataTable GetHSBA_DV()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, MAKTV FROM ADMIN.V_HSBADV_EDIT ORDER BY MAHSBA");
        }

        // Cập nhật MAKTV cho một dịch vụ cụ thể — UPDATE trực tiếp ADMIN.HSBA_DV
        // với column-level grant UPDATE(MAKTV).
        public int CapNhatKTV(string mahsba, string loaidv, string ngaydv, string maktv)
        {
            string sql = $@"UPDATE ADMIN.HSBA_DV
                SET MAKTV  = '{maktv}'
                WHERE MAHSBA = '{mahsba}'
                  AND LOAIDV = '{loaidv}'
                  AND NGAYDV = TO_DATE('{ngaydv}', 'DD/MM/YYYY')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── Danh sách tra cứu phục vụ phân công ──────────────────
        // ADMIN.NHANVIEN — DPV cần quyền SELECT (cần GRANT riêng nếu chưa có).
        public DataTable GetDanhSachBacSi()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MANV, HOTEN, CHUYENKHOA FROM ADMIN.NHANVIEN " +
                "WHERE VAITRO IN ('Bác sĩ', 'Y tá') ORDER BY MANV");
        }

        public DataTable GetDanhSachKTV()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MANV, HOTEN FROM ADMIN.NHANVIEN " +
                "WHERE VAITRO = 'Kỹ thuật viên' ORDER BY MANV");
        }
    }
}