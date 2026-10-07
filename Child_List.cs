using child_clinic.Database;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
    public partial class Child_List : Form
    {
        public Child_List()
        {
            InitializeComponent();
            lblusername.Text = Session.FullName ?? "";
            lblUserRole.Text = Session.Role ?? "";

            LoadBabyData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           dashboard dashboard = new dashboard();
           dashboard.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Child_Form childF = new Child_Form(0,"Create");
            childF.Show();
            this.Close();
        }

        //display data in gried view
        private void LoadBabyData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT  babies.id,child_id, babies.full_name,gender,babies.age,mothers.full_name AS Mother_Name,babies.blood_group
                                    FROM babies 
                                    INNER JOIN mothers ON babies.mother_id = mothers.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvBaby.DataSource = dt;

                    // COLUMN SETTINGS
                    dgvBaby.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dgvBaby.Columns["id"].HeaderText = "ID";
                    dgvBaby.Columns["child_id"].HeaderText = "Child ID";
                    dgvBaby.Columns["full_name"].HeaderText = "Child Name";
                    dgvBaby.Columns["gender"].HeaderText = "Gender";
                    dgvBaby.Columns["age"].HeaderText = "Age";
                    dgvBaby.Columns["Mother_Name"].HeaderText = "Mother Name";
                    dgvBaby.Columns["blood_group"].HeaderText = "Blood group";

                    dgvBaby.Columns["id"].Width = 80;
                    dgvBaby.Columns["child_id"].Width = 160;
                    dgvBaby.Columns["full_name"].Width = 300;
                    dgvBaby.Columns["gender"].Width = 140;
                    dgvBaby.Columns["age"].Width = 100;
                    dgvBaby.Columns["Mother_Name"].Width = 300;
                    dgvBaby.Columns["Blood_group"].Width = 130;

                    // ADD BUTTONS
                    AddActionButtons();

                    // MOVE BUTTONS RIGHT SIDE
                    dgvBaby.Columns["View"].DisplayIndex = dgvBaby.Columns.Count - 1;
                    dgvBaby.Columns["Edit"].DisplayIndex = dgvBaby.Columns.Count - 1;
                    dgvBaby.Columns["Delete"].DisplayIndex = dgvBaby.Columns.Count - 1;

                    // BUTTON WIDTH
                    dgvBaby.Columns["View"].Width = 80;
                    dgvBaby.Columns["Edit"].Width = 80;
                    dgvBaby.Columns["Delete"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddActionButtons()
        {
            if (dgvBaby.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();

                viewBtn.Name = "View";
                viewBtn.HeaderText = "View";
                viewBtn.Text = "View";
                viewBtn.UseColumnTextForButtonValue = true;

                dgvBaby.Columns.Add(viewBtn);
            }

            if (dgvBaby.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();

                editBtn.Name = "Edit";
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;

                dgvBaby.Columns.Add(editBtn);
            }

            if (dgvBaby.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();

                deleteBtn.Name = "Delete";
                deleteBtn.HeaderText = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;

                dgvBaby.Columns.Add(deleteBtn);
            }

        }

    private void dgvBaby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvBaby.Rows[e.RowIndex].Cells["id"].Value);

            string columnName = dgvBaby.Columns[e.ColumnIndex].Name;

            // VIEW
            if (columnName == "View")
            {
                Child_Form childF = new Child_Form(id, "View");
                childF.Show();
                this.Close();
            }

            // EDIT
            else if (columnName == "Edit")
            {

                Child_Form childF = new Child_Form(id, "Edit");
                childF.Show();
                this.Close();
            }

            // DELETE
            else if (columnName == "Delete")
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
                        MySqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            MySqlCommand cmd;

                            // Delete growth records
                            cmd = new MySqlCommand( "DELETE FROM weight_tracking WHERE child_id=@id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            // Delete attendance records
                            cmd = new MySqlCommand( "DELETE FROM attendance_records WHERE child_id=@id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            // Delete nutrition records
                            cmd = new MySqlCommand( "DELETE FROM nutrition_records WHERE child_id=@id",conn, transaction);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            // Delete vaccination records
                            cmd = new MySqlCommand( "DELETE FROM vaccination_records WHERE child_id=@id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            // Finally delete baby record
                            cmd = new MySqlCommand( "DELETE FROM babies WHERE id=@id", conn, transaction);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Deleted Successfully");
                            LoadBabyData();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT  babies.id,child_id, babies.full_name,gender,babies.age,mothers.full_name AS Mother_Name,babies.blood_group
                                    FROM babies 
                                    INNER JOIN mothers ON babies.mother_id = mothers.id
                                    WHERE babies.full_name LIKE @search
                                    OR babies.child_id LIKE @search
                                    OR babies.gender LIKE @search
                                    OR babies.blood_group LIKE @search
                                    OR babies.age LIKE @search
                                    OR mothers.full_name LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" + txtSearch.Text + "%"
                    );

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvBaby.DataSource = dt;
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


    }

}
