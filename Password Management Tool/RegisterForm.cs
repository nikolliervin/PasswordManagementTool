using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Password_Management_Tool
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            var SecurityCode = new GenerateSecurityPin();
            Register_SecurityCodeTextBox.Text = SecurityCode.PinGenerator().ToString();   
            
        }

        private void Register_CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void Register_RegisterButton_Click(object sender, EventArgs e)
        {
            
            EmptyFields();

            SamePasswords();

            while (NoEmptyFields) 
            {

                OleDbConnection my_con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=C:\Users\user\source\repos\C# with Mosh\Password Management Tool\PasswordManagementToolDB.accdb");



                my_con.Open();

                OleDbCommand o_cmd = new OleDbCommand("insert into UsersRegistered(user_username,user_password,user_email,user_securitycode) values(@a,@b,@c,@d)", my_con);
                o_cmd.Parameters.AddWithValue("a", Register_Username.Text);
                o_cmd.Parameters.AddWithValue("b", Register_Password.Text);
                o_cmd.Parameters.AddWithValue("c", Register_Email.Text);
                o_cmd.Parameters.AddWithValue("d", Register_SecurityCodeTextBox.Text);
                int i = o_cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Your account was created successfully!", "Done");
                }
                my_con.Close();

                this.Close();

                var LoginForm = new LoginForm();
                LoginForm.ShowDialog();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Register_SecurityCodeTextBox.Text);
            SecurityCodeCopiedLabel.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public bool NoEmptyFields;

        public void EmptyFields()
        {


            if ((String.IsNullOrEmpty(Register_Username.Text))
                || (String.IsNullOrEmpty(Register_Email.Text))
                || (String.IsNullOrEmpty(Register_Password.Text))
                || (String.IsNullOrEmpty(Register_RepeatPassword.Text)))
            {
                MessageBox.Show("Make sure you have no empty fields!", "Warning!");
                NoEmptyFields = false;
            }
            else
                NoEmptyFields = true;
           
            
        }
        public void SamePasswords()
        {
            if (Register_Password.Text != Register_RepeatPassword.Text)
            {
                MessageBox.Show("Both password fields should be the same!", "Warning!");
            }
        }
    }
}
