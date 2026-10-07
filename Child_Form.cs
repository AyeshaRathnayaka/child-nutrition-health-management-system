using child_clinic.Database;
using iTextSharp.text.pdf; //pdf genereate library
using iTextSharp.text;
using MySql.Data.MySqlClient;// database backup library
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace child_clinic
{
    public partial class Child_Form : Form
    {
        private int child_Id = 0;
        private bool isEditMode = false;
        private bool isViewMode = false;
        private bool isCreateMode = false;


        public Child_Form(int id, string Mode)
        {
            InitializeComponent();

            lblusername.Text = Session.FullName ?? "";
            lblUserRole.Text = Session.Role ?? "";

            child_Id = id;
            lblChildDetails.Text = Mode + " Baby's Details";

            LoadMotherNames();
            GenerateChildID();
            LoadVaccinationRecords();

            //mother names search or type
            cmbMotherName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMotherName.AutoCompleteSource = AutoCompleteSource.ListItems;

            //child profile create time 
            txtChildID.ReadOnly = true;
            txtBMI.ReadOnly = true;
            txtCurrentWeight.ReadOnly = true;
            txtCurrentHeight.ReadOnly = true;
            txtGrowth.ReadOnly = true;
            txtNutritional.ReadOnly = true;
            btnUpdate.Visible = false;

            // field typing disable
            cmbMotherName.DropDownStyle = ComboBoxStyle.DropDown; 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBlood.DropDownStyle = ComboBoxStyle.DropDownList;

            //nutrition record loard
            if (child_Id > 0)
            {
                LoadNutritionRecords();
            }

            //Age calculate from dob
            txtAge.ReadOnly = true;
            dtpdob.ValueChanged += dtpdob_ValueChanged;

            //error messege show
            lblErrorWT.Hide();
            lblRegiError.Hide();
            lblRegiError2.Hide();
            lblNutritionAlert.Hide();


            

            // Attendance date only today
            dtpAttendance.MinDate = DateTime.Today;
            dtpAttendance.MaxDate = DateTime.Today;
            dtpAttendance.Value = DateTime.Today;

            //select the mode
            if (Mode == "Edit")
            {
                isEditMode = true;
                LoadChildDetails();
                LoadWeightTracking();
                LoadGrowthChart();
                btnRegister.Visible = false;
                btnUpdate.Visible = true;

                //vaccine date change disable
                dtpVaccinationDate.Enabled = false;

                //attendance
                LoadAttendanceRecords();


            }
            else if (Mode == "View")
            {
                isViewMode = true;
                LoadChildDetails();
                LoadWeightTracking();
                LoadGrowthChart();
                btnRegister.Visible = false;

                //attendance
                LoadAttendanceRecords();

            }
            else
            {
                isCreateMode = true;

                //create mode tab Vaccine disable
                tabVaccine.Enabled = false;
            }


            // View mode
            if (isViewMode)
            {
                DisableFields();
                dgvWeight.Columns["Delete"].Visible = false;
            }
        }




        //mother Names Load
        private void LoadMotherNames()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT id, full_name FROM mothers";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbMotherName.Items.Add(
                            new ComboBoxItem(
                                reader["full_name"].ToString(),
                                reader["id"].ToString()
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // GENERATE CHILD ID
        private void GenerateChildID()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT id FROM babies ORDER BY id DESC LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                    txtChildID.Text = "CHD-" + count.ToString("D6"); //D = Decimal numbe 6 = The total number of digits must be 6
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Validation --------------------------------------------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //child name validation
                if (txtChildName.Text.Trim() == "")
                {
                    lblRegiError.Show();
                    lblRegiError.Text = ("* Enter Child Name");
                    txtChildName.Focus();
                    return;
                }
                     lblRegiError.Hide();

                //child name ,only letters validation
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtChildName.Text,@"^[a-zA-Z\s]+$"))
                {
                    lblRegiError.Show();
                    lblRegiError.Text =  " * Only letters allowed. No numbers or special characters!";
                    txtChildName.Focus();
                    return;
                }
                    lblRegiError.Hide();

                //gender
                if(comboBoxGender.SelectedIndex == -1)
                {
                    lblRegiError.Show();
                    lblRegiError.Text = " * Select Gender";
                    comboBoxGender.Focus();
                    return;
                }
                lblRegiError.Hide();


                //Mother
                if (cmbMotherName.SelectedItem == null)
                {
                    lblRegiError.Show();
                    lblRegiError.Text = " * Select Mother";
                    cmbMotherName.Focus();
                    return;
                }
                lblRegiError.Hide();

                //Age
                if(txtAge.Text.Trim() == "")
                {
                    lblRegiError.Show();
                    lblRegiError.Text = " * Select Date Of Birth";
                    txtAge.Focus();
                    return;
                }
                lblRegiError.Hide();

                // CHILD AGE LIMIT
                DateTime dob = dtpdob.Value;
                DateTime today = DateTime.Today;
                int years = today.Year - dob.Year;

                // Check if the birthday has not occurred yet this year
                if (today.DayOfYear < dob.DayOfYear)
                {
                    years--;
                }

                if (years > 5)
                {
                    lblRegiError.Show();
                    lblRegiError.Text = " * Child age cannot be more than 6 years!";
                    dtpdob.Focus();
                    return;
                }

                lblRegiError.Hide();




                // ADDRESS
                if (txtAddress.Text.Trim() == "")
                {
                    lblRegiError.Show();
                    lblRegiError.Text = " * Enter Address";
                    txtAddress.Focus();
                    return;
                }
                    lblRegiError.Hide();



                // BLOOD GROUP
                string blood = cmbBlood.Text.ToUpper();

                if (cmbBlood.SelectedItem == null)
                {
                    lblRegiError2.Show();
                    lblRegiError2.Text = " * Enter Blood Group!";
                    cmbBlood.Focus();
                    return;
                }
                lblRegiError2.Hide();




                // BIRTH WEIGHT
                if (txtBirthWeight.Text.Trim() == "")
                {
                    lblRegiError2.Show();
                    lblRegiError2.Text = " * Enter Birth Weight";
                    txtBirthWeight.Focus();
                    return;
                }
                lblRegiError2.Hide();

                double birthWeight;

                if (!double.TryParse(txtBirthWeight.Text, out birthWeight))
                {
                    lblRegiError2.Show();
                    lblRegiError2.Text = " * Birth Weight must be numbers only!";
                    txtBirthWeight.Focus();
                    return;
                }
                lblRegiError2.Hide();

                if (birthWeight <= 0 || birthWeight >= 10)
                {
                    lblRegiError2.Show();
                    lblRegiError2.Text = " * Enter valid Birth Weight!";
                    txtBirthWeight.Focus();
                    return;
                }
                lblRegiError2.Hide();


                lblRegiError.Hide();
                lblRegiError2.Hide();
                lblErrorWT.Hide();


                ComboBoxItem selectedMother =(ComboBoxItem)cmbMotherName.SelectedItem;

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO babies
                    (
                        child_id,
                        full_name,
                        gender,
                        age,
                        mother_id,
                        date_of_birth,
                        address,
                        blood_group,
                        birth_weight
                    )
                    VALUES
                    (
                        @child_id,
                        @full_name,
                        @gender,
                        @age,
                        @mother_id,
                        @date_of_birth,
                        @address,
                        @blood_group,
                        @birth_weight
                    )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@child_id", txtChildID.Text);
                    cmd.Parameters.AddWithValue("@full_name", txtChildName.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue( "@mother_id",
                        selectedMother.Value
                    );

                    cmd.Parameters.AddWithValue("@date_of_birth",dtpdob.Value.Date);
                    cmd.Parameters.AddWithValue("@address",txtAddress.Text);
                    cmd.Parameters.AddWithValue("@blood_group", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@birth_weight",txtBirthWeight.Text.Replace(" kg", ""));
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Baby Registered Successfully!");

                  
                    ClearFields();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // Age calculate from dob 
        private void dtpdob_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dtpdob.Value;
            DateTime today = DateTime.Today;

            int years = today.Year - dob.Year;
            int months = today.Month - dob.Month;
            int days = today.Day - dob.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(today.Year,today.AddMonths(-1).Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }


            // AGE LIMIT VALIDATION
            if (years > 5)
            {
                lblRegiError.Show();
                lblRegiError.Text = " * Child age cannot be more than 6 years!";
                txtAge.Clear();
                return;
            }
            if (dob > today)
            {
                lblRegiError.Show();
                lblRegiError.Text = " *Cannot enter a date earlier than the current date!";
                txtAge.Clear();
                return;
            }
            lblRegiError.Hide();


            // DISPLAY AGE
            if (years > 0)
            {
                txtAge.Text = years + " Years " + months + " Months";
            }
            else if (months > 0)
            {
                txtAge.Text = months + " Months";
            }
            else
            {
                txtAge.Text =days + " Days";
            }
        }




        // COMBOBOX ITEM CLASS - mothers name list load
        public class ComboBoxItem
        {
            public string Text { get; set; }

            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            // Display only the mother's name in the ComboBox
            public override string ToString()
            {
                return Text;
            }
        }



        //clear fields
        private void ClearFields()
        {
            txtChildName.Clear();
            txtAge.Clear();
            

            txtAddress.Clear();
            txtBirthWeight.Clear();

            txtCurrentWeight.Clear();
            txtCurrentHeight.Clear();

            txtGrowth.Clear();
            txtNutritional.Clear();

            comboBoxGender.SelectedIndex = -1;
            cmbMotherName.SelectedIndex = -1;

            dtpdob.Value = DateTime.Today;

            cmbBlood.SelectedIndex = -1;
            GenerateChildID();
        }

        //only numbers alowed as age. 
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

        //disable fields
        private void DisableFields()
        {
           
            // Basic Details
            txtChildName.ReadOnly = true;
            txtChildID.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtAddress.ReadOnly = true;

            // ComboBox (dropdown disable)
            comboBoxGender.Enabled = false;
            cmbMotherName.Enabled = false;
            cmbBlood.Enabled = false;

            // Date picker disable
            dtpdob.Enabled = false;

            // Quick Info (growth / nutrition section)
            txtBirthWeight.ReadOnly = true;
            txtCurrentWeight.ReadOnly = true;
            txtCurrentHeight.ReadOnly = true;
            txtGrowth.ReadOnly = true;
            txtNutritional.ReadOnly = true;

            // Weight Trackingacking

            txtWeight.ReadOnly = true;
            txtHeight.ReadOnly = true;
            txtBMI.ReadOnly = true;

            dtpRecordDate.Enabled = false;

            btnAddWeight.Enabled = false;

            // Vaccination Tracking
            txtVaccineDetails.ReadOnly = true;
            txtNextVaccineName.ReadOnly = true;
            dtpVaccinationDate.Enabled = false;
            dtpNextVaccineDate.Enabled = false;
            btnAddVaccine.Enabled = false;
            dgvVaccination.Enabled = false;



            //Nutrition field disable
            txtNutritionName.ReadOnly = true;
            dtpNutritionDate.Enabled = false;
            btnAddNutrition.Enabled = false;
            dgvNutrition.Enabled = false;


            // Attendance
            cmbAttendance.Enabled = false;
            txtAttendanceNote.ReadOnly = true;
            dtpAttendance.Enabled = false;
            btnAddAttendance.Enabled = false;
            dgvAttendance.Enabled = false;
        }

        //loadchild details
        private void LoadChildDetails()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM babies WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", child_Id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Basic Details
                        txtChildID.Text = reader["child_id"].ToString();
                        txtChildName.Text = reader["full_name"].ToString();
                        txtAge.Text = reader["age"].ToString();
                        txtAddress.Text = reader["address"].ToString();

                        comboBoxGender.Text = reader["gender"].ToString();

                        // Load the child's date of birth into the DateTimePicker
                        if (reader["date_of_birth"] != DBNull.Value)
                            dtpdob.Value = Convert.ToDateTime(reader["date_of_birth"]);


                        // Mother (ComboBox)
                        int motherId = Convert.ToInt32(reader["mother_id"]);

                        foreach (ComboBoxItem item in cmbMotherName.Items)
                        {
                            if (item.Value == motherId.ToString())
                            {
                                cmbMotherName.SelectedItem = item;
                                break;
                            }
                        }

                        // Quick Info
                        cmbBlood.Text = reader["blood_group"].ToString();


                        //birth weight
                        txtBirthWeight.Text= reader["birth_weight"].ToString();
                    }
                    reader.Close();





                    // Load latest weight tracking data for Current Weight, Height, Growth Status
                    string weightQuery = @"SELECT weight, height, bmi 
                                   FROM weight_tracking 
                                   WHERE child_id = @child_id 
                                   ORDER BY recorded_date DESC 
                                   LIMIT 1";

                    MySqlCommand weightCmd = new MySqlCommand(weightQuery, conn);
                    weightCmd.Parameters.AddWithValue("@child_id", child_Id);
                    MySqlDataReader weightReader = weightCmd.ExecuteReader();

                    if (weightReader.Read())
                    {
                        txtCurrentWeight.Text = weightReader["weight"].ToString();
                        txtCurrentHeight.Text = weightReader["height"].ToString();

                        txtGrowth.Text = GetGrowthStatus(Convert.ToDouble( weightReader["bmi"]));
                        lblNutritionAlert.Text = GetAllertStatus(Convert.ToDouble(weightReader["bmi"]));
                    }
                    weightReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //Growth status
        private string GetGrowthStatus(double bmi) //https://www.who.int/tools/child-growth-standards?utm_source=chatgpt.com BMI Citation
        {
            if (bmi < 14)
            {
                return "Underweight";
            }
            else if (bmi >= 14 && bmi < 17)
            {
                return "Healthy";
            }
            else if (bmi >= 17 && bmi < 19)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }



        //Alert 

        private string GetAllertStatus(double bmi)
        {
            // UNDERWEIGHT
            if (bmi < 14)
            {
                lblNutritionAlert.Show();
                lblNutritionAlert.BackColor = Color.MistyRose;

                lblNutritionAlert.ForeColor = Color.Red;

                txtNutritional.Text = "Nutritional Support Required";
                return "This child is underweight and may need vitamins, nutritious food, or Thriposha supplements !.";
            }

            // HEALTHY
            else if (bmi >= 14 && bmi < 17)
            {
                lblNutritionAlert.Show();
                lblNutritionAlert.BackColor = Color.Honeydew;

                lblNutritionAlert.ForeColor = Color.DarkGreen;
                txtNutritional.Text = "Good Nutritional Status";

                return "This child has a healthy growth status and balanced nutrition.";
            }

            // OVERWEIGHT
            else if (bmi >= 17 && bmi < 19)
            {
                lblNutritionAlert.Show();
                lblNutritionAlert.BackColor = Color.LemonChiffon;

                lblNutritionAlert.ForeColor = Color.DarkOrange;
                txtNutritional.Text = "Monitor Dietary Habits";

                return "This child may be overweight. Healthy eating and physical activities are recommended.";
            }

            // OBESE
            else
            {
                lblNutritionAlert.Show();
                lblNutritionAlert.BackColor = Color.LightPink;

                lblNutritionAlert.ForeColor = Color.DarkRed;

                txtNutritional.Text = "Special Nutritional Care Required";

                return "This child may be at risk of obesity and needs nutritional and medical attention !.";
            }
        }

        //loadweight tracking
        private void LoadWeightTracking()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT id ,weight, height ,bmi,recorded_date FROM weight_tracking WHERE child_id=@child_id ORDER BY recorded_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@child_id", child_Id);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvWeight.DataSource = dt;
                    // Hide ID column
                    dgvWeight.Columns["id"].Visible = false;

                    // Remove empty row
                    dgvWeight.AllowUserToAddRows = false;
                    dgvWeight.DefaultCellStyle.Font =new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
                    dgvWeight.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvWeight.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    if (dgvWeight.Columns["Delete"] == null)
                    {
                        DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();

                        deleteBtn.Name = "Delete";
                        deleteBtn.HeaderText = "Delete";
                        deleteBtn.Text = "Delete";
                        deleteBtn.UseColumnTextForButtonValue = true;

                        dgvWeight.Columns.Add(deleteBtn);
                    }
                    dgvWeight.Columns["Delete"].DisplayIndex = dgvWeight.Columns.Count - 1;





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Add weight
        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            try
            {
               //only unable to add record to edit mode validation
                if (!isEditMode)
                {
                    MessageBox.Show("This Feature only available for edit mode.");
                    return;
                }
                

                //validation for weight
                if (txtWeight.Text == "" || txtWeight.Text == " ")
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Weight Can not empty weight field!";
                    return;
                }
                double weight;

                if (!double.TryParse(txtWeight.Text, out weight))
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Weight is Numbers only!";
                    return;
                }

                if (weight <= 0)
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Weight must be greater than 0!";
                    return;
                }

                if (weight >= 50)
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Weight must be less than 50kg!";
                    return;
                }

                lblErrorWT.Hide();

                //validation for height
                if (txtHeight.Text == "" || txtHeight.Text == " ")
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Height Can not empty Height field!";
                    return;
                }
                double height;

                if (!double.TryParse(txtHeight.Text, out height))
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * Height is Numbers only!";
                    return;
                }

                if (height <= 0)
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * height must be greater than 0!";
                    return;
                }

                if (height >= 130)
                {
                    lblErrorWT.Show();
                    lblErrorWT.Text = " * height must be less than 130!";
                    return;
                }

                lblErrorWT.Hide();


                // CHECK SAME DATE RECORD EXISTS
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string checkQuery = @"SELECT COUNT(*)
                          FROM weight_tracking
                          WHERE child_id = @child_id
                          AND recorded_date = @recorded_date";

                    MySqlCommand checkCmd =new MySqlCommand(checkQuery, conn);

                    checkCmd.Parameters.AddWithValue( "@child_id",child_Id);

                    checkCmd.Parameters.AddWithValue( "@recorded_date", dtpRecordDate.Value.Date );

                    int count =Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        lblErrorWT.Show();
                        lblErrorWT.Text =" * A weight record already exists for this date!";
                        dtpRecordDate.Focus();
                        return;
                    }

                    lblErrorWT.Hide();
                }








                // Insert child weight, height, BMI, and recorded date into the database
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO weight_tracking
                                    (child_id, weight, height, bmi, recorded_date)
                                    VALUES
                                    (@child_id, @weight, @height, @bmi, @recorded_date)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@child_id", child_Id);
                    cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@height", txtHeight.Text);

                    cmd.Parameters.AddWithValue("@bmi", txtBMI.Text);
                    cmd.Parameters.AddWithValue("@recorded_date", dtpRecordDate.Value.Date);

                    // Execute the insert query
                    cmd.ExecuteNonQuery();

                    txtWeight.Clear();
                    txtHeight.Clear();
                    txtBMI.Clear();


                    LoadWeightTracking();
                    LoadGrowthChart();
                    LoadChildDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }




        //Calculate BMI
        private void CalculateBMI()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWeight.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text))
                {
                    txtBMI.Text = "";
                    return;
                }

                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // cm -> meter convert
                height = height / 100;

                if (height <= 0) return;

                double bmi = weight / (height * height);

                txtBMI.Text = bmi.ToString("0.00");
            }
            catch
            {
                txtBMI.Text = "";
            }
        }
    





        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }



        //load growth chart
        private void LoadGrowthChart()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT recorded_date, weight
                                     FROM weight_tracking
                                     WHERE child_id=@child_id
                                     ORDER BY recorded_date ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@child_id", child_Id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    chartGrowth.Series.Clear();

                    Series series = new Series("Weight");
                    series.ChartType = SeriesChartType.Line;
                    series.BorderWidth = 3;

                    while (reader.Read())
                    {
                        DateTime date = Convert.ToDateTime(reader["recorded_date"]);
                        double weight = Convert.ToDouble(reader["weight"]);

                        series.Points.AddXY(date.ToString("dd/MM/yyyy"), weight);
                    }

                    chartGrowth.Series.Add(series);

                    chartGrowth.ChartAreas[0].AxisX.Title = "Date";
                    chartGrowth.ChartAreas[0].AxisY.Title = "Weight (Kg)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // Add Vaccine Validation
        private void btnAddVaccine_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDATION
                if (txtVaccineDetails.Text == "")
                {
                    MessageBox.Show("Enter Vaccination Details");

                    return;
                }

                if (txtNextVaccineName.Text == "")
                {
                    MessageBox.Show("Enter Next Vaccine Name");

                    return;
                }

                using (
                    MySqlConnection conn =
                    DatabaseConnection.GetConnection()
                )
                {
                    string query = @"INSERT INTO vaccination_records
                                    (
                                        child_id,
                                        vaccination_details,
                                        vaccination_date,
                                        next_vaccine_name,
                                        next_vaccine_date
                                    )
                                    VALUES
                                    (
                                        @child_id,
                                        @vaccination_details,
                                        @vaccination_date,
                                        @next_vaccine_name,
                                        @next_vaccine_date
                                    )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@child_id", child_Id);
                    cmd.Parameters.AddWithValue("@vaccination_details", txtVaccineDetails.Text);
                    cmd.Parameters.AddWithValue("@vaccination_date", dtpVaccinationDate.Value.Date);
                    cmd.Parameters.AddWithValue("@next_vaccine_name", txtNextVaccineName.Text);
                    cmd.Parameters.AddWithValue("@next_vaccine_date", dtpNextVaccineDate.Value.Date);

                    cmd.ExecuteNonQuery();


                    // CLEAR FIELDS
                    txtVaccineDetails.Clear();
                    txtNextVaccineName.Clear();
                    dtpVaccinationDate.Value = DateTime.Now;
                    dtpNextVaccineDate.Value = DateTime.Now;

                    LoadVaccinationRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //load Vaccination Records
        private void LoadVaccinationRecords()
        {
            try
            {
                using (
                    MySqlConnection conn = DatabaseConnection.GetConnection()
                )
                {
                    string query = @"SELECT
                                vaccination_details,
                                vaccination_date,
                                next_vaccine_name,
                                next_vaccine_date
                                FROM vaccination_records
                                WHERE child_id=@child_id
                                ORDER BY vaccination_date DESC";

                    MySqlCommand cmd =new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@child_id",child_Id);

                    MySqlDataAdapter da =new MySqlDataAdapter(cmd); // create data adapter

                    DataTable dt =new DataTable(); //create data table

                    da.Fill(dt);

                    dgvVaccination.DataSource = dt;
                    
                    //dgv font normal and aligment
                    dgvVaccination.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
                    dgvVaccination.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvVaccination.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //Add Nutrition
        private void btnAddNutrition_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // VALIDATION
                    if (txtNutritionName.Text == "")
                    {
                        MessageBox.Show(
                            "Enter Nutrition Name"
                        );

                        return;
                    }

                    using ( MySqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        string query = @"
                                        INSERT INTO nutrition_records
                                        (
                                            child_id,
                                            nutrition_name,
                                            nutrition_date
                                        )
                                        VALUES
                                        (
                                            @child_id,
                                            @nutrition_name,
                                            @nutrition_date
                                        )";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@child_id",child_Id);
                        cmd.Parameters.AddWithValue("@nutrition_name",txtNutritionName.Text);
                        cmd.Parameters.AddWithValue("@nutrition_date",dtpNutritionDate.Value.Date);
                        cmd.ExecuteNonQuery();
                        
                        txtNutritionName.Clear();

                        dtpNutritionDate.Value = DateTime.Now;

                        LoadNutritionRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //load Nutrition
                private void LoadNutritionRecords()
                 {
                    try
                    {
                    using (MySqlConnection conn = DatabaseConnection.GetConnection())
                        {
                             string query = @"SELECT
                                            nutrition_name AS 'Nutrition Name',
                                            nutrition_date AS 'Nutrition Date'
                                            FROM nutrition_records
                                            WHERE child_id=@child_id
                                            ORDER BY nutrition_date DESC";

                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            cmd.Parameters.AddWithValue("@child_id",child_Id );

                            MySqlDataAdapter da =new MySqlDataAdapter(cmd);
                            
                            // Fill the DataTable with data from the database
                            DataTable dt =new DataTable();
    
                            da.Fill(dt);

                            dgvNutrition.DataSource = dt;

                            dgvNutrition.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
                            dgvNutrition.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            dgvNutrition.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        }
                     }
                    catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message);
                     }
                }


        //Attendance btn
        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isEditMode)
                {
                    MessageBox.Show("Attendance can only be added in Edit Mode.");
                    return;
                }

                if (cmbAttendance.Text == "")
                {
                    MessageBox.Show("Select Attendance Status");
                    return;
                }

                using (MySqlConnection conn =DatabaseConnection.GetConnection())
                {
                    // CHECK SAME DATE ATTENDANCE EXISTS
                    string checkQuery = @"SELECT COUNT(*)
                      FROM attendance_records
                      WHERE child_id=@child_id
                      AND attendance_date=@attendance_date";

                    MySqlCommand checkCmd =
                        new MySqlCommand(checkQuery, conn);

                    checkCmd.Parameters.AddWithValue(
                        "@child_id",
                        child_Id
                    );

                    checkCmd.Parameters.AddWithValue(
                        "@attendance_date",
                        dtpAttendance.Value.Date
                    );

                    int count =
                        Convert.ToInt32(
                            checkCmd.ExecuteScalar()
                        );

                    if (count > 0)
                    {
                        MessageBox.Show(
                            "Attendance for this date already exists!"
                        );
                        return;
                    }



                    string query = @"INSERT INTO attendance_records
                            (
                                child_id,
                                attendance_date,
                                attendance_status,
                                notes
                            )
                            VALUES
                            (
                                @child_id,
                                @attendance_date,
                                @attendance_status,
                                @notes
                            )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@child_id",
                        child_Id
                    );

                    cmd.Parameters.AddWithValue(
                        "@attendance_date",
                        dtpAttendance.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@attendance_status",
                        cmbAttendance.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@notes",
                        txtAttendanceNote.Text
                    );

                    cmd.ExecuteNonQuery();

                    cmbAttendance.SelectedIndex = -1;

                    txtAttendanceNote.Clear();

                    dtpAttendance.Value = DateTime.Today;

                    LoadAttendanceRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //load attendance 
        private void LoadAttendanceRecords()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT id ,
                            attendance_date AS 'Date',
                            attendance_status AS 'Status',
                            notes AS 'Notes'
                            FROM attendance_records
                            WHERE child_id=@child_id
                            ORDER BY attendance_date DESC";

                    MySqlCommand cmd =new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@child_id",child_Id);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvAttendance.DataSource = dt;
                    dgvAttendance.Columns["id"].Visible = false;


                    //ATTENDANCE DLT----------------------------------
                    // Hide empty row
                    dgvAttendance.AllowUserToAddRows = false;

                    // Delete button
                    if (dgvAttendance.Columns["Delete"] == null)
                    {
                        DataGridViewButtonColumn deleteBtn =
                            new DataGridViewButtonColumn();

                        deleteBtn.Name = "Delete";
                        deleteBtn.HeaderText = "Delete";
                        deleteBtn.Text = "Delete";
                        deleteBtn.UseColumnTextForButtonValue = true;

                        dgvAttendance.Columns.Add(deleteBtn);
                    }

                    dgvAttendance.Columns["Delete"].DisplayIndex =
                        dgvAttendance.Columns.Count - 1;

                    //--------------------------------------------------


                    dgvAttendance.DefaultCellStyle.Font =
                        new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);

                    dgvAttendance.DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleLeft;
                    dgvAttendance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void picMother_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenMotherList(this);
        }

        private void dgvWeight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvWeight.Rows[e.RowIndex].Cells["id"].Value);

            string columnName = dgvWeight.Columns[e.ColumnIndex].Name;

             // DELETE
            if (columnName == "Delete")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        string query = "DELETE FROM weight_tracking WHERE id=@id";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Deleted Successfully");

                    LoadChildDetails();
                    LoadWeightTracking();
                    LoadGrowthChart();
                }
            }
        }


        //generate pdf report
        private void GeneratePDFReport()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "PDF File|*.pdf";

                sfd.FileName =txtChildName.Text + "_Report.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);

                    PdfWriter.GetInstance( doc, new FileStream( sfd.FileName, FileMode.Create ) );

                    doc.Open();

                    // TITLE
                    iTextSharp.text.Font titleFont =FontFactory.GetFont( FontFactory.HELVETICA_BOLD, 20f );

                    Paragraph title =
                        new Paragraph("Child Medical Report", titleFont);

                    title.Alignment = Element.ALIGN_CENTER;

                    doc.Add(title);

                    doc.Add(new Paragraph(" "));

                    // CHILD DETAILS
                    PdfPTable table = new PdfPTable(2);

                    table.WidthPercentage = 100;

                    table.AddCell("Child ID");
                    table.AddCell(txtChildID.Text);

                    table.AddCell("Child Name");
                    table.AddCell(txtChildName.Text);

                    table.AddCell("Gender");
                    table.AddCell(comboBoxGender.Text);

                    table.AddCell("Age");
                    table.AddCell(txtAge.Text);

                    table.AddCell("Blood Group");
                    table.AddCell(cmbBlood.Text);

                    table.AddCell("Birth Weight");
                    table.AddCell(txtBirthWeight.Text);

                    table.AddCell("Current Weight");
                    table.AddCell(txtCurrentWeight.Text);

                    table.AddCell("Current Height");
                    table.AddCell(txtCurrentHeight.Text);

                    table.AddCell("Growth Status");
                    table.AddCell(txtGrowth.Text);

                    table.AddCell("Nutrition Status");
                    table.AddCell(txtNutritional.Text);

                    doc.Add(table);

                    doc.Add(new Paragraph(" "));

                    // ALERT MESSAGE
                    Paragraph alert = new Paragraph( lblNutritionAlert.Text);

                    doc.Add(alert);
                    doc.Add(new Paragraph(" "));


                      //Add report to weight and vaccination ---------------------------

                    // WEIGHT TRACKING TITLE

                    Paragraph weightTitle = new Paragraph( "Weight Tracking Records" );

                    weightTitle.Alignment = Element.ALIGN_LEFT;

                    doc.Add(weightTitle);

                    doc.Add(new Paragraph(" "));

                    // WEIGHT TABLE
                    PdfPTable weightTable =new PdfPTable(4);

                    weightTable.WidthPercentage = 100;

                    // TABLE HEADERS
                    weightTable.AddCell("Date");
                    weightTable.AddCell("Weight");
                    weightTable.AddCell("Height");
                    weightTable.AddCell("BMI");

                    using (MySqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        string query =
                            @"SELECT
                            recorded_date,
                            weight,
                            height,
                            bmi
                          FROM weight_tracking
                          WHERE child_id=@child_id
                          ORDER BY recorded_date DESC";

                        MySqlCommand cmd =new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue( "@child_id", child_Id );
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            weightTable.AddCell(Convert.ToDateTime(reader["recorded_date"] ).ToString("dd/MM/yyyy") );
                            weightTable.AddCell( reader["weight"].ToString() );
                            weightTable.AddCell( reader["height"].ToString() );
                            weightTable.AddCell(reader["bmi"].ToString());
                        }
                        reader.Close();
                    }

                    // ADD TABLE TO PDF
                    doc.Add(weightTable);

                    doc.Add(new Paragraph(" "));



                    // VACCINATION TITLE-----------
                    Paragraph vaccineTitle =
                        new Paragraph(
                            "Vaccination Records"
                        );

                    doc.Add(vaccineTitle);

                    doc.Add(new Paragraph(" "));

                    // TABLE
                    PdfPTable vaccineTable =
                        new PdfPTable(4);

                    vaccineTable.WidthPercentage = 100;

                    vaccineTable.AddCell("Vaccination");
                    vaccineTable.AddCell("Vaccination Date");
                    vaccineTable.AddCell("Next Vaccine");
                    vaccineTable.AddCell("Next Date");

                    using (MySqlConnection conn =
                        DatabaseConnection.GetConnection())
                    {
                        string query =
                            @"SELECT vaccination_details,
                             vaccination_date,
                             next_vaccine_name,
                             next_vaccine_date
                          FROM vaccination_records
                          WHERE child_id=@child_id
                          ORDER BY vaccination_date DESC";

                        MySqlCommand cmd =new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@child_id",child_Id);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            vaccineTable.AddCell( reader["vaccination_details"].ToString() );
                            vaccineTable.AddCell( Convert.ToDateTime(reader["vaccination_date"] ).ToString("dd/MM/yyyy") );
                            vaccineTable.AddCell( reader["next_vaccine_name"].ToString());
                            vaccineTable.AddCell( Convert.ToDateTime(reader["next_vaccine_date"]).ToString("dd/MM/yyyy") );
                        }
                    }

                    doc.Add(vaccineTable);

                    doc.Add(new Paragraph(" "));
                    //---------------------------------------

                    // DATE
                    Paragraph date =new Paragraph("Generated Date : " + DateTime.Now.ToString());

                    doc.Add(date);

                    doc.Close();

                    MessageBox.Show("PDF Report Generated Successfully!"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            GeneratePDFReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"UPDATE babies 
                             SET full_name=@name,
                                 age=@age,
                                 address=@address,
                                 gender=@gender,
                                 blood_group=@blood,
                                 birth_weight=@birth_weight,
                                date_of_birth=@date_of_birth
                             WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtChildName.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dtpdob.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    cmd.Parameters.AddWithValue("@blood", cmbBlood.Text);

                    cmd.Parameters.AddWithValue("@id", child_Id);
                    cmd.Parameters.AddWithValue("@birth_weight", txtBirthWeight.Text.Replace(" kg", ""));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Child details updated successfully!");

                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       


        //FOR ATTENDANCE DLT 
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int id = Convert.ToInt32(dgvAttendance.Rows[e.RowIndex].Cells["id"].Value);

            string columnName =
                dgvAttendance.Columns[e.ColumnIndex].Name;

            // DELETE
            if (columnName == "Delete")
            {
                // View mode block
                if (isViewMode)
                {
                    MessageBox.Show(
                        "Delete is not allowed in View Mode!"
                    );
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn =
                        DatabaseConnection.GetConnection())
                    {
                        string query =
                            @"DELETE FROM attendance_records
                      WHERE id=@id";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            id
                        );


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Attendance Deleted Successfully!"
                    );

                    LoadAttendanceRecords();

                }
            }
        }
    }



}
