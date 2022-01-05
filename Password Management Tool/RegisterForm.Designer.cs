namespace Password_Management_Tool
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Register_CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Register_Username = new System.Windows.Forms.TextBox();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.Register_RepeatPassword = new System.Windows.Forms.TextBox();
            this.Register_RegisterButton = new System.Windows.Forms.Button();
            this.Login_UsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SaveSecurityCodeLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Register_SecurityCodeTextBox = new System.Windows.Forms.TextBox();
            this.Register_SecurityCodeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SecurityCodeCopiedLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.Register_CloseLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 121);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Register_CloseLabel
            // 
            this.Register_CloseLabel.AutoSize = true;
            this.Register_CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Register_CloseLabel.ForeColor = System.Drawing.Color.White;
            this.Register_CloseLabel.Location = new System.Drawing.Point(346, 0);
            this.Register_CloseLabel.Name = "Register_CloseLabel";
            this.Register_CloseLabel.Size = new System.Drawing.Size(20, 24);
            this.Register_CloseLabel.TabIndex = 4;
            this.Register_CloseLabel.Text = "x";
            this.Register_CloseLabel.Click += new System.EventHandler(this.Register_CloseLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create your Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Register_Username
            // 
            this.Register_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_Username.Location = new System.Drawing.Point(153, 146);
            this.Register_Username.Name = "Register_Username";
            this.Register_Username.Size = new System.Drawing.Size(154, 13);
            this.Register_Username.TabIndex = 3;
            // 
            // Register_Email
            // 
            this.Register_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_Email.Location = new System.Drawing.Point(153, 186);
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(154, 13);
            this.Register_Email.TabIndex = 4;
            // 
            // Register_Password
            // 
            this.Register_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_Password.Location = new System.Drawing.Point(153, 225);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(154, 13);
            this.Register_Password.TabIndex = 5;
            // 
            // Register_RepeatPassword
            // 
            this.Register_RepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_RepeatPassword.Location = new System.Drawing.Point(153, 263);
            this.Register_RepeatPassword.Name = "Register_RepeatPassword";
            this.Register_RepeatPassword.Size = new System.Drawing.Size(154, 13);
            this.Register_RepeatPassword.TabIndex = 6;
            // 
            // Register_RegisterButton
            // 
            this.Register_RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.Register_RegisterButton.FlatAppearance.BorderSize = 0;
            this.Register_RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_RegisterButton.ForeColor = System.Drawing.Color.White;
            this.Register_RegisterButton.Location = new System.Drawing.Point(201, 369);
            this.Register_RegisterButton.Name = "Register_RegisterButton";
            this.Register_RegisterButton.Size = new System.Drawing.Size(106, 27);
            this.Register_RegisterButton.TabIndex = 12;
            this.Register_RegisterButton.Text = "Create Account";
            this.Register_RegisterButton.UseVisualStyleBackColor = false;
            this.Register_RegisterButton.Click += new System.EventHandler(this.Register_RegisterButton_Click);
            // 
            // Login_UsernameLabel
            // 
            this.Login_UsernameLabel.AutoSize = true;
            this.Login_UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Login_UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.Login_UsernameLabel.Location = new System.Drawing.Point(12, 251);
            this.Login_UsernameLabel.Name = "Login_UsernameLabel";
            this.Login_UsernameLabel.Size = new System.Drawing.Size(70, 32);
            this.Login_UsernameLabel.TabIndex = 13;
            this.Login_UsernameLabel.Text = "Repeat\r\nPassword:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel2.Location = new System.Drawing.Point(153, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 1);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel3.Location = new System.Drawing.Point(153, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 1);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel4.Location = new System.Drawing.Point(153, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 1);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel5.Location = new System.Drawing.Point(153, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 1);
            this.panel5.TabIndex = 20;
            // 
            // SaveSecurityCodeLabel
            // 
            this.SaveSecurityCodeLabel.AutoSize = true;
            this.SaveSecurityCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveSecurityCodeLabel.Location = new System.Drawing.Point(12, 460);
            this.SaveSecurityCodeLabel.Name = "SaveSecurityCodeLabel";
            this.SaveSecurityCodeLabel.Size = new System.Drawing.Size(192, 52);
            this.SaveSecurityCodeLabel.TabIndex = 21;
            this.SaveSecurityCodeLabel.Text = "Note:\r\nPlease save your security code, \r\nyou\'re going to need your security code\r" +
    "\nin case you forget your password.\r\n";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel6.Location = new System.Drawing.Point(153, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(154, 1);
            this.panel6.TabIndex = 23;
            // 
            // Register_SecurityCodeTextBox
            // 
            this.Register_SecurityCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_SecurityCodeTextBox.Location = new System.Drawing.Point(153, 304);
            this.Register_SecurityCodeTextBox.Name = "Register_SecurityCodeTextBox";
            this.Register_SecurityCodeTextBox.Size = new System.Drawing.Size(154, 13);
            this.Register_SecurityCodeTextBox.TabIndex = 22;
            // 
            // Register_SecurityCodeLabel
            // 
            this.Register_SecurityCodeLabel.AutoSize = true;
            this.Register_SecurityCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Register_SecurityCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.Register_SecurityCodeLabel.Location = new System.Drawing.Point(12, 308);
            this.Register_SecurityCodeLabel.Name = "Register_SecurityCodeLabel";
            this.Register_SecurityCodeLabel.Size = new System.Drawing.Size(91, 16);
            this.Register_SecurityCodeLabel.TabIndex = 24;
            this.Register_SecurityCodeLabel.Text = "Security Code";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SecurityCodeCopiedLabel
            // 
            this.SecurityCodeCopiedLabel.AutoSize = true;
            this.SecurityCodeCopiedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SecurityCodeCopiedLabel.Location = new System.Drawing.Point(198, 327);
            this.SecurityCodeCopiedLabel.Name = "SecurityCodeCopiedLabel";
            this.SecurityCodeCopiedLabel.Size = new System.Drawing.Size(109, 13);
            this.SecurityCodeCopiedLabel.TabIndex = 26;
            this.SecurityCodeCopiedLabel.Text = "Security Code Copied";
            this.SecurityCodeCopiedLabel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 521);
            this.Controls.Add(this.SecurityCodeCopiedLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Register_SecurityCodeLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Register_SecurityCodeTextBox);
            this.Controls.Add(this.SaveSecurityCodeLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_UsernameLabel);
            this.Controls.Add(this.Register_RegisterButton);
            this.Controls.Add(this.Register_RepeatPassword);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.Register_Email);
            this.Controls.Add(this.Register_Username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Register_CloseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Register_Username;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.TextBox Register_RepeatPassword;
        private System.Windows.Forms.Button Register_RegisterButton;
        private System.Windows.Forms.Label Login_UsernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label SaveSecurityCodeLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Register_SecurityCodeTextBox;
        private System.Windows.Forms.Label Register_SecurityCodeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SecurityCodeCopiedLabel;
    }
}