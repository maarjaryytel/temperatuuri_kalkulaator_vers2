using System;

namespace temperatuuri_kalkulaator_vers2
{
	class Program
	{
		static void Main(string[] args)
		{
			string userAnswer;
			Console.WriteLine("Do You want to use the Fahrenheit or Celsius calculator? Make Your choice: ");
			userAnswer = Console.ReadLine();

			if (userAnswer.ToLower() == "fahrenheit")
			{
				fahren();
			}
			else if (userAnswer.ToLower() == "celsius")
			{
				celsius();
			}
			else
			{
				Console.WriteLine("You have to choose Fahrenheit or Celsius");
			}
			Console.ReadLine();
		}
		public static void fahren()
		{
			double celsius;
			Console.WriteLine("Enter Your temperature in Fahrenheit (°F): ");
			double fahren = Convert.ToDouble(Console.ReadLine());
			celsius = (fahren - 32) * 5 / 9;
			Console.WriteLine("The temperature in Celsius (°C) is: " + (Math.Round(celsius, 1)));
		}
		public static void celsius()
		{
			double fahren;
			Console.WriteLine("Enter Your temperature in Celsius (°C): ");
			double celsius = Convert.ToDouble(Console.ReadLine());
			fahren = (celsius * 9) / 5 + 32;
			Console.WriteLine("The temperature in Fahrenheit (°F) is: " + (Math.Round(fahren, 1)));
		}
	}
}

