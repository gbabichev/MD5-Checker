/*
MD5 Checker 
George Babichev 2016
Simple Windows Forms application to view MD5 checksum's of files.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MD5Checker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            // "Select File" pressed
            DialogResult result = openFileDialog1.ShowDialog();
            txtBox_FileLoc.Text = openFileDialog1.FileName;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // "Check MD5" Pressed
            try
            {
                // Compute MD5 hash & display it in the history box.
                byte[] hash = MD5.Create().ComputeHash(File.ReadAllBytes(txtBox_FileLoc.Text));
                txtBox_history.AppendText(openFileDialog1.FileName);
                txtBox_history.AppendText(Environment.NewLine);
                txtBox_history.AppendText(BitConverter.ToString(hash).Replace("-", ""));
                txtBox_history.AppendText(Environment.NewLine);
                txtBox_history.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                // If there is an error, generate an error log and show a message box.
                DateTime today = DateTime.Today;
                File.AppendAllText(@"errorLog.txt", today.ToString("d") + " ");
                File.AppendAllText(@"errorLog.txt", DateTime.Now.ToShortTimeString() + ": ");
                File.AppendAllText(@"errorLog.txt", ex.ToString());
                File.AppendAllText(@"errorLog.txt", Environment.NewLine);
                MessageBox.Show("Error opening " + txtBox_FileLoc.Text + "\nCheck errorLog.txt for more details"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // "Clear History" button pressed.
            txtBox_history.Clear();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            // "About Help" pressed.
            Form aboutFormView = new aboutForm();
            aboutFormView.ShowDialog();
        }
    }
}
