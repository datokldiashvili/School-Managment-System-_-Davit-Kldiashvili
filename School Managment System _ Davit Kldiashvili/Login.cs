using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System___Davit_Kldiashvili
{
    public partial class Login : Dashboard
    {
        public Login()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            if(materialSingleLineTextField1.Text == "Enter Username")
            {
                materialSingleLineTextField1.Text = "";
                materialSingleLineTextField1.ForeColor = Color.Black;
            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "Enter Username")
            {
                materialSingleLineTextField1.Text = "";
                materialSingleLineTextField1.ForeColor = Color.Silver;
            }
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            if(materialSingleLineTextField2.Text == "Enter Password")
            {
                materialSingleLineTextField2.Text = "";
                materialSingleLineTextField2.ForeColor = Color.Black;
            }
        }

        private void materialSingleLineTextField2_Leave(object sender, EventArgs e)
        {
            if (materialSingleLineTextField2.Text == "Enter Password")
            {
                materialSingleLineTextField2.Text = "";
                materialSingleLineTextField2.ForeColor = Color.Silver;
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialSingleLineTextField2.UseSystemPasswordChar = false;
            }
            else
            {
                materialSingleLineTextField2.UseSystemPasswordChar = true;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        }        
    }
}
