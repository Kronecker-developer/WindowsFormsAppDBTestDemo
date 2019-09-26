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
    public partial class LibraryUserForm : Form
    {
        public static string LibraryUserFirstName;
        public static string LibraryUserLastName;
        public static string LibraryUserOIB;
        public LibraryUserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.LibraryUsers' table. You can move, or remove it, as needed.
            this.libraryUsersTableAdapter.Fill(this.libraryDBDataSet.LibraryUsers);

        }

        public void RefreshGrid(string tableName)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill(tableName);
            dataGridViewLibraryUsers.DataSource = bs;
        }

        private void ButtonAddLibraryUser_Click(object sender, EventArgs e)
        {
            AddLibraryUserForm aluf = new AddLibraryUserForm(this);
            aluf.ShowDialog();
        }

        private void ButtonEditLibraryUser_Click(object sender, EventArgs e)
        {
            LibraryUserFirstName = dataGridViewLibraryUsers.CurrentRow.Cells[0].Value.ToString();
            LibraryUserLastName = dataGridViewLibraryUsers.CurrentRow.Cells[1].Value.ToString();
            LibraryUserOIB = dataGridViewLibraryUsers.CurrentRow.Cells[2].Value.ToString();
            EditLibraryUserForm eluf = new EditLibraryUserForm(this);
            eluf.textBoxLibraryUserFirstName.Text = LibraryUserFirstName;
            eluf.textBoxLibraryUserLastName.Text = LibraryUserLastName;
            eluf.textBoxLibraryUserOIB.Text = LibraryUserOIB;
            eluf.ShowDialog();
        }

        private void ButtonDeleteLibraryUser_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBDeleteLibraryUser(dataGridViewLibraryUsers.CurrentRow.Cells[0].Value.ToString(), dataGridViewLibraryUsers.CurrentRow.Cells[1].Value.ToString(), dataGridViewLibraryUsers.CurrentRow.Cells[2].Value.ToString()))
            {
                this.RefreshGrid("LibraryUsers");
                MessageBox.Show("User deleted!");
            }
        }
    }
}
