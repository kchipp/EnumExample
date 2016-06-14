using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class DaysEnumExample
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

        public string[] ShowDays()
        {
            string[] day = Enum.GetNames(typeof(Days));
            return day;
            //foreach (string whatDay in day)
            //{
            //    Console.WriteLine(whatDay);
            //}
         
        }
    }
}
