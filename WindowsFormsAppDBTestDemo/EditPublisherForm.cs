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
    public partial class EditPublisherForm : Form
    {
        private readonly PublisherForm pf1;
        public EditPublisherForm(PublisherForm pf)
        {
            InitializeComponent();
            pf1 = pf;
        }

        private void ButtonCancelPublisherEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmPublisherEdit_Click(object sender, EventArgs e)
        {
            new DBQuery().DBUpdatePublisher(PublisherForm.PublisherName, PublisherForm.PublisherMark, textBoxPublisherName.Text, textBoxPublisherMark.Text);
            pf1.RefreshGrid("Publishers");
            MessageBox.Show("Publisher updated!");
            Close();
        }
    }
}
