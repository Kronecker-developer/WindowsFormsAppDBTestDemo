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
    public partial class EditCategoryForm : Form
    {
        private readonly CategoryForm cf1;
        public EditCategoryForm(CategoryForm cf)
        {
            InitializeComponent();
            cf1 = cf;
        }

        private void ButtonCancelCategoryEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmCategoryEdit_Click(object sender, EventArgs e)
        {
            new DBQuery().DBUpdateCategory(CategoryForm.CategoryName, CategoryForm.CategoryDescription, textBoxCategoryName.Text, textBoxCategoryDescription.Text);
            cf1.RefreshGrid("Categories");
            MessageBox.Show("Category updated!");
            Close();
        }
    }
}
