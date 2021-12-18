using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormDetail : Form
    {
        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {//button back ke home
            FormHome FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {//button back ke home
            FormHome FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }

        private void btnWebCatalog_Click(object sender, EventArgs e)
        {//hyperlink ke link e-commerce
            System.Diagnostics.Process.Start("https://secondatebeauty.com/");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {//button logout
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void lblSemuaBarang_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {//logo, direct ke home
            FormHome FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }

        private void panelDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
