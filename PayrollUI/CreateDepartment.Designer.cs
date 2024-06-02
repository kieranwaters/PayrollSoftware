using System;

namespace PayrollUI
{
    partial class CreateDepartment
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
        public void InitializeComponent()
        {
            this.EnterDepartmentNameLabel = new System.Windows.Forms.Label();
            this.MoveExistingTeamLabel = new System.Windows.Forms.Label();
            this.EnterDepartmentNameBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.SelectedTeamsListBox1 = new System.Windows.Forms.ListBox();
            this.SaveDepartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterDepartmentNameLabel
            // 
            this.EnterDepartmentNameLabel.AutoSize = true;
            this.EnterDepartmentNameLabel.Location = new System.Drawing.Point(136, 68);
            this.EnterDepartmentNameLabel.Name = "EnterDepartmentNameLabel";
            this.EnterDepartmentNameLabel.Size = new System.Drawing.Size(154, 16);
            this.EnterDepartmentNameLabel.TabIndex = 0;
            this.EnterDepartmentNameLabel.Text = "Enter Department Name:";
            // 
            // MoveExistingTeamLabel
            // 
            this.MoveExistingTeamLabel.AutoSize = true;
            this.MoveExistingTeamLabel.Location = new System.Drawing.Point(144, 90);
            this.MoveExistingTeamLabel.Name = "MoveExistingTeamLabel";
            this.MoveExistingTeamLabel.Size = new System.Drawing.Size(146, 16);
            this.MoveExistingTeamLabel.TabIndex = 1;
            this.MoveExistingTeamLabel.Text = "Move Existing Team/s: ";
            // 
            // EnterDepartmentNameBox
            // 
            this.EnterDepartmentNameBox.Location = new System.Drawing.Point(296, 62);
            this.EnterDepartmentNameBox.Name = "EnterDepartmentNameBox";
            this.EnterDepartmentNameBox.Size = new System.Drawing.Size(274, 22);
            this.EnterDepartmentNameBox.TabIndex = 2;
            this.EnterDepartmentNameBox.TextChanged += new System.EventHandler(this.EnterDepartmentNameBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(296, 391);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(161, 23);
            this.CreateTeamButton.TabIndex = 4;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // SelectedTeamsListBox1
            // 
            this.SelectedTeamsListBox1.FormattingEnabled = true;
            this.SelectedTeamsListBox1.ItemHeight = 16;
            this.SelectedTeamsListBox1.Location = new System.Drawing.Point(296, 118);
            this.SelectedTeamsListBox1.Name = "SelectedTeamsListBox1";
            this.SelectedTeamsListBox1.Size = new System.Drawing.Size(274, 180);
            this.SelectedTeamsListBox1.TabIndex = 5;
            this.SelectedTeamsListBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedTeamsListBox1_SelectedIndexChanged);
            // 
            // SaveDepartmentButton
            // 
            this.SaveDepartmentButton.Location = new System.Drawing.Point(296, 304);
            this.SaveDepartmentButton.Name = "SaveDepartmentButton";
            this.SaveDepartmentButton.Size = new System.Drawing.Size(274, 36);
            this.SaveDepartmentButton.TabIndex = 6;
            this.SaveDepartmentButton.Text = "Save Department";
            this.SaveDepartmentButton.UseVisualStyleBackColor = true;
            this.SaveDepartmentButton.Click += new System.EventHandler(this.SaveDepartmentButton_Click);
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveDepartmentButton);
            this.Controls.Add(this.SelectedTeamsListBox1);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EnterDepartmentNameBox);
            this.Controls.Add(this.MoveExistingTeamLabel);
            this.Controls.Add(this.EnterDepartmentNameLabel);
            this.Name = "CreateDepartment";
            this.Text = "Create Department";
            this.Load += new System.EventHandler(this.CreateDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

          private void  CreateTeamButton_Click(object sender, EventArgs e)
        {
              CreateTeam newTeam = new CreateTeam();
            newTeam.Show();
        }
 #endregion

        private System.Windows.Forms.Label EnterDepartmentNameLabel;
        private System.Windows.Forms.Label MoveExistingTeamLabel;
        private System.Windows.Forms.TextBox EnterDepartmentNameBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.ListBox SelectedTeamsListBox1;
        private System.Windows.Forms.Button SaveDepartmentButton;
    }
}