namespace PayrollUI
{
    partial class EmployeeList
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
            this.EmployeeSearchLabel = new System.Windows.Forms.Label();
            this.EmployeeSearchBox = new System.Windows.Forms.TextBox();
            this.EmployeeSearchButton = new System.Windows.Forms.Button();
            this.EmployeeSearchResultsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EmployeeSearchLabel
            // 
            this.EmployeeSearchLabel.AutoSize = true;
            this.EmployeeSearchLabel.Location = new System.Drawing.Point(55, 22);
            this.EmployeeSearchLabel.Name = "EmployeeSearchLabel";
            this.EmployeeSearchLabel.Size = new System.Drawing.Size(118, 16);
            this.EmployeeSearchLabel.TabIndex = 0;
            this.EmployeeSearchLabel.Text = "Employee Search:";
            // 
            // EmployeeSearchBox
            // 
            this.EmployeeSearchBox.Location = new System.Drawing.Point(179, 19);
            this.EmployeeSearchBox.Name = "EmployeeSearchBox";
            this.EmployeeSearchBox.Size = new System.Drawing.Size(270, 22);
            this.EmployeeSearchBox.TabIndex = 1;
            this.EmployeeSearchBox.TextChanged += new System.EventHandler(this.EmployeeSearchBox_TextChanged);
            // 
            // EmployeeSearchButton
            // 
            this.EmployeeSearchButton.Location = new System.Drawing.Point(455, 18);
            this.EmployeeSearchButton.Name = "EmployeeSearchButton";
            this.EmployeeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeSearchButton.TabIndex = 2;
            this.EmployeeSearchButton.Text = "Search";
            this.EmployeeSearchButton.UseVisualStyleBackColor = true;
            this.EmployeeSearchButton.Click += new System.EventHandler(this.EmployeeSearchButton_Click);
            // 
            // EmployeeSearchResultsList
            // 
            this.EmployeeSearchResultsList.FormattingEnabled = true;
            this.EmployeeSearchResultsList.ItemHeight = 16;
            this.EmployeeSearchResultsList.Location = new System.Drawing.Point(58, 77);
            this.EmployeeSearchResultsList.Name = "EmployeeSearchResultsList";
            this.EmployeeSearchResultsList.Size = new System.Drawing.Size(472, 356);
            this.EmployeeSearchResultsList.TabIndex = 3;
            this.EmployeeSearchResultsList.SelectedIndexChanged += new System.EventHandler(this.EmployeeSearchResultsList_SelectedIndexChanged);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeSearchResultsList);
            this.Controls.Add(this.EmployeeSearchButton);
            this.Controls.Add(this.EmployeeSearchBox);
            this.Controls.Add(this.EmployeeSearchLabel);
            this.Name = "EmployeeList";
            this.Text = "Employee Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeSearchLabel;
        private System.Windows.Forms.TextBox EmployeeSearchBox;
        private System.Windows.Forms.Button EmployeeSearchButton;
        private System.Windows.Forms.ListBox EmployeeSearchResultsList;
    }
}