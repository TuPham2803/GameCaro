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
            this.components = new System.ComponentModel.Container();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.lbTenNguoiChoi = new System.Windows.Forms.Label();
            this.ptbNguoiChoi = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAIMode = new System.Windows.Forms.Button();
            this.btnPlayerMode = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNguoiChoi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGame.Location = new System.Drawing.Point(27, 49);
            this.pnlGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(679, 673);
            this.pnlGame.TabIndex = 0;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlThongTin.Controls.Add(this.pictureBox1);
            this.pnlThongTin.Location = new System.Drawing.Point(714, 49);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(580, 418);
            this.pnlThongTin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiNhom.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(75, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.Controls.Add(this.prcbCoolDown);
            this.pnlSettings.Controls.Add(this.lbTenNguoiChoi);
            this.pnlSettings.Controls.Add(this.ptbNguoiChoi);
            this.pnlSettings.Controls.Add(this.btnReset);
            this.pnlSettings.Controls.Add(this.btnAIMode);
            this.pnlSettings.Controls.Add(this.btnPlayerMode);
            this.pnlSettings.Location = new System.Drawing.Point(714, 477);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(580, 245);
            this.pnlSettings.TabIndex = 2;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(198, 95);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(157, 32);
            this.prcbCoolDown.TabIndex = 6;
            // 
            // lbTenNguoiChoi
            // 
            this.lbTenNguoiChoi.Location = new System.Drawing.Point(171, 26);
            this.lbTenNguoiChoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNguoiChoi.Name = "lbTenNguoiChoi";
            this.lbTenNguoiChoi.Size = new System.Drawing.Size(196, 60);
            this.lbTenNguoiChoi.TabIndex = 5;
            this.lbTenNguoiChoi.Text = "None";
            this.lbTenNguoiChoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbNguoiChoi
            // 
            this.ptbNguoiChoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbNguoiChoi.Location = new System.Drawing.Point(376, 26);
            this.ptbNguoiChoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbNguoiChoi.Name = "ptbNguoiChoi";
            this.ptbNguoiChoi.Size = new System.Drawing.Size(178, 198);
            this.ptbNguoiChoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNguoiChoi.TabIndex = 4;
            this.ptbNguoiChoi.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(4, 165);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 60);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Chơi lại";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAIMode
            // 
            this.btnAIMode.Location = new System.Drawing.Point(4, 95);
            this.btnAIMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAIMode.Name = "btnAIMode";
            this.btnAIMode.Size = new System.Drawing.Size(158, 60);
            this.btnAIMode.TabIndex = 2;
            this.btnAIMode.Text = "Player vs AI";
            this.btnAIMode.UseVisualStyleBackColor = true;
            // 
            // btnPlayerMode
            // 
            this.btnPlayerMode.Location = new System.Drawing.Point(4, 26);
            this.btnPlayerMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayerMode.Name = "btnPlayerMode";
            this.btnPlayerMode.Size = new System.Drawing.Size(158, 60);
            this.btnPlayerMode.TabIndex = 1;
            this.btnPlayerMode.Text = "Player vs Player";
            this.btnPlayerMode.UseVisualStyleBackColor = true;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 740);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNguoiChoi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

