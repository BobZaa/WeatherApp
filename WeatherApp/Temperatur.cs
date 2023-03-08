using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WeatherApp
{
    internal class Temperatur
    {
        static public void Weekdays()
        {
            int ans = 0;
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine("What temperature is it " + weekdays[i] + "?");
               try
                {
                    ans += Convert.ToInt32(Console.ReadLine());
                    
                } 

                catch
                {
                    i--;
                    Console.WriteLine("Please enter a number.");
                    
                }
                
              
                
            }
            Console.WriteLine(ans/7);
        }
    }
}
