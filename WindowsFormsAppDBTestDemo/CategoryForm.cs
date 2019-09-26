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
    public partial class CategoryForm : Form
    {
        public static string CategoryName;
        public static string CategoryDescription;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.libraryDBDataSet.Categories);

        }

        public void RefreshGrid(string tableName)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill(tableName);
            dataGridViewCategories.DataSource = bs;
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm acf = new AddCategoryForm(this);
            acf.ShowDialog();
        }

        private void ButtonEditCategory_Click(object sender, EventArgs e)
        {
            CategoryName = dataGridViewCategories.CurrentRow.Cells[0].Value.ToString();
            CategoryDescription = dataGridViewCategories.CurrentRow.Cells[1].Value.ToString();
            EditCategoryForm ecf = new EditCategoryForm(this);
            ecf.textBoxCategoryName.Text = CategoryName;
            ecf.textBoxCategoryDescription.Text = CategoryDescription;
            ecf.ShowDialog();
        }

        private void ButtonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBDeleteCategory(dataGridViewCategories.CurrentRow.Cells[0].Value.ToString(), dataGridViewCategories.CurrentRow.Cells[1].Value.ToString()))
            {
                this.RefreshGrid("Categories");
                MessageBox.Show("Category deleted!");
            }
        }
    }
}
