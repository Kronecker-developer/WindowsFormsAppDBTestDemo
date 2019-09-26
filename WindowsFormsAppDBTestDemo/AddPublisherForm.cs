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
    public partial class AddPublisherForm : Form
    {
        private readonly PublisherForm pf1;
        public AddPublisherForm(PublisherForm pf)
        {
            InitializeComponent();
            pf1 = pf;
        }

        private void ButtonCancelPublisherAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmPublisherAdd_Click(object sender, EventArgs e)
        {
            if (new DBQuery().DBInsertPublisher(textBoxPublisherName.Text, textBoxPublisherMark.Text))
            {
                pf1.RefreshGrid("Publishers");
                MessageBox.Show("Publisher added!");
            }
        }
    }
}
