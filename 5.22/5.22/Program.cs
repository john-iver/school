using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._22
{
	class Program
	{
		static void Main(string[] args)
		{
			int mpg = 0;
			float totalMpg = 0;
			Console.WriteLine("Welcome to Gas Tracker.\n");
			//tanks of gas
			Console.Write("How many tanks of gas are you entering? ");
			int gas = int.Parse(Console.ReadLine());
			Console.WriteLine();

			while (gas > 0) 
			{
				//miles driven
				Console.Write("How far did you drive? ");
				int miles = int.Parse(Console.ReadLine());
				Console.WriteLine();

				//Gallons used
				Console.Write("How many gallons of gas did you use? ");
				int gallons = int.Parse(Console.ReadLine());
				Console.WriteLine();

				//mpg for single tank
				mpg += (miles / gallons);
				

				if (gas > 1)
				{ 
					Console.Write("Please enter the next tank. \n");
					Console.WriteLine();
				
				}
				totalMpg = (mpg / gas);
				if (gas == 1)
				{
					//total mpg for all tanks
					// figure out avarage of all tanks entered so far
					 
					Console.WriteLine("Your total gas milage so far is " + totalMpg);
					Console.WriteLine();
				}
				gas--;

			}

		}
	}
}
