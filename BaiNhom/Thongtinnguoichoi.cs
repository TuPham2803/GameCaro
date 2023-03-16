using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiNhom
{
    class Thongtinnguoichoi
    {
        private Point point;

        public Point Point { get => point; set => point = value; }
        public int NguoiChoiHienTai { get => nguoiChoiHienTai; set => nguoiChoiHienTai = value; }

        private int nguoiChoiHienTai;

        public Thongtinnguoichoi(Point point,int nguoiChoiHienTai)
        {
            this.point = point;
            this.nguoiChoiHienTai = nguoiChoiHienTai;

        }


    }
}
