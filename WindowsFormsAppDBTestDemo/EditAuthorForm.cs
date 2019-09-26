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
    public partial class EditAuthorForm : Form
    {
        private readonly AuthorForm af1;
        public EditAuthorForm(AuthorForm af)
        {
            InitializeComponent();
            af1 = af;
        }

        private void ButtonConfirmAuthorEdit_Click(object sender, EventArgs e)
        {
            new DBQuery().DBUpdateAuthor(AuthorForm.AuthorFirstName, AuthorForm.AuthorLastName, textBoxAuthorFirstName.Text, textBoxAuthorFirstName.Text);
            af1.RefreshGrid("Authors");
            MessageBox.Show("Author updated!");
            Close();
        }

        private void ButtonCancelAuthorEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditAuthorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDBDataSet.Authors);

        }
    }
}
