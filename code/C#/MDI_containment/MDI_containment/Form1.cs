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
    public partial class Pform : Form
    {
        public Pform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menufilenew_Click(object sender, EventArgs e)
        {
           // CreateMdiChild(new Form());
            Formchild1 f = new Formchild1();
            f.Show();
           
        }

        private void menufileexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menufile_Click(object sender, EventArgs e)
        {

        }
        //private void CreateMdiChild(Form Child)
        //{

        //    Child.MdiParent = this;
        //    Child.Show();
            
        //}
    }
}
