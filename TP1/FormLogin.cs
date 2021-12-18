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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();//instansiasi
            string username = tbUsername.Text;//atribut username
            string password = tbPassword.Text;//atribut password

            user.Username = Convert.ToString(username);
            user.Password = Convert.ToString(password);

            /*verifikasi ketika login*/
            if (username.Trim() == string.Empty || password.Trim() == string.Empty)
            {//jika belum memasukan username atau password
                MessageBox.Show("Please enter username/password.");
            }
            else
            {//jika sudah memasukan username dan password
                if (password == "pbo123")
                {
                   FormHome FormHome = new FormHome();
                   FormHome.Show();
                    this.Hide();//agar form login hilang
                }
                else
                {//jika password yang dimasukan tidak sesuai
                        MessageBox.Show("You have entered a wrong password!");
                }
            }
        }

        private void pictLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
    }
}
