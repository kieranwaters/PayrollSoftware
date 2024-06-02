namespace PayrollUI
{
    partial class Home
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.EmployeeSearchBox = new System.Windows.Forms.TextBox();
            this.EmployeeSearchButton = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.DepartmentAndTeamsButton = new System.Windows.Forms.Button();
            this.PayrollMenuButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.Location = new System.Drawing.Point(1229, 12);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(10);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Padding = new System.Windows.Forms.Padding(1);
            this.LogOutButton.Size = new System.Drawing.Size(75, 39);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.ClientSizeChanged += new System.EventHandler(this.Home_Load);
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            this.LogOutButton.Move += new System.EventHandler(this.Home_Load);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // EmployeeSearchBox
            // 
            this.EmployeeSearchBox.Location = new System.Drawing.Point(784, 11);
            this.EmployeeSearchBox.Name = "EmployeeSearchBox";
            this.EmployeeSearchBox.Size = new System.Drawing.Size(217, 22);
            this.EmployeeSearchBox.TabIndex = 1;
            this.EmployeeSearchBox.Text = "Enter details";
            this.EmployeeSearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeeSearchButton
            // 
            this.EmployeeSearchButton.Location = new System.Drawing.Point(1007, 12);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeSearchButton.TabIndex = 2;
            this.EmployeeSearchButton.Text = "Search";
            this.EmployeeSearchButton.UseVisualStyleBackColor = true;
            this.EmployeeSearchButton.Click += new System.EventHandler(this.EmployeeSearchButton_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.ItemHeight = 16;
            this.EmployeeList.Location = new System.Drawing.Point(19, 143);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(481, 276);
            this.EmployeeList.TabIndex = 3;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // DepartmentAndTeamsButton
            // 
            this.DepartmentAndTeamsButton.Location = new System.Drawing.Point(19, 11);
            this.DepartmentAndTeamsButton.Name = "DepartmentAndTeamsButton";
            this.DepartmentAndTeamsButton.Size = new System.Drawing.Size(190, 24);
            this.DepartmentAndTeamsButton.TabIndex = 4;
            this.DepartmentAndTeamsButton.Text = "Departments and Teams ";
            this.DepartmentAndTeamsButton.UseVisualStyleBackColor = true;
            this.DepartmentAndTeamsButton.Click += new System.EventHandler(this.DepartmentButton_Click);
            // 
            // PayrollMenuButton
            // 
            this.PayrollMenuButton.Location = new System.Drawing.Point(215, 10);
            this.PayrollMenuButton.Name = "PayrollMenuButton";
            this.PayrollMenuButton.Size = new System.Drawing.Size(75, 24);
            this.PayrollMenuButton.TabIndex = 5;
            this.PayrollMenuButton.Text = "Payroll";
            this.PayrollMenuButton.UseVisualStyleBackColor = true;
            this.PayrollMenuButton.Click += new System.EventHandler(this.PayrollMenuButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add/Modify Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeDatabaseButton
            // 
            this.EmployeeDatabaseButton.Location = new System.Drawing.Point(520, 9);
            this.EmployeeDatabaseButton.Name = "EmployeeDatabaseButton";
            this.EmployeeDatabaseButton.Size = new System.Drawing.Size(149, 24);
            this.EmployeeDatabaseButton.TabIndex = 7;
            this.EmployeeDatabaseButton.Text = "Employee Database";
            this.EmployeeDatabaseButton.UseVisualStyleBackColor = true;
            this.EmployeeDatabaseButton.Click += new System.EventHandler(this.EmployeeDatabaseButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 464);
            this.Controls.Add(this.EmployeeDatabaseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PayrollMenuButton);
            this.Controls.Add(this.DepartmentAndTeamsButton);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.EmployeeSearchButton);
            this.Controls.Add(this.EmployeeSearchBox);
            this.Controls.Add(this.LogOutButton);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResizeEnd += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox EmployeeSearchBox;
        private System.Windows.Forms.Button EmployeeSearchButton;
        private System.Windows.Forms.ListBox EmployeeList;
        private System.Windows.Forms.Button DepartmentAndTeamsButton;
        private System.Windows.Forms.Button PayrollMenuButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EmployeeDatabaseButton;
    }
}

