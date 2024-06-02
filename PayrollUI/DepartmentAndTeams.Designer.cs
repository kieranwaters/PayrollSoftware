using System;

namespace PayrollUI
{
    partial class DepartmentAndTeams
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
            this.SearchDepartmentsLabel = new System.Windows.Forms.Label();
            this.SearchTeamsLabel = new System.Windows.Forms.Label();
            this.DepartmentsSearchBox = new System.Windows.Forms.TextBox();
            this.TeamsSearchBox = new System.Windows.Forms.TextBox();
            this.DepartmentsSearchButton = new System.Windows.Forms.Button();
            this.TeamsSearchButton = new System.Windows.Forms.Button();
            this.DepartmentListBox = new System.Windows.Forms.ListBox();
            this.TeamsListBox = new System.Windows.Forms.ListBox();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchDepartmentsLabel
            // 
            this.SearchDepartmentsLabel.AutoSize = true;
            this.SearchDepartmentsLabel.Location = new System.Drawing.Point(49, 28);
            this.SearchDepartmentsLabel.Name = "SearchDepartmentsLabel";
            this.SearchDepartmentsLabel.Size = new System.Drawing.Size(133, 16);
            this.SearchDepartmentsLabel.TabIndex = 0;
            this.SearchDepartmentsLabel.Text = "Search Departments:";
            // 
            // SearchTeamsLabel
            // 
            this.SearchTeamsLabel.AutoSize = true;
            this.SearchTeamsLabel.Location = new System.Drawing.Point(562, 28);
            this.SearchTeamsLabel.Name = "SearchTeamsLabel";
            this.SearchTeamsLabel.Size = new System.Drawing.Size(99, 16);
            this.SearchTeamsLabel.TabIndex = 1;
            this.SearchTeamsLabel.Text = "Search Teams:";
            // 
            // DepartmentsSearchBox
            // 
            this.DepartmentsSearchBox.Location = new System.Drawing.Point(188, 25);
            this.DepartmentsSearchBox.Name = "DepartmentsSearchBox";
            this.DepartmentsSearchBox.Size = new System.Drawing.Size(181, 22);
            this.DepartmentsSearchBox.TabIndex = 2;
            this.DepartmentsSearchBox.TextChanged += new System.EventHandler(this.DepartmentsSearchBox_TextChanged_1);
            // 
            // TeamsSearchBox
            // 
            this.TeamsSearchBox.Location = new System.Drawing.Point(667, 25);
            this.TeamsSearchBox.Name = "TeamsSearchBox";
            this.TeamsSearchBox.Size = new System.Drawing.Size(181, 22);
            this.TeamsSearchBox.TabIndex = 3;
            this.TeamsSearchBox.TextChanged += new System.EventHandler(this.TeamsSearchBox_TextChanged);
            // 
            // DepartmentsSearchButton
            // 
            this.DepartmentsSearchButton.Location = new System.Drawing.Point(378, 25);
            this.DepartmentsSearchButton.Name = "DepartmentsSearchButton";
            this.DepartmentsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DepartmentsSearchButton.TabIndex = 4;
            this.DepartmentsSearchButton.Text = "Search";
            this.DepartmentsSearchButton.UseVisualStyleBackColor = true;
            this.DepartmentsSearchButton.Click += new System.EventHandler(this.DepartmentsSearchButton_Click);
            // 
            // TeamsSearchButton
            // 
            this.TeamsSearchButton.Location = new System.Drawing.Point(854, 24);
            this.TeamsSearchButton.Name = "TeamsSearchButton";
            this.TeamsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.TeamsSearchButton.TabIndex = 5;
            this.TeamsSearchButton.Text = "Search";
            this.TeamsSearchButton.UseVisualStyleBackColor = true;
            this.TeamsSearchButton.Click += new System.EventHandler(this.TeamsSearchButton_Click);
            // 
            // DepartmentListBox
            // 
            this.DepartmentListBox.FormattingEnabled = true;
            this.DepartmentListBox.ItemHeight = 16;
            this.DepartmentListBox.Location = new System.Drawing.Point(120, 81);
            this.DepartmentListBox.Name = "DepartmentListBox";
            this.DepartmentListBox.Size = new System.Drawing.Size(291, 324);
            this.DepartmentListBox.TabIndex = 6;
            this.DepartmentListBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentListBox_SelectedIndexChanged_1);
            // 
            // TeamsListBox
            // 
            this.TeamsListBox.FormattingEnabled = true;
            this.TeamsListBox.ItemHeight = 16;
            this.TeamsListBox.Location = new System.Drawing.Point(601, 81);
            this.TeamsListBox.Name = "TeamsListBox";
            this.TeamsListBox.Size = new System.Drawing.Size(291, 324);
            this.TeamsListBox.TabIndex = 7;
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Location = new System.Drawing.Point(120, 411);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(291, 47);
            this.AddDepartmentButton.TabIndex = 8;
            this.AddDepartmentButton.Text = "Add Department";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(601, 411);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(291, 47);
            this.AddTeamButton.TabIndex = 9;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // DepartmentAndTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 835);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.AddDepartmentButton);
            this.Controls.Add(this.TeamsListBox);
            this.Controls.Add(this.DepartmentListBox);
            this.Controls.Add(this.TeamsSearchButton);
            this.Controls.Add(this.DepartmentsSearchButton);
            this.Controls.Add(this.TeamsSearchBox);
            this.Controls.Add(this.DepartmentsSearchBox);
            this.Controls.Add(this.SearchTeamsLabel);
            this.Controls.Add(this.SearchDepartmentsLabel);
            this.Name = "DepartmentAndTeams";
            this.Text = "Search Departmennt and Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchDepartmentsLabel;
        private System.Windows.Forms.Label SearchTeamsLabel;
        private System.Windows.Forms.TextBox DepartmentsSearchBox;
        private System.Windows.Forms.TextBox TeamsSearchBox;
        private System.Windows.Forms.Button DepartmentsSearchButton;
        private System.Windows.Forms.Button TeamsSearchButton;
        private System.Windows.Forms.ListBox DepartmentListBox;
        private System.Windows.Forms.ListBox TeamsListBox;
        private readonly EventHandler DepartmentsSearchBox_TextChanged;
        private readonly EventHandler DepartmentListBox_SelectedIndexChanged;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.Button AddTeamButton;
    }
}