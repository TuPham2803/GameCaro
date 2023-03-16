using System.Drawing;

namespace BaiNhom
{
    internal class NguoiChoi
    {
        private string _tenNguoiChoi;
        private Image _hinhDaiDien;

        public string TenNguoiChoi { get => _tenNguoiChoi; set => _tenNguoiChoi = value; }
        public Image HinhDaiDien { get => _hinhDaiDien; set => _hinhDaiDien = value; }

        public NguoiChoi() { }

        public NguoiChoi(string tenNguoiChoi, Image hinhDaiDien)
        {
            this.TenNguoiChoi = tenNguoiChoi;
            this.HinhDaiDien = hinhDaiDien;
        }


    }
}
