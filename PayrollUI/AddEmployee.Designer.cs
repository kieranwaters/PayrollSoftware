using System;

namespace PayrollUI
{
    partial class AddEmployee
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
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeJobLabel = new System.Windows.Forms.Label();
            this.ManagerNameLabel = new System.Windows.Forms.Label();
            this.EmployeeMonthlyPayLabel = new System.Windows.Forms.Label();
            this.EmployeeTeamLabel = new System.Windows.Forms.Label();
            this.NINumber = new System.Windows.Forms.Label();
            this.EmployerNationalInsuranceLabel = new System.Windows.Forms.Label();
            this.EmployeeIncomeTax = new System.Windows.Forms.Label();
            this.EmployeePensionContribution = new System.Windows.Forms.Label();
            this.EmployerPensionContributionLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddEmployeeSubmitButton = new System.Windows.Forms.Button();
            this.EmployeeNameBox1 = new System.Windows.Forms.TextBox();
            this.EmployeeJobBox1 = new System.Windows.Forms.TextBox();
            this.ManagerNameBox1 = new System.Windows.Forms.TextBox();
            this.MonthlyPayBox1 = new System.Windows.Forms.TextBox();
            this.TeamBox1 = new System.Windows.Forms.TextBox();
            this.NationalInsuranceNumberBox1 = new System.Windows.Forms.TextBox();
            this.EmployerNationalInsuranceTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeNationalInsuranceTextbox = new System.Windows.Forms.TextBox();
            this.EmployeePensionContributionTextbox = new System.Windows.Forms.TextBox();
            this.EmployerPensionContributionTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeIncomeTax1 = new System.Windows.Forms.TextBox();
            this.NICategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(54, 61);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(112, 16);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee Name:";
            this.EmployeeNameLabel.Click += new System.EventHandler(this.EmployeeNameLabel_Click);
            // 
            // EmployeeJobLabel
            // 
            this.EmployeeJobLabel.AutoSize = true;
            this.EmployeeJobLabel.Location = new System.Drawing.Point(54, 88);
            this.EmployeeJobLabel.Name = "EmployeeJobLabel";
            this.EmployeeJobLabel.Size = new System.Drawing.Size(98, 16);
            this.EmployeeJobLabel.TabIndex = 1;
            this.EmployeeJobLabel.Text = "Employee Job:";
            this.EmployeeJobLabel.Click += new System.EventHandler(this.EmployeeJobLabel_Click);
            // 
            // ManagerNameLabel
            // 
            this.ManagerNameLabel.AutoSize = true;
            this.ManagerNameLabel.Location = new System.Drawing.Point(54, 115);
            this.ManagerNameLabel.Name = "ManagerNameLabel";
            this.ManagerNameLabel.Size = new System.Drawing.Size(104, 16);
            this.ManagerNameLabel.TabIndex = 2;
            this.ManagerNameLabel.Text = "Manager Name:";
            this.ManagerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManagerNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmployeeMonthlyPayLabel
            // 
            this.EmployeeMonthlyPayLabel.AutoSize = true;
            this.EmployeeMonthlyPayLabel.Location = new System.Drawing.Point(54, 140);
            this.EmployeeMonthlyPayLabel.Name = "EmployeeMonthlyPayLabel";
            this.EmployeeMonthlyPayLabel.Size = new System.Drawing.Size(83, 16);
            this.EmployeeMonthlyPayLabel.TabIndex = 3;
            this.EmployeeMonthlyPayLabel.Text = "Monthly Pay:";
            this.EmployeeMonthlyPayLabel.Click += new System.EventHandler(this.EmployeeMonthlyPayLabel_Click);
            // 
            // EmployeeTeamLabel
            // 
            this.EmployeeTeamLabel.AutoSize = true;
            this.EmployeeTeamLabel.Location = new System.Drawing.Point(54, 166);
            this.EmployeeTeamLabel.Name = "EmployeeTeamLabel";
            this.EmployeeTeamLabel.Size = new System.Drawing.Size(46, 16);
            this.EmployeeTeamLabel.TabIndex = 4;
            this.EmployeeTeamLabel.Text = "Team:";
            this.EmployeeTeamLabel.Click += new System.EventHandler(this.EmployeeDepartmentLabel_Click);
            // 
            // NINumber
            // 
            this.NINumber.AutoSize = true;
            this.NINumber.Location = new System.Drawing.Point(54, 191);
            this.NINumber.Name = "NINumber";
            this.NINumber.Size = new System.Drawing.Size(172, 16);
            this.NINumber.TabIndex = 5;
            this.NINumber.Text = "National Insurance Number:";
            this.NINumber.Click += new System.EventHandler(this.NINumber_Click);
            // 
            // EmployerNationalInsuranceLabel
            // 
            this.EmployerNationalInsuranceLabel.AutoSize = true;
            this.EmployerNationalInsuranceLabel.Location = new System.Drawing.Point(54, 248);
            this.EmployerNationalInsuranceLabel.Name = "EmployerNationalInsuranceLabel";
            this.EmployerNationalInsuranceLabel.Size = new System.Drawing.Size(182, 16);
            this.EmployerNationalInsuranceLabel.TabIndex = 6;
            this.EmployerNationalInsuranceLabel.Text = "Employer National Insurance:";
            this.EmployerNationalInsuranceLabel.Click += new System.EventHandler(this.EmployerNationalInsuranceLabel_Click);
            // 
            // EmployeeIncomeTax
            // 
            this.EmployeeIncomeTax.AutoSize = true;
            this.EmployeeIncomeTax.Location = new System.Drawing.Point(54, 301);
            this.EmployeeIncomeTax.Name = "EmployeeIncomeTax";
            this.EmployeeIncomeTax.Size = new System.Drawing.Size(145, 16);
            this.EmployeeIncomeTax.TabIndex = 8;
            this.EmployeeIncomeTax.Text = "Employee Income Tax:";
            this.EmployeeIncomeTax.Click += new System.EventHandler(this.EmployeeIncomeTax_Click);
            // 
            // EmployeePensionContribution
            // 
            this.EmployeePensionContribution.AutoSize = true;
            this.EmployeePensionContribution.Location = new System.Drawing.Point(54, 357);
            this.EmployeePensionContribution.Name = "EmployeePensionContribution";
            this.EmployeePensionContribution.Size = new System.Drawing.Size(197, 16);
            this.EmployeePensionContribution.TabIndex = 9;
            this.EmployeePensionContribution.Text = "Employee Pension Contribution:";
            this.EmployeePensionContribution.Click += new System.EventHandler(this.EmployeePensionContribution_Click);
            // 
            // EmployerPensionContributionLabel
            // 
            this.EmployerPensionContributionLabel.AutoSize = true;
            this.EmployerPensionContributionLabel.Location = new System.Drawing.Point(54, 329);
            this.EmployerPensionContributionLabel.Name = "EmployerPensionContributionLabel";
            this.EmployerPensionContributionLabel.Size = new System.Drawing.Size(193, 16);
            this.EmployerPensionContributionLabel.TabIndex = 10;
            this.EmployerPensionContributionLabel.Text = "Employer Pension Contribution:";
            this.EmployerPensionContributionLabel.Click += new System.EventHandler(this.EmployerPensionContributionLabel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Employee National Insurance:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // AddEmployeeSubmitButton
            // 
            this.AddEmployeeSubmitButton.Location = new System.Drawing.Point(596, 115);
            this.AddEmployeeSubmitButton.Name = "AddEmployeeSubmitButton";
            this.AddEmployeeSubmitButton.Size = new System.Drawing.Size(115, 44);
            this.AddEmployeeSubmitButton.TabIndex = 34;
            this.AddEmployeeSubmitButton.Text = "Add Employee";
            this.AddEmployeeSubmitButton.UseVisualStyleBackColor = true;
            this.AddEmployeeSubmitButton.Click += new System.EventHandler(this.AddEmployeeSubmitButton_Click);
            // 
            // EmployeeNameBox1
            // 
            this.EmployeeNameBox1.Location = new System.Drawing.Point(263, 57);
            this.EmployeeNameBox1.Name = "EmployeeNameBox1";
            this.EmployeeNameBox1.Size = new System.Drawing.Size(161, 22);
            this.EmployeeNameBox1.TabIndex = 35;
            this.EmployeeNameBox1.TextChanged += new System.EventHandler(this.EmployeeNameBox1_TextChanged);
            // 
            // EmployeeJobBox1
            // 
            this.EmployeeJobBox1.Location = new System.Drawing.Point(263, 85);
            this.EmployeeJobBox1.Name = "EmployeeJobBox1";
            this.EmployeeJobBox1.Size = new System.Drawing.Size(161, 22);
            this.EmployeeJobBox1.TabIndex = 36;
            this.EmployeeJobBox1.TextChanged += new System.EventHandler(this.EmployeeJobBox1_TextChanged);
            // 
            // ManagerNameBox1
            // 
            this.ManagerNameBox1.Location = new System.Drawing.Point(263, 112);
            this.ManagerNameBox1.Name = "ManagerNameBox1";
            this.ManagerNameBox1.Size = new System.Drawing.Size(161, 22);
            this.ManagerNameBox1.TabIndex = 37;
            this.ManagerNameBox1.TextChanged += new System.EventHandler(this.ManagerNameBox1_TextChanged);
            // 
            // MonthlyPayBox1
            // 
            this.MonthlyPayBox1.Location = new System.Drawing.Point(263, 137);
            this.MonthlyPayBox1.Name = "MonthlyPayBox1";
            this.MonthlyPayBox1.Size = new System.Drawing.Size(161, 22);
            this.MonthlyPayBox1.TabIndex = 38;
            this.MonthlyPayBox1.TextChanged += new System.EventHandler(this.MonthlyPayBox1_TextChanged);
            // 
            // TeamBox1
            // 
            this.TeamBox1.Location = new System.Drawing.Point(263, 163);
            this.TeamBox1.Name = "TeamBox1";
            this.TeamBox1.Size = new System.Drawing.Size(161, 22);
            this.TeamBox1.TabIndex = 39;
            this.TeamBox1.TextChanged += new System.EventHandler(this.TeamBox1_TextChanged);
            // 
            // NationalInsuranceNumberBox1
            // 
            this.NationalInsuranceNumberBox1.Location = new System.Drawing.Point(263, 188);
            this.NationalInsuranceNumberBox1.Name = "NationalInsuranceNumberBox1";
            this.NationalInsuranceNumberBox1.Size = new System.Drawing.Size(132, 22);
            this.NationalInsuranceNumberBox1.TabIndex = 40;
            this.NationalInsuranceNumberBox1.TextChanged += new System.EventHandler(this.NationalInsuranceNumberBox1_TextChanged);
            // 
            // EmployerNationalInsuranceTextbox
            // 
            this.EmployerNationalInsuranceTextbox.Location = new System.Drawing.Point(263, 245);
            this.EmployerNationalInsuranceTextbox.Name = "EmployerNationalInsuranceTextbox";
            this.EmployerNationalInsuranceTextbox.ReadOnly = true;
            this.EmployerNationalInsuranceTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmployerNationalInsuranceTextbox.TabIndex = 41;
            this.EmployerNationalInsuranceTextbox.TextChanged += new System.EventHandler(this.EmployerNationalInsuranceTextbox_TextChanged);
            // 
            // EmployeeNationalInsuranceTextbox
            // 
            this.EmployeeNationalInsuranceTextbox.Location = new System.Drawing.Point(263, 270);
            this.EmployeeNationalInsuranceTextbox.Name = "EmployeeNationalInsuranceTextbox";
            this.EmployeeNationalInsuranceTextbox.ReadOnly = true;
            this.EmployeeNationalInsuranceTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmployeeNationalInsuranceTextbox.TabIndex = 42;
            this.EmployeeNationalInsuranceTextbox.TextChanged += new System.EventHandler(this.EmployeeNationalInsuranceTextbox_TextChanged);
            // 
            // EmployeePensionContributionTextbox
            // 
            this.EmployeePensionContributionTextbox.Location = new System.Drawing.Point(263, 354);
            this.EmployeePensionContributionTextbox.Name = "EmployeePensionContributionTextbox";
            this.EmployeePensionContributionTextbox.ReadOnly = true;
            this.EmployeePensionContributionTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmployeePensionContributionTextbox.TabIndex = 44;
            this.EmployeePensionContributionTextbox.TextChanged += new System.EventHandler(this.EmployeePensionContributionTextbox_TextChanged);
            // 
            // EmployerPensionContributionTextbox
            // 
            this.EmployerPensionContributionTextbox.Location = new System.Drawing.Point(263, 326);
            this.EmployerPensionContributionTextbox.Name = "EmployerPensionContributionTextbox";
            this.EmployerPensionContributionTextbox.ReadOnly = true;
            this.EmployerPensionContributionTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmployerPensionContributionTextbox.TabIndex = 45;
            // 
            // EmployeeIncomeTax1
            // 
            this.EmployeeIncomeTax1.AcceptsReturn = true;
            this.EmployeeIncomeTax1.Location = new System.Drawing.Point(263, 298);
            this.EmployeeIncomeTax1.Name = "EmployeeIncomeTax1";
            this.EmployeeIncomeTax1.ReadOnly = true;
            this.EmployeeIncomeTax1.Size = new System.Drawing.Size(100, 22);
            this.EmployeeIncomeTax1.TabIndex = 46;
            this.EmployeeIncomeTax1.TextChanged += new System.EventHandler(this.EmployeeIncomeTax1_TextChanged);
            // 
            // NICategory
            // 
            this.NICategory.FormattingEnabled = true;
            this.NICategory.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "S",
            "V",
            "Z"});
            this.NICategory.Location = new System.Drawing.Point(263, 216);
            this.NICategory.Name = "NICategory";
            this.NICategory.Size = new System.Drawing.Size(100, 24);
            this.NICategory.TabIndex = 47;
            //this.NICategory.SelectedIndexChanged += new System.EventHandler(this.NICategory_SelectedIndexChanged); TODO, UNCOMMENT THIS, AS IS PRPBBALY NEEDED SOMEHWAT
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "National Insurance Category: ";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NICategory);
            this.Controls.Add(this.EmployeeIncomeTax1);
            this.Controls.Add(this.EmployerPensionContributionTextbox);
            this.Controls.Add(this.EmployeePensionContributionTextbox);
            this.Controls.Add(this.EmployeeNationalInsuranceTextbox);
            this.Controls.Add(this.EmployerNationalInsuranceTextbox);
            this.Controls.Add(this.NationalInsuranceNumberBox1);
            this.Controls.Add(this.TeamBox1);
            this.Controls.Add(this.MonthlyPayBox1);
            this.Controls.Add(this.ManagerNameBox1);
            this.Controls.Add(this.EmployeeJobBox1);
            this.Controls.Add(this.EmployeeNameBox1);
            this.Controls.Add(this.AddEmployeeSubmitButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmployerPensionContributionLabel);
            this.Controls.Add(this.EmployeePensionContribution);
            this.Controls.Add(this.EmployeeIncomeTax);
            this.Controls.Add(this.EmployerNationalInsuranceLabel);
            this.Controls.Add(this.NINumber);
            this.Controls.Add(this.EmployeeTeamLabel);
            this.Controls.Add(this.EmployeeMonthlyPayLabel);
            this.Controls.Add(this.ManagerNameLabel);
            this.Controls.Add(this.EmployeeJobLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeJobLabel;
        private System.Windows.Forms.Label ManagerNameLabel;
        private System.Windows.Forms.Label EmployeeMonthlyPayLabel;
        private System.Windows.Forms.Label EmployeeTeamLabel;
        private System.Windows.Forms.Label NINumber;
        private System.Windows.Forms.Label EmployerNationalInsuranceLabel;
        private System.Windows.Forms.Label EmployeeIncomeTax;
        private System.Windows.Forms.Label EmployeePensionContribution;
        private System.Windows.Forms.Label EmployerPensionContributionLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddEmployeeSubmitButton;
        private System.Windows.Forms.TextBox EmployeeNameBox1;
        private System.Windows.Forms.TextBox EmployeeJobBox1;
        private System.Windows.Forms.TextBox ManagerNameBox1;
        private System.Windows.Forms.TextBox MonthlyPayBox1;
        private System.Windows.Forms.TextBox TeamBox1;
        private System.Windows.Forms.TextBox NationalInsuranceNumberBox1;
        private System.Windows.Forms.TextBox EmployerNationalInsuranceTextbox;
        private System.Windows.Forms.TextBox EmployeeNationalInsuranceTextbox;
        private System.Windows.Forms.TextBox EmployeePensionContributionTextbox;
        private System.Windows.Forms.TextBox EmployerPensionContributionTextbox;
        private System.Windows.Forms.TextBox EmployeeIncomeTax1;
        private System.Windows.Forms.ComboBox NICategory;
        private System.Windows.Forms.Label label1;

       
   
    }
}