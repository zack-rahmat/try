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
    public partial class Baju : UserControl
    {
        public Baju()
        {
            InitializeComponent();
        }

        private void Baju_Load(object sender, EventArgs e)
        {

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
