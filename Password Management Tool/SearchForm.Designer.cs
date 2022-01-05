namespace Password_Management_Tool
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_Title = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.SearchPB = new System.Windows.Forms.PictureBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.SeachBoxPanel = new System.Windows.Forms.Panel();
            this.PasswordNameSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.Search_Title);
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 85);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Search_Title
            // 
            this.Search_Title.AutoSize = true;
            this.Search_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Search_Title.ForeColor = System.Drawing.Color.White;
            this.Search_Title.Location = new System.Drawing.Point(157, 20);
            this.Search_Title.Name = "Search_Title";
            this.Search_Title.Size = new System.Drawing.Size(246, 25);
            this.Search_Title.TabIndex = 5;
            this.Search_Title.Text = "Search your password";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(553, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(20, 24);
            this.CloseLabel.TabIndex = 4;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // SearchPB
            // 
            this.SearchPB.Image = ((System.Drawing.Image)(resources.GetObject("SearchPB.Image")));
            this.SearchPB.Location = new System.Drawing.Point(354, 101);
            this.SearchPB.Name = "SearchPB";
            this.SearchPB.Size = new System.Drawing.Size(24, 24);
            this.SearchPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchPB.TabIndex = 3;
            this.SearchPB.TabStop = false;
            this.SearchPB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Location = new System.Drawing.Point(160, 105);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(188, 13);
            this.SearchTextBox.TabIndex = 3;
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Location = new System.Drawing.Point(28, 190);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.Size = new System.Drawing.Size(523, 332);
            this.SearchDataGridView.TabIndex = 4;
            // 
            // SeachBoxPanel
            // 
            this.SeachBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.SeachBoxPanel.Location = new System.Drawing.Point(160, 124);
            this.SeachBoxPanel.Name = "SeachBoxPanel";
            this.SeachBoxPanel.Size = new System.Drawing.Size(188, 1);
            this.SeachBoxPanel.TabIndex = 5;
            // 
            // PasswordNameSearch
            // 
            this.PasswordNameSearch.AutoSize = true;
            this.PasswordNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.PasswordNameSearch.Location = new System.Drawing.Point(32, 110);
            this.PasswordNameSearch.Name = "PasswordNameSearch";
            this.PasswordNameSearch.Size = new System.Drawing.Size(101, 15);
            this.PasswordNameSearch.TabIndex = 6;
            this.PasswordNameSearch.Text = "Password Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.panel2.Location = new System.Drawing.Point(7, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 1);
            this.panel2.TabIndex = 7;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasswordNameSearch);
            this.Controls.Add(this.SeachBoxPanel);
            this.Controls.Add(this.SearchDataGridView);
            this.Controls.Add(this.SearchPB);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox SearchPB;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.Panel SeachBoxPanel;
        private System.Windows.Forms.Label PasswordNameSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Search_Title;
    }
}