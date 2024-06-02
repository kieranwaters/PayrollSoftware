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
using Aspose.Pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static PayrollUI.AddEmployee;


namespace PayrollUI
{
    public partial class AddEmployee : Form
    {
        private string connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";
        private double lowerBoundLowerRateEmployeeNIContributions;
        private double monthlyPay;

        public double PersonalAllowanceLowerThreshold { get; private set; }
        public double PersonalAllowanceUpperThreshold { get; private set; }
        public double BasicRateLowerThreshold { get; private set; }
        public double BasicRateUpperThreshold { get; private set; }
        public double AdditionalRateUpperThreshold { get; private set; }
        public double HigherRateLowerThreshold { get; private set; }
        public double HigherRateUpperThreshold { get; private set; }
        public double AdditionalRateLowerThreshold { get; private set; }
        public double PersonalAllowanceTaxRateBox { get; private set; }
        public double BasicRateTaxRateBox { get; private set; }
        public double HigherRateTaxRateBox { get; private set; }
        public double AdditionalRateTaxRateBox { get; private set; }
        public double TotalEmployeePensionContribution { get; private set; }
        public double MinimumPensionEmployeeContributionRate { get; set; }

        public double LowerBoundLowerRateEmployeeNIContributions { get; set; }
        public double UpperBoundLowerRateEmployeeNIContributions { get; set; }
        public double LowerBoundMiddleRateEmployeeNIContributions { get; set; }
        public double UpperBoundMiddleRateEmployeeNIContributions { get; set; }
        public double HigherThresholdRateEmployeeNIContributions { get; set; }
        public static double CatAEmployeeLowNITextbox { get; set; }
        public static double CatAEmployeeMidNITextbox { get; set; }
        public static double CatAEmployeeHighNITextbox { get; set; }
        public static double CatBEmployeeLowNITextbox { get; set; }
        public static double CatBEmployeeMidNITextbox { get; set; }
        public static double CatBEmployeeHighNITextbox { get; set; }
        public static double CatCEmployeeLowNITextbox { get; set; }
        public static double CatCEmployeeMidNITextbox { get; set; }
        public static double CatCEmployeeHighNITextbox { get; set; }
        public static double CatDEmployeeLowNITextbox { get; set; }
        public static double CatDEmployeeMidNITextbox { get; set; }
        public static double CatDEmployeeHighNITextbox { get; set; }
        public static double CatEEmployeeLowNITextbox { get; set; }
        public static double CatEEmployeeMidNITextbox { get; set; }
        public static double CatEEmployeeHighNITextbox { get; set; }
        public static double CatFEmployeeLowNITextbox { get; set; }
        public static double CatFEmployeeMidNITextbox { get; set; }
        public static double CatFEmployeeHighNITextbox { get; set; }
        public static double CatHEmployeeLowNITextbox { get; set; }
        public static double CatHEmployeeMidNITextbox { get; set; }
        public static double CatHEmployeeHighNITextbox { get; set; }
        public static double CatIEmployeeLowNITextbox { get; set; }
        public static double CatIEmployeeMidNITextbox { get; set; }
        public static double CatIEmployeeHighNITextbox { get; set; }
        public static double CatJEmployeeLowNITextbox { get; set; }
        public static double CatJEmployeeMidNITextbox { get; set; }
        public static double CatJEmployeeHighNITextbox { get; set; }
        public static double CatKEmployeeLowNITextbox { get; set; }
        public static double CatKEmployeeMidNITextbox { get; set; }
        public static double CatKEmployeeHighNITextbox { get; set; }
        public static double CatLEmployeeLowNITextbox { get; set; }
        public static double CatLEmployeeMidNITextbox { get; set; }
        public static double CatLEmployeeHighNITextbox { get; set; }
        public static double CatMEmployeeLowNITextbox { get; set; }
        public static double CatMEmployeeMidNITextbox { get; set; }
        public static double CatMEmployeeHighNITextbox { get; set; }
        public static double CatNEmployeeLowNITextbox { get; set; }
        public static double CatNEmployeeMidNITextbox { get; set; }
        public static double CatNEmployeeHighNITextbox { get; set; }
        public static double CatSEmployeeLowNITextbox { get; set; }
        public static double CatSEmployeeMidNITextbox { get; set; }
        public static double CatSEmployeeHighNITextbox { get; set; }
        public static double CatVEmployeeLowNITextbox { get; set; }
        public static double CatVEmployeeMidNITextbox { get; set; }
        public static double CatVEmployeeHighNITextbox { get; set; }
        public static double CatZEmployeeLowNITextbox { get; set; }
        public static double CatZEmployeeMidNITextbox { get; set; }
        public static double CatZEmployeeHighNITextbox { get; set; }
        public string MinimumPensionEmployeeContributionRate_ { get; private set; }

        public AddEmployee()
        {
            InitializeComponent();
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            MonthlyPayBox1.TextChanged += MonthlyPayBox1_TextChanged;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDepartmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void EmployerPensionContributionLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePensionContribution_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeIncomeTax_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EmployerNationalInsuranceLabel_Click(object sender, EventArgs e)
        {

        }

        private void NINumber_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeSubmitButton_Click(object sender, EventArgs e) { }
        public class EmployeeDataLayer // Class to handle database interactions
        {
            public static void AddEmployeeToDatabase(string connectionString, Employee employee) { }
        }

        public partial class AddEmployeeData : Form // Replace 'YourFormName' with your actual form class name
        {
            private string connectionString;

            private string GetTextBoxValue(System.Windows.Forms.TextBox textBox)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return null; // Handle empty textbox values (optional)
                }
                return textBox.Text.Trim();
            }

            private void AddEmployeeSubmitButton_Click(object sender, EventArgs e)
            {
                ;
                AddEmployee newEmployeeData = new AddEmployee();
                // Get data from textboxes with error handling (replace textbox names with your actual names)
                string employeeName = newEmployeeData.EmployeeNameBox1.Text;
                string employeeJob = newEmployeeData.EmployeeJobBox1.Text;
                string managerName = newEmployeeData.ManagerNameBox1.Text;
                double monthlyPay;
                if (!double.TryParse(newEmployeeData.MonthlyPayBox1.Text, out monthlyPay))
                {
                    MessageBox.Show("Invalid monthly pay format. Please enter a number.");
                    return;
                }
                string department = newEmployeeData.TeamBox1.Text;
                string nationalInsuranceNumber = newEmployeeData.NationalInsuranceNumberBox1.Text;
                double employeeEmployerNI;
                if (!double.TryParse(newEmployeeData.EmployerNationalInsuranceTextbox.Text, out employeeEmployerNI))
                {
                    MessageBox.Show("Invalid tax contribution format. Please enter a financial value");
                    return;
                }
                double employeePAYENI;
                if (!double.TryParse(newEmployeeData.EmployeeNationalInsuranceTextbox.Text, out employeePAYENI))
                {
                    MessageBox.Show("Invalid tax contribution format. Please enter a financial value");
                    return;
                }
                double employeePAYEIncomeTax;
                if (!double.TryParse(newEmployeeData.EmployeeIncomeTax1.Text, out employeePAYEIncomeTax))
                {
                    MessageBox.Show("Invalid tax contribution format. Please enter a financial value");
                    return;
                }
                double employeePensionContribution;
                if (!double.TryParse(newEmployeeData.EmployeePensionContributionTextbox.Text, out employeePensionContribution))
                {
                    MessageBox.Show("Invalid pension contribution format. Please enter a financial value");
                    return;
                }
                double employerPensionContribution;
                if (!double.TryParse(newEmployeeData.EmployerPensionContributionTextbox.Text, out employerPensionContribution))
                {
                    MessageBox.Show("Invalid pension contribution format. Please enter a financial value");
                    return;
                }
                // Create Employee object
                Employee newEmployee = new Employee(
                    employeeName, employeeJob, managerName, monthlyPay, department, nationalInsuranceNumber,
                    employeeEmployerNI, employeePAYENI, employeePAYEIncomeTax, employeePensionContribution,
                    employerPensionContribution);

                try
                {
                    EmployeeDataLayer.AddEmployeeToDatabase(connectionString, newEmployee); // Call static method in EmployeeDataLayer class
                    MessageBox.Show("Employee added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message);
                }
            }
        }

        private void EmployeeMonthlyPayLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeJobLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeNameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeJobBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NationalInsuranceNumberBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployerNationalInsuranceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagerNameBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void TeamBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalculateIncomeTax_Load(object sender, EventArgs e)
        {
            CalculateEmployeeIncomeTax(); // Call a separate function
        }

        private void CalculateEmployeeIncomeTax()
        {
            this.Load += CalculateIncomeTax_Load;
        }

        private void EmployeeNationalInsuranceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public partial class CalculateIncomeTaxForm : Form
        {
            private double PersonalAllowanceUpperThreshold;
            private double PersonalAllowanceTaxRateBox;
            private double BasicRateLowerThreshold;
            private double BasicRateUpperThreshold;
            private double BasicRateTaxRateBox;
            private double HigherRateLowerThreshold;
            private double HigherRateUpperThreshold;
            private double HigherRateTaxRateBox;
            private double AdditionalRateLowerThreshold;
            private double AdditionalRateUpperThreshold;
            private double AdditionalRateTaxRateBox;
            private double MonthlyPayBox1;
            public object EmployeeIncomeTax { get; private set; }

            private void CalculateEmployeeNationalInsurance_Load(object sender, EventArgs e)//May need removing
            {
                CalculateEmployeeNationalInsurance(); // Call a separate function
            }

            private void CalculateEmployeeNationalInsurance()//May need removing
            {
                this.Load += CalculateEmployeeNationalInsurance_Load;
            }


        }

        private void EmployeePensionContributionTextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void EmployerPensionContributionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthlyPayBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                monthlyPay = double.Parse(MonthlyPayBox1.Text);
                {

                    string NICategory1 = NICategory.SelectedItem?.ToString();
                    if (NICategory1 == null)
                    {
                        MessageBox.Show("Please select a NIC category.");
                        return;
                    }
                    ChangeTaxRatesAndPensionContributions formInstance = new ChangeTaxRatesAndPensionContributions();
                    string textValue = formInstance.MinimumPensionEmployeeContributionRate_.Text;

                    if (!double.TryParse(textValue, out double employeePensionContributionPercentage))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.1");
                        return;
                    }
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.PersonalAllowanceUpperThreshold_.Text, out double personalAllowanceUpperThreshold))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.2");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.BasicRateLowerThreshold_.Text, out double basicRateLowerThreshold)) ;
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.BasicRateUpperThreshold_.Text, out double basicRateUpperThreshold)){
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.3");
                        return;
                    } ;
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.HigherRateLowerThreshold_.Text, out double higherRateLowerThreshold))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.4");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.HigherRateUpperThreshold_.Text, out double higherRateUpperThreshold))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.5");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.AdditionalRateLowerThreshold_.Text, out double additionalRateLowerThreshold))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.6");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.AdditionalRateUpperThreshold_.Text, out double additionalRateUpperThreshold))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.7");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.PersonalAllowanceTaxRateBox_.Text, out double personalAllowanceTaxRate))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.8");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.BasicRateTaxRateBox_.Text, out double basicRateTaxRate))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.9");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.HigherRateTaxRateBox_.Text, out double higherRateTaxRate))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.10");
                        return;
                    };
                    if (!double.TryParse(ChangeTaxRatesAndPensionContributions.TaxAndPensionRates.AdditionalRateTaxRateBox_.Text, out double additionalRateTaxRate))
                    {
                        MessageBox.Show("Invalid input format. Please enter valid numbers for all fields.11");
                        return;
                    };
                    
                    double totalEmployeePensionContribution = CalculateEmployeePensionContribution(monthlyPay, employeePensionContributionPercentage);
                    double totalIncomeTax = CalculateIncomeTax(monthlyPay, personalAllowanceUpperThreshold, personalAllowanceTaxRate, basicRateLowerThreshold, basicRateUpperThreshold, basicRateTaxRate, higherRateLowerThreshold, higherRateUpperThreshold, higherRateTaxRate, additionalRateLowerThreshold, additionalRateUpperThreshold, additionalRateTaxRate);
                    double totalEmployeeNationalInsuranceContribution = CalculateEmployeeNationalInsurance(NICategory1, monthlyPay);

                    EmployeePensionContributionTextbox.Text = totalEmployeePensionContribution.ToString("C2"); // Format as currency with 2 decimal places
                    EmployeeIncomeTax1.Text = totalIncomeTax.ToString("C2");
                    EmployeeNationalInsuranceTextbox.Text = totalEmployeeNationalInsuranceContribution.ToString("C2");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numbers for monthly pay.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void EmployeeIncomeTax1_TextChanged(object sender, EventArgs e)

        {
            try
            {
                TaxAndPensionRates calculator = new TaxAndPensionRates();
                double result1 = calculator.CalculateIncomeTax(monthlyPay,
                                                              PersonalAllowanceUpperThreshold,
                                                              PersonalAllowanceTaxRateBox,
                                                              BasicRateLowerThreshold,
                                                              BasicRateUpperThreshold,
                                                              BasicRateTaxRateBox,
                                                              HigherRateLowerThreshold,
                                                              HigherRateUpperThreshold,
                                                              HigherRateTaxRateBox,
                                                              AdditionalRateLowerThreshold,
                                                              AdditionalRateUpperThreshold,
                                                              AdditionalRateTaxRateBox);

                string EmployeeIncomeTax = result1.ToString("F2");
                Console.WriteLine(EmployeeIncomeTax);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private double CalculateEmployeePensionContribution(double monthlyPay, double employeePensionContributionPercentage)
        {
            return monthlyPay * (employeePensionContributionPercentage / 100);
        }

        private double CalculateIncomeTax(double monthlyPay,
                                                   double personalAllowanceUpperThreshold,
                                                   double personalAllowanceTaxRate,
                                                   double basicRateLowerThreshold,
                                                   double basicRateUpperThreshold,
                                                   double basicRateTaxRate,
                                                   double higherRateLowerThreshold,
                                                   double higherRateUpperThreshold,
                                                   double higherRateTaxRate,
                                                   double additionalRateLowerThreshold,
                                                   double additionalRateUpperThreshold,
                                                   double additionalRateTaxRate)
        {
            double annualPay = monthlyPay * 12;
            double totalIncomeTax = 0;

            // Calculate the tax based on thresholds and rates
            if (annualPay <= personalAllowanceUpperThreshold)
            {
                totalIncomeTax = 0;
            }
            else if (annualPay > basicRateLowerThreshold)
            {
                double taxableAmount = Math.Min(annualPay, basicRateUpperThreshold) - basicRateLowerThreshold;
                totalIncomeTax += taxableAmount * basicRateTaxRate / 100;
            }

            if (annualPay > higherRateLowerThreshold)
            {
                double taxableAmount = Math.Min(annualPay, higherRateUpperThreshold) - higherRateLowerThreshold;
                totalIncomeTax += taxableAmount * higherRateTaxRate / 100;
            }

            if (annualPay > additionalRateLowerThreshold)
            {
                double taxableAmount = annualPay - additionalRateLowerThreshold;
                totalIncomeTax += taxableAmount * additionalRateTaxRate / 100;
            }

            return totalIncomeTax;
        }

        public double CalculateEmployeeNationalInsurance(string NICategory, double monthlyPay)
        {
            var niCategoryMap = new Dictionary<string, (double low, double mid, double high)>
            {
        { "A", (CatAEmployeeLowNITextbox, CatAEmployeeMidNITextbox, CatAEmployeeHighNITextbox) },
        { "B", (CatBEmployeeLowNITextbox, CatBEmployeeMidNITextbox, CatBEmployeeHighNITextbox) },
        { "C", (CatCEmployeeLowNITextbox, CatCEmployeeMidNITextbox, CatCEmployeeHighNITextbox) },
        { "D", (CatDEmployeeLowNITextbox, CatDEmployeeMidNITextbox, CatDEmployeeHighNITextbox) },
        { "E", (CatEEmployeeLowNITextbox, CatEEmployeeMidNITextbox, CatEEmployeeHighNITextbox) },
        { "F", (CatFEmployeeLowNITextbox, CatFEmployeeMidNITextbox, CatFEmployeeHighNITextbox) },
        { "H", (CatHEmployeeLowNITextbox, CatHEmployeeMidNITextbox, CatHEmployeeHighNITextbox) },
        { "I", (CatIEmployeeLowNITextbox, CatIEmployeeMidNITextbox, CatIEmployeeHighNITextbox) },
        { "J", (CatJEmployeeLowNITextbox, CatJEmployeeMidNITextbox, CatJEmployeeHighNITextbox) },
        { "K", (CatKEmployeeLowNITextbox, CatKEmployeeMidNITextbox, CatKEmployeeHighNITextbox) },
        { "L", (CatLEmployeeLowNITextbox, CatLEmployeeMidNITextbox, CatLEmployeeHighNITextbox) },
        { "M", (CatMEmployeeLowNITextbox, CatMEmployeeMidNITextbox, CatMEmployeeHighNITextbox) },
        { "N", (CatNEmployeeLowNITextbox, CatNEmployeeMidNITextbox, CatNEmployeeHighNITextbox) },
        { "S", (CatSEmployeeLowNITextbox, CatSEmployeeMidNITextbox, CatSEmployeeHighNITextbox) },
        { "V", (CatVEmployeeLowNITextbox, CatVEmployeeMidNITextbox, CatVEmployeeHighNITextbox) },
        { "Z", (CatZEmployeeLowNITextbox, CatZEmployeeMidNITextbox, CatZEmployeeHighNITextbox) }
            };

            if (!niCategoryMap.TryGetValue(NICategory, out var textBoxes))
            {
                throw new ArgumentException($"Invalid NICategory: {NICategory}");
            }

            double totalEmployeeNationalInsurance = 0;

            if (monthlyPay <= LowerBoundLowerRateEmployeeNIContributions)
            {
                return 0; // No contributions if pay is below the lower bound
            }

            if (monthlyPay > LowerBoundLowerRateEmployeeNIContributions)
            {
                double taxableAmount = Math.Min(monthlyPay, UpperBoundLowerRateEmployeeNIContributions) - LowerBoundLowerRateEmployeeNIContributions;
                totalEmployeeNationalInsurance += taxableAmount * textBoxes.low / 100;
            }

            if (monthlyPay > LowerBoundMiddleRateEmployeeNIContributions)
            {
                double taxableAmount = Math.Min(monthlyPay, UpperBoundMiddleRateEmployeeNIContributions) - LowerBoundMiddleRateEmployeeNIContributions;
                totalEmployeeNationalInsurance += taxableAmount * textBoxes.mid / 100;
            }

            if (monthlyPay > HigherThresholdRateEmployeeNIContributions)
            {
                double taxableAmount = monthlyPay - HigherThresholdRateEmployeeNIContributions;
                totalEmployeeNationalInsurance += taxableAmount * textBoxes.high / 100;
            }

            return totalEmployeeNationalInsurance;
        }

        private static void NICategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    } }
