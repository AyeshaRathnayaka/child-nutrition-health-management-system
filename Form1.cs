using child_clinic.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace child_clinic
{
    public partial class LoginForm : Form
    {
        bool isError = false;
        public LoginForm()
        {
            InitializeComponent();
            labError.Hide();

        }


     
        //exit button
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //empty field validation
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {

                isError = true;
                labError.Show();
                labError.Text = "Please enter username and password!";
                return;
            }


            try
            {
                string query = @"SELECT * FROM users 
                            WHERE username = @username 
                            AND password_hash = @password";

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text));

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {


                            isError = false;

                            // Session values store 
                            Session.UserId = Convert.ToInt32(reader["user_id"]);
                            Session.FullName = reader["username"].ToString();
                            Session.Role = reader["designation"].ToString();


                            //goto dashboard
                            dashboard dash = new dashboard();
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                
                            isError = true;
                            labError.Show();
                            labError.Text = "Invalid username or password!";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
             //register form open
             Register regi = new Register();  
             regi.Show();
             this.Hide();
        }

      
    }
    
}
