namespace Password_Management_Tool
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AboutTextLabel = new System.Windows.Forms.Label();
            this.CloseAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 1);
            this.panel1.TabIndex = 0;
            // 
            // AboutTitle
            // 
            this.AboutTitle.AutoSize = true;
            this.AboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTitle.Location = new System.Drawing.Point(135, 9);
            this.AboutTitle.Name = "AboutTitle";
            this.AboutTitle.Size = new System.Drawing.Size(75, 29);
            this.AboutTitle.TabIndex = 1;
            this.AboutTitle.Text = "About";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel2.Location = new System.Drawing.Point(12, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 1);
            this.panel2.TabIndex = 1;
            // 
            // AboutTextLabel
            // 
            this.AboutTextLabel.AutoSize = true;
            this.AboutTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTextLabel.Location = new System.Drawing.Point(12, 120);
            this.AboutTextLabel.Name = "AboutTextLabel";
            this.AboutTextLabel.Size = new System.Drawing.Size(298, 176);
            this.AboutTextLabel.TabIndex = 2;
            this.AboutTextLabel.Text = resources.GetString("AboutTextLabel.Text");
            // 
            // CloseAbout
            // 
            this.CloseAbout.AutoSize = true;
            this.CloseAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAbout.Location = new System.Drawing.Point(328, 3);
            this.CloseAbout.Name = "CloseAbout";
            this.CloseAbout.Size = new System.Drawing.Size(15, 16);
            this.CloseAbout.TabIndex = 3;
            this.CloseAbout.Text = "X";
            this.CloseAbout.Click += new System.EventHandler(this.CloseAbout_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.CloseAbout);
            this.Controls.Add(this.AboutTextLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AboutTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AboutTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AboutTextLabel;
        private System.Windows.Forms.Label CloseAbout;
    }
}