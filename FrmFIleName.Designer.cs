namespace FrmLab1
{
    partial class FrmFIleName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(24, 93);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(308, 29);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.Red;
            btnOkay.Cursor = Cursors.Hand;
            btnOkay.FlatAppearance.BorderColor = Color.DarkRed;
            btnOkay.FlatAppearance.BorderSize = 0;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Location = new Point(121, 150);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(89, 35);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFIleName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 246);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "FrmFIleName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFIleName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}