using System.Windows.Forms;

namespace BaiNhom
{
    public partial class Form1 : Form
    {
        QuanLyBanCo qlbc;

        public Form1()
        {
            InitializeComponent();

            qlbc = new QuanLyBanCo(pnlGame, lbTenNguoiChoi, ptbNguoiChoi);
            qlbc.VeBang();
        }

    }
}
