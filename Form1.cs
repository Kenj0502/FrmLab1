using System;
using System.Windows.Forms;
using System.IO;


namespace FrmLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFIleName Fn = new FrmFIleName();
            Fn.ShowDialog();

            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, FrmFIleName.SetFileName);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFIleName.SetFileName))) 
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);


                MessageBox.Show("File created successfully!\n\nSaved as:\n" + fullPath,
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }
    }
}
