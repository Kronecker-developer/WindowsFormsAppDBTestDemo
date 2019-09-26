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
    public partial class AddBookForm : Form
    {
        private readonly BookForm bf1;
        public AddBookForm(BookForm bf)
        {
            InitializeComponent();
            bf1 = bf;
        }

        private void ButtonConfirmBookAdd_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBInsertBook(textBoxBookTitle.Text, textBoxISBN.Text))
            {
                bf1.RefreshGrid("Books");
                MessageBox.Show("Book added!");
            }
        }

        private void ButtonCancelBookAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
