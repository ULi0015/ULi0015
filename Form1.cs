using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Аутентификация01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int j = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = txtLogin.Text;
            b = txtPwd.Text;
            if ((a == "ulan") && (b == "2001"))
            {
                lblYes.Visible = true;
                lblNot.Visible = false;
                button1.Enabled = false;
            }
            else 
            {
                lblNot.Visible = true;
                j--;
                if (j > 0)
                    MessageBox.Show("У вас осталось " + (j) + " попытки");
                else if (j == 0)
                    Application.Exit();
            }
        }
    }
}
