using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal static class Temperature
    {
        // Get all week days
        public static string[] GetWeekDays()
        {
            return new string[]
            { 
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        }

        // Ask the user what temperature it was a day
        private static int _askUserForTemperatureOfADay(string day)
        {
            while (true)
            {
                try
                {
                    // Let the user give input, which is parsed as string
                    // This string is then converted to an integer
                    Console.Write($"What temperature was it this {day}? ");
                    string temperatureRaw = Console.ReadLine();
                    int temperature = Convert.ToInt32(temperatureRaw);
                    return temperature;
                }
                // If the program catches an error, ask the user for new input
                // This prevents side effects
                catch
                {
                    Console.WriteLine("That was an invalid input! Please, try again.");
                    continue;
                }
            }
        }

        // Ask the user what the temperature was for an amount of days
        public static int[] AskUserForTemperaturesEachDay(string[] days)
        {
            return days.Select(day => _askUserForTemperatureOfADay(day)).ToArray();
        }

        // Calculates the average temperature of an amount of days
        public static int CalculateAverageOfTemperatures(int[] temperatures)
        {
            int sumOfAllTemperatures = temperatures.Sum();
            int average = sumOfAllTemperatures / temperatures.Length;
            return average;
        }
    }
}
