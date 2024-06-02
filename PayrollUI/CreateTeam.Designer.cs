using System;

namespace PayrollUI
{
    partial class CreateTeam
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
            this.SaveTeamButton = new System.Windows.Forms.Button();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.FindEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.FindEmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamLeaderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveTeamButton
            // 
            this.SaveTeamButton.Location = new System.Drawing.Point(259, 301);
            this.SaveTeamButton.Name = "SaveTeamButton";
            this.SaveTeamButton.Size = new System.Drawing.Size(323, 44);
            this.SaveTeamButton.TabIndex = 0;
            this.SaveTeamButton.Text = "Save Team";
            this.SaveTeamButton.UseVisualStyleBackColor = true;
            this.SaveTeamButton.Click += new System.EventHandler(this.SaveTeamButton_Click);
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(260, 394);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(195, 23);
            this.CreateEmployeeButton.TabIndex = 1;
            this.CreateEmployeeButton.Text = "Create Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Location = new System.Drawing.Point(167, 41);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(86, 16);
            this.TeamNameLabel.TabIndex = 2;
            this.TeamNameLabel.Text = "Team Name:";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(173, 89);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(80, 16);
            this.DepartmentLabel.TabIndex = 3;
            this.DepartmentLabel.Text = "Department:";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(259, 35);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(323, 22);
            this.TeamNameTextBox.TabIndex = 4;
            this.TeamNameTextBox.TextChanged += new System.EventHandler(this.TeamNameTextBox_TextChanged);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(260, 86);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(322, 24);
            this.DepartmentComboBox.TabIndex = 5;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // FindEmployeeComboBox
            // 
            this.FindEmployeeComboBox.FormattingEnabled = true;
            this.FindEmployeeComboBox.Location = new System.Drawing.Point(260, 113);
            this.FindEmployeeComboBox.Name = "FindEmployeeComboBox";
            this.FindEmployeeComboBox.Size = new System.Drawing.Size(322, 24);
            this.FindEmployeeComboBox.TabIndex = 6;
            this.FindEmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.FindEmployeeComboBox_SelectedIndexChanged);
            // 
            // FindEmployeeLabel
            // 
            this.FindEmployeeLabel.AutoSize = true;
            this.FindEmployeeLabel.Location = new System.Drawing.Point(152, 116);
            this.FindEmployeeLabel.Name = "FindEmployeeLabel";
            this.FindEmployeeLabel.Size = new System.Drawing.Size(101, 16);
            this.FindEmployeeLabel.TabIndex = 7;
            this.FindEmployeeLabel.Text = "Find Employee:";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 16;
            this.EmployeeListBox.Location = new System.Drawing.Point(259, 144);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(323, 148);
            this.EmployeeListBox.TabIndex = 8;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team Leader:";
            // 
            // TeamLeaderTextBox
            // 
            this.TeamLeaderTextBox.Location = new System.Drawing.Point(259, 61);
            this.TeamLeaderTextBox.Name = "TeamLeaderTextBox";
            this.TeamLeaderTextBox.Size = new System.Drawing.Size(323, 22);
            this.TeamLeaderTextBox.TabIndex = 11;
            this.TeamLeaderTextBox.TextChanged += new System.EventHandler(this.TeamLeaderTextBox_TextChanged);
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeamLeaderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.FindEmployeeLabel);
            this.Controls.Add(this.FindEmployeeComboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.SaveTeamButton);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TeamNameTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FindEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        #endregion

        private System.Windows.Forms.Button SaveTeamButton;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox TeamNameTextBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox FindEmployeeComboBox;
        private System.Windows.Forms.Label FindEmployeeLabel;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeamLeaderTextBox;
    }
}