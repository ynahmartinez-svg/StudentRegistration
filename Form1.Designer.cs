namespace StudentRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentRegform = new Label();
            lbldob = new Label();
            lblgen = new Label();
            lblmname = new Label();
            lblfname = new Label();
            lblname = new Label();
            txtlastname = new TextBox();
            txtmiddlename = new TextBox();
            txtfirstname = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cbDay = new ComboBox();
            cbYear = new ComboBox();
            cbMonth = new ComboBox();
            btnStudentReg = new Button();
            label2 = new Label();
            cbProgram = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // lblStudentRegform
            // 
            lblStudentRegform.AutoSize = true;
            lblStudentRegform.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentRegform.Location = new Point(19, 9);
            lblStudentRegform.Name = "lblStudentRegform";
            lblStudentRegform.Size = new Size(262, 28);
            lblStudentRegform.TabIndex = 0;
            lblStudentRegform.Text = "Student Registration Form";
            lblStudentRegform.Click += lblStudentRegform_Click;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldob.Location = new Point(19, 264);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(136, 28);
            lbldob.TabIndex = 1;
            lbldob.Text = "Date of birth";
            // 
            // lblgen
            // 
            lblgen.AutoSize = true;
            lblgen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgen.Location = new Point(19, 229);
            lblgen.Name = "lblgen";
            lblgen.Size = new Size(80, 28);
            lblgen.TabIndex = 2;
            lblgen.Text = "Gender";
            // 
            // lblmname
            // 
            lblmname.AutoSize = true;
            lblmname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmname.Location = new Point(29, 159);
            lblmname.Name = "lblmname";
            lblmname.Size = new Size(136, 28);
            lblmname.TabIndex = 3;
            lblmname.Text = "Middle name";
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfname.Location = new Point(29, 98);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(111, 28);
            lblfname.TabIndex = 4;
            lblfname.Text = "First name";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.Location = new Point(29, 37);
            lblname.Name = "lblname";
            lblname.Size = new Size(108, 28);
            lblname.TabIndex = 5;
            lblname.Text = "Last name";
            lblname.Click += label6_Click;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(39, 68);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(155, 27);
            txtlastname.TabIndex = 6;
            // 
            // txtmiddlename
            // 
            txtmiddlename.Location = new Point(39, 190);
            txtmiddlename.Name = "txtmiddlename";
            txtmiddlename.Size = new Size(155, 27);
            txtmiddlename.TabIndex = 7;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(39, 129);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(155, 27);
            txtfirstname.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(105, 229);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 32);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(186, 229);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(95, 32);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbDay.Location = new Point(29, 295);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(82, 28);
            cbDay.TabIndex = 11;
            cbDay.Text = "-Day-";
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026" });
            cbYear.Location = new Point(215, 295);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(82, 28);
            cbYear.TabIndex = 12;
            cbYear.Text = "-Year-";
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbMonth.Location = new Point(127, 295);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(82, 28);
            cbMonth.TabIndex = 13;
            cbMonth.Text = "-Month-";
            // 
            // btnStudentReg
            // 
            btnStudentReg.BackColor = Color.Crimson;
            btnStudentReg.FlatStyle = FlatStyle.Flat;
            btnStudentReg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentReg.ForeColor = Color.White;
            btnStudentReg.Location = new Point(12, 398);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(278, 40);
            btnStudentReg.TabIndex = 14;
            btnStudentReg.Text = "Register student";
            btnStudentReg.UseVisualStyleBackColor = false;
            btnStudentReg.Click += btnreg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 326);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 15;
            label2.Text = "Program to apply";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems", "Bachelor of Science in Computer Engineering" });
            cbProgram.Location = new Point(20, 360);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(270, 28);
            cbProgram.TabIndex = 16;
            cbProgram.Text = "-Select-";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(450, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(418, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(392, 344);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(cbProgram);
            Controls.Add(label2);
            Controls.Add(btnStudentReg);
            Controls.Add(cbMonth);
            Controls.Add(cbYear);
            Controls.Add(cbDay);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtfirstname);
            Controls.Add(txtmiddlename);
            Controls.Add(txtlastname);
            Controls.Add(lblname);
            Controls.Add(lblfname);
            Controls.Add(lblmname);
            Controls.Add(lblgen);
            Controls.Add(lbldob);
            Controls.Add(lblStudentRegform);
            Name = "Form1";
            Text = "Student Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentRegform;
        private Label lbldob;
        private Label lblgen;
        private Label lblmname;
        private Label lblfname;
        private Label lblname;
        private TextBox txtlastname;
        private TextBox txtmiddlename;
        private TextBox txtfirstname;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private ComboBox cbDay;
        private ComboBox cbYear;
        private ComboBox cbMonth;
        private Button btnStudentReg;
        private Label label2;
        private ComboBox cbProgram;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
    }
}
