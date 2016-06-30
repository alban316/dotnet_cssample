using System;
using System.Collections.Generic;
using System.Linq;

namespace Temps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Hi Temps for Sydney, AU */
            Dictionary<DateTime, double> hi_temp = new Dictionary<DateTime, double>{
                {DateTime.Parse("6/23/16"), 19d},
                {new DateTime(2016, 6, 24), 17d}, // a couple of ways to init a DateTime
                {DateTime.Parse("6/25/16"), 14d},
                {DateTime.Parse("6/26/16"), 15d},
                {DateTime.Parse("6/27/16"), 11d},
                {DateTime.Parse("6/28/16"), 15d},
                {DateTime.Parse("6/29/16"), 18d}
            };

            double daytemp = hi_temp.Where(t => t.Key == DateTime.Parse("6/25/16")).FirstOrDefault().Value;

            Console.WriteLine(daytemp);


            foreach(var temp in hi_temp)
            {
                Console.WriteLine("Hi temp (F) on {0} was {1}", temp.Key, Convert.ToFahrenheit(temp.Value));
            }
        }
    }
}
