
namespace PayCalc_Dashboard
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlEmployeeDetails = new System.Windows.Forms.Panel();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCodeValue = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.pnlSearchEmployee = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pnlEmployeesTable = new System.Windows.Forms.Panel();
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmployeeDetails2 = new System.Windows.Forms.Panel();
            this.lblStatusValue2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodeValue2 = new System.Windows.Forms.Label();
            this.lblCode2 = new System.Windows.Forms.Label();
            this.lblPositionValue2 = new System.Windows.Forms.Label();
            this.lblPosition2 = new System.Windows.Forms.Label();
            this.lblEmployeeName2 = new System.Windows.Forms.Label();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.lbxSearchNameResult = new System.Windows.Forms.ListBox();
            this.circularPictureBox1 = new PayCalc_Dashboard.CircularPictureBox();
            this.richButton2 = new CustomControls.RJControls.RichButton();
            this.cbxEmployeeImage = new PayCalc_Dashboard.CircularPictureBox();
            this.circularButton2 = new PayCalc_Dashboard.CircularButton();
            this.circularButton1 = new PayCalc_Dashboard.CircularButton();
            this.btnAdd = new PayCalc_Dashboard.CircularButton();
            this.lblHourRate = new System.Windows.Forms.Label();
            this.lblWorkDays = new System.Windows.Forms.Label();
            this.lblOvertimeHours = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.tbxHourlyRate = new System.Windows.Forms.TextBox();
            this.tbxDeduction = new System.Windows.Forms.TextBox();
            this.tbxBonus = new System.Windows.Forms.TextBox();
            this.tbxOvertimeHours = new System.Windows.Forms.TextBox();
            this.tbxWorkDays = new System.Windows.Forms.TextBox();
            this.pnlTotalSalary = new System.Windows.Forms.Panel();
            this.tbxTotalSalary = new System.Windows.Forms.TextBox();
            this.pnlTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlEmployees.SuspendLayout();
            this.pnlEmployeeDetails.SuspendLayout();
            this.pnlSearchEmployee.SuspendLayout();
            this.pnlEmployeesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.pnlEmployeeDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmployeeImage)).BeginInit();
            this.pnlTotalSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTabs.Controls.Add(this.btnHistory);
            this.pnlTabs.Controls.Add(this.btnEmployees);
            this.pnlTabs.Controls.Add(this.btnDashboard);
            this.pnlTabs.Controls.Add(this.pictureBox1);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1200, 60);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.White;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(337, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(169, 60);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(168, 0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(169, 60);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(169, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayCalc_Dashboard.Properties.Resources.PayCalc_Logo;
            this.pictureBox1.InitialImage = global::PayCalc_Dashboard.Properties.Resources.PayCalc_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(989, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.BackgroundImage = global::PayCalc_Dashboard.Properties.Resources.add_black_24dp_1;
            this.pnlDashboard.Controls.Add(this.richButton2);
            this.pnlDashboard.Controls.Add(this.pnlEmployeeDetails);
            this.pnlDashboard.Controls.Add(this.pnlSearchEmployee);
            this.pnlDashboard.Controls.Add(this.pnlEmployeesTable);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1200, 660);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BackColor = System.Drawing.Color.White;
            this.pnlEmployees.Controls.Add(this.pnlTotalSalary);
            this.pnlEmployees.Controls.Add(this.tbxWorkDays);
            this.pnlEmployees.Controls.Add(this.tbxOvertimeHours);
            this.pnlEmployees.Controls.Add(this.tbxBonus);
            this.pnlEmployees.Controls.Add(this.tbxDeduction);
            this.pnlEmployees.Controls.Add(this.tbxHourlyRate);
            this.pnlEmployees.Controls.Add(this.lblBonus);
            this.pnlEmployees.Controls.Add(this.lblDeduction);
            this.pnlEmployees.Controls.Add(this.lblOvertimeHours);
            this.pnlEmployees.Controls.Add(this.lblWorkDays);
            this.pnlEmployees.Controls.Add(this.lblHourRate);
            this.pnlEmployees.Controls.Add(this.pnlEmployeeDetails2);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 60);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1200, 660);
            this.pnlEmployees.TabIndex = 6;
            // 
            // pnlEmployeeDetails
            // 
            this.pnlEmployeeDetails.Controls.Add(this.cbxEmployeeImage);
            this.pnlEmployeeDetails.Controls.Add(this.circularButton2);
            this.pnlEmployeeDetails.Controls.Add(this.circularButton1);
            this.pnlEmployeeDetails.Controls.Add(this.btnAdd);
            this.pnlEmployeeDetails.Controls.Add(this.lblStatusValue);
            this.pnlEmployeeDetails.Controls.Add(this.lblStatus);
            this.pnlEmployeeDetails.Controls.Add(this.lblCodeValue);
            this.pnlEmployeeDetails.Controls.Add(this.lblCode);
            this.pnlEmployeeDetails.Controls.Add(this.lblPositionValue);
            this.pnlEmployeeDetails.Controls.Add(this.txtPosition);
            this.pnlEmployeeDetails.Controls.Add(this.lblEmployeeName);
            this.pnlEmployeeDetails.Location = new System.Drawing.Point(41, 35);
            this.pnlEmployeeDetails.Name = "pnlEmployeeDetails";
            this.pnlEmployeeDetails.Size = new System.Drawing.Size(331, 589);
            this.pnlEmployeeDetails.TabIndex = 0;
            this.pnlEmployeeDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployeeDetails_Paint);
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(169, 306);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(88, 19);
            this.lblStatusValue.TabIndex = 7;
            this.lblStatusValue.Text = "Status Ipsum";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(82, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblCodeValue
            // 
            this.lblCodeValue.AutoSize = true;
            this.lblCodeValue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeValue.Location = new System.Drawing.Point(169, 282);
            this.lblCodeValue.Name = "lblCodeValue";
            this.lblCodeValue.Size = new System.Drawing.Size(45, 19);
            this.lblCodeValue.TabIndex = 5;
            this.lblCodeValue.Text = "#1234";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(82, 282);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 19);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.AutoSize = true;
            this.lblPositionValue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionValue.Location = new System.Drawing.Point(169, 258);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(99, 19);
            this.lblPositionValue.TabIndex = 3;
            this.lblPositionValue.Text = "Position Ipsum";
            // 
            // txtPosition
            // 
            this.txtPosition.AutoSize = true;
            this.txtPosition.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(82, 258);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(60, 19);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.Text = "Position";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(94, 217);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(162, 27);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // pnlSearchEmployee
            // 
            this.pnlSearchEmployee.Controls.Add(this.tbxSearch);
            this.pnlSearchEmployee.Location = new System.Drawing.Point(415, 35);
            this.pnlSearchEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearchEmployee.Name = "pnlSearchEmployee";
            this.pnlSearchEmployee.Size = new System.Drawing.Size(737, 46);
            this.pnlSearchEmployee.TabIndex = 4;
            this.pnlSearchEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchEmployee_Paint);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(24, 11);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(650, 21);
            this.tbxSearch.TabIndex = 0;
            // 
            // pnlEmployeesTable
            // 
            this.pnlEmployeesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmployeesTable.Controls.Add(this.dgvEmployeesList);
            this.pnlEmployeesTable.Location = new System.Drawing.Point(415, 105);
            this.pnlEmployeesTable.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEmployeesTable.Name = "pnlEmployeesTable";
            this.pnlEmployeesTable.Size = new System.Drawing.Size(760, 519);
            this.pnlEmployeesTable.TabIndex = 5;
            this.pnlEmployeesTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployeesTable_Paint);
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.code,
            this.designation,
            this.contact,
            this.status});
            this.dgvEmployeesList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvEmployeesList.Location = new System.Drawing.Point(24, 22);
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployeesList.RowHeadersVisible = false;
            this.dgvEmployeesList.Size = new System.Drawing.Size(713, 462);
            this.dgvEmployeesList.TabIndex = 4;
            this.dgvEmployeesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeesList_CellContentClick);
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // designation
            // 
            this.designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.designation.HeaderText = "Designation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contact.HeaderText = "Contact";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // pnlEmployeeDetails2
            // 
            this.pnlEmployeeDetails2.Controls.Add(this.lbxSearchNameResult);
            this.pnlEmployeeDetails2.Controls.Add(this.tbxSearchName);
            this.pnlEmployeeDetails2.Controls.Add(this.circularPictureBox1);
            this.pnlEmployeeDetails2.Controls.Add(this.lblStatusValue2);
            this.pnlEmployeeDetails2.Controls.Add(this.label2);
            this.pnlEmployeeDetails2.Controls.Add(this.lblCodeValue2);
            this.pnlEmployeeDetails2.Controls.Add(this.lblCode2);
            this.pnlEmployeeDetails2.Controls.Add(this.lblPositionValue2);
            this.pnlEmployeeDetails2.Controls.Add(this.lblPosition2);
            this.pnlEmployeeDetails2.Controls.Add(this.lblEmployeeName2);
            this.pnlEmployeeDetails2.Location = new System.Drawing.Point(41, 35);
            this.pnlEmployeeDetails2.Name = "pnlEmployeeDetails2";
            this.pnlEmployeeDetails2.Size = new System.Drawing.Size(331, 589);
            this.pnlEmployeeDetails2.TabIndex = 1;
            this.pnlEmployeeDetails2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployeeDetails2_Paint);
            // 
            // lblStatusValue2
            // 
            this.lblStatusValue2.AutoSize = true;
            this.lblStatusValue2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue2.Location = new System.Drawing.Point(169, 306);
            this.lblStatusValue2.Name = "lblStatusValue2";
            this.lblStatusValue2.Size = new System.Drawing.Size(88, 19);
            this.lblStatusValue2.TabIndex = 7;
            this.lblStatusValue2.Text = "Status Ipsum";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "lblStatus2";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // lblCodeValue2
            // 
            this.lblCodeValue2.AutoSize = true;
            this.lblCodeValue2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeValue2.Location = new System.Drawing.Point(169, 282);
            this.lblCodeValue2.Name = "lblCodeValue2";
            this.lblCodeValue2.Size = new System.Drawing.Size(45, 19);
            this.lblCodeValue2.TabIndex = 5;
            this.lblCodeValue2.Text = "#1234";
            // 
            // lblCode2
            // 
            this.lblCode2.AutoSize = true;
            this.lblCode2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode2.Location = new System.Drawing.Point(82, 282);
            this.lblCode2.Name = "lblCode2";
            this.lblCode2.Size = new System.Drawing.Size(40, 19);
            this.lblCode2.TabIndex = 4;
            this.lblCode2.Text = "Code";
            // 
            // lblPositionValue2
            // 
            this.lblPositionValue2.AutoSize = true;
            this.lblPositionValue2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionValue2.Location = new System.Drawing.Point(169, 258);
            this.lblPositionValue2.Name = "lblPositionValue2";
            this.lblPositionValue2.Size = new System.Drawing.Size(99, 19);
            this.lblPositionValue2.TabIndex = 3;
            this.lblPositionValue2.Text = "Position Ipsum";
            // 
            // lblPosition2
            // 
            this.lblPosition2.AutoSize = true;
            this.lblPosition2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition2.Location = new System.Drawing.Point(82, 258);
            this.lblPosition2.Name = "lblPosition2";
            this.lblPosition2.Size = new System.Drawing.Size(60, 19);
            this.lblPosition2.TabIndex = 2;
            this.lblPosition2.Text = "Position";
            // 
            // lblEmployeeName2
            // 
            this.lblEmployeeName2.AutoSize = true;
            this.lblEmployeeName2.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName2.Location = new System.Drawing.Point(94, 217);
            this.lblEmployeeName2.Name = "lblEmployeeName2";
            this.lblEmployeeName2.Size = new System.Drawing.Size(162, 27);
            this.lblEmployeeName2.TabIndex = 1;
            this.lblEmployeeName2.Text = "Employee Name";
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.tbxSearchName.Location = new System.Drawing.Point(58, 366);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(220, 28);
            this.tbxSearchName.TabIndex = 8;
            // 
            // lbxSearchNameResult
            // 
            this.lbxSearchNameResult.FormattingEnabled = true;
            this.lbxSearchNameResult.Location = new System.Drawing.Point(58, 410);
            this.lbxSearchNameResult.Name = "lbxSearchNameResult";
            this.lbxSearchNameResult.Size = new System.Drawing.Size(220, 108);
            this.lbxSearchNameResult.TabIndex = 9;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = global::PayCalc_Dashboard.Properties.Resources._242975480_2985671261680879_7459125111186422667_n_2;
            this.circularPictureBox1.Location = new System.Drawing.Point(86, 21);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(170, 170);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // richButton2
            // 
            this.richButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.richButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.richButton2.BackgroundImage = global::PayCalc_Dashboard.Properties.Resources.Vectorsearch_icon_employeeSection;
            this.richButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.richButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.richButton2.BorderRadius = 5;
            this.richButton2.BorderSize = 0;
            this.richButton2.FlatAppearance.BorderSize = 0;
            this.richButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.richButton2.ForeColor = System.Drawing.Color.Black;
            this.richButton2.Location = new System.Drawing.Point(1110, 35);
            this.richButton2.Name = "richButton2";
            this.richButton2.Size = new System.Drawing.Size(65, 46);
            this.richButton2.TabIndex = 3;
            this.richButton2.TextColor = System.Drawing.Color.Black;
            this.richButton2.UseVisualStyleBackColor = false;
            // 
            // cbxEmployeeImage
            // 
            this.cbxEmployeeImage.Image = global::PayCalc_Dashboard.Properties.Resources._242975480_2985671261680879_7459125111186422667_n_2;
            this.cbxEmployeeImage.Location = new System.Drawing.Point(86, 21);
            this.cbxEmployeeImage.Name = "cbxEmployeeImage";
            this.cbxEmployeeImage.Size = new System.Drawing.Size(170, 170);
            this.cbxEmployeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cbxEmployeeImage.TabIndex = 1;
            this.cbxEmployeeImage.TabStop = false;
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.circularButton2.BackgroundImage = global::PayCalc_Dashboard.Properties.Resources.edit_black_24dp_1;
            this.circularButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Location = new System.Drawing.Point(140, 344);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(50, 50);
            this.circularButton2.TabIndex = 11;
            this.circularButton2.UseVisualStyleBackColor = false;
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.circularButton1.BackgroundImage = global::PayCalc_Dashboard.Properties.Resources.delete_outline_black_24dp_1;
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(218, 344);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(50, 50);
            this.circularButton1.TabIndex = 10;
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.btnAdd.BackgroundImage = global::PayCalc_Dashboard.Properties.Resources.add_black_24dp_1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(62, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblHourRate
            // 
            this.lblHourRate.AutoSize = true;
            this.lblHourRate.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourRate.Location = new System.Drawing.Point(562, 134);
            this.lblHourRate.Name = "lblHourRate";
            this.lblHourRate.Size = new System.Drawing.Size(141, 27);
            this.lblHourRate.TabIndex = 10;
            this.lblHourRate.Text = "Rate per Hour";
            // 
            // lblWorkDays
            // 
            this.lblWorkDays.AutoSize = true;
            this.lblWorkDays.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDays.Location = new System.Drawing.Point(562, 185);
            this.lblWorkDays.Name = "lblWorkDays";
            this.lblWorkDays.Size = new System.Drawing.Size(110, 27);
            this.lblWorkDays.TabIndex = 11;
            this.lblWorkDays.Text = "Work Days";
            // 
            // lblOvertimeHours
            // 
            this.lblOvertimeHours.AutoSize = true;
            this.lblOvertimeHours.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimeHours.Location = new System.Drawing.Point(562, 236);
            this.lblOvertimeHours.Name = "lblOvertimeHours";
            this.lblOvertimeHours.Size = new System.Drawing.Size(158, 27);
            this.lblOvertimeHours.TabIndex = 12;
            this.lblOvertimeHours.Text = "Overtime Hours";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduction.Location = new System.Drawing.Point(562, 338);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(107, 27);
            this.lblDeduction.TabIndex = 13;
            this.lblDeduction.Text = "Deduction";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(562, 287);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(70, 27);
            this.lblBonus.TabIndex = 14;
            this.lblBonus.Text = "Bonus";
            // 
            // tbxHourlyRate
            // 
            this.tbxHourlyRate.BackColor = System.Drawing.Color.White;
            this.tbxHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHourlyRate.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxHourlyRate.Location = new System.Drawing.Point(767, 132);
            this.tbxHourlyRate.Name = "tbxHourlyRate";
            this.tbxHourlyRate.Size = new System.Drawing.Size(194, 33);
            this.tbxHourlyRate.TabIndex = 15;
            // 
            // tbxDeduction
            // 
            this.tbxDeduction.BackColor = System.Drawing.Color.White;
            this.tbxDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDeduction.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxDeduction.Location = new System.Drawing.Point(767, 336);
            this.tbxDeduction.Name = "tbxDeduction";
            this.tbxDeduction.Size = new System.Drawing.Size(194, 33);
            this.tbxDeduction.TabIndex = 16;
            // 
            // tbxBonus
            // 
            this.tbxBonus.BackColor = System.Drawing.Color.White;
            this.tbxBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBonus.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxBonus.Location = new System.Drawing.Point(767, 285);
            this.tbxBonus.Name = "tbxBonus";
            this.tbxBonus.Size = new System.Drawing.Size(194, 33);
            this.tbxBonus.TabIndex = 17;
            // 
            // tbxOvertimeHours
            // 
            this.tbxOvertimeHours.BackColor = System.Drawing.Color.White;
            this.tbxOvertimeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOvertimeHours.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxOvertimeHours.Location = new System.Drawing.Point(767, 234);
            this.tbxOvertimeHours.Name = "tbxOvertimeHours";
            this.tbxOvertimeHours.Size = new System.Drawing.Size(194, 33);
            this.tbxOvertimeHours.TabIndex = 18;
            // 
            // tbxWorkDays
            // 
            this.tbxWorkDays.BackColor = System.Drawing.Color.White;
            this.tbxWorkDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWorkDays.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxWorkDays.Location = new System.Drawing.Point(767, 183);
            this.tbxWorkDays.Name = "tbxWorkDays";
            this.tbxWorkDays.Size = new System.Drawing.Size(194, 33);
            this.tbxWorkDays.TabIndex = 19;
            // 
            // pnlTotalSalary
            // 
            this.pnlTotalSalary.Controls.Add(this.tbxTotalSalary);
            this.pnlTotalSalary.Location = new System.Drawing.Point(415, 540);
            this.pnlTotalSalary.Name = "pnlTotalSalary";
            this.pnlTotalSalary.Size = new System.Drawing.Size(757, 81);
            this.pnlTotalSalary.TabIndex = 20;
            this.pnlTotalSalary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotalSalary_Paint);
            // 
            // tbxTotalSalary
            // 
            this.tbxTotalSalary.BackColor = System.Drawing.Color.White;
            this.tbxTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotalSalary.Font = new System.Drawing.Font("Open Sans Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalSalary.Location = new System.Drawing.Point(24, 15);
            this.tbxTotalSalary.Name = "tbxTotalSalary";
            this.tbxTotalSalary.ReadOnly = true;
            this.tbxTotalSalary.Size = new System.Drawing.Size(713, 51);
            this.tbxTotalSalary.TabIndex = 21;
            this.tbxTotalSalary.Text = "0.00";
            this.tbxTotalSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.pnlEmployeeDetails.ResumeLayout(false);
            this.pnlEmployeeDetails.PerformLayout();
            this.pnlSearchEmployee.ResumeLayout(false);
            this.pnlSearchEmployee.PerformLayout();
            this.pnlEmployeesTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.pnlEmployeeDetails2.ResumeLayout(false);
            this.pnlEmployeeDetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmployeeImage)).EndInit();
            this.pnlTotalSalary.ResumeLayout(false);
            this.pnlTotalSalary.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodeValue;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblPositionValue;
        private CircularButton btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton circularButton2;
        private CircularButton circularButton1;
        private CircularPictureBox cbxEmployeeImage;
        private CustomControls.RJControls.RichButton richButton2;
        private System.Windows.Forms.Panel pnlSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel pnlEmployeesTable;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label txtPosition;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlEmployeeDetails2;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label lblStatusValue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodeValue2;
        private System.Windows.Forms.Label lblCode2;
        private System.Windows.Forms.Label lblPositionValue2;
        private System.Windows.Forms.Label lblPosition2;
        private System.Windows.Forms.Label lblEmployeeName2;
        private System.Windows.Forms.TextBox tbxSearchName;
        private System.Windows.Forms.ListBox lbxSearchNameResult;
        private System.Windows.Forms.Panel pnlTotalSalary;
        private System.Windows.Forms.TextBox tbxTotalSalary;
        private System.Windows.Forms.TextBox tbxWorkDays;
        private System.Windows.Forms.TextBox tbxOvertimeHours;
        private System.Windows.Forms.TextBox tbxBonus;
        private System.Windows.Forms.TextBox tbxDeduction;
        private System.Windows.Forms.TextBox tbxHourlyRate;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label lblOvertimeHours;
        private System.Windows.Forms.Label lblWorkDays;
        private System.Windows.Forms.Label lblHourRate;
    }
}

