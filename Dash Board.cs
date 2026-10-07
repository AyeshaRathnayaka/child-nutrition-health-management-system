using child_clinic.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace child_clinic
{
    public partial class dashboard : Form
    {
       
        public dashboard()
        {
            InitializeComponent();
            lblusername.Text = Session.FullName;
            lblUserRole.Text = Session.Role;

            LoadDashboardCounts();
            LoadGrowthStatusChart();
            LoadMonthlyClinicVisits();
            LoadAttendanceOverview();
            LoadUpcomingVaccines();

        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //goto login form and session logout
            Session.UserId = 0;
            Session.FullName = "";
            Session.Role = "";

            LoginForm logi = new LoginForm(); 
            logi.Show();
            this.Close();
        }


        private void btnmother_Click(object sender, EventArgs e)
        {
           
            Mother_List mother = new Mother_List();
            mother.Show();
            this.Close();
        }


        private void btnchild_Click(object sender, EventArgs e)
        {
            Child_List child = new Child_List();
            child.Show();
            this.Close();
        }

        // LOAD COUNTS
        private void LoadDashboardCounts()
        {
            try
            {
                using (MySqlConnection conn =DatabaseConnection.GetConnection())
                {
                    // TOTAL MOTHERS
                    string motherQuery ="SELECT COUNT(*) FROM mothers";

                    MySqlCommand motherCmd =new MySqlCommand( motherQuery, conn);

                    lblTotalMothers.Text =  motherCmd.ExecuteScalar().ToString();


                    // TOTAL BABIES
                    string babyQuery = "SELECT COUNT(*) FROM babies";

                    MySqlCommand babyCmd = new MySqlCommand(babyQuery,conn);

                    lblTotalBabies.Text = babyCmd.ExecuteScalar().ToString();


                    // HEALTHY CHILDREN
                    string healthyQuery = @"
                                        SELECT COUNT(*)
                                        FROM weight_tracking wt
                                        WHERE bmi >= 14
                                        AND bmi < 17
                                        AND id IN (
                                            SELECT MAX(id)
                                            FROM weight_tracking
                                            GROUP BY child_id
                                        )";

                    MySqlCommand healthyCmd = new MySqlCommand( healthyQuery, conn);

                    lblHealthy.Text =healthyCmd.ExecuteScalar().ToString();


                    // UNDERWEIGHT
                    string underQuery = @"SELECT COUNT(*)
                                        FROM weight_tracking wt
                                        WHERE bmi < 14
                                        AND id IN (
                                            SELECT MAX(id)
                                            FROM weight_tracking
                                            GROUP BY child_id
                                        )";

                    MySqlCommand underCmd = new MySqlCommand(underQuery, conn );

                    lblUnderweight.Text =underCmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // PIE CHART
        private void LoadGrowthStatusChart()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    chartGrowth.Series.Clear();

                    Series series = new Series("Growth");

                    series.ChartType = SeriesChartType.Pie;

                    series.IsValueShownAsLabel = true;

                    // HEALTHY
                    string healthyQuery = @"SELECT COUNT(*)
                                            FROM weight_tracking wt
                                            WHERE bmi >= 14
                                            AND bmi < 17
                                            AND id IN (
                                                SELECT MAX(id)
                                                FROM weight_tracking
                                                GROUP BY child_id
                                            );";

                    MySqlCommand healthyCmd =new MySqlCommand(healthyQuery, conn);

                    int healthy = Convert.ToInt32(healthyCmd.ExecuteScalar() );

                    // UNDERWEIGHT
                    string underQuery = @"SELECT COUNT(*)
                                        FROM weight_tracking wt
                                        WHERE bmi < 14
                                        AND id IN (
                                            SELECT MAX(id)
                                            FROM weight_tracking
                                            GROUP BY child_id
                                        );";

                    MySqlCommand underCmd =
                        new MySqlCommand( underQuery,conn);

                    int underweight =  Convert.ToInt32( underCmd.ExecuteScalar());

                    // OVERWEIGHT
                    string overQuery = @"SELECT COUNT(*)
                                        FROM weight_tracking wt
                                        WHERE bmi >= 17
                                        AND bmi < 19
                                        AND id IN (
                                            SELECT MAX(id)
                                            FROM weight_tracking
                                            GROUP BY child_id
                                        );";

                    MySqlCommand overCmd = new MySqlCommand(overQuery,conn);

                    int overweight =Convert.ToInt32(overCmd.ExecuteScalar());

                    // OBESITY
                    string obesityQuery = @"SELECT COUNT(*)
                                            FROM weight_tracking wt
                                            WHERE bmi >= 19
                                            AND id IN (
                                                SELECT MAX(id)
                                                FROM weight_tracking
                                                GROUP BY child_id
                                            );";

                    MySqlCommand obesityCmd = new MySqlCommand(obesityQuery,conn );

                    int obesity = Convert.ToInt32( obesityCmd.ExecuteScalar());

                    series.Points.AddXY("Healthy",healthy);

                    series.Points.AddXY("Underweight",underweight);

                    series.Points.AddXY("Overweight",overweight);

                    series.Points.AddXY("Obesity",obesity);

                    chartGrowth.Series.Add(series);

                    chartGrowth.Legends[0].Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // MONTHLY CLINIC VISITS
        private void LoadMonthlyClinicVisits()
        {
            try
            {
                using (MySqlConnection conn =DatabaseConnection.GetConnection())
                {
                    chartVisits.Series.Clear();

                    Series series = new Series("Visits");

                    series.ChartType = SeriesChartType.Column;

                    string query = @"SELECT MONTH(attendance_date) AS month, COUNT(*) AS total FROM attendance_records GROUP BY MONTH(attendance_date)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader =cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        series.Points.AddXY( reader["month"].ToString(), reader["total"]);
                    }

                    chartVisits.Series.Add(series);

                    chartVisits.ChartAreas[0].AxisX.Title = "Month";

                    chartVisits.ChartAreas[0].AxisY.Title = "Clinic Visits";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ATTENDANCE OVERVIEW (TODAY)
        private void LoadAttendanceOverview()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    chartAttendance.Series.Clear();

                    Series series =  new Series("Attendance");

                    series.ChartType = SeriesChartType.Pie;

                    series.IsValueShownAsLabel = true;

                    // TOTAL CHILDREN
                    string totalQuery = "SELECT COUNT(*) FROM babies";

                    MySqlCommand totalCmd = new MySqlCommand(totalQuery, conn);

                    int totalChildren = Convert.ToInt32( totalCmd.ExecuteScalar() );

                    // PRESENT CHILDREN
                    string presentQuery =@"SELECT COUNT(DISTINCT child_id)
                  FROM attendance_records
                  WHERE attendance_date = CURDATE()
                  AND attendance_status = 'Present'";

                    MySqlCommand presentCmd = new MySqlCommand( presentQuery,conn);

                    int present =Convert.ToInt32(presentCmd.ExecuteScalar());

                    // ABSENT CHILDREN
                    int absent = totalChildren - present;

                    // PIE CHART
                    series.Points.AddXY( "Present",present);

                    series.Points.AddXY("Absent",absent);

                    chartAttendance.Series.Add(series);

                    chartAttendance.Legends[0].Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // UPCOMING VACCINES (NEXT 7 DAYS)
        private void LoadUpcomingVaccines()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query =
                        @"SELECT
                    b.full_name AS child_name,
                    v.next_vaccine_name,
                    v.next_vaccine_date
                  FROM vaccination_records v
                  INNER JOIN babies b
                  ON v.child_id = b.id
                  WHERE v.next_vaccine_date
                  BETWEEN CURDATE()
                  AND DATE_ADD(CURDATE(), INTERVAL 7 DAY)
                  ORDER BY v.next_vaccine_date ASC";

                    MySqlDataAdapter adapter =new MySqlDataAdapter( query,conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvUpcomingVaccines.DataSource = dt;

                    dgvUpcomingVaccines.Columns["child_name"].HeaderText = "Child Name";

                    dgvUpcomingVaccines.Columns["next_vaccine_name"].HeaderText = "Vaccine";

                    dgvUpcomingVaccines.Columns["next_vaccine_date"].HeaderText = "Next Vaccine Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblviewDetails_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenMotherList(this);
        }

        private void lblviewC_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenChildList(this);
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenChildList(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenChildList(this);
        }

        private void btnDBbackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Backup folder
                string backupFolder = @"D:\Clinic_Backups\";

                // Create folder if not exists
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                // Backup file name
                string fileName = "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") +".sql";

                string backupPath = Path.Combine(backupFolder, fileName);

                // MySQL dump path
                string mysqlDumpPath =  @"C:\xampp\mysql\bin\mysqldump.exe";

                // Database details
                string database = "child_clinic";
                string username = "root";
                string password = "";

                // Command
                string command =$"-u {username} {database} -r \"{backupPath}\"";

                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = mysqlDumpPath;
                psi.Arguments = command;

                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                Process process = Process.Start(psi);

                process.WaitForExit();

                MessageBox.Show("Database Backup Created Successfully!"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblBackupLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string backupFolder = @"D:\Clinic_Backups\";
                System.Diagnostics.Process.Start(
                    "explorer.exe",
                    backupFolder
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
