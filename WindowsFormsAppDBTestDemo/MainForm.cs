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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAuthors_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void ButtonPublishers_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            publisherForm.ShowDialog();
        }

        private void ButtonCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            LibraryUserForm userForm = new LibraryUserForm();
            userForm.ShowDialog();
        }
    }
}
