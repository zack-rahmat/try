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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        
        //private string _namaBarang;
        //private string _hargaBarang;
        //private Image _gambar;

        //[Category("Custom Props")]
        //public string Nama
        //{
            //get { return _namaBarang; }
            //set { _namaBarang = value; lblNama.Text = value; }
        //}

        //[Category("Custom Props")]
        // string Harga
        //{
            //get { return _hargaBarang; }
        //set { _hargaBarang = value; lblHarga.Text = value; }
       //}

        //[Category("Custom Props")]
        //public Image Gambar
        //{
            //get { return _gambar; }
        //set { _gambar = value; pictureBox1.Image = value; }
        //}

        //[Category("Custom Props")]
        //public string Button
        //{
            //get { return btnBeli.Name; }
        //set { btnBeli.Name = value; }
        //}

        //private void btnBeli_Click(object sender, EventArgs e)
        //{
        //FormDetail detailBeli = new FormDetailBeli();
        //string s = (sender as Button).Name;

        //if (string.Compare(s, "btn1") == 0)
        //{
        //detailBeli.Nama = "iWatch";
        //detailBeli.Harga = "Rp 1.000.000";
        //detailBeli.Gambar = icons8-apple-watch-100;
        //detailBeli.Deskripsi = "iWatch Second kondisi 80%";
        //detailBeli.Show();
        //}
        //else if (string.Compare(s, "btn2") == 0)
        //{
        //detailBeli.Nama = "Madu";
        //detailBeli.Harga = "Rp 300.000";
        //detailBeli.Gambar = icons8-honey-100;
        //detailBeli.Deskripsi = "Untuk meningkatkan sistem kekebalan tubuh";
        //detailBeli.Show();
        //}
        //else if (string.Compare(s, "btn3") == 0)
        //{
        //detailBeli.Nama = "Croissant";
        //detailBeli.Harga = "Rp 100.000";
        //detailBeli.Gambar = icons8-croissant-100;
        //detailBeli.Deskripsi = "Croissant enak dengan keju yang banyak";
        //detailBeli.Show();
        // }
        //else if (string.Compare(s, "btn4") == 0)
        //{
        //detailBeli.Nama = "Scarf";
        //detailBeli.Harga = "Rp 700.000";
        //detailBeli.Gambar = icons8-scarf-100;
        //detailBeli.Deskripsi = "Nyaman berbahan voal";
        //detailBeli.Show();
        //}
        //else if (string.Compare(s, "btn5") == 0)
        //{
        //detailBeli.Nama = "Swimsuit";
        //detailBeli.Harga = "Rp 900.000";
        //detailBeli.Gambar = icons8-swimming-suit-100;
        //detailBeli.Deskripsi = "Baju renang fashionable";
        //detailBeli.Show();
        //}
        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {//iWatch
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
            //DetailiWatch i = new DetailiWatch();
            //ControlClass.showControl(i, panelCont);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
        }
    }
}
