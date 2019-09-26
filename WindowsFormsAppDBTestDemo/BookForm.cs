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
    public partial class BookForm : Form
    {
        public static string BookTitle;
        public static string BookISBN;
        public static string AuthorLastName;
        public static string BookPublisherName;
        public static string BookCategoryName;
        string filterFieldTitle = "Title";
        string filterFieldISBN = "ISBN";
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSetBooks.BooksCategories' table. You can move, or remove it, as needed.
            this.booksCategoriesTableAdapter.Fill(this.libraryDBDataSetBooks.BooksCategories);
            // TODO: This line of code loads data into the 'libraryDBDataSetBooks.BooksPublishers' table. You can move, or remove it, as needed.
            this.booksPublishersTableAdapter.Fill(this.libraryDBDataSetBooks.BooksPublishers);
            // TODO: This line of code loads data into the 'libraryDBDataSetBooks.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDBDataSetBooks.Publishers);
            // TODO: This line of code loads data into the 'libraryDBDataSetBooks.AuthorsBooks' table. You can move, or remove it, as needed.
            this.authorsBooksTableAdapter.Fill(this.libraryDBDataSetBooks.AuthorsBooks);
            // TODO: This line of code loads data into the 'libraryDBDataSetBooks.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDBDataSetBooks.Books);
            //this.DataSetFill("Books");
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm(this);
            abf.ShowDialog();
        }

        public void RefreshGrid(string tableName)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill(tableName);
            dataGridViewBooks.DataSource = bs;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            BookTitle = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
            BookISBN = dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
            if (dataGridViewBooksAuthorsJoin.CurrentRow == null)
            {
                AuthorLastName = "";
            }
            else
            {
                if (dataGridViewBooksAuthorsJoin.CurrentRow.Cells != null)
                    AuthorLastName = dataGridViewBooksAuthorsJoin.CurrentRow.Cells[4].Value.ToString();
            }
            if (dataGridViewBooksPublishersJoin.CurrentRow == null)
            {
                BookPublisherName = "";
            }
            else
            {
                if (dataGridViewBooksPublishersJoin.CurrentRow.Cells != null)
                    BookPublisherName = dataGridViewBooksPublishersJoin.CurrentRow.Cells[2].Value.ToString();
            }
            if (dataGridViewBooksCategoriesJoin.CurrentRow == null)
            {
                BookCategoryName = "";
            }
            else
            {
                if (dataGridViewBooksCategoriesJoin.CurrentRow.Cells != null)
                    BookCategoryName = dataGridViewBooksCategoriesJoin.CurrentRow.Cells[3].Value.ToString();
            }
            EditBookForm ebf = new EditBookForm(this);
            ebf.textBoxTitle.Text = BookTitle;
            ebf.textBoxISBN.Text = BookISBN;
            ebf.ShowDialog();
        }

        private void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBDeleteBook(dataGridViewBooks.CurrentRow.Cells[0].Value.ToString(), dataGridViewBooks.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("Book deleted!");
                this.RefreshGrid("Books");
            }
        }

        private void TextBoxFilterByBookTitle_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("Books");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldTitle, textBoxFilterByBookTitle.Text);
            dataGridViewBooks.DataSource = bs;
        }

        private void TextBoxFilterByBookISBN_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill("Books");
            bs.Filter = string.Format("[{0}] LIKE '%{1}%'", filterFieldISBN, textBoxFilterByBookISBN.Text);
            dataGridViewBooks.DataSource = bs;
        }

        private void ButtonLendBook_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Availability:"+ dataGridViewBooks.CurrentRow.Cells[2].Value);
            if ((bool)dataGridViewBooks.CurrentRow.Cells[2].Value == true)
            {
                BookTitle = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
                BookISBN = dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
                BookLendForm blf = new BookLendForm(this);
                blf.textBoxLendBookTitle.Text = BookTitle;
                blf.textBoxLendBookISBN.Text = BookISBN;
                blf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Book unavailable!");
            }
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {
            BookReturnForm brf = new BookReturnForm(this);
            brf.ShowDialog();
        }

        private void DataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            DataSet BooksAuthorsJoin = new DataSet();
            BooksAuthorsJoin.Tables.Add(new DBQuery().DBTablesAuthorsBooksJoin());

            BindingSource bs = new BindingSource();
            bs.DataSource = BooksAuthorsJoin.Tables[0].DefaultView;
            bs.Filter = string.Format("BookID = '{0}'", (int)dataGridViewBooks.CurrentRow.Cells[3].Value);
            dataGridViewBooksAuthorsJoin.DataSource = bs;
            // -------------------------------------------------------------//
            DataSet BooksPublishersJoin = new DataSet();
            BooksPublishersJoin.Tables.Add(new DBQuery().DBTablesPublishersBooksJoin());

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = BooksPublishersJoin.Tables[0].DefaultView;
            bs2.Filter = string.Format("BookID = '{0}'", (int)dataGridViewBooks.CurrentRow.Cells[3].Value);
            dataGridViewBooksPublishersJoin.DataSource = bs2;
            // -------------------------------------------------------------//
            DataSet BooksCategoriesJoin = new DataSet();
            BooksCategoriesJoin.Tables.Add(new DBQuery().DBTablesBooksCategoriesJoin());

            BindingSource bs3 = new BindingSource();
            bs3.DataSource = BooksCategoriesJoin.Tables[0].DefaultView;
            bs3.Filter = string.Format("BookID = '{0}'", (int)dataGridViewBooks.CurrentRow.Cells[3].Value);
            dataGridViewBooksCategoriesJoin.DataSource = bs3;
        }
    }
}
