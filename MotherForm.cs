using child_clinic.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace child_clinic
{
    public partial class MotherForm : Form
    {
        private int motherId = 0;
        private bool isEditMode = false;
        private bool isViewMode = false;
        private bool isCreateMode = false;
        bool isDeliveryDateSelected = false;
        bool isRegDateSelected = false;




        public MotherForm(int id, String Mode)
        {

            InitializeComponent();
            lblusername.Text = Session.FullName ?? "";
            lblUserRole.Text = Session.Role ?? "";

            motherId = id;
            lblMdetails.Text = Mode + " Mother Details";

            //Age from dob 
            dateDOB.ValueChanged += dateDOB_ValueChanged;
            txtAge.ReadOnly = true;


            //select the mode------------------
            if (Mode == "Edit")
            {
                isEditMode = true;
                LoadMotherDetails();
                btnReset.Visible = false;

            } else if(Mode == "View")
            {

                isViewMode = true;
                LoadMotherDetails();
                btnReset.Visible = false;
               
            }
            else
            {
                isCreateMode = true;
                btnReset.Visible = true;
            }

            // View mode-----------------
            if (isViewMode)
            {
                DisableFields();
                btnSave.Enabled = false;
                btnSave.Visible = false;
            }


            //error msg hide-------------
            lblRegiError.Hide();
            lblRegiError2.Hide();
            lblRegiError3.Hide();

            //blood only select,can't type
            cmbBlood.DropDownStyle = ComboBoxStyle.DropDownList;

            //User cannot select a past date in delvery date
            dateDelivery.MinDate = DateTime.Today;

            //regi date disable
            dateRegi.Enabled = false;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //username 
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                lblRegiError.Show();
                lblRegiError.Text = ("* Enter mother Name");
                txtusername.Focus();
                return;
            }
            lblRegiError.Hide();



            //NIC
            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                lblRegiError.Show();
                lblRegiError.Text = ("* Please enter NIC");
                txtNIC.Focus();
                return;
            }
            lblRegiError.Hide();

            if (!(txtNIC.Text.Length == 10 || txtNIC.Text.Length == 12))
            {
                lblRegiError.Show();
                lblRegiError.Text = ("*NIC must be 10 or 12 characters long");
                txtNIC.Focus();
                return;
            }

            lblRegiError.Hide();



            //Age
            if (txtAge.Text.Trim() == "")
            {
                lblRegiError.Show();
                lblRegiError.Text = " * Select Date Of Birth";
                txtAge.Focus();
                return;
            }
            lblRegiError.Hide();


            // DOB VALIDATION
            if (dateDOB.Value.Date > DateTime.Now.Date)
            {
                lblRegiError.Show();
                lblRegiError.Text = "* Invalid date of birth!";
                dateDOB.Focus();
                return;
            }
            lblRegiError.Hide();



            // AGE AUTO CALCULATE
            DateTime dob = dateDOB.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (today.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            txtAge.Text = age.ToString();



            //phone number
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblRegiError.Show();
                lblRegiError.Text = "Please enter phone number";
                txtPhone.Focus();
                return;
            }

            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number must contain 10 digits");
                txtPhone.Focus();
                return;
            }



            //pregnancy status----redio button
            if (!rbYes.Checked && !rbNo.Checked)
            {
                lblRegiError2.Show();
                lblRegiError2.Text="Please select pregnancy status";
                return;
            }
            // PREGNANCY MONTH
            if (rbYes.Checked &&
                comboBox1.SelectedIndex == -1)
            {
                lblRegiError2.Show();
                lblRegiError2.Text =
                "* Please select pregnancy month";
                comboBox1.Focus();
                return;
            }


            // DELIVERY DATE VALIDATION
            if (rbYes.Checked && dateDelivery.Value.Date < DateTime.Today)
            {
                lblRegiError2.Show();
                lblRegiError2.Text = "* Delivery date cannot be earlier than today!";
                dateDelivery.Focus();
                return;
            }

            lblRegiError2.Hide();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string pregnancyStatus = "";

                    if (rbYes.Checked)
                    {
                        pregnancyStatus = "Yes";
                    }
                    else if (rbNo.Checked)
                    {
                        pregnancyStatus = "No";
                    }

                    string query = "";
                    if (isEditMode)
                    {
                        query = @"UPDATE mothers SET
                                full_name=@full_name,
                                nic=@nic,
                                dob=@dob,
                                age=@age,
                                address=@address,
                                phone=@phone,
                                blood_group=@blood_group,
                                medical_condition=@medical_condition,
                                allergies=@allergies,
                                emergency_contact_person=@emergency_contact_person,
                                emergency_contact_number=@emergency_contact_number,
                                pregnancy_status=@pregnancy_status,
                                pregnancy_month=@pregnancy_month,
                                expected_delivery_date=@expected_delivery_date,
                                doctor_name=@doctor_name,
                                registration_date=@registration_date,
                                notes=@notes
                                WHERE id=@id";
                    }
                    else
                    {
                        query = @"INSERT INTO mothers
                        (
                            full_name,
                            nic,
                            dob,
                            age,
                            address,
                            phone,
                            blood_group,
                            medical_condition,
                            allergies,
                            emergency_contact_person,
                            emergency_contact_number,
                            pregnancy_status,
                            pregnancy_month,
                            expected_delivery_date,
                            doctor_name,
                            registration_date,
                            notes
                        )
                        VALUES
                        (
                            @full_name,
                            @nic,
                            @dob,
                            @age,
                            @address,
                            @phone,
                            @blood_group,
                            @medical_condition,
                            @allergies,
                            @emergency_contact_person,
                            @emergency_contact_number,
                            @pregnancy_status,
                            @pregnancy_month,
                            @expected_delivery_date,
                            @doctor_name,
                            @registration_date,
                            @notes
                        )";

                    }


                        MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@full_name", txtusername.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@dob", dateDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    cmd.Parameters.AddWithValue("@blood_group", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@medical_condition", txtMedical.Text);
                    cmd.Parameters.AddWithValue("@allergies", txtAllergies.Text);
                    cmd.Parameters.AddWithValue("@emergency_contact_person", txtEmergency.Text);
                    cmd.Parameters.AddWithValue("@emergency_contact_number", txtEmergencyNo.Text);

                    cmd.Parameters.AddWithValue("@pregnancy_status", pregnancyStatus);
                    cmd.Parameters.AddWithValue("@pregnancy_month", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@expected_delivery_date", dateDelivery.Value.Date);
                    cmd.Parameters.AddWithValue("@doctor_name", txtNameDoctor.Text);

                    cmd.Parameters.AddWithValue("@registration_date", dateRegi.Value.Date);
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text);

                    if (isEditMode)
                    {
                        cmd.Parameters.AddWithValue("@id", motherId);
                    }
                    cmd.ExecuteNonQuery();


                    ClearFields();

                    if (isEditMode)
                    {
                        LoadMotherDetails();
                        MessageBox.Show("Mother Details updated Successfully!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Mother Details Saved Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void ClearFields()
        {
            txtusername.Clear();
            txtNIC.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtPhone.Clear();

            cmbBlood.SelectedIndex = -1;
            txtMedical.Clear();
            txtAllergies.Clear();
            txtEmergency.Clear();
            txtEmergencyNo.Clear();

            comboBox1.SelectedIndex = -1;

            txtNameDoctor.Clear();
            txtNotes.Clear();

            rbYes.Checked = false;
            rbNo.Checked = false;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DisableFields()
        {
            txtusername.ReadOnly = true;
            txtNIC.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhone.ReadOnly = true;

            cmbBlood.Enabled = false;
            txtMedical.ReadOnly = true;
            txtAllergies.ReadOnly = true;
            txtEmergency.ReadOnly = true;
            txtEmergencyNo.ReadOnly = true;

            txtNameDoctor.ReadOnly = true;
            txtNotes.ReadOnly = true;

            comboBox1.Enabled = false;

            dateDOB.Enabled = false;
            dateDelivery.Enabled = false;
            

            rbYes.Enabled = false;
            rbNo.Enabled = false;
        }






        private void LoadMotherDetails()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM mothers WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", motherId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtusername.Text = reader["full_name"].ToString();
                        txtNIC.Text = reader["nic"].ToString();
                        txtAge.Text = reader["age"].ToString();
                        txtAddress.Text = reader["address"].ToString();
                        txtPhone.Text = reader["phone"].ToString();

                        cmbBlood.Text = reader["blood_group"].ToString();
                        txtMedical.Text = reader["medical_condition"].ToString();
                        txtAllergies.Text = reader["allergies"].ToString();
                        txtEmergency.Text = reader["emergency_contact_person"].ToString();
                        txtEmergencyNo.Text = reader["emergency_contact_number"].ToString();

                        comboBox1.Text = reader["pregnancy_month"].ToString();
                        txtNameDoctor.Text = reader["doctor_name"].ToString();
                        txtNotes.Text = reader["notes"].ToString();

                        dateDOB.Value = Convert.ToDateTime(reader["dob"]);
                        dateDelivery.Value = Convert.ToDateTime(reader["expected_delivery_date"]);
                        dateRegi.Value = Convert.ToDateTime(reader["registration_date"]);

                        if (reader["pregnancy_status"].ToString() == "Yes")
                        {
                            rbYes.Checked = true;
                        }
                        else
                        {
                            rbNo.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Mother_List motherL = new Mother_List();
            motherL.Show();
            this.Close();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mother_List motherL = new Mother_List();
            motherL.Show();
            this.Close();
        }

        private void dateDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateDOB.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (today.DayOfYear < dob.DayOfYear)
            {
                age--;
            }
            txtAge.Text = age.ToString();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenDashboard(this);
        }

        private void picChild_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenChildList(this);
        }


        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                comboBox1.Enabled = false;
                dateDelivery.Enabled = false;
                txtNameDoctor.ReadOnly = true;

                // Optional clear fields
                comboBox1.SelectedIndex = -1;
                txtNameDoctor.Clear();
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                comboBox1.Enabled = true;
                dateDelivery.Enabled = true;
                txtNameDoctor.ReadOnly = false;
            }
        }


        private void picMother_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenMotherList(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
