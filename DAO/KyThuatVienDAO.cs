using System.Data;

namespace QLBV.DAO
{
    public class KyThuatVienDAO
    {
        private static KyThuatVienDAO instance;
        public static KyThuatVienDAO Instance
        {
            get { if (instance == null) instance = new KyThuatVienDAO(); return instance; }
            private set { instance = value; }
        }
        private KyThuatVienDAO() { }

        // Lấy danh sách dịch vụ được giao (VIEW tự lọc theo MAKTV = SESSION_USER)
        public DataTable GetDanhSachDichVu()
        {
            return DataProvider.Instance.ExecuteQuery(
                "SELECT MAHSBA, LOAIDV, TO_CHAR(NGAYDV,'DD/MM/YYYY') AS NGAYDV, MAKTV, KETQUA " +
                "FROM ADMIN.V_HSBA_DV_KTV ORDER BY NGAYDV DESC");
        }

        // Cập nhật kết quả (chỉ được phép sửa cột KETQUA)
        public int CapNhatKetQua(string mahsba, string loaidv, string ngaydv, string ketqua)
        {
            // Dùng TRIM() để loại bỏ khoảng trắng thừa (nếu dùng kiểu CHAR trong CSDL)
            // Dùng TRUNC() để chỉ so sánh Ngày/Tháng/Năm, bỏ qua Giờ/Phút/Giây
            string sql = $@"UPDATE ADMIN.V_HSBA_DV_KTV
                SET KETQUA = '{ketqua.Replace("'", "''")}'
                WHERE TRIM(MAHSBA) = '{mahsba.Trim()}'
                  AND TRIM(LOAIDV) = '{loaidv.Trim()}'
                  AND TRUNC(NGAYDV) = TO_DATE('{ngaydv}', 'DD/MM/YYYY')";

            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
