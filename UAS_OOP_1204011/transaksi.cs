﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace UAS_OOP_1204011
{
    public partial class transaksi : Form
    {
        private string url = "server=localhost;userid=root;password=;database=uaspem";

        private void UpdateDB(string cmd)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=uaspem";
                MySqlConnection newSql = new MySqlConnection(connectionString);
                Program newprogram = new Program();
                newSql.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = newSql;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diinput", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public transaksi()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT tr_daftar_ulang VALUES('"
                + textBox1.Text + "','"
                + textBox2.Text + "','"
                + textBox3.Text + "','"
                + textBox4.Text + "','"
                + radioButton1.Text + "','"
                + radioButton2.Text + "','"
                + radioButton3.Text + "','"
                + textBox5.Text + "','"
                + textBox6.Text + "','";
            UpdateDB(myCmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
