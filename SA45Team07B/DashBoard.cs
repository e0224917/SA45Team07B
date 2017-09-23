﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class DashBoard : SA45Team07B.BaseForm
    {
        public DashBoard()
        {
            InitializeComponent();
            this.dataGridView1.ColumnCount = 6;
            this.dataGridView1.ColumnHeadersVisible = true;
            this.dataGridView1.AutoGenerateColumns = false;
            DataGridViewCheckBoxColumn selectCol = new DataGridViewCheckBoxColumn();
            selectCol.HeaderText = "Select";
            selectCol.FalseValue = "False";
            selectCol.TrueValue = "True";
            dataGridView1.Columns.Insert(0, selectCol);
            selectCol.ReadOnly = false;
            this.dataGridView1.Columns[1].Name = "Booking ID";
            this.dataGridView1.Columns[2].Name = "Tour Destination";
            this.dataGridView1.Columns[3].Name = "Tour Date";
            this.dataGridView1.Columns[4].Name = "Booking Status";
            this.dataGridView1.Columns[5].Name = "Special Request";
            this.dataGridView1.Columns[6].Name = "Reason for cancellation";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells[1].Value = "MY1200875";
            this.dataGridView1.Rows[0].Cells[2].Value = "Malaysia";
            this.dataGridView1.Rows[0].Cells[3].Value = "12/12/2017";
            this.dataGridView1.Rows[0].Cells[4].Value = "Pending Cancellation";
            this.dataGridView1.Rows[0].Cells[5].Value = "Nil";
            this.dataGridView1.Rows[0].Cells[6].Value = "Attending wedding";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[1].Cells[1].Value = "FR2500125";
            this.dataGridView1.Rows[1].Cells[2].Value = "France";
            this.dataGridView1.Rows[1].Cells[3].Value = "20/11/2017";
            this.dataGridView1.Rows[1].Cells[4].Value = "Confirmed";
            this.dataGridView1.Rows[1].Cells[5].Value = "Flight Extension";
            this.dataGridView1.Rows[1].Cells[6].Value = "NA";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[2].Cells[1].Value = "AU1400391";
            this.dataGridView1.Rows[2].Cells[2].Value = "Australia";
            this.dataGridView1.Rows[2].Cells[3].Value = "12/11/2017";
            this.dataGridView1.Rows[2].Cells[4].Value = "Cancelled";
            this.dataGridView1.Rows[2].Cells[5].Value = "Special Request Cancelled";
            this.dataGridView1.Rows[2].Cells[6].Value = "Going for surgery";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[3].Cells[1].Value = "CN2000422";
            this.dataGridView1.Rows[3].Cells[2].Value = "China";
            this.dataGridView1.Rows[3].Cells[3].Value = "08/10/2016";
            this.dataGridView1.Rows[3].Cells[4].Value = "Tour Completed";
            this.dataGridView1.Rows[3].Cells[5].Value = "Nil";
            this.dataGridView1.Rows[3].Cells[6].Value = "NA";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[4].Cells[1].Value = "MY1200319";
            this.dataGridView1.Rows[4].Cells[2].Value = "Malaysia";
            this.dataGridView1.Rows[4].Cells[3].Value = "01/05/2016";
            this.dataGridView1.Rows[4].Cells[4].Value = "Tour Completed";
            this.dataGridView1.Rows[4].Cells[5].Value = "Nil";
            this.dataGridView1.Rows[4].Cells[6].Value = "NA";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[5].Cells[1].Value = "RU7600217";
            this.dataGridView1.Rows[5].Cells[2].Value = "Russia";
            this.dataGridView1.Rows[5].Cells[3].Value = "08/08/2015";
            this.dataGridView1.Rows[5].Cells[4].Value = "Tour Completed";
            this.dataGridView1.Rows[5].Cells[5].Value = "Hotel Extension";
            this.dataGridView1.Rows[5].Cells[6].Value = "NA";
        }
    }
}