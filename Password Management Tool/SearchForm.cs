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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void AddPasswordTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection DataBaseConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=C:\Users\user\source\repos\C# with Mosh\Password Management Tool\PasswordManagementToolDB.accdb");
            DataBaseConnection.Open();
            DataSet DSet = new DataSet();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter("select psw_Name,psw_Website,psw_Password,psw_Username,psw_Email from PasswordManagement Where psw_Name Like ('" + SearchTextBox.Text + "%')", DataBaseConnection);
            DataAdapter.Fill(DSet);
            SearchDataGridView.DataSource = DSet.Tables[0];
            DataBaseConnection.Close();


        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
