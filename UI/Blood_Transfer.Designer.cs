namespace Blood_Bank
{
    partial class Blood_Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Transfer));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AvailableLbl = new System.Windows.Forms.Label();
            this.TransferBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BloodGroup = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PatNameTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(308, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 67);
            this.label10.TabIndex = 43;
            this.label10.Text = "Blood Transfer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(639, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 45);
            this.label13.TabIndex = 46;
            this.label13.Text = "Blood Group";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(362, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 45);
            this.label12.TabIndex = 48;
            this.label12.Text = "Patient Name";
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Items.AddRange(new object[] {
            "A+",
            "A−",
            "B+",
            "B−",
            "AB+",
            "AB−",
            "O+",
            "O−"});
            this.PatientIdCb.Location = new System.Drawing.Point(96, 312);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(250, 27);
            this.PatientIdCb.TabIndex = 51;
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(88, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 45);
            this.label11.TabIndex = 50;
            this.label11.Text = "Patient ID";
            // 
            // AvailableLbl
            // 
            this.AvailableLbl.AutoSize = true;
            this.AvailableLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLbl.ForeColor = System.Drawing.Color.Red;
            this.AvailableLbl.Location = new System.Drawing.Point(412, 372);
            this.AvailableLbl.Name = "AvailableLbl";
            this.AvailableLbl.Size = new System.Drawing.Size(165, 25);
            this.AvailableLbl.TabIndex = 53;
            this.AvailableLbl.Text = "AvailableOrNot";
            this.AvailableLbl.Visible = false;
            // 
            // TransferBtn
            // 
            this.TransferBtn.BorderRadius = 20;
            this.TransferBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TransferBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TransferBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TransferBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TransferBtn.FillColor = System.Drawing.Color.Red;
            this.TransferBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferBtn.ForeColor = System.Drawing.Color.White;
            this.TransferBtn.Location = new System.Drawing.Point(344, 428);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(301, 45);
            this.TransferBtn.TabIndex = 54;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.Visible = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 804);
            this.panel1.TabIndex = 55;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel10.Location = new System.Drawing.Point(17, 637);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(19, 52);
            this.panel10.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 647);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Donate Blood";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = " < Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel9.Location = new System.Drawing.Point(17, 548);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(19, 52);
            this.panel9.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dashboard";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel8.Location = new System.Drawing.Point(17, 459);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(19, 52);
            this.panel8.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Blood Transfer";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel7.Location = new System.Drawing.Point(17, 372);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 52);
            this.panel7.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Blood Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel6.Location = new System.Drawing.Point(17, 283);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(19, 52);
            this.panel6.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "View Patient";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel5.Location = new System.Drawing.Point(17, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 52);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel4.Location = new System.Drawing.Point(17, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 52);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Donors";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel3.Location = new System.Drawing.Point(17, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 52);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Donor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TransferBtn);
            this.panel2.Controls.Add(this.BloodGroup);
            this.panel2.Controls.Add(this.AvailableLbl);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.PatientIdCb);
            this.panel2.Controls.Add(this.PatNameTb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(212, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 804);
            this.panel2.TabIndex = 56;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Bank.Properties.Resources.saline;
            this.pictureBox1.Location = new System.Drawing.Point(444, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // BloodGroup
            // 
            this.BloodGroup.AcceptsReturn = false;
            this.BloodGroup.AcceptsTab = false;
            this.BloodGroup.AnimationSpeed = 200;
            this.BloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.BloodGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BloodGroup.BackgroundImage")));
            this.BloodGroup.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.BloodGroup.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BloodGroup.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BloodGroup.BorderColorIdle = System.Drawing.Color.Silver;
            this.BloodGroup.BorderRadius = 1;
            this.BloodGroup.BorderThickness = 1;
            this.BloodGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BloodGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BloodGroup.DefaultFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.DefaultText = "";
            this.BloodGroup.FillColor = System.Drawing.Color.White;
            this.BloodGroup.HideSelection = true;
            this.BloodGroup.IconLeft = null;
            this.BloodGroup.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.BloodGroup.IconPadding = 10;
            this.BloodGroup.IconRight = null;
            this.BloodGroup.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.BloodGroup.Lines = new string[0];
            this.BloodGroup.Location = new System.Drawing.Point(647, 312);
            this.BloodGroup.MaxLength = 32767;
            this.BloodGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.BloodGroup.Modified = false;
            this.BloodGroup.Multiline = false;
            this.BloodGroup.Name = "BloodGroup";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BloodGroup.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.BloodGroup.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BloodGroup.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BloodGroup.OnIdleState = stateProperties4;
            this.BloodGroup.Padding = new System.Windows.Forms.Padding(3);
            this.BloodGroup.PasswordChar = '\0';
            this.BloodGroup.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.BloodGroup.PlaceholderText = "Enter text";
            this.BloodGroup.ReadOnly = false;
            this.BloodGroup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BloodGroup.SelectedText = "";
            this.BloodGroup.SelectionLength = 0;
            this.BloodGroup.SelectionStart = 0;
            this.BloodGroup.ShortcutsEnabled = true;
            this.BloodGroup.Size = new System.Drawing.Size(260, 40);
            this.BloodGroup.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.BloodGroup.TabIndex = 47;
            this.BloodGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BloodGroup.TextMarginBottom = 0;
            this.BloodGroup.TextMarginLeft = 3;
            this.BloodGroup.TextMarginTop = 0;
            this.BloodGroup.TextPlaceholder = "Enter text";
            this.BloodGroup.UseSystemPasswordChar = false;
            this.BloodGroup.WordWrap = true;
            // 
            // PatNameTb
            // 
            this.PatNameTb.AcceptsReturn = false;
            this.PatNameTb.AcceptsTab = false;
            this.PatNameTb.AnimationSpeed = 200;
            this.PatNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatNameTb.BackColor = System.Drawing.Color.Transparent;
            this.PatNameTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PatNameTb.BackgroundImage")));
            this.PatNameTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PatNameTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PatNameTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PatNameTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.PatNameTb.BorderRadius = 1;
            this.PatNameTb.BorderThickness = 1;
            this.PatNameTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatNameTb.DefaultFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNameTb.DefaultText = "";
            this.PatNameTb.FillColor = System.Drawing.Color.White;
            this.PatNameTb.HideSelection = true;
            this.PatNameTb.IconLeft = null;
            this.PatNameTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PatNameTb.IconPadding = 10;
            this.PatNameTb.IconRight = null;
            this.PatNameTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PatNameTb.Lines = new string[0];
            this.PatNameTb.Location = new System.Drawing.Point(375, 312);
            this.PatNameTb.MaxLength = 32767;
            this.PatNameTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.PatNameTb.Modified = false;
            this.PatNameTb.Multiline = false;
            this.PatNameTb.Name = "PatNameTb";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PatNameTb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PatNameTb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PatNameTb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PatNameTb.OnIdleState = stateProperties8;
            this.PatNameTb.Padding = new System.Windows.Forms.Padding(3);
            this.PatNameTb.PasswordChar = '\0';
            this.PatNameTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PatNameTb.PlaceholderText = "Enter text";
            this.PatNameTb.ReadOnly = false;
            this.PatNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatNameTb.SelectedText = "";
            this.PatNameTb.SelectionLength = 0;
            this.PatNameTb.SelectionStart = 0;
            this.PatNameTb.ShortcutsEnabled = true;
            this.PatNameTb.Size = new System.Drawing.Size(260, 40);
            this.PatNameTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PatNameTb.TabIndex = 49;
            this.PatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PatNameTb.TextMarginBottom = 0;
            this.PatNameTb.TextMarginLeft = 3;
            this.PatNameTb.TextMarginTop = 0;
            this.PatNameTb.TextPlaceholder = "Enter text";
            this.PatNameTb.UseSystemPasswordChar = false;
            this.PatNameTb.WordWrap = true;
            // 
            // Blood_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Blood_Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Blood_Transfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox BloodGroup;
        private System.Windows.Forms.Label label13;
        private Bunifu.UI.WinForms.BunifuTextBox PatNameTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label AvailableLbl;
        private Guna.UI2.WinForms.Guna2Button TransferBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}