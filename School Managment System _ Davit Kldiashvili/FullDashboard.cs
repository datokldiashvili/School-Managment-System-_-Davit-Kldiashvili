using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Managment_System___Davit_Kldiashvili.Controllers;
namespace School_Managment_System___Davit_Kldiashvili
{
    public partial class FullDashboard : Dashboard
    {
        public FullDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmissionControl dc = new AdmissionControl();
            showControl(dc);
        }

        public void showControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}
