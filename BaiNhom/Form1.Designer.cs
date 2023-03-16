namespace BaiNhom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lbTenNguoiChoi = new System.Windows.Forms.Label();
            this.ptbNguoiChoi = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAIMode = new System.Windows.Forms.Button();
            this.btnPlayerMode = new System.Windows.Forms.Button();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNguoiChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGame.Location = new System.Drawing.Point(12, 19);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(450, 450);
            this.pnlGame.TabIndex = 0;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlThongTin.Controls.Add(this.pictureBox1);
            this.pnlThongTin.Location = new System.Drawing.Point(476, 19);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(387, 285);
            this.pnlThongTin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiNhom.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(50, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.Controls.Add(this.lbTenNguoiChoi);
            this.pnlSettings.Controls.Add(this.ptbNguoiChoi);
            this.pnlSettings.Controls.Add(this.btnReset);
            this.pnlSettings.Controls.Add(this.btnAIMode);
            this.pnlSettings.Controls.Add(this.btnPlayerMode);
            this.pnlSettings.Location = new System.Drawing.Point(476, 310);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(387, 159);
            this.pnlSettings.TabIndex = 2;
            // 
            // lbTenNguoiChoi
            // 
            this.lbTenNguoiChoi.Location = new System.Drawing.Point(114, 17);
            this.lbTenNguoiChoi.Name = "lbTenNguoiChoi";
            this.lbTenNguoiChoi.Size = new System.Drawing.Size(131, 39);
            this.lbTenNguoiChoi.TabIndex = 5;
            this.lbTenNguoiChoi.Text = "None";
            this.lbTenNguoiChoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbNguoiChoi
            // 
            this.ptbNguoiChoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbNguoiChoi.Location = new System.Drawing.Point(251, 17);
            this.ptbNguoiChoi.Name = "ptbNguoiChoi";
            this.ptbNguoiChoi.Size = new System.Drawing.Size(119, 129);
            this.ptbNguoiChoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNguoiChoi.TabIndex = 4;
            this.ptbNguoiChoi.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 107);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 39);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Chơi lại";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAIMode
            // 
            this.btnAIMode.Location = new System.Drawing.Point(3, 62);
            this.btnAIMode.Name = "btnAIMode";
            this.btnAIMode.Size = new System.Drawing.Size(105, 39);
            this.btnAIMode.TabIndex = 2;
            this.btnAIMode.Text = "Player vs AI";
            this.btnAIMode.UseVisualStyleBackColor = true;
            // 
            // btnPlayerMode
            // 
            this.btnPlayerMode.Location = new System.Drawing.Point(3, 17);
            this.btnPlayerMode.Name = "btnPlayerMode";
            this.btnPlayerMode.Size = new System.Drawing.Size(105, 39);
            this.btnPlayerMode.TabIndex = 1;
            this.btnPlayerMode.Text = "Player vs Player";
            this.btnPlayerMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 481);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlThongTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNguoiChoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAIMode;
        private System.Windows.Forms.Button btnPlayerMode;
        private System.Windows.Forms.PictureBox ptbNguoiChoi;
        private System.Windows.Forms.Label lbTenNguoiChoi;
    }
}

