using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_containment
{
    public partial class Formchild1 : Form
    {
        public Formchild1()
        {
            InitializeComponent();
        }

        private void Formchild1_Load(object sender, EventArgs e)
        {

        }

        private void newchild_Click(object sender, EventArgs e)
        {
            CreateForm(new Form());
        }

        private void newexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CreateForm(Form child)
        {
            child.MdiParent = this;
            child.Show();
        }

    }
}
