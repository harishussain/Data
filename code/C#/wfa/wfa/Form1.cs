using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      public  double total = 1;
      public double total1 = 1;
      public char c;
        private void btn1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text =TxtDisplay.Text +btn1.Text;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            
          
             total1 = total * double.Parse(TxtDisplay.Text);
            total = 1;
            TxtDisplay.Text = total1.ToString();        
        
        }
            
        
        private void btn0_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn0.Text;
        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn4.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
           
            total = total + double.Parse(TxtDisplay.Text);
            TxtDisplay.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            total = total * double.Parse(TxtDisplay.Text);
            TxtDisplay.Clear();
        }
    }
}
