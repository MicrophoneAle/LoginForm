﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormProject
{
    public partial class RegisterForm : Form
    {
        // MySqlConnection con = new MySqlConnection(@"Data Source=pc.savagerpls.fr;port=3306;Initial Catalog=LoginForm;User Id=Arloniumexec;password='Arlonium628807800'");
        MySqlConnection con = new MySqlConnection();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fm = new LoginForm();
            fm.Show();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO LoginForm (username, password) VALUES ('" + usernametxt.Text + "','" + passwordtxt.Text + "');";
            DataTable de = new DataTable();
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);
            dp.Fill(de);
            con.Close();
            MessageBox.Show("placeholder text");
        }
    }
}
