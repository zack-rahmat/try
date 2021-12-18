using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    class ControlClass
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control panelCont)
        {
            panelCont.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelCont.Controls.Add(control);
        }
    }
}
