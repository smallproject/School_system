using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_80437_C_Side_Solution.Model;

namespace Exam_80437_C_Side_Solution
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();

            //**********************************************
            //initialize form from here
            initialize();
        }

        private void initialize()
        {
            lblwelcome.Text = "Welcome!";
            lbluser.Text = "Username";
            lblpassword.Text = "Password";
            txtbuser.Clear();
            txtbpass.Clear();
            btnlogin.Text = "log-in";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (IsAuthenticated(txtbuser.Text, txtbpass.Text))
            {
                //Application.Exit();

                this.Hide();
                formmain main = new formmain();
                main.ShowDialog();
                this.Close();
            }
        }

        private bool IsAuthenticated(string user, string pass)
        {
            return true;
        }
    }
}
