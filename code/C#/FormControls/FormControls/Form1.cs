using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormControls
{
    public partial class MultiCon : Form
    {
        public MultiCon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public string output = "your order/n"; 
        private void btnOrder_Click(object sender, EventArgs e)
        {
           string output = "your order/n"; 
            if (ChkService.Checked == true)
             output = Output + "you have selected a full home services";
       


           
        }
        private void Output_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void ChkService_CheckedChanged(object sender, EventArgs e)
        {
          
               
        }
    }
}
 