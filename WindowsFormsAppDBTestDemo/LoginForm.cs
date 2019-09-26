using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppDBTestDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DBQuery query = new DBQuery();
            if (query.DBLogin(textBoxUsername.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Welcome!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
    }
}
