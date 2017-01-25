using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Checker
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            // Disable the Minimize & Maximize box.
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //StatusStrip.SizingGrip = false;
            // Disaplay programs current version.
            lbl_Version.Text = "Version: " + Application.ProductVersion;
        }

        private void btn_Visit_Click(object sender, EventArgs e)
        {
            // "Visit Website" button pressed.
            System.Diagnostics.Process.Start("http://www.georgebabichev.com");
        }
    }
}
