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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            ListItem listitem = new ListItem();
            ControlClass.showControl(listitem, panelCont);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.jenis = Convert.ToString(cbJenisBarang.Text);
            item.harga = Convert.ToString(cbRangeHarga.Text);

            if(cbJenisBarang.Text == "Elektronik")
            {
                if(cbRangeHarga.Text == "500rb - 1jt")
                {
                    ControlElektronik elektronik = new ControlElektronik();
                    ControlClass.showControl(elektronik, panelCont);
                }
                else
                {
                    MessageBox.Show("Barang yang anda cari tidak ada.");
                }
            }else if(cbJenisBarang.Text == "Makanan")
            {
                if(cbRangeHarga.Text == "100rb - 200rb")
                {
                    ControlMakanan makanan = new ControlMakanan();
                    ControlClass.showControl(makanan, panelCont);
                }
                else
                {
                    MessageBox.Show("Barang yang anda cari tidak ada.");
                }
            } else if (cbJenisBarang.Text == "Baju")
            {
                if (cbRangeHarga.Text == "200rb - 500rb")
                {
                    Baju bj = new Baju();
                    ControlClass.showControl(bj, panelCont);
                }
                else
                {
                    MessageBox.Show("Barang yang anda cari tidak ada.");
                }
            }
            cbJenisBarang.Text = "Jenis Barang";
            cbRangeHarga.Text = "Range Harga";
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //PnlUtama.Controls.Add(ListItem);

            //dropdown list jenis barang
            cbJenisBarang.Items.Add("Elektronik");
            cbJenisBarang.Items.Add("Baju");
            cbJenisBarang.Items.Add("Makanan");

            //dropdown list range harga
            cbRangeHarga.Items.Add("100rb - 200rb");
            cbRangeHarga.Items.Add("200rb - 500rb");
            cbRangeHarga.Items.Add("500rb - 1jt");
        }

        private void button3_Click(object sender, EventArgs e)
        {//button logout
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }

        private void btnWebCatalog_Click(object sender, EventArgs e)
        {//hyperlink ke link e-commerce
            System.Diagnostics.Process.Start("https://secondatebeauty.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//button home
            ListItem listitem = new ListItem();
            ControlClass.showControl(listitem, panelCont);
        }

        private void cbRangeHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblValue.Text = cbRangeHarga.Text;
        }

        private void cbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblValue.Text = cbJenisBarang.Text;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
