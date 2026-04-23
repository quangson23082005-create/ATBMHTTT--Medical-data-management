using System.Data;
using QLBV.DTO;
using System.Collections.Generic;

namespace QLBV.DAO
{
    public class BenhNhanDAO
    {
        private static BenhNhanDAO instance;
        public static BenhNhanDAO Instance
        {
            get { if (instance == null) instance = new BenhNhanDAO(); return instance; }
            private set { instance = value; }
        }
        private BenhNhanDAO() { }

        // Lấy thông tin cá nhân (VIEW tự lọc theo SESSION_USER)
        public DataTable GetThongTinCaNhan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM ADMIN.V_BENHNHAN_SELF");
        }

        // Lấy danh sách HSBA của bệnh nhân đang đăng nhập
        public DataTable GetHSBA()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM ADMIN.V_HSBA_BN ORDER BY NGAY DESC");
        }

        // Cập nhật thông tin được phép sửa
        public int CapNhatThongTin(BenhNhanDTO dto)
        {
            string sql = $@"UPDATE ADMIN.V_BENHNHAN_SELF SET
                SONHA        = '{dto.SoNha.Replace("'", "''")}',
                TENDUONG     = '{dto.TenDuong.Replace("'", "''")}',
                QUANHUYEN    = '{dto.QuanHuyen.Replace("'", "''")}',
                TINHTP       = '{dto.TinhTP.Replace("'", "''")}',
                TIENSUBENH   = '{dto.TienSuBenh.Replace("'", "''")}',
                TIENSUBENHGD = '{dto.TienSuBenhGD.Replace("'", "''")}',
                DIUNGTHUOC   = '{dto.DiUngThuoc.Replace("'", "''")}'
                WHERE MABN = SYS_CONTEXT('USERENV', 'SESSION_USER')";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
