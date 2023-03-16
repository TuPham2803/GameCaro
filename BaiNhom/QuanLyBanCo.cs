using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaiNhom
{
    internal class QuanLyBanCo
    {
        private Panel _banCo;
        private Label _tenNguoiChoi;
        private PictureBox _hinhNguoiChoi;
        private List<List<Button>> _maTran;
        private List<NguoiChoi> nguoiChoi;
        private int nguoiChoiHienTai;

        public Panel BanCo { get => _banCo; set => _banCo = value; }
        public Label TenNguoiChoi { get => _tenNguoiChoi; set => _tenNguoiChoi = value; }
        public PictureBox HinhNguoiChoi { get => _hinhNguoiChoi; set => _hinhNguoiChoi = value; }
        public List<List<Button>> MaTran { get => _maTran; set => _maTran = value; }
        internal List<NguoiChoi> NguoiChoi { get => nguoiChoi; set => nguoiChoi = value; }
        public int NguoiChoiHienTai { get => nguoiChoiHienTai; set => nguoiChoiHienTai = value; }
        public Stack<Thongtinnguoichoi> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

        private event EventHandler thongBaoClick;

        public event EventHandler ThongBaoClick
        {
            add
            {
                thongBaoClick += value;
            }
            remove
            {
                thongBaoClick -= value;
            }
        }


        private event EventHandler ketThucGame;

        public event EventHandler KetThucGame
        {
            add
            {
                ketThucGame += value;
            }
            remove
            {
                ketThucGame -= value;
            }
        }

        private Stack<Thongtinnguoichoi> playTimeLine;

        


        public QuanLyBanCo(Panel banCo, Label tenNguoiChoi, PictureBox hinhNguoiChoi)
        {
            this._banCo = banCo;
            this.NguoiChoi = new List<NguoiChoi>()
            {
                new NguoiChoi("Nguoi choi 1", Image.FromFile(LopHangSo.path + "x.PNG")),
                new NguoiChoi("Nguoi choi 2", Image.FromFile(LopHangSo.path + "o.PNG"))
            };
            this._tenNguoiChoi = tenNguoiChoi;
            this._hinhNguoiChoi = hinhNguoiChoi;

            PlayTimeLine = new Stack<Thongtinnguoichoi>();

        }

        


        public void VeBang()
        {
            BanCo.Enabled = true;
            BanCo.Controls.Clear();
            NguoiChoiHienTai = 0;
            thayNguoiChoi();

            MaTran = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };

            for (int i = 0; i < LopHangSo.chieuCaoBanCo; i++)
            {
                MaTran.Add(new List<Button>());
                for (int j = 0; j < LopHangSo.chieuDaiBanCo; j++)
                {
                    Button btn = new Button()
                    {
                        Width = LopHangSo.chieuDaiOCo,
                        Height = LopHangSo.chieuCaoOCo,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    BanCo.Controls.Add(btn);

                    MaTran[i].Add(btn);

                    oldButton = btn;
                }

                oldButton.Location = new Point(0, oldButton.Location.Y + LopHangSo.chieuCaoOCo);
                oldButton.Height = 0;
                oldButton.Width = 0;
            }


        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point point = layViTri(btn);

            if (btn.BackgroundImage != null)
                return;

            hienHinhNguoiChoi(btn);

            PlayTimeLine.Push(new Thongtinnguoichoi(layViTri(btn),nguoiChoiHienTai));


            NguoiChoiHienTai = NguoiChoiHienTai == 0 ? 1 : 0;
            thayNguoiChoi();

            if (thongBaoClick != null)
            {
                thongBaoClick(this, new EventArgs());
            }
            if (isKetThuc(btn))
            {
                KetThuc();
            }

     
        }

        private void hienHinhNguoiChoi(Button btn)
        {
            btn.BackgroundImage = NguoiChoi[NguoiChoiHienTai].HinhDaiDien;

            
        }

        private void thayNguoiChoi()
        {
            _hinhNguoiChoi.Image = NguoiChoi[NguoiChoiHienTai].HinhDaiDien;
            _tenNguoiChoi.Text = NguoiChoi[nguoiChoiHienTai].TenNguoiChoi;
        }

        public void KetThuc()
        {
            /*if (isKetThuc(btn))
            {
                MessageBox.Show("Ket thuc");
            }*/
            if (ketThucGame != null)
                ketThucGame(this, new EventArgs());
        }

        private Point layViTri(Button btn)
        {
            int ngang = Convert.ToInt32(btn.Tag);
            int doc = MaTran[ngang].IndexOf(btn);

            Point point = new Point(doc, ngang);

            return point;
        }

        private bool isKetThuc(Button btn)
        {

            return isKetThucNgang(btn) || isKetThucDoc(btn) || isKetThucCheo(btn) || isKetThucCheoPhu(btn);
        }

        private bool isKetThucNgang(Button btn)
        {
            Point point = layViTri(btn);

            int demBenTrai = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (MaTran[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTrai++;
                }
                else
                    break;
            }

            int demBenPhai = 0;
            for (int i = point.X + 1; i < LopHangSo.chieuDaiBanCo; i++)
            {
                if (MaTran[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    demBenPhai++;
                }
                else
                    break;
            }

            return demBenPhai + demBenTrai == 5;
        }

        private bool isKetThucDoc(Button btn)
        {
            Point point = layViTri(btn);

            int demBenTren = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (MaTran[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    demBenTren++;
                }
                else
                    break;
            }

            int demBenDuoi = 0;
            for (int i = point.Y + 1; i < LopHangSo.chieuCaoBanCo; i++)
            {
                if (MaTran[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    demBenDuoi++;
                }
                else
                    break;
            }

            return demBenDuoi + demBenTren == 5;
        }

        private bool isKetThucCheo(Button btn)
        {
            Point point = layViTri(btn);

            int demBenTren = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (MaTran[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    demBenTren++;
                else
                    break;
            }

            int demBenDuoi = 0;
            for (int i = 1; i <= LopHangSo.chieuDaiBanCo - point.X; i++)
            {
                if (point.Y + i >= LopHangSo.chieuCaoBanCo || point.X + i >= LopHangSo.chieuDaiBanCo)
                    break;

                if (MaTran[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    demBenDuoi++;
                else
                    break;
            }

            return demBenDuoi + demBenTren == 5;
        }

        private bool isKetThucCheoPhu(Button btn)
        {
            Point point = layViTri(btn);

            int demBenTren = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > LopHangSo.chieuDaiBanCo || point.Y - i < 0)
                    break;

                if (MaTran[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    demBenTren++;
                else
                    break;
            }

            int demBenDuoi = 0;
            for (int i = 1; i <= LopHangSo.chieuDaiBanCo - point.X; i++)
            {
                if (point.Y + i >= LopHangSo.chieuCaoBanCo || point.X - i < 0)
                    break;

                if (MaTran[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    demBenDuoi++;
                else
                    break;
            }

            return demBenDuoi + demBenTren == 5;
        }

        public bool quayVe()
        {
            Thongtinnguoichoi diemCu = PlayTimeLine.Pop();
            Button btn = MaTran[diemCu.Point.Y][diemCu.Point.X];
            btn.BackgroundImage = null;


            nguoiChoiHienTai = PlayTimeLine.Peek().NguoiChoiHienTai == 1 ? 0 : 1; 
            thayNguoiChoi();
            return true;
        }
      
     

    }
}
