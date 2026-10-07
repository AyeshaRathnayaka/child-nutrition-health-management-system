using child_clinic.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace child_clinic
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            lblRegiError.Hide();
        }

        // goto login form
        private void lblsignup_Click(object sender, EventArgs e)
        {
            LoginForm logi = new LoginForm(); 
            logi.Show();
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            // 1. Validation all fields
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtNIC.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            //NIC VAlidation -----------------------------------------------------
            string nic = txtNIC.Text.Trim();

            // Length check
            if (!(nic.Length == 10 || nic.Length == 12))
            {
                lblRegiError.Show();
                lblRegiError.Text="Invalid NIC Length!";
                return;
            }
            lblRegiError.Hide();


            // 10 digit old NIC format (9 numbers + V only)
            if (nic.Length == 10)
            {
                // First 9 characters must be numbers
                if (!nic.Substring(0, 9).All(char.IsDigit) ||
                    nic[9] != 'V')
                {
                    lblRegiError.Show();
                    lblRegiError.Text = "Old NIC must contain 9 digits and end with V only!";
                    return;
                }
                lblRegiError.Hide();
            }
            lblRegiError.Hide();


            // 12 digit new NIC format (numbers only)
            if (nic.Length == 12)
            {
                if (!nic.All(char.IsDigit))
                {
                    lblRegiError.Show();
                    lblRegiError.Text = "New NIC must contain numbers only!";
                    return;
                }
                lblRegiError.Hide();
                lblRegiError.Hide();
            //---------------------------------------------------------------------


            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblRegiError.Show();
                lblRegiError.Text = "Passwords do not match!";
                return;
            }
            lblRegiError.Hide();



            string gender = "";

            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
          


                // 2. Save to DB
                    
            try
                {
                    string query = @"INSERT INTO users 
                                     (username, full_name, designation, nic,gender, password_hash)
                                     VALUES 
                                     (@username, @fullName, @designation, @nic,@gender, @password)";

                    using (MySqlConnection conn = DatabaseConnection.GetConnection()) // Calls the GetConnection() method from the DatabaseConnection class  and stores the MySQL connection object in the 'conn' variable.

                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) // Creates a command object named 'cmd' to execute the SQL query using the database connection.
                    {
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@designation", cmbboxDesignation.Text);
                        cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text));

                        cmd.ExecuteNonQuery(); //SQL command execute method.

                        MessageBox.Show("Registration Successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Login form 
                        LoginForm logi = new LoginForm();
                        logi.Show();
                        this.Close();
                    }
                }

                // error catch from db
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Username or NIC already exists!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Database Error: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            //error catch from code
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SHA-256 Hash
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        
    }
    
}
