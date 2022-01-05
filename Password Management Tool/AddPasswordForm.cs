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
    public partial class AddPasswordForm : Form
    {
        public AddPasswordForm()
        {
            InitializeComponent();
            
        }

        private void AddPasswordTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_AddButton_Click(object sender, EventArgs e)
        {
            EmptyFields();

            if(NoEmptyFields) 
            {


                OleDbConnection my_con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=C:\Users\user\source\repos\C# with Mosh\Password Management Tool\PasswordManagementToolDB.accdb");


                my_con.Open();
                OleDbCommand o_cmd = new OleDbCommand("insert into PasswordManagement(psw_Name,psw_Website,psw_Password,psw_Username,psw_Email) values(@Name,@Website,@Password,@Username,@Email)", my_con);

                o_cmd.Parameters.AddWithValue("Name", Add_NameTextBox.Text.Trim());
                o_cmd.Parameters.AddWithValue("Website", Add_WebsiteTextBox.Text.Trim());
                o_cmd.Parameters.AddWithValue("Password", Add_PasswordTextBox.Text.Trim());
                o_cmd.Parameters.AddWithValue("Username", Add_UsernameTextBox.Text.Trim());
                o_cmd.Parameters.AddWithValue("Email", Add_EmailTextBox.Text.Trim());

                int ActionCounter = o_cmd.ExecuteNonQuery();
                if (ActionCounter > 0)
                {
                    MessageBox.Show("Password was inserted successfully", "Done");
                }
                my_con.Close();


                this.Close();
            } 
        }

        public bool NoEmptyFields;
        public void EmptyFields()
        {
            if ((String.IsNullOrEmpty(Add_NameTextBox.Text))
                || (String.IsNullOrEmpty(Add_UsernameTextBox.Text))
                || (String.IsNullOrEmpty(Add_EmailTextBox.Text))
                || (String.IsNullOrEmpty(Add_PasswordTextBox.Text))
                || (String.IsNullOrEmpty(Add_WebsiteTextBox.Text)))
            {
                MessageBox.Show("Make sure you have no empty fields!", "Warning!");
                NoEmptyFields = false;
            }
            else
                NoEmptyFields = true;
        }


        private void AddPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
    }

