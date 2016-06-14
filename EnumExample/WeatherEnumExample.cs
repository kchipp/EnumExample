using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnumExample
{
    public class WeatherEnumExample
    {
        enum Weather { Sunny, Cloudy, Thunderstorms, Showers, Hazy, Overcast};

        public string Forecast()
        {
            string[] weather = Enum.GetNames(typeof(Weather));
            Random random = new Random();
            string choice = weather[random.Next(0, 6)];
            return choice;
            //foreach (string thew in weather)
            //{
            //    Console.WriteLine(weather[random.Next(0, 7)]);
            //}



        }
        
    }
}
