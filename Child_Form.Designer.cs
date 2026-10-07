using System.Drawing;
using System.Windows.Forms;

namespace child_clinic
{
    partial class Child_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Child_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChildDetails = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picChild = new System.Windows.Forms.PictureBox();
            this.picMother = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.lblRegiError2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNutritional = new System.Windows.Forms.TextBox();
            this.lblNutritional = new System.Windows.Forms.Label();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.txtCurrentHeight = new System.Windows.Forms.TextBox();
            this.lblCurrentHeight = new System.Windows.Forms.Label();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.txtBirthWeight = new System.Windows.Forms.TextBox();
            this.lblBirthWeight = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegiError = new System.Windows.Forms.Label();
            this.cmbMotherName = new System.Windows.Forms.ComboBox();
            this.lblNutritionAlert = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblbasic = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.txtChildID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.lblChildName = new System.Windows.Forms.Label();
            this.tabWeight = new System.Windows.Forms.TabPage();
            this.lblErrorWT = new System.Windows.Forms.Label();
            this.chartGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.dgvWeight = new System.Windows.Forms.DataGridView();
            this.lblWeightTrack = new System.Windows.Forms.Label();
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.tabNutrition = new System.Windows.Forms.TabPage();
            this.lblNutritionDate = new System.Windows.Forms.Label();
            this.dgvNutrition = new System.Windows.Forms.DataGridView();
            this.lblNutritionName = new System.Windows.Forms.Label();
            this.lblNutrition = new System.Windows.Forms.Label();
            this.btnAddNutrition = new System.Windows.Forms.Button();
            this.dtpNutritionDate = new System.Windows.Forms.DateTimePicker();
            this.txtNutritionName = new System.Windows.Forms.TextBox();
            this.tabVaccination = new System.Windows.Forms.TabPage();
            this.lblVacDate = new System.Windows.Forms.Label();
            this.lblNextVaccDate = new System.Windows.Forms.Label();
            this.dtpNextVaccineDate = new System.Windows.Forms.DateTimePicker();
            this.dgvVaccination = new System.Windows.Forms.DataGridView();
            this.lblNextVaccine = new System.Windows.Forms.Label();
            this.lblVaccineDetails = new System.Windows.Forms.Label();
            this.lblVaccineTracking = new System.Windows.Forms.Label();
            this.btnAddVaccine = new System.Windows.Forms.Button();
            this.txtNextVaccineName = new System.Windows.Forms.TextBox();
            this.dtpVaccinationDate = new System.Windows.Forms.DateTimePicker();
            this.txtVaccineDetails = new System.Windows.Forms.TextBox();
            this.tabVaccine = new System.Windows.Forms.TabControl();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAttendance = new System.Windows.Forms.ComboBox();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.lblAttendanceNote = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.dtpAttendance = new System.Windows.Forms.DateTimePicker();
            this.txtAttendanceNote = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMother)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).BeginInit();
            this.tabNutrition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrition)).BeginInit();
            this.tabVaccination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccination)).BeginInit();
            this.tabVaccine.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Controls.Add(this.lblChildDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picLogout, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 78);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblChildDetails
            // 
            this.lblChildDetails.AutoSize = true;
            this.lblChildDetails.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.lblChildDetails.Location = new System.Drawing.Point(4, 0);
            this.lblChildDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildDetails.Name = "lblChildDetails";
            this.lblChildDetails.Size = new System.Drawing.Size(314, 60);
            this.lblChildDetails.TabIndex = 7;
            this.lblChildDetails.Text = "Babies Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1532, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.lblUserRole);
            this.panel1.Location = new System.Drawing.Point(1605, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 55);
            this.panel1.TabIndex = 9;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblusername.Location = new System.Drawing.Point(17, 1);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblusername.Size = new System.Drawing.Size(101, 32);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "Username";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblUserRole.Location = new System.Drawing.Point(49, 32);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(43, 23);
            this.lblUserRole.TabIndex = 7;
            this.lblUserRole.Text = "Role";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel6.Controls.Add(this.picHome);
            this.panel6.Controls.Add(this.picChild);
            this.panel6.Controls.Add(this.picMother);
            this.panel6.Location = new System.Drawing.Point(1272, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 55);
            this.panel6.TabIndex = 11;
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::child_clinic.Properties.Resources.HomeNav;
            this.picHome.Location = new System.Drawing.Point(31, 6);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(43, 48);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 11;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picChild
            // 
            this.picChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picChild.Image = ((System.Drawing.Image)(resources.GetObject("picChild.Image")));
            this.picChild.Location = new System.Drawing.Point(89, 1);
            this.picChild.Margin = new System.Windows.Forms.Padding(4);
            this.picChild.Name = "picChild";
            this.picChild.Size = new System.Drawing.Size(65, 55);
            this.picChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChild.TabIndex = 10;
            this.picChild.TabStop = false;
            this.picChild.Click += new System.EventHandler(this.picChild_Click);
            // 
            // picMother
            // 
            this.picMother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMother.Image = ((System.Drawing.Image)(resources.GetObject("picMother.Image")));
            this.picMother.Location = new System.Drawing.Point(165, 0);
            this.picMother.Margin = new System.Windows.Forms.Padding(4);
            this.picMother.Name = "picMother";
            this.picMother.Size = new System.Drawing.Size(65, 55);
            this.picMother.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMother.TabIndex = 8;
            this.picMother.TabStop = false;
            this.picMother.Click += new System.EventHandler(this.picMother_Click);
            // 
            // picLogout
            // 
            this.picLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::child_clinic.Properties.Resources.ChatGPT_Image_May_27__2026__11_06_02_PM1;
            this.picLogout.Location = new System.Drawing.Point(1776, 7);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Padding = new System.Windows.Forms.Padding(4);
            this.picLogout.Size = new System.Drawing.Size(129, 49);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 12;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1924, 443);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnPDF);
            this.panel4.Controls.Add(this.cmbBlood);
            this.panel4.Controls.Add(this.lblRegiError2);
            this.panel4.Controls.Add(this.btnRegister);
            this.panel4.Controls.Add(this.txtNutritional);
            this.panel4.Controls.Add(this.lblNutritional);
            this.panel4.Controls.Add(this.txtGrowth);
            this.panel4.Controls.Add(this.lblGrowth);
            this.panel4.Controls.Add(this.txtCurrentHeight);
            this.panel4.Controls.Add(this.lblCurrentHeight);
            this.panel4.Controls.Add(this.txtCurrentWeight);
            this.panel4.Controls.Add(this.lblCurrentWeight);
            this.panel4.Controls.Add(this.txtBirthWeight);
            this.panel4.Controls.Add(this.lblBirthWeight);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lblBlood);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(1167, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 424);
            this.panel4.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(287, 361);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 44);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Image = global::child_clinic.Properties.Resources.report__;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.Location = new System.Drawing.Point(683, 85);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(56, 60);
            this.btnPDF.TabIndex = 52;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // cmbBlood
            // 
            this.cmbBlood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBlood.Location = new System.Drawing.Point(99, 197);
            this.cmbBlood.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(111, 36);
            this.cmbBlood.TabIndex = 51;
            // 
            // lblRegiError2
            // 
            this.lblRegiError2.BackColor = System.Drawing.Color.Transparent;
            this.lblRegiError2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiError2.ForeColor = System.Drawing.Color.Red;
            this.lblRegiError2.Location = new System.Drawing.Point(71, 134);
            this.lblRegiError2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegiError2.Name = "lblRegiError2";
            this.lblRegiError2.Size = new System.Drawing.Size(391, 28);
            this.lblRegiError2.TabIndex = 50;
            this.lblRegiError2.Text = "error";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(493, 361);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(199, 44);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNutritional
            // 
            this.txtNutritional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.txtNutritional.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNutritional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.txtNutritional.Location = new System.Drawing.Point(415, 197);
            this.txtNutritional.Margin = new System.Windows.Forms.Padding(4);
            this.txtNutritional.Multiline = true;
            this.txtNutritional.Name = "txtNutritional";
            this.txtNutritional.Size = new System.Drawing.Size(281, 40);
            this.txtNutritional.TabIndex = 45;
            // 
            // lblNutritional
            // 
            this.lblNutritional.AutoSize = true;
            this.lblNutritional.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutritional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNutritional.Location = new System.Drawing.Point(411, 170);
            this.lblNutritional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutritional.Name = "lblNutritional";
            this.lblNutritional.Size = new System.Drawing.Size(153, 23);
            this.lblNutritional.TabIndex = 44;
            this.lblNutritional.Text = "Nutritional Status";
            // 
            // txtGrowth
            // 
            this.txtGrowth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.txtGrowth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.txtGrowth.Location = new System.Drawing.Point(415, 303);
            this.txtGrowth.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrowth.Multiline = true;
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(281, 40);
            this.txtGrowth.TabIndex = 43;
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblGrowth.Location = new System.Drawing.Point(411, 268);
            this.lblGrowth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(125, 23);
            this.lblGrowth.TabIndex = 42;
            this.lblGrowth.Text = "Growth Status";
            // 
            // txtCurrentHeight
            // 
            this.txtCurrentHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txtCurrentHeight.Location = new System.Drawing.Point(253, 302);
            this.txtCurrentHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentHeight.Multiline = true;
            this.txtCurrentHeight.Name = "txtCurrentHeight";
            this.txtCurrentHeight.Size = new System.Drawing.Size(123, 40);
            this.txtCurrentHeight.TabIndex = 41;
            // 
            // lblCurrentHeight
            // 
            this.lblCurrentHeight.AutoSize = true;
            this.lblCurrentHeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblCurrentHeight.Location = new System.Drawing.Point(249, 277);
            this.lblCurrentHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentHeight.Name = "lblCurrentHeight";
            this.lblCurrentHeight.Size = new System.Drawing.Size(131, 23);
            this.lblCurrentHeight.TabIndex = 40;
            this.lblCurrentHeight.Text = "Current Height";
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txtCurrentWeight.Location = new System.Drawing.Point(89, 303);
            this.txtCurrentWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentWeight.Multiline = true;
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(123, 40);
            this.txtCurrentWeight.TabIndex = 39;
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblCurrentWeight.Location = new System.Drawing.Point(85, 277);
            this.lblCurrentWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(135, 23);
            this.lblCurrentWeight.TabIndex = 38;
            this.lblCurrentWeight.Text = "Current Weight";
            // 
            // txtBirthWeight
            // 
            this.txtBirthWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txtBirthWeight.Location = new System.Drawing.Point(253, 197);
            this.txtBirthWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthWeight.Multiline = true;
            this.txtBirthWeight.Name = "txtBirthWeight";
            this.txtBirthWeight.Size = new System.Drawing.Size(123, 40);
            this.txtBirthWeight.TabIndex = 37;
            // 
            // lblBirthWeight
            // 
            this.lblBirthWeight.AutoSize = true;
            this.lblBirthWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblBirthWeight.Location = new System.Drawing.Point(249, 170);
            this.lblBirthWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthWeight.Name = "lblBirthWeight";
            this.lblBirthWeight.Size = new System.Drawing.Size(114, 23);
            this.lblBirthWeight.TabIndex = 36;
            this.lblBirthWeight.Text = "Birth Weight";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 79);
            this.panel5.TabIndex = 35;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 12);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(99, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quick Info";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblBlood.Location = new System.Drawing.Point(95, 170);
            this.lblBlood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(112, 23);
            this.lblBlood.TabIndex = 24;
            this.lblBlood.Text = "Blood Group";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblRegiError);
            this.panel2.Controls.Add(this.cmbMotherName);
            this.panel2.Controls.Add(this.lblNutritionAlert);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.lblAge);
            this.panel2.Controls.Add(this.comboBoxGender);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.dtpdob);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lbldob);
            this.panel2.Controls.Add(this.lblMotherName);
            this.panel2.Controls.Add(this.txtChildID);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.txtChildName);
            this.panel2.Controls.Add(this.lblChildName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 424);
            this.panel2.TabIndex = 1;
            // 
            // lblRegiError
            // 
            this.lblRegiError.BackColor = System.Drawing.Color.Transparent;
            this.lblRegiError.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiError.ForeColor = System.Drawing.Color.Red;
            this.lblRegiError.Location = new System.Drawing.Point(319, 134);
            this.lblRegiError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegiError.Name = "lblRegiError";
            this.lblRegiError.Size = new System.Drawing.Size(391, 28);
            this.lblRegiError.TabIndex = 49;
            this.lblRegiError.Text = "error";
            // 
            // cmbMotherName
            // 
            this.cmbMotherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotherName.FormattingEnabled = true;
            this.cmbMotherName.Location = new System.Drawing.Point(323, 277);
            this.cmbMotherName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMotherName.Name = "cmbMotherName";
            this.cmbMotherName.Size = new System.Drawing.Size(352, 36);
            this.cmbMotherName.TabIndex = 43;
            // 
            // lblNutritionAlert
            // 
            this.lblNutritionAlert.AutoSize = true;
            this.lblNutritionAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNutritionAlert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutritionAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNutritionAlert.Location = new System.Drawing.Point(317, 85);
            this.lblNutritionAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutritionAlert.Name = "lblNutritionAlert";
            this.lblNutritionAlert.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNutritionAlert.Size = new System.Drawing.Size(169, 32);
            this.lblNutritionAlert.TabIndex = 47;
            this.lblNutritionAlert.Text = "Nutritional Status";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(745, 270);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(352, 40);
            this.txtAge.TabIndex = 40;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAge.Location = new System.Drawing.Point(741, 245);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 23);
            this.lblAge.TabIndex = 39;
            this.lblAge.Text = "Age";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(745, 197);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(352, 36);
            this.comboBoxGender.TabIndex = 38;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblGender.Location = new System.Drawing.Point(741, 167);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 23);
            this.lblGender.TabIndex = 37;
            this.lblGender.Text = "Gender";
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(323, 358);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(352, 34);
            this.dtpdob.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblbasic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 79);
            this.panel3.TabIndex = 35;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lblbasic
            // 
            this.lblbasic.AutoSize = true;
            this.lblbasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblbasic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.lblbasic.Location = new System.Drawing.Point(99, 22);
            this.lblbasic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbasic.Name = "lblbasic";
            this.lblbasic.Size = new System.Drawing.Size(222, 32);
            this.lblbasic.TabIndex = 19;
            this.lblbasic.Text = "Child Basic Deatils";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(745, 358);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(352, 40);
            this.txtAddress.TabIndex = 34;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAddress.Location = new System.Drawing.Point(741, 334);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 23);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbldob.Location = new System.Drawing.Point(319, 334);
            this.lbldob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(118, 23);
            this.lbldob.TabIndex = 31;
            this.lbldob.Text = "Date Of Birth";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblMotherName.Location = new System.Drawing.Point(319, 245);
            this.lblMotherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(121, 23);
            this.lblMotherName.TabIndex = 29;
            this.lblMotherName.Text = "Mother Name";
            // 
            // txtChildID
            // 
            this.txtChildID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtChildID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.txtChildID.Location = new System.Drawing.Point(17, 354);
            this.txtChildID.Margin = new System.Windows.Forms.Padding(4);
            this.txtChildID.Multiline = true;
            this.txtChildID.Name = "txtChildID";
            this.txtChildID.Size = new System.Drawing.Size(263, 40);
            this.txtChildID.TabIndex = 28;
            this.txtChildID.Text = "CHD-000123";
            this.txtChildID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblID.Location = new System.Drawing.Point(104, 334);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 23);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "Child ID";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 94);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(263, 236);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // txtChildName
            // 
            this.txtChildName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildName.ForeColor = System.Drawing.Color.Black;
            this.txtChildName.Location = new System.Drawing.Point(323, 192);
            this.txtChildName.Margin = new System.Windows.Forms.Padding(4);
            this.txtChildName.Multiline = true;
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(352, 40);
            this.txtChildName.TabIndex = 25;
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblChildName.Location = new System.Drawing.Point(319, 167);
            this.lblChildName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(91, 23);
            this.lblChildName.TabIndex = 24;
            this.lblChildName.Text = "Full Name";
            // 
            // tabWeight
            // 
            this.tabWeight.Controls.Add(this.lblErrorWT);
            this.tabWeight.Controls.Add(this.chartGrowth);
            this.tabWeight.Controls.Add(this.lblBMI);
            this.tabWeight.Controls.Add(this.lblHeight);
            this.tabWeight.Controls.Add(this.lblWeight);
            this.tabWeight.Controls.Add(this.dgvWeight);
            this.tabWeight.Controls.Add(this.lblWeightTrack);
            this.tabWeight.Controls.Add(this.btnAddWeight);
            this.tabWeight.Controls.Add(this.txtBMI);
            this.tabWeight.Controls.Add(this.txtHeight);
            this.tabWeight.Controls.Add(this.dtpRecordDate);
            this.tabWeight.Controls.Add(this.txtWeight);
            this.tabWeight.Location = new System.Drawing.Point(4, 44);
            this.tabWeight.Margin = new System.Windows.Forms.Padding(4);
            this.tabWeight.Name = "tabWeight";
            this.tabWeight.Padding = new System.Windows.Forms.Padding(4);
            this.tabWeight.Size = new System.Drawing.Size(1916, 464);
            this.tabWeight.TabIndex = 3;
            this.tabWeight.Text = "Weight Tracking";
            this.tabWeight.UseVisualStyleBackColor = true;
            // 
            // lblErrorWT
            // 
            this.lblErrorWT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblErrorWT.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorWT.ForeColor = System.Drawing.Color.Red;
            this.lblErrorWT.Location = new System.Drawing.Point(23, 57);
            this.lblErrorWT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorWT.Name = "lblErrorWT";
            this.lblErrorWT.Size = new System.Drawing.Size(391, 28);
            this.lblErrorWT.TabIndex = 48;
            this.lblErrorWT.Text = "error";
            // 
            // chartGrowth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrowth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrowth.Legends.Add(legend1);
            this.chartGrowth.Location = new System.Drawing.Point(1227, 87);
            this.chartGrowth.Margin = new System.Windows.Forms.Padding(4);
            this.chartGrowth.Name = "chartGrowth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrowth.Series.Add(series1);
            this.chartGrowth.Size = new System.Drawing.Size(651, 338);
            this.chartGrowth.TabIndex = 47;
            this.chartGrowth.Text = "chart2";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblBMI.Location = new System.Drawing.Point(505, 85);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(47, 23);
            this.lblBMI.TabIndex = 46;
            this.lblBMI.Text = "BMI ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblHeight.Location = new System.Drawing.Point(240, 85);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(111, 23);
            this.lblHeight.TabIndex = 45;
            this.lblHeight.Text = "Height (cm) ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblWeight.Location = new System.Drawing.Point(19, 85);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(113, 23);
            this.lblWeight.TabIndex = 44;
            this.lblWeight.Text = "Weight (Kg) ";
            // 
            // dgvWeight
            // 
            this.dgvWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeight.BackgroundColor = System.Drawing.Color.White;
            this.dgvWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWeight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWeight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWeight.EnableHeadersVisualStyles = false;
            this.dgvWeight.Location = new System.Drawing.Point(33, 187);
            this.dgvWeight.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWeight.Name = "dgvWeight";
            this.dgvWeight.ReadOnly = true;
            this.dgvWeight.RowHeadersVisible = false;
            this.dgvWeight.RowHeadersWidth = 51;
            this.dgvWeight.Size = new System.Drawing.Size(1165, 190);
            this.dgvWeight.TabIndex = 43;
            this.dgvWeight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeight_CellContentClick);
            // 
            // lblWeightTrack
            // 
            this.lblWeightTrack.AutoSize = true;
            this.lblWeightTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblWeightTrack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.lblWeightTrack.Location = new System.Drawing.Point(896, 20);
            this.lblWeightTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeightTrack.Name = "lblWeightTrack";
            this.lblWeightTrack.Size = new System.Drawing.Size(218, 38);
            this.lblWeightTrack.TabIndex = 42;
            this.lblWeightTrack.Text = "Weight Traking";
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnAddWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWeight.ForeColor = System.Drawing.Color.White;
            this.btnAddWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddWeight.Location = new System.Drawing.Point(999, 98);
            this.btnAddWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.Size = new System.Drawing.Size(199, 44);
            this.btnAddWeight.TabIndex = 41;
            this.btnAddWeight.Text = "Add Weight";
            this.btnAddWeight.UseVisualStyleBackColor = false;
            this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.ForeColor = System.Drawing.Color.Black;
            this.txtBMI.Location = new System.Drawing.Point(505, 110);
            this.txtBMI.Margin = new System.Windows.Forms.Padding(4);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(197, 34);
            this.txtBMI.TabIndex = 40;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.Color.Black;
            this.txtHeight.Location = new System.Drawing.Point(244, 110);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(197, 34);
            this.txtHeight.TabIndex = 39;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // dtpRecordDate
            // 
            this.dtpRecordDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRecordDate.Location = new System.Drawing.Point(743, 110);
            this.dtpRecordDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRecordDate.Name = "dtpRecordDate";
            this.dtpRecordDate.Size = new System.Drawing.Size(221, 34);
            this.dtpRecordDate.TabIndex = 38;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.Location = new System.Drawing.Point(15, 110);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(197, 34);
            this.txtWeight.TabIndex = 35;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // tabNutrition
            // 
            this.tabNutrition.Controls.Add(this.lblNutritionDate);
            this.tabNutrition.Controls.Add(this.dgvNutrition);
            this.tabNutrition.Controls.Add(this.lblNutritionName);
            this.tabNutrition.Controls.Add(this.lblNutrition);
            this.tabNutrition.Controls.Add(this.btnAddNutrition);
            this.tabNutrition.Controls.Add(this.dtpNutritionDate);
            this.tabNutrition.Controls.Add(this.txtNutritionName);
            this.tabNutrition.Location = new System.Drawing.Point(4, 44);
            this.tabNutrition.Margin = new System.Windows.Forms.Padding(4);
            this.tabNutrition.Name = "tabNutrition";
            this.tabNutrition.Padding = new System.Windows.Forms.Padding(4);
            this.tabNutrition.Size = new System.Drawing.Size(1916, 464);
            this.tabNutrition.TabIndex = 2;
            this.tabNutrition.Text = "Nutrition";
            this.tabNutrition.UseVisualStyleBackColor = true;
            // 
            // lblNutritionDate
            // 
            this.lblNutritionDate.AutoSize = true;
            this.lblNutritionDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutritionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNutritionDate.Location = new System.Drawing.Point(853, 85);
            this.lblNutritionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutritionDate.Name = "lblNutritionDate";
            this.lblNutritionDate.Size = new System.Drawing.Size(127, 23);
            this.lblNutritionDate.TabIndex = 57;
            this.lblNutritionDate.Text = "Nutrition Date";
            // 
            // dgvNutrition
            // 
            this.dgvNutrition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNutrition.BackgroundColor = System.Drawing.Color.White;
            this.dgvNutrition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNutrition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNutrition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNutrition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNutrition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNutrition.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNutrition.EnableHeadersVisualStyles = false;
            this.dgvNutrition.Location = new System.Drawing.Point(339, 187);
            this.dgvNutrition.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNutrition.Name = "dgvNutrition";
            this.dgvNutrition.RowHeadersVisible = false;
            this.dgvNutrition.RowHeadersWidth = 51;
            this.dgvNutrition.Size = new System.Drawing.Size(1165, 190);
            this.dgvNutrition.TabIndex = 56;
            // 
            // lblNutritionName
            // 
            this.lblNutritionName.AutoSize = true;
            this.lblNutritionName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutritionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNutritionName.Location = new System.Drawing.Point(603, 85);
            this.lblNutritionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutritionName.Name = "lblNutritionName";
            this.lblNutritionName.Size = new System.Drawing.Size(136, 23);
            this.lblNutritionName.TabIndex = 53;
            this.lblNutritionName.Text = "Nutrition Name";
            // 
            // lblNutrition
            // 
            this.lblNutrition.AutoSize = true;
            this.lblNutrition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblNutrition.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutrition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.lblNutrition.Location = new System.Drawing.Point(896, 20);
            this.lblNutrition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutrition.Name = "lblNutrition";
            this.lblNutrition.Size = new System.Drawing.Size(251, 38);
            this.lblNutrition.TabIndex = 52;
            this.lblNutrition.Text = "Nutritional Status";
            // 
            // btnAddNutrition
            // 
            this.btnAddNutrition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNutrition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnAddNutrition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNutrition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNutrition.ForeColor = System.Drawing.Color.White;
            this.btnAddNutrition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNutrition.Location = new System.Drawing.Point(1144, 98);
            this.btnAddNutrition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNutrition.Name = "btnAddNutrition";
            this.btnAddNutrition.Size = new System.Drawing.Size(199, 44);
            this.btnAddNutrition.TabIndex = 51;
            this.btnAddNutrition.Text = "Add Nutrition";
            this.btnAddNutrition.UseVisualStyleBackColor = false;
            this.btnAddNutrition.Click += new System.EventHandler(this.btnAddNutrition_Click);
            // 
            // dtpNutritionDate
            // 
            this.dtpNutritionDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNutritionDate.Location = new System.Drawing.Point(857, 110);
            this.dtpNutritionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNutritionDate.Name = "dtpNutritionDate";
            this.dtpNutritionDate.Size = new System.Drawing.Size(221, 34);
            this.dtpNutritionDate.TabIndex = 48;
            // 
            // txtNutritionName
            // 
            this.txtNutritionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNutritionName.ForeColor = System.Drawing.Color.Black;
            this.txtNutritionName.Location = new System.Drawing.Point(599, 110);
            this.txtNutritionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNutritionName.Name = "txtNutritionName";
            this.txtNutritionName.Size = new System.Drawing.Size(197, 34);
            this.txtNutritionName.TabIndex = 47;
            // 
            // tabVaccination
            // 
            this.tabVaccination.Controls.Add(this.lblVacDate);
            this.tabVaccination.Controls.Add(this.lblNextVaccDate);
            this.tabVaccination.Controls.Add(this.dtpNextVaccineDate);
            this.tabVaccination.Controls.Add(this.dgvVaccination);
            this.tabVaccination.Controls.Add(this.lblNextVaccine);
            this.tabVaccination.Controls.Add(this.lblVaccineDetails);
            this.tabVaccination.Controls.Add(this.lblVaccineTracking);
            this.tabVaccination.Controls.Add(this.btnAddVaccine);
            this.tabVaccination.Controls.Add(this.txtNextVaccineName);
            this.tabVaccination.Controls.Add(this.dtpVaccinationDate);
            this.tabVaccination.Controls.Add(this.txtVaccineDetails);
            this.tabVaccination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVaccination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.tabVaccination.Location = new System.Drawing.Point(4, 44);
            this.tabVaccination.Margin = new System.Windows.Forms.Padding(4);
            this.tabVaccination.Name = "tabVaccination";
            this.tabVaccination.Padding = new System.Windows.Forms.Padding(4);
            this.tabVaccination.Size = new System.Drawing.Size(1916, 464);
            this.tabVaccination.TabIndex = 1;
            this.tabVaccination.Text = "Vaccination Records";
            this.tabVaccination.UseVisualStyleBackColor = true;
            // 
            // lblVacDate
            // 
            this.lblVacDate.AutoSize = true;
            this.lblVacDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblVacDate.Location = new System.Drawing.Point(589, 85);
            this.lblVacDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVacDate.Name = "lblVacDate";
            this.lblVacDate.Size = new System.Drawing.Size(144, 23);
            this.lblVacDate.TabIndex = 59;
            this.lblVacDate.Text = "Vaccination Date";
            // 
            // lblNextVaccDate
            // 
            this.lblNextVaccDate.AutoSize = true;
            this.lblNextVaccDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextVaccDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNextVaccDate.Location = new System.Drawing.Point(1120, 85);
            this.lblNextVaccDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextVaccDate.Name = "lblNextVaccDate";
            this.lblNextVaccDate.Size = new System.Drawing.Size(155, 23);
            this.lblNextVaccDate.TabIndex = 58;
            this.lblNextVaccDate.Text = "Next Vaccine Date";
            // 
            // dtpNextVaccineDate
            // 
            this.dtpNextVaccineDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextVaccineDate.Location = new System.Drawing.Point(1124, 110);
            this.dtpNextVaccineDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNextVaccineDate.Name = "dtpNextVaccineDate";
            this.dtpNextVaccineDate.Size = new System.Drawing.Size(221, 34);
            this.dtpNextVaccineDate.TabIndex = 57;
            // 
            // dgvVaccination
            // 
            this.dgvVaccination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVaccination.BackgroundColor = System.Drawing.Color.White;
            this.dgvVaccination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVaccination.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVaccination.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVaccination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVaccination.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVaccination.EnableHeadersVisualStyles = false;
            this.dgvVaccination.Location = new System.Drawing.Point(339, 187);
            this.dgvVaccination.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVaccination.Name = "dgvVaccination";
            this.dgvVaccination.RowHeadersVisible = false;
            this.dgvVaccination.RowHeadersWidth = 51;
            this.dgvVaccination.Size = new System.Drawing.Size(1165, 190);
            this.dgvVaccination.TabIndex = 56;
            // 
            // lblNextVaccine
            // 
            this.lblNextVaccine.AutoSize = true;
            this.lblNextVaccine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextVaccine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblNextVaccine.Location = new System.Drawing.Point(864, 85);
            this.lblNextVaccine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextVaccine.Name = "lblNextVaccine";
            this.lblNextVaccine.Size = new System.Drawing.Size(164, 23);
            this.lblNextVaccine.TabIndex = 54;
            this.lblNextVaccine.Text = "Next Vaccine Name";
            // 
            // lblVaccineDetails
            // 
            this.lblVaccineDetails.AutoSize = true;
            this.lblVaccineDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccineDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblVaccineDetails.Location = new System.Drawing.Point(339, 85);
            this.lblVaccineDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaccineDetails.Name = "lblVaccineDetails";
            this.lblVaccineDetails.Size = new System.Drawing.Size(161, 23);
            this.lblVaccineDetails.TabIndex = 53;
            this.lblVaccineDetails.Text = "Vaccination Details";
            // 
            // lblVaccineTracking
            // 
            this.lblVaccineTracking.AutoSize = true;
            this.lblVaccineTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblVaccineTracking.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccineTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.lblVaccineTracking.Location = new System.Drawing.Point(896, 20);
            this.lblVaccineTracking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaccineTracking.Name = "lblVaccineTracking";
            this.lblVaccineTracking.Size = new System.Drawing.Size(287, 38);
            this.lblVaccineTracking.TabIndex = 52;
            this.lblVaccineTracking.Text = "Vaccination Tracking";
            // 
            // btnAddVaccine
            // 
            this.btnAddVaccine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVaccine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnAddVaccine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVaccine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVaccine.ForeColor = System.Drawing.Color.White;
            this.btnAddVaccine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVaccine.Location = new System.Drawing.Point(1389, 98);
            this.btnAddVaccine.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVaccine.Name = "btnAddVaccine";
            this.btnAddVaccine.Size = new System.Drawing.Size(199, 44);
            this.btnAddVaccine.TabIndex = 51;
            this.btnAddVaccine.Text = "Add Vaccine";
            this.btnAddVaccine.UseVisualStyleBackColor = false;
            this.btnAddVaccine.Click += new System.EventHandler(this.btnAddVaccine_Click);
            // 
            // txtNextVaccineName
            // 
            this.txtNextVaccineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextVaccineName.ForeColor = System.Drawing.Color.Black;
            this.txtNextVaccineName.Location = new System.Drawing.Point(868, 110);
            this.txtNextVaccineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNextVaccineName.Name = "txtNextVaccineName";
            this.txtNextVaccineName.Size = new System.Drawing.Size(197, 34);
            this.txtNextVaccineName.TabIndex = 49;
            // 
            // dtpVaccinationDate
            // 
            this.dtpVaccinationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVaccinationDate.Location = new System.Drawing.Point(595, 110);
            this.dtpVaccinationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVaccinationDate.Name = "dtpVaccinationDate";
            this.dtpVaccinationDate.Size = new System.Drawing.Size(221, 34);
            this.dtpVaccinationDate.TabIndex = 48;
            // 
            // txtVaccineDetails
            // 
            this.txtVaccineDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaccineDetails.ForeColor = System.Drawing.Color.Black;
            this.txtVaccineDetails.Location = new System.Drawing.Point(339, 110);
            this.txtVaccineDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtVaccineDetails.Name = "txtVaccineDetails";
            this.txtVaccineDetails.Size = new System.Drawing.Size(197, 34);
            this.txtVaccineDetails.TabIndex = 47;
            // 
            // tabVaccine
            // 
            this.tabVaccine.Controls.Add(this.tabWeight);
            this.tabVaccine.Controls.Add(this.tabAttendance);
            this.tabVaccine.Controls.Add(this.tabVaccination);
            this.tabVaccine.Controls.Add(this.tabNutrition);
            this.tabVaccine.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabVaccine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVaccine.ItemSize = new System.Drawing.Size(200, 40);
            this.tabVaccine.Location = new System.Drawing.Point(0, 521);
            this.tabVaccine.Margin = new System.Windows.Forms.Padding(4);
            this.tabVaccine.Name = "tabVaccine";
            this.tabVaccine.SelectedIndex = 0;
            this.tabVaccine.Size = new System.Drawing.Size(1924, 512);
            this.tabVaccine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabVaccine.TabIndex = 9;
            // 
            // tabAttendance
            // 
            this.tabAttendance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAttendance.Controls.Add(this.label1);
            this.tabAttendance.Controls.Add(this.cmbAttendance);
            this.tabAttendance.Controls.Add(this.lblAttendanceDate);
            this.tabAttendance.Controls.Add(this.dgvAttendance);
            this.tabAttendance.Controls.Add(this.lblAttendanceNote);
            this.tabAttendance.Controls.Add(this.lblAttendance);
            this.tabAttendance.Controls.Add(this.btnAddAttendance);
            this.tabAttendance.Controls.Add(this.dtpAttendance);
            this.tabAttendance.Controls.Add(this.txtAttendanceNote);
            this.tabAttendance.Location = new System.Drawing.Point(4, 44);
            this.tabAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(1916, 464);
            this.tabAttendance.TabIndex = 5;
            this.tabAttendance.Text = "Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(717, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Attendance ";
            // 
            // cmbAttendance
            // 
            this.cmbAttendance.Enabled = false;
            this.cmbAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAttendance.FormattingEnabled = true;
            this.cmbAttendance.Location = new System.Drawing.Point(713, 110);
            this.cmbAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAttendance.Name = "cmbAttendance";
            this.cmbAttendance.Size = new System.Drawing.Size(219, 36);
            this.cmbAttendance.TabIndex = 65;
            this.cmbAttendance.Text = "present";
            // 
            // lblAttendanceDate
            // 
            this.lblAttendanceDate.AutoSize = true;
            this.lblAttendanceDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAttendanceDate.Location = new System.Drawing.Point(433, 85);
            this.lblAttendanceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendanceDate.Name = "lblAttendanceDate";
            this.lblAttendanceDate.Size = new System.Drawing.Size(145, 23);
            this.lblAttendanceDate.TabIndex = 64;
            this.lblAttendanceDate.Text = "Attendance Date";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Location = new System.Drawing.Point(339, 187);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.Size = new System.Drawing.Size(1165, 144);
            this.dgvAttendance.TabIndex = 63;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // lblAttendanceNote
            // 
            this.lblAttendanceNote.AutoSize = true;
            this.lblAttendanceNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAttendanceNote.Location = new System.Drawing.Point(995, 85);
            this.lblAttendanceNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendanceNote.Name = "lblAttendanceNote";
            this.lblAttendanceNote.Size = new System.Drawing.Size(49, 23);
            this.lblAttendanceNote.TabIndex = 62;
            this.lblAttendanceNote.Text = "Note";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblAttendance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.lblAttendance.Location = new System.Drawing.Point(896, 20);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(167, 38);
            this.lblAttendance.TabIndex = 61;
            this.lblAttendance.Text = "Attendance";
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(219)))));
            this.btnAddAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAddAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAttendance.Location = new System.Drawing.Point(1229, 98);
            this.btnAddAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(199, 44);
            this.btnAddAttendance.TabIndex = 60;
            this.btnAddAttendance.Text = "Add Attendance";
            this.btnAddAttendance.UseVisualStyleBackColor = false;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // dtpAttendance
            // 
            this.dtpAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendance.Location = new System.Drawing.Point(429, 110);
            this.dtpAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAttendance.Name = "dtpAttendance";
            this.dtpAttendance.Size = new System.Drawing.Size(221, 34);
            this.dtpAttendance.TabIndex = 59;
            // 
            // txtAttendanceNote
            // 
            this.txtAttendanceNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendanceNote.ForeColor = System.Drawing.Color.Black;
            this.txtAttendanceNote.Location = new System.Drawing.Point(989, 110);
            this.txtAttendanceNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendanceNote.Name = "txtAttendanceNote";
            this.txtAttendanceNote.Size = new System.Drawing.Size(197, 34);
            this.txtAttendanceNote.TabIndex = 58;
            // 
            // Child_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabVaccine);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Child_Form";
            this.Text = "Growth Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMother)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabWeight.ResumeLayout(false);
            this.tabWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).EndInit();
            this.tabNutrition.ResumeLayout(false);
            this.tabNutrition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrition)).EndInit();
            this.tabVaccination.ResumeLayout(false);
            this.tabVaccination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccination)).EndInit();
            this.tabVaccine.ResumeLayout(false);
            this.tabAttendance.ResumeLayout(false);
            this.tabAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblChildDetails;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblbasic;
        private System.Windows.Forms.TextBox txtChildID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblNutritional;
        private System.Windows.Forms.TextBox txtGrowth;
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.TextBox txtCurrentHeight;
        private System.Windows.Forms.Label lblCurrentHeight;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.TextBox txtBirthWeight;
        private System.Windows.Forms.Label lblBirthWeight;
        private System.Windows.Forms.TextBox txtNutritional;
        private System.Windows.Forms.TabPage tabWeight;
        private System.Windows.Forms.TabPage tabNutrition;
        private System.Windows.Forms.TabPage tabVaccination;
        private System.Windows.Forms.TabControl tabVaccine;
        private System.Windows.Forms.ComboBox cmbMotherName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnAddWeight;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.DataGridView dgvWeight;
        private System.Windows.Forms.Label lblWeightTrack;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrowth;
        private Label lblNutritionName;
        private Label lblNutrition;
        private Button btnAddNutrition;
        private DateTimePicker dtpNutritionDate;
        private TextBox txtNutritionName;
        private Label lblNextVaccine;
        private Label lblVaccineDetails;
        private Label lblVaccineTracking;
        private Button btnAddVaccine;
        private TextBox txtNextVaccineName;
        private DateTimePicker dtpVaccinationDate;
        private TextBox txtVaccineDetails;
        private DataGridView dgvNutrition;
        private DataGridView dgvVaccination;
        private Label lblVacDate;
        private Label lblNextVaccDate;
        private DateTimePicker dtpNextVaccineDate;
        private Label lblNutritionDate;
        private Label lblNutritionAlert;
        private Label lblErrorWT;
        private TabPage tabAttendance;
        private Label lblAttendanceDate;
        private DataGridView dgvAttendance;
        private Label lblAttendanceNote;
        private Label lblAttendance;
        private Button btnAddAttendance;
        private DateTimePicker dtpAttendance;
        private TextBox txtAttendanceNote;
        private ComboBox cmbAttendance;
        private Label label1;
        private Panel panel1;
        private Label lblusername;
        private Label lblUserRole;
        private Label lblRegiError;
        private Label lblRegiError2;
        private ComboBox cmbBlood;
        private Panel panel6;
        private PictureBox picHome;
        private PictureBox picChild;
        private PictureBox picMother;
        private PictureBox picLogout;
        private Button btnPDF;
        private Button btnUpdate;
    }
}