using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Console_App
{
	internal class PersonalPrograms
	{
		internal static void CalculatorFromGrossSalary()
		{
			CultureInfo ukCulture = new CultureInfo("en-GB");

			// Prompt the user for their gross annual salary and parse the input
			Console.Write("Please enter your gross annual salary: ");
			decimal grossSalary = decimal.Parse(Console.ReadLine());

			// Calculate weekly salary and initialize National Insurance
			decimal weeklySalary = grossSalary / 52m;
			decimal nationalInsurance = 0m;

			// Calculate National Insurance based on weekly salary
			if (weeklySalary > 145m && weeklySalary <= 864m)
			{
				nationalInsurance = (weeklySalary - 145m) * 0.11m;
			}
			else if (weeklySalary > 864m)
			{
				nationalInsurance = (864m - 145m) * 0.11m + (weeklySalary - 864m) * 0.01m;
			}

			// Round to nearest penny and calculate annual and monthly National Insurance
			nationalInsurance = Math.Round(nationalInsurance, 2);
			decimal annualNationalInsurance = nationalInsurance * 52m;
			decimal monthlyNationalInsurance = Math.Round(annualNationalInsurance / 12m, 2);

			// Calculate personal allowance and adjust if gross salary is over 100,000
			decimal personalAllowance = 14500m;
			if (grossSalary > 100000m)
			{
				decimal excess = grossSalary - 100000m;
				personalAllowance = Math.Max(personalAllowance - (excess / 2m), 0m);
			}

			// Calculate taxable income and tax
			decimal taxableIncome = grossSalary - personalAllowance;
			decimal tax = 0m;
			if (taxableIncome > 0m)
			{
				if (taxableIncome <= 6500m)
				{
					tax = taxableIncome * 0.10m;
				}
				else
				{
					tax = 6500m * 0.10m + (taxableIncome - 6500m) * 0.22m;
				}
			}

			// Round to nearest penny and calculate annual and monthly tax
			tax = Math.Round(tax, 2);
			decimal annualTax = tax;
			decimal monthlyTax = Math.Round(annualTax / 12m, 2);

			// Calculate net salary and monthly values
			decimal netSalary = grossSalary - annualNationalInsurance - annualTax;
			decimal monthlyNetSalary = Math.Round(netSalary / 12m, 2);
			decimal monthlyGrossSalary = grossSalary / 12m;

			// Output results
			Console.WriteLine("\r\nResults: \r\n");

			Console.WriteLine("Monthly National Insurance: " + monthlyNationalInsurance.ToString("C", ukCulture));
			Console.WriteLine("Monthly Tax: " + monthlyTax.ToString("C", ukCulture));
			Console.WriteLine("\r");

			Console.WriteLine("Annual National Insurance: " + annualNationalInsurance.ToString("C", ukCulture));
			Console.WriteLine("Annual Tax: " + annualTax.ToString("C", ukCulture));
			Console.WriteLine("\r\n");

			Console.WriteLine("Monthly Net Salary: " + monthlyNetSalary.ToString("C", ukCulture));
			Console.WriteLine("Monthly Gross Salary: " + monthlyGrossSalary.ToString("C", ukCulture));
			Console.WriteLine("\r");

			Console.WriteLine("Annual Net Salary: " + netSalary.ToString("C", ukCulture));
			Console.WriteLine("Annual Gross Salary: " + grossSalary.ToString("C", ukCulture));
		}
	}
}
