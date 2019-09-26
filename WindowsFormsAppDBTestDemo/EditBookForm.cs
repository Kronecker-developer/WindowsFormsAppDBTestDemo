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
    public partial class EditBookForm : Form
    {
        private readonly BookForm bf1;
        public EditBookForm(BookForm bf)
        {
            InitializeComponent();
            bf1 = bf;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            int BookID = new DBQuery().DBGetBookIDByTitleISBN(textBoxTitle.Text, textBoxISBN.Text);
            if (((DataRowView)comboBoxAuthor.SelectedItem) != null)
            {
                DataRow selectedAuthorDataRow = (((DataRowView)comboBoxAuthor.SelectedItem).Row);
                int AuthorID = Convert.ToInt32(selectedAuthorDataRow["AuthorID"]);
                new DBQuery().DBUpdateOrInsertAuthorsBooks(AuthorID, BookID);
            }

            if (((DataRowView)comboBoxCategory.SelectedItem) != null)
            {
                DataRow selectedCategoryDataRow = (((DataRowView)comboBoxCategory.SelectedItem).Row);
                int CategoryID = Convert.ToInt32(selectedCategoryDataRow["CategoryID"]);
                new DBQuery().DBUpdateOrInsertBooksCategories(BookID, CategoryID);
            }

            if (((DataRowView)comboBoxPublisher.SelectedItem) != null)
            {
                DataRow selectedPublisherDataRow = (((DataRowView)comboBoxPublisher.SelectedItem).Row);
                int PublisherID = Convert.ToInt32(selectedPublisherDataRow["PublisherID"]);
                new DBQuery().DBUpdateOrInsertBooksPublishers(BookID, PublisherID);
            }

            new DBQuery().DBUpdateBook(BookForm.BookTitle, BookForm.BookISBN,textBoxTitle.Text,textBoxISBN.Text);

            bf1.RefreshGrid("Books");
            MessageBox.Show("Book updated!");
            Close();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.libraryDBDataSet.Categories);
            // TODO: This line of code loads data into the 'libraryDBDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDBDataSet.Publishers);
            // TODO: This line of code loads data into the 'libraryDBDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDBDataSet.Authors);
            comboBoxAuthor.ValueMember = "LastName";
            comboBoxAuthor.SelectedValue = BookForm.AuthorLastName;
            comboBoxPublisher.ValueMember = "Name";
            comboBoxPublisher.SelectedValue = BookForm.BookPublisherName;
            comboBoxCategory.ValueMember = "Name";
            comboBoxCategory.SelectedValue = BookForm.BookCategoryName;

        }

    }
}
