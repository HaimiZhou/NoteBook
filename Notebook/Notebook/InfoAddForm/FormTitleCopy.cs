using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notebook.InfoAddForm
{
    public partial class FormTitleCopy : Form
    {
        public FormTitleCopy()
        {
            InitializeComponent();
        }

        private void FormTitleCopy_Load(object sender, EventArgs e)
        {
            panelExitTop.BackColor = ColorTranslator.FromHtml("#398dee");
        }

        private void buttonfinish_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
