namespace FrmLab1
{
    partial class Registration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnRegister = new Button();
            txtStudentNumber = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            label10 = new Label();
            txtMIddleInitial = new TextBox();
            txtFirstName = new TextBox();
            txtContactNumber = new TextBox();
            dtpBirthday = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 125);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 167);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 205);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(365, 84);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(365, 125);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(365, 167);
            label8.Name = "label8";
            label8.Size = new Size(52, 17);
            label8.TabIndex = 7;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(355, 205);
            label9.Name = "label9";
            label9.Size = new Size(85, 17);
            label9.TabIndex = 8;
            label9.Text = " Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Red;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.Maroon;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(304, 267);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 34);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNumber.Location = new Point(128, 79);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(222, 27);
            txtStudentNumber.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(128, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 27);
            txtLastName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(128, 157);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(64, 27);
            txtAge.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(577, 167);
            label10.Name = "label10";
            label10.Size = new Size(32, 17);
            label10.TabIndex = 13;
            label10.Text = "M.I.";
            // 
            // txtMIddleInitial
            // 
            txtMIddleInitial.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMIddleInitial.Location = new Point(615, 162);
            txtMIddleInitial.Name = "txtMIddleInitial";
            txtMIddleInitial.Size = new Size(53, 27);
            txtMIddleInitial.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(446, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(222, 27);
            txtFirstName.TabIndex = 16;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(446, 201);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(222, 27);
            txtContactNumber.TabIndex = 17;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(128, 201);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(228, 23);
            dtpBirthday.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(446, 166);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(106, 23);
            cmbGender.TabIndex = 19;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS INFORMATION TECHNOLOGY" });
            cmbProgram.Location = new Point(446, 83);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(236, 23);
            cmbProgram.TabIndex = 20;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 329);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthday);
            Controls.Add(txtContactNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtMIddleInitial);
            Controls.Add(label10);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNumber);
            Controls.Add(btnRegister);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnRegister;
        private TextBox txtStudentNumber;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Label label10;
        private TextBox txtMIddleInitial;
        private TextBox txtFirstName;
        private TextBox txtContactNumber;
        private DateTimePicker dtpBirthday;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
    }
}