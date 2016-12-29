namespace MD5Checker
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.btn_Visit = new System.Windows.Forms.Button();
            this.txtBox_About = new System.Windows.Forms.TextBox();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Visit
            // 
            this.btn_Visit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Visit.Location = new System.Drawing.Point(12, 271);
            this.btn_Visit.Name = "btn_Visit";
            this.btn_Visit.Size = new System.Drawing.Size(220, 23);
            this.btn_Visit.TabIndex = 0;
            this.btn_Visit.Text = "Visit Website";
            this.btn_Visit.UseVisualStyleBackColor = true;
            this.btn_Visit.Click += new System.EventHandler(this.btn_Visit_Click);
            // 
            // txtBox_About
            // 
            this.txtBox_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_About.Location = new System.Drawing.Point(12, 12);
            this.txtBox_About.Multiline = true;
            this.txtBox_About.Name = "txtBox_About";
            this.txtBox_About.Size = new System.Drawing.Size(220, 253);
            this.txtBox_About.TabIndex = 1;
            this.txtBox_About.Text = resources.GetString("txtBox_About.Text");
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(12, 306);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(42, 13);
            this.lbl_Version.TabIndex = 2;
            this.lbl_Version.Text = "Version";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 327);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.txtBox_About);
            this.Controls.Add(this.btn_Visit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(260, 366);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 366);
            this.Name = "aboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About MD5 Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Visit;
        private System.Windows.Forms.TextBox txtBox_About;
        private System.Windows.Forms.Label lbl_Version;
    }
}