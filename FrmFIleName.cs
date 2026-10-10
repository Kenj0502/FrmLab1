using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FrmLab1
{
    public partial class FrmFIleName : Form
    {
        public static string SetFileName = "";
        public FrmFIleName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text)) 
            {
                MessageBox.Show("File name cannot be empty! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }

            SetFileName = txtFileName.Text + ".txt";
            this.Close();
        }
    }
}
