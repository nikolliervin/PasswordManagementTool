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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void Login_CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_RegisterButton_Click(object sender, EventArgs e)
        {
            var RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public static string TransferTextBoxValue = "";


        private void Login_LoginButton_Click(object sender, EventArgs e)
        {
            EmptyFields();


            if (NoEmptyFields)
            {


                OleDbConnection DatabaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=C:\Users\user\source\repos\C# with Mosh\Password Management Tool\PasswordManagementToolDB.accdb");


                OleDbCommand Command;
                OleDbDataReader DataReader;

                Command = new OleDbCommand();

                DatabaseConnection.Open();
                Command.Connection = DatabaseConnection;
                Command.CommandText = "SELECT * FROM UsersRegistered where user_username='" + Login_UsernameTextBox.Text + "' AND user_password='" + Login_PasswordTextBox.Text + "'";
                DataReader = Command.ExecuteReader();


                        if (DataReader.Read())
                         {
                            MessageBox.Show("You logged in successfully", "Done!");

                            this.Hide();


                            TransferTextBoxValue = Login_UsernameTextBox.Text;
                                var Home = new EirPass();
                                Home.Show();


                         }


                        else
                        {
                            MessageBox.Show("Username or password is incorrect", "Error");
                        }

            }

        }

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var Forgot=new ForgotPasswordForm();
            Forgot.ShowDialog();
        }

        public bool NoEmptyFields;
        public void EmptyFields()
        {
            if (String.IsNullOrEmpty(Login_UsernameTextBox.Text) ||
               (string.IsNullOrEmpty(Login_PasswordTextBox.Text)))
            {
                MessageBox.Show("Make sure you have no empty fields", "Warning!");
                NoEmptyFields = false;
            }
            else
                NoEmptyFields = true;
        }
    }
}
