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

        // ── HSBA ─────────────────────────────────────────────────────────────
        public DataTable GetHSBACuaToi()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, MABN, TO_CHAR(NGAY,'DD/MM/YYYY') AS NGAY, " +
                "CHANDOAN, DIEUTRI, MABS, MAKHOA, KETLUAN " +
                "FROM ADMIN.HSBA ORDER BY NGAY DESC");
        }

        public int CapNhatHSBA(string mahsba, string chandoan, string dieutri, string ketluan)
        {
            string sql = $@"UPDATE ADMIN.HSBA SET
                CHANDOAN = '{chandoan.Replace("'", "''")}',
                DIEUTRI  = '{dieutri.Replace("'", "''")}',
                KETLUAN  = '{ketluan.Replace("'", "''")}' WHERE MAHSBA = '{mahsba}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── HSBA_DV ──────────────────────────────────────────────────────────
        /// <summary>Tat ca DV cua bac si (VPD tu loc) — dung khi chua chon HSBA.</summary>
        public DataTable GetAllHSBA_DV()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, LOAIDV, TO_CHAR(NGAYDV,'DD/MM/YYYY') AS NGAYDV, " +
                "MAKTV, KETQUA FROM ADMIN.HSBA_DV ORDER BY NGAYDV DESC");
        }

        /// <summary>DV cua 1 HSBA cu the.</summary>
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
                WHERE MAHSBA = '{mahsba}'
                  AND LOAIDV = '{loaidv}'
                  AND NGAYDV = TO_DATE('{ngaydv}', 'DD/MM/YYYY')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── BENH NHAN — GIU NGUYEN HOAN TOAN CODE GOC ────────────────────────
        public DataTable GetBenhNhanCuaToi()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MABN, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC " +
                "FROM ADMIN.V_BENHNHAN_EDIT ORDER BY MABN");
        }

        public int CapNhatBenhNhan(string mabn, string tiensu, string tiensuGD, string diung)
        {
            string sql = $@"UPDATE ADMIN.V_BENHNHAN_EDIT SET
                TIENSUBENH    = '{tiensu.Replace("'", "''")}',
                TIENSUBENHGD  = '{tiensuGD.Replace("'", "''")}',
                DIUNGTHUOC    = '{diung.Replace("'", "''")}' WHERE MABN = '{mabn}'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }

        // ── DON THUOC ────────────────────────────────────────────────────────
        /// <summary>Tat ca don thuoc cua bac si (VPD tu loc) — dung khi chua chon HSBA.</summary>
        public DataTable GetAllDonThuoc()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, TO_CHAR(NGAYDT,'DD/MM/YYYY') AS NGAYDT, " +
                "TENTHUOC, LIEUDUNG FROM ADMIN.DONTHUOC ORDER BY NGAYDT DESC");
        }

        /// <summary>Don thuoc cua 1 HSBA cu the.</summary>
        public DataTable GetDonThuoc(string mahsba)
        {
            return DataProvider.Instance.ExecuteQuery(
                $"SELECT MAHSBA, TO_CHAR(NGAYDT,'DD/MM/YYYY') AS NGAYDT, " +
                $"TENTHUOC, LIEUDUNG FROM ADMIN.DONTHUOC " +
                $"WHERE MAHSBA = '{mahsba}' ORDER BY NGAYDT DESC");
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