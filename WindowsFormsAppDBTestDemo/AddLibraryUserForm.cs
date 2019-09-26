using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDBTestDemo
{
    
    public partial class AddLibraryUserForm : Form
    {
        private readonly LibraryUserForm luf1;
        public AddLibraryUserForm(LibraryUserForm luf)
        {
            InitializeComponent();
            luf1 = luf;
        }

        private void ButtonCancelLibraryUserAdd_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void ButtonConfirmLibraryUserAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLibraryUserOIB.TextLength == 11)
            {
                if (new DBQuery().DBInsertLibraryUser(textBoxLibraryUserFirstName.Text, textBoxLibraryUserLastName.Text, textBoxLibraryUserOIB.Text))
                {
                    luf1.RefreshGrid("LibraryUsers");
                    MessageBox.Show("User added!");
                }
            }
            else
            {
                MessageBox.Show("OIB must have 11 characters!");
            }

        }

    }
}
