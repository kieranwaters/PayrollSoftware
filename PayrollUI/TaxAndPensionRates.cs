using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Amazon.Runtime.Internal;
using PayrollUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
public class TaxAndPensionRates
{
    public double PAYEIncomeTaxRate;
    public double EmployerNationalInsuranceContribution;
    public double PAYENIRate;
    public double EmployerPensionContribution;
    public double EmployeePensionContribution;
    public double MinimumPensionEmployeeContributionRate;

    public double CalculateIncomeTax(double monthlyPay,
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

        if (personalAllowanceUpperThreshold < 0 ||
                    personalAllowanceTaxRate < 0 ||
                    basicRateLowerThreshold < 0 ||
                    basicRateUpperThreshold < 0 ||
                    basicRateTaxRate < 0 ||
                    higherRateLowerThreshold < 0 ||
                    higherRateUpperThreshold < 0 ||
                    higherRateTaxRate < 0 ||
                    additionalRateLowerThreshold < 0 ||
                    additionalRateUpperThreshold < 0 ||
                    additionalRateTaxRate < 0)
        {
            throw new ArgumentOutOfRangeException("Tax thresholds and rates cannot be negative.");
        }

        double annualPay = monthlyPay * 12;
        double totalIncomeTax = 0;

        if (annualPay <= personalAllowanceUpperThreshold)
        {
            // No tax up to personal allowance threshold
            totalIncomeTax = 0;
        }


        // Basic Rate
        if (annualPay > basicRateLowerThreshold)
        {
            double taxableAmount = Math.Min(annualPay, basicRateUpperThreshold) - basicRateLowerThreshold;
            totalIncomeTax += taxableAmount * basicRateTaxRate / 100;

        }

        // Higher Rate
        if (annualPay > higherRateLowerThreshold)
        {
            double taxableAmount = Math.Min(annualPay, higherRateUpperThreshold) - higherRateLowerThreshold;
            totalIncomeTax += taxableAmount * higherRateTaxRate / 100;

        }

        // Additional Rate
        if (annualPay > additionalRateLowerThreshold)
        {
            double taxableAmount = annualPay - additionalRateLowerThreshold;
            totalIncomeTax += taxableAmount * additionalRateTaxRate / 100;
        }

        return totalIncomeTax;
    }

  

    public static object NICategory { get; private set; }

    public class EmployeeNationalInsuranceRates
    {

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
        public string NICategory_ { get; private set; }

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
    } 
    public static double CalculateEmployeePensionContribution(double monthlyPay, double MinimumPensionEmployeeContributionRate)
    {
        double EmployeePensionContribution = 0;
        EmployeePensionContribution = monthlyPay * MinimumPensionEmployeeContributionRate;
        return EmployeePensionContribution;
    }

    public class PensionRates
    {
        public double MonthlyPayBox1 { get; set; }
        public double MinimumPensionEmployeeContributionRate { get; set; }
        public double MaximumPensionEmployeeContributionRate { get; set; }
        public double MinimumPensionEmployerContributionRate { get; set; }
        public double MaximumPensionEmployerContributionRate { get; set; }

        public PensionRates(double monthlyPayBox1, double minimumPensionEmployeeContributionRate, double maximumPensionEmployeeContributionRates,
             double minimumPensionEmployerContributionRate, double maximumPensionEmployerContributionRate)

        {
            MonthlyPayBox1 = monthlyPayBox1;
            MinimumPensionEmployeeContributionRate = minimumPensionEmployeeContributionRate;
            MaximumPensionEmployeeContributionRate = maximumPensionEmployeeContributionRates;
            MinimumPensionEmployerContributionRate = minimumPensionEmployerContributionRate;
            MaximumPensionEmployerContributionRate = maximumPensionEmployerContributionRate;
        }
    }
    public class IncomeTaxRates
    {
        public double MonthlyPayBox1 { get; set; }
        public double PersonalAllowanceLowerThreshold { get; set; }
        public double PersonalAllowanceUpperThreshold { get; set; }
        public double BasicRateLowerThreshold { get; set; }
        public double BasicRateUpperThreshold { get; set; }
        public double HigherRateLowerThreshold { get; set; }
        public double HigherRateUpperThreshold { get; set; }
        public double AdditionalRateLowerThreshold { get; set; }
        public double AdditionalRateUpperThreshold { get; set; }
        public double PersonalAllowanceTaxRateBox { get; set; }
        public double BasicRateTaxRateBox { get; set; }
        public double HigherRateTaxRateBox { get; set; }
        public double AdditionalRateTaxRateBox { get; set; }



        public IncomeTaxRates(double monthlyPay, double personalAllowanceLowerThreshold, double personalAllowanceUpperThreshold,
                                 double basicRateLowerThreshold, double basicRateUpperThreshold,
                                 double higherRateLowerThreshold, double higherRateUpperThreshold,
                                 double additionalRateLowerThreshold, double additionalRateUpperThreshold,
                                 double personalAllowanceTaxRate, double basicRateTaxRate,
                                 double higherRateTaxRate, double additionalRateTaxRate)
        {
            // Assign arguments to properties
            MonthlyPayBox1 = monthlyPay;
            PersonalAllowanceLowerThreshold = personalAllowanceLowerThreshold;
            PersonalAllowanceUpperThreshold = personalAllowanceUpperThreshold;
            BasicRateLowerThreshold = basicRateLowerThreshold;
            BasicRateUpperThreshold = basicRateUpperThreshold;
            HigherRateLowerThreshold = higherRateLowerThreshold;
            HigherRateUpperThreshold = higherRateUpperThreshold;
            AdditionalRateLowerThreshold = additionalRateLowerThreshold;
            AdditionalRateUpperThreshold = additionalRateUpperThreshold;
            PersonalAllowanceTaxRateBox = personalAllowanceTaxRate;
            BasicRateTaxRateBox = basicRateTaxRate;
            HigherRateTaxRateBox = higherRateTaxRate;
            AdditionalRateTaxRateBox = additionalRateTaxRate;
        }
    }

    public class PensionContributionRates
    {
        public double MinimumPensionEmployeeContribution { get; set; }
        public double MaximumPensionEmployeeContribution { get; set; }
        public double MinimumPensionEmployerContribution { get; set; }
        public double MaximumPensionEmployerContribution { get; set; }

        public PensionContributionRates(double minimumPensionEmployeeContribution, double maximumPensionEmployeeContribution, double minimumPensionEmployerContribution, double maximumPensionEmployerContribution)
        {
            MinimumPensionEmployeeContribution = minimumPensionEmployeeContribution;
            MaximumPensionEmployeeContribution = maximumPensionEmployeeContribution;
            MinimumPensionEmployerContribution = minimumPensionEmployerContribution;
            MaximumPensionEmployerContribution = maximumPensionEmployerContribution;
        }
    }

   
}

