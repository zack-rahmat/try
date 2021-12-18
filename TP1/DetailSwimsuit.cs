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
    public partial class DetailSwimsuit : UserControl
    {
        public DetailSwimsuit()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Thankyou!";
            string title = "";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
