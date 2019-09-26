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
    public partial class BookReturnForm : Form
    {
        private readonly BookForm bf1;
        string filterFieldFirstName = "FirstName";
        string filterFieldLastName = "LastName";
        string filterFieldOIB = "OIB";
        public BookReturnForm(BookForm bf)
        {
            InitializeComponent();
            bf1 = bf;
        }

        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Books' table. You can move, or remove it, as needed.
            DataSet BooksUsersJoin = new DataSet();
            BooksUsersJoin.Tables.Add(new DBQuery().DBTablesBooksUsersJoin());
            this.booksTableAdapter.Fill(this.libraryDBDataSet.Books);
            dataGridViewBooksUsersJoin.DataSource = BooksUsersJoin.Tables[0].DefaultView;
            // TODO: This line of code loads data into the 'libraryDBDataSet.LibraryUsers' table. You can move, or remove it, as needed.
            this.libraryUsersTableAdapter.Fill(this.libraryDBDataSet.LibraryUsers);
            
        }

        private void TextBoxReturnBookUserFirstName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldFirstName, textBoxReturnBookLibraryUsersFirstName.Text);
            dataGridViewReturnBookLibraryUsers.DataSource = bs;
        }

        private void TextBoxReturnBookLibraryUsersLastName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldLastName, textBoxReturnBookLibraryUsersLastName.Text);
            dataGridViewReturnBookLibraryUsers.DataSource = bs;
        }

        private void TextBoxReturnBookLibraryUsersOIB_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("LibraryUsers");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldOIB, textBoxReturnBookLibraryUsersOIB.Text);
            dataGridViewReturnBookLibraryUsers.DataSource = bs;
        }

        private void DataGridViewReturnBookLibraryUsers_SelectionChanged(object sender, EventArgs e)
        {
            DataSet BooksUsersJoin = new DataSet();
            BooksUsersJoin.Tables.Add(new DBQuery().DBTablesBooksUsersJoin());

            BindingSource bs = new BindingSource();
            bs.DataSource = BooksUsersJoin.Tables[0].DefaultView;
            bs.Filter = string.Format("LibraryUserID = '{0}'", (int)dataGridViewReturnBookLibraryUsers.CurrentRow.Cells[0].Value);
            dataGridViewBooksUsersJoin.DataSource = bs;
        }

        private void ButtonBookReturnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBookReturn_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridViewBooksUsersJoin.CurrentRow.Cells[6].Value == true)
            {
                MessageBox.Show("Book already returned!");
            }
            else
            {
                int BookID = (int)dataGridViewBooksUsersJoin.CurrentRow.Cells[0].Value;
                int LibraryUserID = (int)dataGridViewBooksUsersJoin.CurrentRow.Cells[5].Value;
                new DBQuery().DBMakeBookAvailable(BookID);
                new DBQuery().DBUpdateBookUser(BookID, LibraryUserID);
                bf1.RefreshGrid("Books");
            }

        }
    }
}
