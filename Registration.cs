using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                MessageBox.Show("Student Number is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNumber.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtStudentNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Student Number must contain numbers only!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNumber.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMIddleInitial.Text))
            {
                MessageBox.Show("Middle Initial is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMIddleInitial.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Age is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 99)
            {
                MessageBox.Show("Age must be a number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact Number is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContactNumber.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Contact Number must be exactly 11 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return;
            }

            if (cmbProgram.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Program!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProgram.Focus();
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return;
            }

            string fileName = txtStudentNumber.Text.Trim() + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, fileName);

            if (File.Exists(fullPath))
            {
                DialogResult result = MessageBox.Show(
                    "A file with this Student Number already exists.\nDo you want to overwrite it?",
                    "File Already Exists",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return; 
                }
            }

            string[] lines =
            {
                "Student No.: " + txtStudentNumber.Text.Trim(),
                "Full Name: " + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() + txtMIddleInitial.Text.Trim() + ".",
                "Program: " + cmbProgram.Text,
                "Gender: " + cmbGender.Text,
                "Age: " + txtAge.Text.Trim(),
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No. " + txtContactNumber.Text.Trim()
            };

            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                if (File.Exists(fullPath) && new FileInfo(fullPath).Length > 0)
                {
                    MessageBox.Show("Registration successful!\nFile saved as:\n" + fullPath,
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create the text file or the file is empty.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the file:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
