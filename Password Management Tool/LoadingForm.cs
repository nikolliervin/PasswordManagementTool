using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Management_Tool
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadBar.Width += 1;

            BarFull();

        }
        public void BarFull()
        {
            if (LoadBar.Width > 800)
            {
                LoadTimer.Stop();

                var Login = new LoginForm();
                this.Hide();
                Login.ShowDialog();
                
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
