using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Password_Management_Tool
{   
    public partial class EirPass : Form
    {
        int MoveThis = 0;
        int MoveX = 0;
        int MoveY = 0;

        public EirPass()
        {
            InitializeComponent();

            WelcomeUserLabel.Text = LoginForm.TransferTextBoxValue;


            ShowOnlyBackgroundPanel();

           

        }

        private void PasswordsButton_Click(object sender, EventArgs e)
        {
            ShowOnlyPasswordsPanel();

            OleDbConnection DataBaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=C:\Users\user\source\repos\Password Management Tool\PasswordManagementToolDB.accdb");
            DataBaseConnection.Open();
            DataSet DSet = new DataSet();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter("select psw_Name,psw_Website,psw_Password,psw_Username,psw_Email from PasswordManagement", DataBaseConnection);
            DataAdapter.Fill(DSet);
            DataGridViewDB.DataSource = DSet.Tables[0];
            DataBaseConnection.Close();





        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            ShowOnlyGeneratedPasswordsPanel();
            


        }

       

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimazeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
        private void PassGenButton_Click(object sender, EventArgs e)
        {   CopyPictureBox.Visible=true; 
            PasswordCopiedMessage.Visible=false;
            var GeneratePassword = new GeneratePassword();
            
            GeneratePassword.CreateRandomPassword();

            GeneratedPassTextBox.Text=GeneratePassword.CreateRandomPassword().ToString();   
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

            ShowOnlyBackgroundPanel();

        }

        

        private void ClearGeneratedPassButton_Click(object sender, EventArgs e)
        {   
            
            GeneratedPassTextBox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (GeneratedPassTextBox.Text == "")
            {
                MessageBox.Show("Please generate your password first!");
            }
            else
            {
                Clipboard.SetText(GeneratedPassTextBox.Text);
                PasswordCopiedMessage.Visible = true;
            }

            ClearGeneratedPassButton.Visible = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowOnlyBackgroundPanel();
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            var AddPassword=new AddPasswordForm();
            AddPassword.ShowDialog();
        }

        

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            ShowOnlyPasswordsPanel();

            OleDbConnection DataBaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=C:\Users\user\source\repos\Password Management Tool\PasswordManagementToolDB.accdb");
            DataBaseConnection.Open();
            DataSet DSet = new DataSet();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter("select psw_Name,psw_Website,psw_Password,psw_Username,psw_Email from PasswordManagement", DataBaseConnection);
            DataAdapter.Fill(DSet);
            DataGridViewDB.DataSource = DSet.Tables[0];
            DataBaseConnection.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowOnlyPasswordsPanel();


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var SearchForm = new SearchForm();
            SearchForm.ShowDialog();

        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            if (DataGridViewDB.SelectedRows.Count>0) {

                foreach (DataGridViewRow row in DataGridViewDB.SelectedRows)
                {
                    DataGridViewDB.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowOnlyPassCheckerPanel();
            
            
        }

        private void Checker_PasteButton_Click_1(object sender, EventArgs e)
        {
            
            PassCheckTextBox.Text= Clipboard.GetText();


        }

        private void PassCheck_CheckButton_Click(object sender, EventArgs e)
        {
            var PassChecker = new PasswordStrengthChecker();

            OutPutCheckLabel.Text = PasswordStrengthChecker.CheckStrength(PassCheckTextBox.Text).ToString();

            OutPutCheckLabel.Visible = true;
            PassStrengthLabel.Visible = true;

            switch (OutPutCheckLabel.Text)
            {
                case "Blank":
                    OutPutCheckLabel.ForeColor = System.Drawing.Color.Red;
                    break;
                case "VeryWeak":
                    OutPutCheckLabel.ForeColor = System.Drawing.Color.Red;
                    SuggestionLabel.Visible = true;
                    break;
                case "Medium":
                    OutPutCheckLabel.ForeColor = System.Drawing.Color.LightGreen;
                    break;
                case "Strong":
                    OutPutCheckLabel.ForeColor = System.Drawing.Color.Green;
                    break;
                case "Very Strong":
                    OutPutCheckLabel.ForeColor= System.Drawing.Color.Green;
                    break;
                    
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            this.Close();
            var LoginForm = new LoginForm();
            LoginForm.ShowDialog();
        }

        public void ShowOnlyBackgroundPanel()
        {
            BackgroudPanel.Visible = true;
            GeneratePasswordPanel.Visible = false;
            PasswordsPanel.Visible = false;
            PassCheckerPanel.Visible = false;
        }
        public void ShowOnlyPasswordsPanel()
        {
            BackgroudPanel.Hide();
            GeneratePasswordPanel.Visible = false;
            PasswordsPanel.Visible = true;
            PassCheckerPanel.Visible = false;
            DataGridViewDB.Visible = true;
        }
        public void ShowOnlyPassCheckerPanel()
        {
            PassCheckerPanel.Visible = true;
            BackgroudPanel.Visible = false;
            GeneratePasswordPanel.Visible = false;
            GeneratedPassPanel.Visible = false;
            PasswordsPanel.Visible = false;
        }
        public void ShowOnlyGeneratedPasswordsPanel()
        {
            GeneratePasswordPanel.Visible = true;
            BackgroudPanel.Visible = false;
            PasswordsPanel.Visible = false;
            PassCheckerPanel.Visible = false;
            GeneratedPassPanel.Visible = true;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var AboutForm = new AboutForm();
            AboutForm.ShowDialog();
           
        }

        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveThis = 1;
            MoveX = e.X;
            MoveY = e.Y;
            
        }

        private void MovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveThis = 0;
        }

        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveThis == 1)
            {
                this.SetDesktopLocation(MousePosition.X-MoveX, MousePosition.Y-MoveY);
            }
        }
    }   
}
