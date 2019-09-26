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
    
    public partial class AddAuthorForm : Form
    {
        private readonly AuthorForm af1;
        public AddAuthorForm(AuthorForm af)
        {
            InitializeComponent();
            af1 = af;
        }

        private void ButtonCancelAuthorAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmAuthorAdd_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBInsertAuthor(textBoxAuthorFirstName.Text, textBoxAuthorLastName.Text))
            {
                af1.RefreshGrid("Authors");
                MessageBox.Show("Author added!");
            }
        }
    }
}
