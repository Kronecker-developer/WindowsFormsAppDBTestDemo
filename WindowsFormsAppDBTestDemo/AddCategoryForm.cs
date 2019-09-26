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
    public partial class AddCategoryForm : Form
    {
        private readonly CategoryForm cf1;
        public AddCategoryForm(CategoryForm cf)
        {
            InitializeComponent();
            cf1 = cf;
        }

        private void ButtonCancelCategoryAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmCategoryAdd_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBInsertCategory(textBoxCategoryName.Text, textBoxCategoryDescription.Text))
            {
                cf1.RefreshGrid("Categories");
                MessageBox.Show("Category added!");
            }
        }
    }
}
