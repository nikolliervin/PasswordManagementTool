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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ForgotPass_SecurityCode.Text=Clipboard.GetText();
        }

        private void Login_CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            
            var Login=new LoginForm();
            Login.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Forgot_YourPasswordTextBox.Text);
        }

        private void Forgot_GetPasswordButton_Click(object sender, EventArgs e)
        {
            EmptyFields();


            if (NoEmptyFields)
            {


                OleDbConnection DataBaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=C:\Users\user\source\repos\Password Management Tool\PasswordManagementToolDB.accdb");
                DataBaseConnection.Open();



                OleDbCommand Commad = new OleDbCommand("SELECT user_password FROM UsersRegistered where user_securitycode=@a and user_username=@b", DataBaseConnection);
                Commad.Parameters.AddWithValue("a", ForgotPass_SecurityCode.Text);
                Commad.Parameters.AddWithValue("b", ForgotPass_UsernameTextBox.Text);
                ;
                OleDbDataReader reader = Commad.ExecuteReader();

                if (reader.Read())
                {
                    Forgot_YourPasswordTextBox.Text = reader[0].ToString();

                }

                DataBaseConnection.Close();


                PasswordFound();
            }

            

            
        }

        public void PasswordFound()
        {
            if (!String.IsNullOrEmpty(Forgot_YourPasswordTextBox.Text))
            {
                CopyYourPassLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("No password related to that security code was found!", "Error");
            }
        }

        public bool NoEmptyFields;
        public void EmptyFields()
        {
            if ((String.IsNullOrEmpty(ForgotPass_SecurityCode.Text))
             || (String.IsNullOrEmpty(ForgotPass_UsernameTextBox.Text)))
                
            {
                MessageBox.Show("Make sure you have no empty fields!", "Warning!");
                NoEmptyFields = false;
            }
            else
                NoEmptyFields = true;
        }


        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
