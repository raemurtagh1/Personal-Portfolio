using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Console_App;

namespace Personal_Console_App
{
	internal class Program
	{
		internal static void MenuTitle()
		{
			Console.Clear();
			Console.WriteLine("**************** Enter number of program to view ****************");
			Console.WriteLine("");
		}
		internal static void ProgramIsFinished()
		{
			Console.WriteLine("\r\n\r\n");
			Console.WriteLine("Done. Hit enter to select another option from menu.");
			Console.ReadLine();
			Console.Clear();
		}

		static void Main(string[] args)
		{
			string mainmenuresponse = "";

			// MENU
			while (mainmenuresponse != "Q")
			{
				MenuTitle();

				Console.WriteLine("1. Personal Programs");

				Console.WriteLine("\r\n\r\nQ. Quit\r\n\r\n");

				mainmenuresponse = Console.ReadLine();

				Console.Clear();

				switch (mainmenuresponse)
				{
					case "1": PersonalProgramsMenu(); break;
					case "q": Environment.Exit(0); break;
					case "Q": Environment.Exit(0); break;
				}
			}
		}

		internal static void PersonalProgramsMenu()
		{
			string personalmenuresponse = "";

			// MENU
			while (personalmenuresponse != "Q")
			{
				MenuTitle();

				Console.WriteLine("1. Net Salary, NI and Tax Calculator from Gross Salary input");

				Console.WriteLine("\r\n\r\nQ. Back to Main Menu\r\n\r\n");

				personalmenuresponse = Console.ReadLine();

				Console.Clear();

				switch (personalmenuresponse)
				{
					case "1": PersonalPrograms.CalculatorFromGrossSalary(); break;
					case "q":
					case "Q":
						return;
				}

				ProgramIsFinished();
			}
		}

	}
}
