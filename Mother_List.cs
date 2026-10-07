using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using child_clinic.Database;
using MySql.Data.MySqlClient;



namespace child_clinic
{
    public partial class Mother_List : Form
    {
        
        public Mother_List()
        {
            InitializeComponent();
            LoadMotherData();
            lblusername.Text = Session.FullName;
            lblUserRole.Text = Session.Role;



        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            MotherForm motherF = new MotherForm(0,"Create");
            motherF.Show();
            this.Close();
        }

        private void Mother_List_Load(object sender, EventArgs e)
        {

        }

        private void LoadMotherData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT id,full_name, nic, phone,age,address FROM mothers";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvMother.DataSource = dt;

                    // Column settings
                    dgvMother.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dgvMother.Columns["id"].HeaderText = "ID";
                    dgvMother.Columns["full_name"].HeaderText = "Full Name";
                    dgvMother.Columns["nic"].HeaderText = "NIC";
                    dgvMother.Columns["phone"].HeaderText = "Phone";
                    dgvMother.Columns["age"].HeaderText = "Age";
                    dgvMother.Columns["address"].HeaderText = "Address";

                    dgvMother.Columns["id"].Width = 50;
                    dgvMother.Columns["full_name"].Width = 400;
                    dgvMother.Columns["nic"].Width = 150;
                    dgvMother.Columns["phone"].Width = 150;
                    dgvMother.Columns["age"].Width = 80;
                    dgvMother.Columns["address"].Width = 400;


                    // ADD BUTTONS AFTER DATASOURCE
                    AddActionButtons();

                    //  move buttons to right side
                    dgvMother.Columns["View"].DisplayIndex = dgvMother.Columns.Count - 1;
                    dgvMother.Columns["Edit"].DisplayIndex = dgvMother.Columns.Count - 1;
                    dgvMother.Columns["Delete"].DisplayIndex = dgvMother.Columns.Count - 1;

                    //  button column width
                    dgvMother.Columns["View"].Width = 80;
                    dgvMother.Columns["Edit"].Width = 80;
                    dgvMother.Columns["Delete"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddActionButtons()
        {
            if (dgvMother.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                viewBtn.Name = "View";
                viewBtn.HeaderText = "View";
                viewBtn.Text = "View";
                viewBtn.UseColumnTextForButtonValue = true;
                dgvMother.Columns.Add(viewBtn);


            }

            if (dgvMother.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "Edit";
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                dgvMother.Columns.Add(editBtn);
               
            }

            if (dgvMother.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Delete";
                deleteBtn.HeaderText = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvMother.Columns.Add(deleteBtn);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT id,full_name, nic, phone,age,address  FROM mothers
                             WHERE full_name LIKE @search
                             OR nic LIKE @search
                             OR phone LIKE @search
                             OR address LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvMother.DataSource = dt;

                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbluserrole_Click(object sender, EventArgs e)
        {

        }

        private void dgvMother_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvMother.Rows[e.RowIndex].Cells["id"].Value);

            string columnName = dgvMother.Columns[e.ColumnIndex].Name;

            // VIEW
            if (columnName == "View")
            {
                MotherForm motherF = new MotherForm(id, "View");
                motherF.Show();
                this.Close();
            }

            // EDIT
            else if (columnName == "Edit")
            {
   
                MotherForm motherF = new MotherForm(id, "Edit");
                motherF.Show();
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
                        string query = "DELETE FROM mothers WHERE id=@id";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Deleted Successfully");

                    LoadMotherData();
                }
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