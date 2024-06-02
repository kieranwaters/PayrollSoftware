using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollUI
{
    public partial class ChangeTaxRatesAndPensionContributions : Form
    {
        private string connectionString;
        public static ChangeTaxRatesAndPensionContributions TaxAndPensionRates;

        public TextBox MinimumPensionEmployeeContributionRate_;

        public TextBox PersonalAllowanceUpperThreshold_;
        public TextBox BasicRateLowerThreshold_;
        public TextBox BasicRateUpperThreshold_;
        public TextBox HigherRateLowerThreshold_;
        public TextBox HigherRateUpperThreshold_;
        public TextBox AdditionalRateLowerThreshold_;
        public TextBox AdditionalRateUpperThreshold_;
        public TextBox PersonalAllowanceTaxRateBox_;
        public TextBox BasicRateTaxRateBox_;
        public TextBox HigherRateTaxRateBox_;
        public TextBox AdditionalRateTaxRateBox_;

        // Employee NI Contributions
        public TextBox LowerBoundLowerRateEmployeeNIContributions_;
        public TextBox UpperBoundLowerRateEmployeeNIContributions_;
        public TextBox UpperBoundMiddleRateEmployeeNIContributions_;
        public TextBox HigherThresholdRateEmployeeNIContributions_;
        public TextBox LowerBoundLowerRateEmployerNIContributions_;
        public TextBox UpperBoundLowerRateEmployerNIContributions_;
        public TextBox LowerBoundLowerMiddleRateEmployerNIContributions_;
        public TextBox UpperBoundLowerMiddleRateEmployerNIContributions_;
        public TextBox LowerBoundHigherMiddleRateEmployerNIContributions_;
        public TextBox UpperBoundHigherMiddleRateEmployerNIContributions_;
        public TextBox HigherThresholdHigherRateEmployerNIContributions_;
        public TextBox LowerBoundMiddleRateEmployeeNIContributions_;

        // Employee Low NI Textboxes
        public TextBox CatAEmployeeLowNITextbox_;
        public TextBox CatBEmployeeLowNITextbox_;
        public TextBox CatCEmployeeLowNITextbox_;
        public TextBox CatDEmployeeLowNITextbox_;
        public TextBox CatEEmployeeLowNITextbox_;
        public TextBox CatFEmployeeLowNITextbox_;
        public TextBox CatHEmployeeLowNITextbox_;
        public TextBox CatIEmployeeLowNITextbox_;
        public TextBox CatJEmployeeLowNITextbox_;
        public TextBox CatKEmployeeLowNITextbox_;
        public TextBox CatLEmployeeLowNITextbox_;
        public TextBox CatMEmployeeLowNITextbox_;
        public TextBox CatNEmployeeLowNITextbox_;
        public TextBox CatSEmployeeLowNITextbox_;
        public TextBox CatVEmployeeLowNITextbox_;
        public TextBox CatZEmployeeLowNITextbox_;

        // Employee Mid NI Textboxes
        public TextBox CatAEmployeeMidNITextbox_;
        public TextBox CatBEmployeeMidNITextbox_;
        public TextBox CatCEmployeeMidNITextbox_;
        public TextBox CatDEmployeeMidNITextbox_;
        public TextBox CatEEmployeeMidNITextbox_;
        public TextBox CatFEmployeeMidNITextbox_;
        public TextBox CatHEmployeeMidNITextbox_;
        public TextBox CatIEmployeeMidNITextbox_;
        public TextBox CatJEmployeeMidNITextbox_;
        public TextBox CatKEmployeeMidNITextbox_;
        public TextBox CatLEmployeeMidNITextbox_;
        public TextBox CatMEmployeeMidNITextbox_;
        public TextBox CatNEmployeeMidNITextbox_;
        public TextBox CatSEmployeeMidNITextbox_;
        public TextBox CatVEmployeeMidNITextbox_;
        public TextBox CatZEmployeeMidNITextbox_;

        // Employee High NI Textboxes
        public TextBox CatAEmployeeHighNITextbox_;
        public TextBox CatBEmployeeHighNITextbox_;
        public TextBox CatCEmployeeHighNITextbox_;
        public TextBox CatDEmployeeHighNITextbox_;
        public TextBox CatEEmployeeHighNITextbox_;
        public TextBox CatFEmployeeHighNITextbox_;
        public TextBox CatHEmployeeHighNITextbox_;
        public TextBox CatIEmployeeHighNITextbox_;
        public TextBox CatJEmployeeHighNITextbox_;
        public TextBox CatKEmployeeHighNITextbox_;
        public TextBox CatLEmployeeHighNITextbox_;
        public TextBox CatMEmployeeHighNITextbox_;
        public TextBox CatNEmployeeHighNITextbox_;
        public TextBox CatSEmployeeHighNITextbox_;
        public TextBox CatVEmployeeHighNITextbox_;
        public TextBox CatZEmployeeHighNITextbox_;

        // Employer Low NI Textboxes
        public TextBox CatAEmployerLowNITextbox_;
        public TextBox CatBEmployerLowNITextbox_;
        public TextBox CatCEmployerLowNITextbox_;
        public TextBox CatDEmployerLowNITextbox_;
        public TextBox CatEEmployerLowNITextbox_;
        public TextBox CatFEmployerLowNITextbox_;
        public TextBox CatHEmployerLowNITextbox_;
        public TextBox CatIEmployerLowNITextbox_;
        public TextBox CatJEmployerLowNITextbox_;
        public TextBox CatKEmployerLowNITextbox_;
        public TextBox CatLEmployerLowNITextbox_;
        public TextBox CatMEmployerLowNITextbox_;
        public TextBox CatNEmployerLowNITextbox_;
        public TextBox CatSEmployerLowNITextbox_;
        public TextBox CatVEmployerLowNITextbox_;
        public TextBox CatZEmployerLowNITextbox_;

        // Employer Low Mid NI Textboxes
        public TextBox CatAEmployerLowMidNITextbox_;
        public TextBox CatBEmployerLowMidNITextbox_;
        public TextBox CatCEmployerLowMidNITextbox_;
        public TextBox CatDEmployerLowMidNITextbox_;
        public TextBox CatEEmployerLowMidNITextbox_;
        public TextBox CatFEmployerLowMidNITextbox_;
        public TextBox CatHEmployerLowMidNITextbox_;
        public TextBox CatIEmployerLowMidNITextbox_;
        public TextBox CatJEmployerLowMidNITextbox_;
        public TextBox CatKEmployerLowMidNITextbox_;
        public TextBox CatLEmployerLowMidNITextbox_;
        public TextBox CatMEmployerLowMidNITextbox_;
        public TextBox CatNEmployerLowMidNITextbox_;
        public TextBox CatSEmployerLowMidNITextbox_;
        public TextBox CatVEmployerLowMidNITextbox_;
        public TextBox CatZEmployerLowMidNITextbox_;

        // Employer High Mid NI Textboxes
        public TextBox CatAEmployerHighMidNITextbox_;
        public TextBox CatBEmployerHighMidNITextbox_;
        public TextBox CatCEmployerHighMidNITextbox_;
        public TextBox CatDEmployerHighMidNITextbox_;
        public TextBox CatEEmployerHighMidNITextbox_;
        public TextBox CatFEmployerHighMidNITextbox_;
        public TextBox CatHEmployerHighMidNITextbox_;
        public TextBox CatIEmployerHighMidNITextbox_;
        public TextBox CatJEmployerHighMidNITextbox_;
        public TextBox CatKEmployerHighMidNITextbox_;
        public TextBox CatLEmployerHighMidNITextbox_;
        public TextBox CatMEmployerHighMidNITextbox_;
        public TextBox CatNEmployerHighMidNITextbox_;
        public TextBox CatSEmployerHighMidNITextbox_;
        public TextBox CatVEmployerHighMidNITextbox_;
        public TextBox CatZEmployerHighMidNITextbox_;

        // Employer High NI Textboxes
        public TextBox CatAEmployerHighNITextbox_;
        public TextBox CatBEmployerHighNITextbox_;
        public TextBox CatCEmployerHighNITextbox_;
        public TextBox CatDEmployerHighNITextbox_;
        public TextBox CatEEmployerHighNITextbox_;
        public TextBox CatFEmployerHighNITextbox_;
        public TextBox CatHEmployerHighNITextbox_;
        public TextBox CatIEmployerHighNITextbox_;
        public TextBox CatJEmployerHighNITextbox_;
        public TextBox CatKEmployerHighNITextbox_;
        public TextBox CatLEmployerHighNITextbox_;
        public TextBox CatMEmployerHighNITextbox_;
        public TextBox CatNEmployerHighNITextbox_;
        public TextBox CatSEmployerHighNITextbox_;
        public TextBox CatVEmployerHighNITextbox_;
        public TextBox CatZEmployerHighNITextbox_;


        public ChangeTaxRatesAndPensionContributions()
        {
            InitializeComponent();
            TaxAndPensionRates = this;
            MinimumPensionEmployeeContributionRate_ = MinimumPensionEmployeeContributionRate;
            PersonalAllowanceUpperThreshold_ = PersonalAllowanceUpperThreshold;
            BasicRateLowerThreshold_ = BasicRateLowerThreshold;
            BasicRateUpperThreshold_ = BasicRateUpperThreshold;
            HigherRateLowerThreshold_ = HigherRateLowerThreshold;
            HigherRateUpperThreshold_ = HigherRateUpperThreshold;
            
            AdditionalRateLowerThreshold_ = AdditionalRateLowerThreshold;
            AdditionalRateUpperThreshold_ = AdditionalRateUpperThreshold;
            PersonalAllowanceTaxRateBox_ = PersonalAllowanceTaxRateBox;
            BasicRateTaxRateBox_ = BasicRateTaxRateBox;
            HigherRateTaxRateBox_ = HigherRateTaxRateBox;
            AdditionalRateTaxRateBox_ = AdditionalRateTaxRateBox;

            LowerBoundLowerRateEmployeeNIContributions_ = LowerBoundLowerRateEmployeeNIContributions;
            UpperBoundLowerRateEmployeeNIContributions_ = UpperBoundLowerRateEmployeeNIContributions;
            UpperBoundMiddleRateEmployeeNIContributions_ = UpperBoundMiddleRateEmployeeNIContributions;
            HigherThresholdRateEmployeeNIContributions_ = HigherThresholdRateEmployeeNIContributions;
            LowerBoundLowerRateEmployerNIContributions_ = LowerBoundLowerRateEmployerNIContributions;
            UpperBoundLowerRateEmployerNIContributions_ = UpperBoundLowerRateEmployerNIContributions;
            LowerBoundLowerMiddleRateEmployerNIContributions_ = LowerBoundLowerMiddleRateEmployerNIContributions;
            UpperBoundLowerMiddleRateEmployerNIContributions_ = UpperBoundLowerMiddleRateEmployerNIContributions;
            LowerBoundHigherMiddleRateEmployerNIContributions_ = LowerBoundHigherMiddleRateEmployerNIContributions;
            UpperBoundHigherMiddleRateEmployerNIContributions_ = UpperBoundHigherMiddleRateEmployerNIContributions;
            HigherThresholdHigherRateEmployerNIContributions_ = HigherThresholdHigherRateEmployerNIContributions;

            CatAEmployeeLowNITextbox_ = CatAEmployeeLowNITextbox;
            CatBEmployeeLowNITextbox_ = CatBEmployeeLowNITextbox;
            CatCEmployeeLowNITextbox_ = CatCEmployeeLowNITextbox;
            CatDEmployeeLowNITextbox_ = CatDEmployeeLowNITextbox;
            CatEEmployeeLowNITextbox_ = CatEEmployeeLowNITextbox;
            CatFEmployeeLowNITextbox_ = CatFEmployeeLowNITextbox;
            CatHEmployeeLowNITextbox_ = CatHEmployeeLowNITextbox;
            CatIEmployeeLowNITextbox_ = CatIEmployeeLowNITextbox;
            CatJEmployeeLowNITextbox_ = CatJEmployeeLowNITextbox;
            CatKEmployeeLowNITextbox_ = CatKEmployeeLowNITextbox;
            CatLEmployeeLowNITextbox_ = CatLEmployeeLowNITextbox;
            CatMEmployeeLowNITextbox_ = CatMEmployeeLowNITextbox;
            CatNEmployeeLowNITextbox_ = CatNEmployeeLowNITextbox;
            CatSEmployeeLowNITextbox_ = CatSEmployeeLowNITextbox;
            CatVEmployeeLowNITextbox_ = CatVEmployeeLowNITextbox;
            CatZEmployeeLowNITextbox_ = CatZEmployeeLowNITextbox;

            CatAEmployeeMidNITextbox_ = CatAEmployeeMidNITextbox;
            CatBEmployeeMidNITextbox_ = CatBEmployeeMidNITextbox;
            CatCEmployeeMidNITextbox_ = CatCEmployeeMidNITextbox;
            CatDEmployeeMidNITextbox_ = CatDEmployeeMidNITextbox;
            CatEEmployeeMidNITextbox_ = CatEEmployeeMidNITextbox;
            CatFEmployeeMidNITextbox_ = CatFEmployeeMidNITextbox;
            CatHEmployeeMidNITextbox_ = CatHEmployeeMidNITextbox;
            CatIEmployeeMidNITextbox_ = CatIEmployeeMidNITextbox;
            CatJEmployeeMidNITextbox_ = CatJEmployeeMidNITextbox;
            CatKEmployeeMidNITextbox_ = CatKEmployeeMidNITextbox;
            CatLEmployeeMidNITextbox_ = CatLEmployeeMidNITextbox;
            CatMEmployeeMidNITextbox_ = CatMEmployeeMidNITextbox;
            CatNEmployeeMidNITextbox_ = CatNEmployeeMidNITextbox;
            CatSEmployeeMidNITextbox_ = CatSEmployeeMidNITextbox;
            CatVEmployeeMidNITextbox_ = CatVEmployeeMidNITextbox;
            CatZEmployeeMidNITextbox_ = CatZEmployeeMidNITextbox;

            CatAEmployeeHighNITextbox_ = CatAEmployeeHighNITextbox;
            CatBEmployeeHighNITextbox_ = CatBEmployeeHighNITextbox;
            CatCEmployeeHighNITextbox_ = CatCEmployeeHighNITextbox;
            CatDEmployeeHighNITextbox_ = CatDEmployeeHighNITextbox;
            CatEEmployeeHighNITextbox_ = CatEEmployeeHighNITextbox;
            CatFEmployeeHighNITextbox_ = CatFEmployeeHighNITextbox;
            CatHEmployeeHighNITextbox_ = CatHEmployeeHighNITextbox;
            CatIEmployeeHighNITextbox_ = CatIEmployeeHighNITextbox;
            CatJEmployeeHighNITextbox_ = CatJEmployeeHighNITextbox;
            CatKEmployeeHighNITextbox_ = CatKEmployeeHighNITextbox;
            CatLEmployeeHighNITextbox_ = CatLEmployeeHighNITextbox;
            CatMEmployeeHighNITextbox_ = CatMEmployeeHighNITextbox;
            CatNEmployeeHighNITextbox_ = CatNEmployeeHighNITextbox;
            CatSEmployeeHighNITextbox_ = CatSEmployeeHighNITextbox;
            CatVEmployeeHighNITextbox_ = CatVEmployeeHighNITextbox;
            CatZEmployeeHighNITextbox_ = CatZEmployeeHighNITextbox;

            CatAEmployerLowNITextbox_ = CatAEmployerLowNITextbox;
            CatBEmployerLowNITextbox_ = CatBEmployerLowNITextbox;
            CatCEmployerLowNITextbox_ = CatCEmployerLowNITextbox;
            CatDEmployerLowNITextbox_ = CatDEmployerLowNITextbox;
            CatEEmployerLowNITextbox_ = CatEEmployerLowNITextbox;
            CatFEmployerLowNITextbox_ = CatFEmployerLowNITextbox;
            CatHEmployerLowNITextbox_ = CatHEmployerLowNITextbox;
            CatIEmployerLowNITextbox_ = CatIEmployerLowNITextbox;
            CatJEmployerLowNITextbox_ = CatJEmployerLowNITextbox;
            CatKEmployerLowNITextbox_ = CatKEmployerLowNITextbox;
            CatLEmployerLowNITextbox_ = CatLEmployerLowNITextbox;
            CatMEmployerLowNITextbox_ = CatMEmployerLowNITextbox;
            CatNEmployerLowNITextbox_ = CatNEmployerLowNITextbox;
            CatSEmployerLowNITextbox_ = CatSEmployerLowNITextbox;
            CatVEmployerLowNITextbox_ = CatVEmployerLowNITextbox;
            CatZEmployerLowNITextbox_ = CatZEmployerLowNITextbox;

            CatAEmployerLowMidNITextbox_ = CatAEmployerLowMidNITextbox;
            CatBEmployerLowMidNITextbox_ = CatBEmployerLowMidNITextbox;
            CatCEmployerLowMidNITextbox_ = CatCEmployerLowMidNITextbox;
            CatDEmployerLowMidNITextbox_ = CatDEmployerLowMidNITextbox;
            CatEEmployerLowMidNITextbox_ = CatEEmployerLowMidNITextbox;
            CatFEmployerLowMidNITextbox_ = CatFEmployerLowMidNITextbox;
            CatHEmployerLowMidNITextbox_ = CatHEmployerLowMidNITextbox;
            CatIEmployerLowMidNITextbox_ = CatIEmployerLowMidNITextbox;
            CatJEmployerLowMidNITextbox_ = CatJEmployerLowMidNITextbox;
            CatKEmployerLowMidNITextbox_ = CatKEmployerLowMidNITextbox;
            CatLEmployerLowMidNITextbox_ = CatLEmployerLowMidNITextbox;
            CatMEmployerLowMidNITextbox_ = CatMEmployerLowMidNITextbox;
            CatNEmployerLowMidNITextbox_ = CatNEmployerLowMidNITextbox;
            CatSEmployerLowMidNITextbox_ = CatSEmployerLowMidNITextbox;
            CatVEmployerLowMidNITextbox_ = CatVEmployerLowMidNITextbox;
            CatZEmployerLowMidNITextbox_ = CatZEmployerLowMidNITextbox;

            CatAEmployerHighMidNITextbox_ = CatAEmployerHighMidNITextbox;
            CatBEmployerHighMidNITextbox_ = CatBEmployerHighMidNITextbox;
            CatCEmployerHighMidNITextbox_ = CatCEmployerHighMidNITextbox;
            CatDEmployerHighMidNITextbox_ = CatDEmployerHighMidNITextbox;
            CatEEmployerHighMidNITextbox_ = CatEEmployerHighMidNITextbox;
            CatFEmployerHighMidNITextbox_ = CatFEmployerHighMidNITextbox;
            CatHEmployerHighMidNITextbox_ = CatHEmployerHighMidNITextbox;
            CatIEmployerHighMidNITextbox_ = CatIEmployerHighMidNITextbox;
            CatJEmployerHighMidNITextbox_ = CatJEmployerHighMidNITextbox;
            CatKEmployerHighMidNITextbox_ = CatKEmployerHighMidNITextbox;
            CatLEmployerHighMidNITextbox_ = CatLEmployerHighMidNITextbox;
            CatMEmployerHighMidNITextbox_ = CatMEmployerHighMidNITextbox;
            CatNEmployerHighMidNITextbox_ = CatNEmployerHighMidNITextbox;
            CatSEmployerHighMidNITextbox_ = CatSEmployerHighMidNITextbox;
            CatVEmployerHighMidNITextbox_ = CatVEmployerHighMidNITextbox;
            CatZEmployerHighMidNITextbox_ = CatZEmployerHighMidNITextbox;

            CatAEmployerHighNITextbox_ = CatAEmployerHighNITextbox;
            CatBEmployerHighNITextbox_ = CatBEmployerHighNITextbox;
            CatCEmployerHighNITextbox_ = CatCEmployerHighNITextbox;
            CatDEmployerHighNITextbox_ = CatDEmployerHighNITextbox;
            CatEEmployerHighNITextbox_ = CatEEmployerHighNITextbox;
            CatFEmployerHighNITextbox_ = CatFEmployerHighNITextbox;
            CatHEmployerHighNITextbox_ = CatHEmployerHighNITextbox;
            CatIEmployerHighNITextbox_ = CatIEmployerHighNITextbox;
            CatJEmployerHighNITextbox_ = CatJEmployerHighNITextbox;
            CatKEmployerHighNITextbox_ = CatKEmployerHighNITextbox;
            CatLEmployerHighNITextbox_ = CatLEmployerHighNITextbox;
            CatMEmployerHighNITextbox_ = CatMEmployerHighNITextbox;
            CatNEmployerHighNITextbox_ = CatNEmployerHighNITextbox;
            CatSEmployerHighNITextbox_ = CatSEmployerHighNITextbox;
            CatVEmployerHighNITextbox_ = CatVEmployerHighNITextbox;
            CatZEmployerHighNITextbox_ = CatZEmployerHighNITextbox;
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ChageIncomeTaxButton_Click(object sender, EventArgs e)
        {
            PersonalAllowanceLowerThreshold.ReadOnly = false;
            PersonalAllowanceUpperThreshold.ReadOnly = false;
            BasicRateLowerThreshold.ReadOnly = false;
            BasicRateUpperThreshold.ReadOnly = false;
            HigherRateLowerThreshold.ReadOnly = false;
            HigherRateLowerThreshold.ReadOnly = false;
            HigherRateUpperThreshold.ReadOnly = false;
            AdditionalRateLowerThreshold.ReadOnly = false;
            AdditionalRateUpperThreshold.ReadOnly = false;
        }

        public void PersonalAllowanceLowerThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void PersonalAllowanceUpperThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void BasicRateLowerThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void BasicRateUpperThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void HigherRateLowerThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void HigherRateUpperThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        public void AdditionalRateLowerThreshold_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void AdditionalRateUpperThreshold_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void PersonalAllowanceTaxRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void BasicRateTaxRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void HigherRateTaxRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void AdditionalRateTaxRateBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void BasicRateLabel_Click(object sender, EventArgs e)
        {

        }

        public void HigherRateLabel_Click(object sender, EventArgs e)
        {

        }

        public void AdditionalRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveIncomeTaxButton_Click(object sender, EventArgs e)

        {
            PersonalAllowanceLowerThreshold.ReadOnly = true;
            PersonalAllowanceUpperThreshold.ReadOnly = true;
            BasicRateLowerThreshold.ReadOnly = true;
            BasicRateUpperThreshold.ReadOnly = true;
            HigherRateLowerThreshold.ReadOnly = true;
            HigherRateLowerThreshold.ReadOnly = true;
            HigherRateUpperThreshold.ReadOnly = true;
            AdditionalRateLowerThreshold.ReadOnly = true;
            AdditionalRateUpperThreshold.ReadOnly = true;

        }

        public void MinimumPensionEmployeeContributionRate_TextChanged(object sender, EventArgs e)
        {

        }

        public void MaximumPensionEmployeeContributionRate_TextChanged(object sender, EventArgs e)
        {

        }

        public void MinimumPensionEmployerContributionRate_TextChanged(object sender, EventArgs e)
        {

        }

        public void MaximumPensionEmployerContributionRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePensionContributionButton_Click(object sender, EventArgs e)
        {
            MinimumPensionEmployeeContributionRate.ReadOnly = false;
            MaximumPensionEmployeeContributionRate.ReadOnly = false;
            MinimumPensionEmployerContributionRate.ReadOnly = false;
            MaximumPensionEmployerContributionRate.ReadOnly = false;
        }

        private void SavePensionContributionAmount_Click(object sender, EventArgs e)
        {
            MinimumPensionEmployeeContributionRate.ReadOnly = true;
            MaximumPensionEmployeeContributionRate.ReadOnly = true;
            MinimumPensionEmployerContributionRate.ReadOnly = true;
            MaximumPensionEmployerContributionRate.ReadOnly = true;
            /* double minimumPensionEmployeeContribution = double.Parse(MinimumPensionEmployeeContributionRate.Text);
             double maximumPensionEmployeeContribution = double.Parse(MaximumPensionEmployeeContributionRate.Text);
             double minimumPensionEmployerContribution = double.Parse(MinimumPensionEmployerContributionRate.Text);
             double maximumPensionEmployerContribution = double.Parse(MaximumPensionEmployerContributionRate.Text);


             PensionContributionRates UpdatedPensionContributionRates = new PensionContributionRates(
                 minimumPensionEmployeeContribution, maximumPensionEmployeeContribution,
                 minimumPensionEmployerContribution, maximumPensionEmployerContribution

                         );

             UpdateUpdatedPensionContributionRatesDatabase(UpdatedPensionContributionRates);
         }

         public void UpdateUpdatedPensionContributionRatesDatabase(PensionContributionRates UpdatedPensionContributionRates)
         {
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 connection.Open(); 
                 string sql = "INSERT INTO PensionContributionRates (MinimumPensionEmployeeContribution, MaximumPensionEmployeeContribution, MinimumPensionEmployerContribution, MaximumPensionEmployerContribution) VALUES (@MinimumPensionEmployeeContribution, @MaximumPensionEmployeeContribution, @MinimumPensionEmployerContribution, @MaximumPensionEmployerContribution)";
                 SqlCommand command = new SqlCommand(sql, connection);
                 command.Parameters.AddWithValue("@MinimumPensionEmployeeContribution", UpdatedPensionContributionRates.MinimumPensionEmployeeContribution);
                 command.Parameters.AddWithValue("@MaximumPensionEmployeeContribution", UpdatedPensionContributionRates.MaximumPensionEmployeeContribution);
                 command.Parameters.AddWithValue("@MinimumPensionEmployerContribution", UpdatedPensionContributionRates.MinimumPensionEmployerContribution);
                 command.Parameters.AddWithValue("@MaximumPensionEmployerContribution", UpdatedPensionContributionRates.MaximumPensionEmployerContribution);

                 command.ExecuteNonQuery();
             }*/
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CategoryA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void LowerBoundMiddleRateEmployeeNIContributions_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatAEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployeeLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployeeLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployeeMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployeeMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployeeHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployeeHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployerLowNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployerLowNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployerLowMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployerLowMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployerHighMidNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployerHighMidNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatAEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatAEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatBEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatBEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatCEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatCEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatDEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatDEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatEEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatEEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatFEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatFEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatHEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatHEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatIEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatIEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatJEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatJEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatKEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatKEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatLEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatLEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatMEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatMEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatNEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatNEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatSEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatSEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatVEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatVEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void CatZEmployerHighNITextbox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CatZEmployerHighNITextbox.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.If N/A enter 0");
            }
        }

        private void HigherThresholdHigherRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = HigherThresholdHigherRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void UpperBoundHigherMiddleRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = UpperBoundHigherMiddleRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void LowerBoundHigherMiddleRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = LowerBoundHigherMiddleRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void UpperBoundLowerMiddleRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = UpperBoundLowerMiddleRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void LowerBoundLowerMiddleRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = LowerBoundLowerMiddleRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void UpperBoundLowerRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = UpperBoundLowerRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void LowerBoundLowerRateEmployerNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = LowerBoundLowerRateEmployerNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void HigherThresholdRateEmployeeNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = HigherThresholdRateEmployeeNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void UpperBoundMiddleRateEmployeeNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = UpperBoundMiddleRateEmployeeNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void UpperBoundLowerRateEmployeeNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = UpperBoundLowerRateEmployeeNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void LowerBoundLowerRateEmployeeNIContributions_TextChanged(object sender, EventArgs e)
        {
            string userInput = LowerBoundLowerRateEmployeeNIContributions.Text;
            int number;

            if (int.TryParse(userInput, out number))
            { }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ChangeNationalInsuranceRatesButton_Click(object sender, EventArgs e)
        {
            LowerBoundLowerRateEmployeeNIContributions.ReadOnly = false;
            UpperBoundLowerRateEmployeeNIContributions.ReadOnly = false;
            UpperBoundMiddleRateEmployeeNIContributions.ReadOnly = false;
            HigherThresholdRateEmployeeNIContributions.ReadOnly = false;
            LowerBoundLowerRateEmployerNIContributions.ReadOnly = false;
            UpperBoundLowerRateEmployerNIContributions.ReadOnly = false;
            LowerBoundLowerMiddleRateEmployerNIContributions.ReadOnly = false;
            UpperBoundLowerMiddleRateEmployerNIContributions.ReadOnly = false;
            LowerBoundHigherMiddleRateEmployerNIContributions.ReadOnly = false;
            UpperBoundHigherMiddleRateEmployerNIContributions.ReadOnly = false;
            HigherThresholdHigherRateEmployerNIContributions.ReadOnly = false;

            CatAEmployeeLowNITextbox.ReadOnly = false;
            CatBEmployeeLowNITextbox.ReadOnly = false;
            CatCEmployeeLowNITextbox.ReadOnly = false;
            CatDEmployeeLowNITextbox.ReadOnly = false;
            CatEEmployeeLowNITextbox.ReadOnly = false;
            CatFEmployeeLowNITextbox.ReadOnly = false;
            CatHEmployeeLowNITextbox.ReadOnly = false;
            CatIEmployeeLowNITextbox.ReadOnly = false;
            CatJEmployeeLowNITextbox.ReadOnly = false;
            CatKEmployeeLowNITextbox.ReadOnly = false;
            CatLEmployeeLowNITextbox.ReadOnly = false;
            CatMEmployeeLowNITextbox.ReadOnly = false;
            CatNEmployeeLowNITextbox.ReadOnly = false;
            CatSEmployeeLowNITextbox.ReadOnly = false;
            CatVEmployeeLowNITextbox.ReadOnly = false;
            CatZEmployeeLowNITextbox.ReadOnly = false;

            CatAEmployeeMidNITextbox.ReadOnly = false;
            CatBEmployeeMidNITextbox.ReadOnly = false;
            CatCEmployeeMidNITextbox.ReadOnly = false;
            CatDEmployeeMidNITextbox.ReadOnly = false;
            CatEEmployeeMidNITextbox.ReadOnly = false;
            CatFEmployeeMidNITextbox.ReadOnly = false;
            CatHEmployeeMidNITextbox.ReadOnly = false;
            CatIEmployeeMidNITextbox.ReadOnly = false;
            CatJEmployeeMidNITextbox.ReadOnly = false;
            CatKEmployeeMidNITextbox.ReadOnly = false;
            CatLEmployeeMidNITextbox.ReadOnly = false;
            CatMEmployeeMidNITextbox.ReadOnly = false;
            CatNEmployeeMidNITextbox.ReadOnly = false;
            CatSEmployeeMidNITextbox.ReadOnly = false;
            CatVEmployeeMidNITextbox.ReadOnly = false;
            CatZEmployeeMidNITextbox.ReadOnly = false;

            CatAEmployeeHighNITextbox.ReadOnly = false;
            CatBEmployeeHighNITextbox.ReadOnly = false;
            CatCEmployeeHighNITextbox.ReadOnly = false;
            CatDEmployeeHighNITextbox.ReadOnly = false;
            CatEEmployeeHighNITextbox.ReadOnly = false;
            CatFEmployeeHighNITextbox.ReadOnly = false;
            CatHEmployeeHighNITextbox.ReadOnly = false;
            CatIEmployeeHighNITextbox.ReadOnly = false;
            CatJEmployeeHighNITextbox.ReadOnly = false;
            CatKEmployeeHighNITextbox.ReadOnly = false;
            CatLEmployeeHighNITextbox.ReadOnly = false;
            CatMEmployeeHighNITextbox.ReadOnly = false;
            CatNEmployeeHighNITextbox.ReadOnly = false;
            CatSEmployeeHighNITextbox.ReadOnly = false;
            CatVEmployeeHighNITextbox.ReadOnly = false;
            CatZEmployeeHighNITextbox.ReadOnly = false;

            CatAEmployerLowNITextbox.ReadOnly = false;
            CatBEmployerLowNITextbox.ReadOnly = false;
            CatCEmployerLowNITextbox.ReadOnly = false;
            CatDEmployerLowNITextbox.ReadOnly = false;
            CatEEmployerLowNITextbox.ReadOnly = false;
            CatFEmployerLowNITextbox.ReadOnly = false;
            CatHEmployerLowNITextbox.ReadOnly = false;
            CatIEmployerLowNITextbox.ReadOnly = false;
            CatJEmployerLowNITextbox.ReadOnly = false;
            CatKEmployerLowNITextbox.ReadOnly = false;
            CatLEmployerLowNITextbox.ReadOnly = false;
            CatMEmployerLowNITextbox.ReadOnly = false;
            CatNEmployerLowNITextbox.ReadOnly = false;
            CatSEmployerLowNITextbox.ReadOnly = false;
            CatVEmployerLowNITextbox.ReadOnly = false;
            CatZEmployerLowNITextbox.ReadOnly = false;

            CatAEmployerLowMidNITextbox.ReadOnly = false;
            CatBEmployerLowMidNITextbox.ReadOnly = false;
            CatCEmployerLowMidNITextbox.ReadOnly = false;
            CatDEmployerLowMidNITextbox.ReadOnly = false;
            CatEEmployerLowMidNITextbox.ReadOnly = false;
            CatFEmployerLowMidNITextbox.ReadOnly = false;
            CatHEmployerLowMidNITextbox.ReadOnly = false;
            CatIEmployerLowMidNITextbox.ReadOnly = false;
            CatJEmployerLowMidNITextbox.ReadOnly = false;
            CatKEmployerLowMidNITextbox.ReadOnly = false;
            CatLEmployerLowMidNITextbox.ReadOnly = false;
            CatMEmployerLowMidNITextbox.ReadOnly = false;
            CatNEmployerLowMidNITextbox.ReadOnly = false;
            CatSEmployerLowMidNITextbox.ReadOnly = false;
            CatVEmployerLowMidNITextbox.ReadOnly = false;
            CatZEmployerLowMidNITextbox.ReadOnly = false;

            CatAEmployerHighMidNITextbox.ReadOnly = false;
            CatBEmployerHighMidNITextbox.ReadOnly = false;
            CatCEmployerHighMidNITextbox.ReadOnly = false;
            CatDEmployerHighMidNITextbox.ReadOnly = false;
            CatEEmployerHighMidNITextbox.ReadOnly = false;
            CatFEmployerHighMidNITextbox.ReadOnly = false;
            CatHEmployerHighMidNITextbox.ReadOnly = false;
            CatIEmployerHighMidNITextbox.ReadOnly = false;
            CatJEmployerHighMidNITextbox.ReadOnly = false;
            CatKEmployerHighMidNITextbox.ReadOnly = false;
            CatLEmployerHighMidNITextbox.ReadOnly = false;
            CatMEmployerHighMidNITextbox.ReadOnly = false;
            CatNEmployerHighMidNITextbox.ReadOnly = false;
            CatSEmployerHighMidNITextbox.ReadOnly = false;
            CatVEmployerHighMidNITextbox.ReadOnly = false;
            CatZEmployerHighMidNITextbox.ReadOnly = false;

            CatAEmployerHighNITextbox.ReadOnly = false;
            CatBEmployerHighNITextbox.ReadOnly = false;
            CatCEmployerHighNITextbox.ReadOnly = false;
            CatDEmployerHighNITextbox.ReadOnly = false;
            CatEEmployerHighNITextbox.ReadOnly = false;
            CatFEmployerHighNITextbox.ReadOnly = false;
            CatHEmployerHighNITextbox.ReadOnly = false;
            CatIEmployerHighNITextbox.ReadOnly = false;
            CatJEmployerHighNITextbox.ReadOnly = false;
            CatKEmployerHighNITextbox.ReadOnly = false;
            CatLEmployerHighNITextbox.ReadOnly = false;
            CatMEmployerHighNITextbox.ReadOnly = false;
            CatNEmployerHighNITextbox.ReadOnly = false;
            CatSEmployerHighNITextbox.ReadOnly = false;
            CatVEmployerHighNITextbox.ReadOnly = false;
            CatZEmployerHighNITextbox.ReadOnly = false;
        }

        private void SaveChangesInNationalInsuranceRatesButton_Click(object sender, EventArgs e)
        {
            LowerBoundLowerRateEmployeeNIContributions.ReadOnly = true;
            UpperBoundLowerRateEmployeeNIContributions.ReadOnly = true;
            UpperBoundMiddleRateEmployeeNIContributions.ReadOnly = true;
            HigherThresholdRateEmployeeNIContributions.ReadOnly = true;
            LowerBoundLowerRateEmployerNIContributions.ReadOnly = true;
            UpperBoundLowerRateEmployerNIContributions.ReadOnly = true;
            LowerBoundLowerMiddleRateEmployerNIContributions.ReadOnly = true;
            UpperBoundLowerMiddleRateEmployerNIContributions.ReadOnly = true;
            LowerBoundHigherMiddleRateEmployerNIContributions.ReadOnly = true;
            UpperBoundHigherMiddleRateEmployerNIContributions.ReadOnly = true;
            HigherThresholdHigherRateEmployerNIContributions.ReadOnly = true;

            CatAEmployeeLowNITextbox.ReadOnly = true;
            CatBEmployeeLowNITextbox.ReadOnly = true;
            CatCEmployeeLowNITextbox.ReadOnly = true;
            CatDEmployeeLowNITextbox.ReadOnly = true;
            CatEEmployeeLowNITextbox.ReadOnly = true;
            CatFEmployeeLowNITextbox.ReadOnly = true;
            CatHEmployeeLowNITextbox.ReadOnly = true;
            CatIEmployeeLowNITextbox.ReadOnly = true;
            CatJEmployeeLowNITextbox.ReadOnly = true;
            CatKEmployeeLowNITextbox.ReadOnly = true;
            CatLEmployeeLowNITextbox.ReadOnly = true;
            CatMEmployeeLowNITextbox.ReadOnly = true;
            CatNEmployeeLowNITextbox.ReadOnly = true;
            CatSEmployeeLowNITextbox.ReadOnly = true;
            CatVEmployeeLowNITextbox.ReadOnly = true;
            CatZEmployeeLowNITextbox.ReadOnly = true;

            CatAEmployeeMidNITextbox.ReadOnly = true;
            CatBEmployeeMidNITextbox.ReadOnly = true;
            CatCEmployeeMidNITextbox.ReadOnly = true;
            CatDEmployeeMidNITextbox.ReadOnly = true;
            CatEEmployeeMidNITextbox.ReadOnly = true;
            CatFEmployeeMidNITextbox.ReadOnly = true;
            CatHEmployeeMidNITextbox.ReadOnly = true;
            CatIEmployeeMidNITextbox.ReadOnly = true;
            CatJEmployeeMidNITextbox.ReadOnly = true;
            CatKEmployeeMidNITextbox.ReadOnly = true;
            CatLEmployeeMidNITextbox.ReadOnly = true;
            CatMEmployeeMidNITextbox.ReadOnly = true;
            CatNEmployeeMidNITextbox.ReadOnly = true;
            CatSEmployeeMidNITextbox.ReadOnly = true;
            CatVEmployeeMidNITextbox.ReadOnly = true;
            CatZEmployeeMidNITextbox.ReadOnly = true;

            CatAEmployeeHighNITextbox.ReadOnly = true;
            CatBEmployeeHighNITextbox.ReadOnly = true;
            CatCEmployeeHighNITextbox.ReadOnly = true;
            CatDEmployeeHighNITextbox.ReadOnly = true;
            CatEEmployeeHighNITextbox.ReadOnly = true;
            CatFEmployeeHighNITextbox.ReadOnly = true;
            CatHEmployeeHighNITextbox.ReadOnly = true;
            CatIEmployeeHighNITextbox.ReadOnly = true;
            CatJEmployeeHighNITextbox.ReadOnly = true;
            CatKEmployeeHighNITextbox.ReadOnly = true;
            CatLEmployeeHighNITextbox.ReadOnly = true;
            CatMEmployeeHighNITextbox.ReadOnly = true;
            CatNEmployeeHighNITextbox.ReadOnly = true;
            CatSEmployeeHighNITextbox.ReadOnly = true;
            CatVEmployeeHighNITextbox.ReadOnly = true;
            CatZEmployeeHighNITextbox.ReadOnly = true;

            CatAEmployerLowNITextbox.ReadOnly = true;
            CatBEmployerLowNITextbox.ReadOnly = true;
            CatCEmployerLowNITextbox.ReadOnly = true;
            CatDEmployerLowNITextbox.ReadOnly = true;
            CatEEmployerLowNITextbox.ReadOnly = true;
            CatFEmployerLowNITextbox.ReadOnly = true;
            CatHEmployerLowNITextbox.ReadOnly = true;
            CatIEmployerLowNITextbox.ReadOnly = true;
            CatJEmployerLowNITextbox.ReadOnly = true;
            CatKEmployerLowNITextbox.ReadOnly = true;
            CatLEmployerLowNITextbox.ReadOnly = true;
            CatMEmployerLowNITextbox.ReadOnly = true;
            CatNEmployerLowNITextbox.ReadOnly = true;
            CatSEmployerLowNITextbox.ReadOnly = true;
            CatVEmployerLowNITextbox.ReadOnly = true;
            CatZEmployerLowNITextbox.ReadOnly = true;

            CatAEmployerLowMidNITextbox.ReadOnly = true;
            CatBEmployerLowMidNITextbox.ReadOnly = true;
            CatCEmployerLowMidNITextbox.ReadOnly = true;
            CatDEmployerLowMidNITextbox.ReadOnly = true;
            CatEEmployerLowMidNITextbox.ReadOnly = true;
            CatFEmployerLowMidNITextbox.ReadOnly = true;
            CatHEmployerLowMidNITextbox.ReadOnly = true;
            CatIEmployerLowMidNITextbox.ReadOnly = true;
            CatJEmployerLowMidNITextbox.ReadOnly = true;
            CatKEmployerLowMidNITextbox.ReadOnly = true;
            CatLEmployerLowMidNITextbox.ReadOnly = true;
            CatMEmployerLowMidNITextbox.ReadOnly = true;
            CatNEmployerLowMidNITextbox.ReadOnly = true;
            CatSEmployerLowMidNITextbox.ReadOnly = true;
            CatVEmployerLowMidNITextbox.ReadOnly = true;
            CatZEmployerLowMidNITextbox.ReadOnly = true;

            CatAEmployerHighMidNITextbox.ReadOnly = true;
            CatBEmployerHighMidNITextbox.ReadOnly = true;
            CatCEmployerHighMidNITextbox.ReadOnly = true;
            CatDEmployerHighMidNITextbox.ReadOnly = true;
            CatEEmployerHighMidNITextbox.ReadOnly = true;
            CatFEmployerHighMidNITextbox.ReadOnly = true;
            CatHEmployerHighMidNITextbox.ReadOnly = true;
            CatIEmployerHighMidNITextbox.ReadOnly = true;
            CatJEmployerHighMidNITextbox.ReadOnly = true;
            CatKEmployerHighMidNITextbox.ReadOnly = true;
            CatLEmployerHighMidNITextbox.ReadOnly = true;
            CatMEmployerHighMidNITextbox.ReadOnly = true;
            CatNEmployerHighMidNITextbox.ReadOnly = true;
            CatSEmployerHighMidNITextbox.ReadOnly = true;
            CatVEmployerHighMidNITextbox.ReadOnly = true;
            CatZEmployerHighMidNITextbox.ReadOnly = true;

            CatAEmployerHighNITextbox.ReadOnly = true;
            CatBEmployerHighNITextbox.ReadOnly = true;
            CatCEmployerHighNITextbox.ReadOnly = true;
            CatDEmployerHighNITextbox.ReadOnly = true;
            CatEEmployerHighNITextbox.ReadOnly = true;
            CatFEmployerHighNITextbox.ReadOnly = true;
            CatHEmployerHighNITextbox.ReadOnly = true;
            CatIEmployerHighNITextbox.ReadOnly = true;
            CatJEmployerHighNITextbox.ReadOnly = true;
            CatKEmployerHighNITextbox.ReadOnly = true;
            CatLEmployerHighNITextbox.ReadOnly = true;
            CatMEmployerHighNITextbox.ReadOnly = true;
            CatNEmployerHighNITextbox.ReadOnly = true;
            CatSEmployerHighNITextbox.ReadOnly = true;
            CatVEmployerHighNITextbox.ReadOnly = true;
            CatZEmployerHighNITextbox.ReadOnly = true;
        }
    }
}    

   

