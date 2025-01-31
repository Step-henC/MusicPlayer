namespace MusicPlayer
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.selectSongs = new System.Windows.Forms.Button();
            this.windowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblCopywrite = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(687, 28);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(8, 6);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(112, 16);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(449, 40);
            this.listBoxSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(227, 329);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // selectSongs
            // 
            this.selectSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectSongs.ForeColor = System.Drawing.Color.White;
            this.selectSongs.Location = new System.Drawing.Point(450, 373);
            this.selectSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectSongs.Name = "selectSongs";
            this.selectSongs.Size = new System.Drawing.Size(226, 62);
            this.selectSongs.TabIndex = 2;
            this.selectSongs.Text = "Select Songs";
            this.selectSongs.UseVisualStyleBackColor = false;
            this.selectSongs.Click += new System.EventHandler(this.selectSongs_Click);
            // 
            // windowsMediaPlayerMusic
            // 
            this.windowsMediaPlayerMusic.Enabled = true;
            this.windowsMediaPlayerMusic.Location = new System.Drawing.Point(12, 39);
            this.windowsMediaPlayerMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windowsMediaPlayerMusic.Name = "windowsMediaPlayerMusic";
            this.windowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayerMusic.OcxState")));
            this.windowsMediaPlayerMusic.Size = new System.Drawing.Size(433, 396);
            this.windowsMediaPlayerMusic.TabIndex = 3;
            // 
            // lblCopywrite
            // 
            this.lblCopywrite.AutoSize = true;
            this.lblCopywrite.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCopywrite.Location = new System.Drawing.Point(185, 438);
            this.lblCopywrite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopywrite.Name = "lblCopywrite";
            this.lblCopywrite.Size = new System.Drawing.Size(179, 13);
            this.lblCopywrite.TabIndex = 4;
            this.lblCopywrite.Text = "Developed By Stephen Cunningham";
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 460);
            this.Controls.Add(this.lblCopywrite);
            this.Controls.Add(this.windowsMediaPlayerMusic);
            this.Controls.Add(this.selectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button selectSongs;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayerMusic;
        private System.Windows.Forms.Label lblCopywrite;
    }
}

