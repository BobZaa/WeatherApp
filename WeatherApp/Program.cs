namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GO GO GO GO!!!! RUN!
            string[] days = Temperature.GetWeekDays();
            int[] temperatures = Temperature.AskUserForTemperaturesEachDay(days);
            int averageTemperature = Temperature.CalculateAverageOfTemperatures(temperatures);
            Console.WriteLine("The average temperature was: " + averageTemperature);
        }
    }
}