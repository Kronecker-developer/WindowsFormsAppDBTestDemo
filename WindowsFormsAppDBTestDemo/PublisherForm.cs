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
    public partial class PublisherForm : Form
    {
        public static string PublisherName;
        public static string PublisherMark;
        public PublisherForm()
        {
            InitializeComponent();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDBDataSet.Publishers);

        }

        public void RefreshGrid(string tableName)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DBQuery().DBTableFill(tableName);
            dataGridViewPublishers.DataSource = bs;
        }

        private void ButtonAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisherForm apf = new AddPublisherForm(this);
            apf.ShowDialog();
        }

        private void ButtonEditPublisher_Click(object sender, EventArgs e)
        {
            PublisherName = dataGridViewPublishers.CurrentRow.Cells[0].Value.ToString();
            PublisherMark = dataGridViewPublishers.CurrentRow.Cells[1].Value.ToString();
            EditPublisherForm epf = new EditPublisherForm(this);
            epf.textBoxPublisherName.Text = PublisherName;
            epf.textBoxPublisherMark.Text = PublisherMark;
            epf.ShowDialog();
        }

        private void ButtonDeletePublisher_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBDeletePublisher(dataGridViewPublishers.CurrentRow.Cells[0].Value.ToString(), dataGridViewPublishers.CurrentRow.Cells[1].Value.ToString()))
            {
                this.RefreshGrid("Publishers");
                MessageBox.Show("Publisher deleted!");
            }
        }
    }
}
