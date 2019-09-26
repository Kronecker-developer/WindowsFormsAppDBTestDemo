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
    public partial class AuthorForm : Form
    {
        public static string AuthorFirstName;
        public static string AuthorLastName;
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSetAuthors.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDBDataSetAuthors.Authors);
            //this.DataSetFill("Authors");
        }

        public void RefreshGrid(string tableName)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill(tableName);
            dataGridViewAuthors.DataSource = bs;
        }

        private void ButtonAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm aaf = new AddAuthorForm(this);
            aaf.ShowDialog();
        }

        private void ButtonEditAuthor_Click(object sender, EventArgs e)
        {
            AuthorFirstName = dataGridViewAuthors.CurrentRow.Cells[1].Value.ToString();
            AuthorLastName = dataGridViewAuthors.CurrentRow.Cells[2].Value.ToString();
            EditAuthorForm eaf = new EditAuthorForm(this);
            eaf.textBoxAuthorFirstName.Text = AuthorFirstName;
            eaf.textBoxAuthorLastName.Text = AuthorLastName;
            eaf.ShowDialog();
        }

        private void ButtonDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBDeleteAuthor(dataGridViewAuthors.CurrentRow.Cells[1].Value.ToString(), dataGridViewAuthors.CurrentRow.Cells[2].Value.ToString()))
            {
                this.RefreshGrid("Authors");
                MessageBox.Show("Author deleted!");
            }
        }
    }
}
