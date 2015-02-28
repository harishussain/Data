using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADOwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            string strconnection = @"Provider=Microsoft.Jet.OLEDB.4.0;data Source=E:\compile\ADOwork\ADOwork\Northwind.mdb;Persist Security Info=True";
            string strcommand = "Select ProductName,UnitPrice from Products";
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(strcommand, strconnection);
            Mydataset dataSet = new Mydataset();
            DataAdapter.Fill(dataSet,"Products");
            DataTable dataTable = dataSet.Tables[0]; 
           



        }

        private void lbProducts_TextChanged(object sender, EventArgs e)
        
        {

            ////DataTable datatable = new DataTable();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                lbProducts.Items.Add(dataRow["ProductName"] +
                " (at $" + dataRow["UnitPrice"] + ")");
            }

        }


    }
}

