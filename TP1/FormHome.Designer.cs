
namespace TP1
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnCari = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUtama = new System.Windows.Forms.Panel();
            this.btnWebCatalog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbRangeHarga = new System.Windows.Forms.ComboBox();
            this.cbJenisBarang = new System.Windows.Forms.ComboBox();
            this.panelCont = new System.Windows.Forms.Panel();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(27, 138);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(65, 32);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(333, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 29);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(877, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 44);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNavbar.Controls.Add(this.pictureBox1);
            this.panelNavbar.Controls.Add(this.panelUtama);
            this.panelNavbar.Controls.Add(this.btnWebCatalog);
            this.panelNavbar.Controls.Add(this.button1);
            this.panelNavbar.Controls.Add(this.label14);
            this.panelNavbar.Controls.Add(this.label3);
            this.panelNavbar.Controls.Add(this.btnLogout);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1246, 87);
            this.panelNavbar.TabIndex = 29;
            this.panelNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(71, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUtama
            // 
            this.panelUtama.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelUtama.Location = new System.Drawing.Point(210, 87);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(1036, 454);
            this.panelUtama.TabIndex = 0;
            // 
            // btnWebCatalog
            // 
            this.btnWebCatalog.FlatAppearance.BorderSize = 0;
            this.btnWebCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebCatalog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWebCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btnWebCatalog.Image")));
            this.btnWebCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebCatalog.Location = new System.Drawing.Point(568, 26);
            this.btnWebCatalog.Name = "btnWebCatalog";
            this.btnWebCatalog.Size = new System.Drawing.Size(167, 36);
            this.btnWebCatalog.TabIndex = 17;
            this.btnWebCatalog.Text = "Web Catalog";
            this.btnWebCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWebCatalog.UseVisualStyleBackColor = true;
            this.btnWebCatalog.Click += new System.EventHandler(this.btnWebCatalog_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(304, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1092, 46);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(119, 27);
            this.label14.TabIndex = 14;
            this.label14.Text = "Abighail Shafira I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1092, 14);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "1908860";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSide.Controls.Add(this.panel3);
            this.panelSide.Controls.Add(this.cbRangeHarga);
            this.panelSide.Controls.Add(this.cbJenisBarang);
            this.panelSide.Controls.Add(this.btnCari);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 87);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(212, 458);
            this.panelSide.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 458);
            this.panel3.TabIndex = 5;
            // 
            // cbRangeHarga
            // 
            this.cbRangeHarga.FormattingEnabled = true;
            this.cbRangeHarga.Location = new System.Drawing.Point(27, 96);
            this.cbRangeHarga.Name = "cbRangeHarga";
            this.cbRangeHarga.Size = new System.Drawing.Size(161, 24);
            this.cbRangeHarga.TabIndex = 4;
            this.cbRangeHarga.Text = "Range Harga";
            this.cbRangeHarga.SelectedIndexChanged += new System.EventHandler(this.cbRangeHarga_SelectedIndexChanged);
            // 
            // cbJenisBarang
            // 
            this.cbJenisBarang.FormattingEnabled = true;
            this.cbJenisBarang.Location = new System.Drawing.Point(27, 52);
            this.cbJenisBarang.Name = "cbJenisBarang";
            this.cbJenisBarang.Size = new System.Drawing.Size(161, 24);
            this.cbJenisBarang.TabIndex = 3;
            this.cbJenisBarang.Text = "Jenis Barang";
            this.cbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cbJenisBarang_SelectedIndexChanged);
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCont.Location = new System.Drawing.Point(213, 87);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(1033, 463);
            this.panelCont.TabIndex = 0;
            this.panelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1246, 545);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to TOKOKU!";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbRangeHarga;
        private System.Windows.Forms.ComboBox cbJenisBarang;
        private System.Windows.Forms.Button btnWebCatalog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelUtama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCont;
    }
}