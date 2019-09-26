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
    public partial class EditLibraryUserForm : Form
    {
        private readonly LibraryUserForm luf1;
        public EditLibraryUserForm(LibraryUserForm luf)
        {
            InitializeComponent();
            luf1 = luf;
        }

        private void ButtonCancelLibraryUserEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmLibraryUserEdit_Click(object sender, EventArgs e)
        {
            new DBQuery().DBUpdateLibraryUser(LibraryUserForm.LibraryUserFirstName, LibraryUserForm.LibraryUserLastName, LibraryUserForm.LibraryUserOIB, textBoxLibraryUserFirstName.Text, textBoxLibraryUserLastName.Text, textBoxLibraryUserOIB.Text);
            luf1.RefreshGrid("LibraryUsers");
            MessageBox.Show("User updated!");
            Close();
        }

        private void TextBoxLibraryUserOIB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
