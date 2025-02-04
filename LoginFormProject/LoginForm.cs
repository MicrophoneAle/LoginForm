using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LoginFormProject
{
    public partial class LoginForm : Form
    {
        connection con = new connection();
        string id, username, password, firstname, lastname, address;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm fm = new RegisterForm();
            fm.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    con.Open();
                    string query = "select id,username,password,firstname,lastname,address from user WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            firstname = row["firstname"].ToString();
                            lastname = row["lastname"].ToString();
                            address = row["address"].ToString();
                        }
                        MessageBox.Show("Data found, your name is " + firstname + " " + lastname + " and your address is at " + address);
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}
