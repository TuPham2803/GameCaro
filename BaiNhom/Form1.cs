using System;
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
            NewGame();
           qlbc.KetThucGame += qlbc_KetThucGame;
            qlbc.ThongBaoClick += qlbc_ThongBaoClick;


            prcbCoolDown.Step = LopHangSo.buocdem;
            prcbCoolDown.Maximum = LopHangSo.tgKetthuc;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = LopHangSo.tgTangmotlan;

         

        }
        void Ketthuc()
        {
            tmCoolDown.Stop();
            pnlGame.Enabled = false;
            MessageBox.Show("Ket thuc!");
        }

         void qlbc_ThongBaoClick(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }
         void qlbc_KetThucGame(object sender, EventArgs e)
        {
            Ketthuc();
        }

       

        private void tmCoolDown_Tick(object sender, System.EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                
                Ketthuc();
                
            }
        }


        void NewGame()
        {
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            qlbc.VeBang();

            
        }
        void Quit()
        {
            Application.Exit();
        }



        void quayVe()
        {
            qlbc.quayVe();
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                                e.Cancel = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
