﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdoForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Northwind.mdb";
           string strCommand ="Select productName, unitPrice from Products";
         OleDbDataAdapter dataAdapter =new OleDbDataAdapter(strCommand, strConnection);
         DataSet dataSet = new DataSet();
         dataAdapter.Fill(dataSet, "Product");
         DataTable dataTable = dataSet.Tables[0];
         foreach (DataRow dataRow in dataTable.Rows)
         {
             lblProducts.Items.Add(dataRow["ProductName"] +
             " (at $" + dataRow["UnitPrice"] + ")");
         }




        }
    }
}
