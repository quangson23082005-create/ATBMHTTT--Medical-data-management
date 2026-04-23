namespace QLBV.DTO
{
    public class BenhNhanDTO
    {
        // Chỉ đọc (không cho sửa)
        public string MaBN       { get; set; }
        public string TenBN      { get; set; }
        public string Phai       { get; set; }
        public string NgaySinh   { get; set; }
        public string CCCD       { get; set; }

        // Được phép cập nhật
        public string SoNha        { get; set; }
        public string TenDuong     { get; set; }
        public string QuanHuyen    { get; set; }
        public string TinhTP       { get; set; }
        public string TienSuBenh   { get; set; }
        public string TienSuBenhGD { get; set; }
        public string DiUngThuoc   { get; set; }
    }
}
