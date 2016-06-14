using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This week's forecast is:");
            DaysEnumExample days = new DaysEnumExample();
            string[] weekdays = days.ShowDays();
            WeatherEnumExample forecast = new WeatherEnumExample();
            //forecast.Forecast();
           
            for (int i = 0; i < 7; i++)
            {       
                Console.WriteLine("{0}: {1}", weekdays[i], forecast.Forecast());
                System.Threading.Thread.Sleep(5);
            }
                    
            Console.ReadKey();
        }
    }
}
