using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  

            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind.mdb;Persist Security Info=True";
            string strCommand = "Select ProductName, UnitPrice from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strCommand, strConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Product");
            DataTable dataTable = dataSet.Tables[5]; 
            foreach (DataRow dataRow in dataTable.Rows)
            {
                lbProducts.Items.Add(dataRow["ProductName"] + " (at $" + dataRow["UnitPrice"] + ")");
            }
              
        }
    }
}
