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
    public partial class ControlElektronik : UserControl
    {
        public ControlElektronik()
        {
            InitializeComponent();
        }

        private void ControlElektronik_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDetail FormDetail = new FormDetail();
            FormDetail.Show();
            this.Hide();
        }
    }
}
