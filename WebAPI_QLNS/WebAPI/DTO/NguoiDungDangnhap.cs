namespace WebAPI_QLNS.DTO
{
    public class NguoiDungDangnhap:NguoiDung
    {
        public string TenNhanVien { set; get; }
        public string SoDT { set; get; }
        public string Email { set; get; }
        public int NhanVienId { set; get; }
    }
}
