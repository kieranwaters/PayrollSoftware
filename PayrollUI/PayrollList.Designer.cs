namespace PayrollUI
{
    partial class PayrollList
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
            this.SearchEmployeeResultsList = new System.Windows.Forms.ListBox();
            this.SearchEmployeeBox = new System.Windows.Forms.TextBox();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeLabel = new System.Windows.Forms.Label();
            this.TaxRatesAndPensionContributionRatesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchEmployeeResultsList
            // 
            this.SearchEmployeeResultsList.FormattingEnabled = true;
            this.SearchEmployeeResultsList.ItemHeight = 16;
            this.SearchEmployeeResultsList.Location = new System.Drawing.Point(913, 79);
            this.SearchEmployeeResultsList.Name = "SearchEmployeeResultsList";
            this.SearchEmployeeResultsList.Size = new System.Drawing.Size(416, 468);
            this.SearchEmployeeResultsList.TabIndex = 65;
            // 
            // SearchEmployeeBox
            // 
            this.SearchEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEmployeeBox.Location = new System.Drawing.Point(1031, 28);
            this.SearchEmployeeBox.Name = "SearchEmployeeBox";
            this.SearchEmployeeBox.Size = new System.Drawing.Size(216, 22);
            this.SearchEmployeeBox.TabIndex = 64;
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEmployeeButton.Location = new System.Drawing.Point(1253, 27);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.SearchEmployeeButton.TabIndex = 63;
            this.SearchEmployeeButton.Text = "Search";
            this.SearchEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // SearchEmployeeLabel
            // 
            this.SearchEmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEmployeeLabel.AutoSize = true;
            this.SearchEmployeeLabel.Location = new System.Drawing.Point(910, 31);
            this.SearchEmployeeLabel.Name = "SearchEmployeeLabel";
            this.SearchEmployeeLabel.Size = new System.Drawing.Size(118, 16);
            this.SearchEmployeeLabel.TabIndex = 62;
            this.SearchEmployeeLabel.Text = "Search Employee:";
            // 
            // TaxRatesAndPensionContributionRatesButton
            // 
            this.TaxRatesAndPensionContributionRatesButton.Location = new System.Drawing.Point(13, 13);
            this.TaxRatesAndPensionContributionRatesButton.Name = "TaxRatesAndPensionContributionRatesButton";
            this.TaxRatesAndPensionContributionRatesButton.Size = new System.Drawing.Size(329, 23);
            this.TaxRatesAndPensionContributionRatesButton.TabIndex = 66;
            this.TaxRatesAndPensionContributionRatesButton.Text = "Tax Rates and Pension Contribution Rates";
            this.TaxRatesAndPensionContributionRatesButton.UseVisualStyleBackColor = true;
            this.TaxRatesAndPensionContributionRatesButton.Click += new System.EventHandler(this.TaxRatesAndPensionContributionRatesButton_Click);
            // 
            // PayrollList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 811);
            this.Controls.Add(this.TaxRatesAndPensionContributionRatesButton);
            this.Controls.Add(this.SearchEmployeeResultsList);
            this.Controls.Add(this.SearchEmployeeBox);
            this.Controls.Add(this.SearchEmployeeButton);
            this.Controls.Add(this.SearchEmployeeLabel);
            this.Name = "PayrollList";
            this.Text = "Payroll List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SearchEmployeeResultsList;
        private System.Windows.Forms.TextBox SearchEmployeeBox;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.Label SearchEmployeeLabel;
        private System.Windows.Forms.Button TaxRatesAndPensionContributionRatesButton;
    }
}