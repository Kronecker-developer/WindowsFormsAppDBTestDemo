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
    public partial class BookLendForm : Form
    {
        private readonly BookForm bf1;
        string filterFieldFirstName = "FirstName";
        string filterFieldLastName = "LastName";
        string filterFieldOIB= "OIB";
        public BookLendForm(BookForm bf)
        {
            InitializeComponent();
            bf1 = bf;
        }

        private void ButtonCancelLendBook_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookLendForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.LibraryUsers' table. You can move, or remove it, as needed.
            this.libraryUsersTableAdapter.Fill(this.libraryDBDataSet.LibraryUsers);

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLibraryUsersFirstName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldFirstName, textBoxLibraryUsersFirstName.Text);
            dataGridViewLibraryUsers.DataSource = bs;
        }

        private void TextBoxLibraryUsersLastName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldLastName, textBoxLibraryUsersLastName.Text);
            dataGridViewLibraryUsers.DataSource = bs;
        }

        private void TextBoxLibraryUsersOIB_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldOIB, textBoxLibraryUsersOIB.Text);
            dataGridViewLibraryUsers.DataSource = bs;
        }

        private void ButtonLendBook_Click(object sender, EventArgs e)
        {
            int BookID = new DBQuery().DBGetBookID(textBoxLendBookTitle.Text, textBoxLendBookISBN.Text, 1);
            new DBQuery().DBInsertBookUser(BookID, (int)dataGridViewLibraryUsers.CurrentRow.Cells[0].Value);
            new DBQuery().DBMakeBookUnavailable(BookID);
            bf1.RefreshGrid("Books");
            MessageBox.Show("Book lended!");
        }
    }
}
