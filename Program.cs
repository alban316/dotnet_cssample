using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Hi Temps for Sydney, AU */
            Dictionary<DateTime, double> hi_temp = new Dictionary<DateTime, double>{
                {DateTime.Parse("6/23/16"), 19d},
                {DateTime.Parse("6/24/16"), 17d},
                {DateTime.Parse("6/25/16"), 14d},
                {DateTime.Parse("6/26/16"), 15d},
                {DateTime.Parse("6/27/16"), 11d},
                {DateTime.Parse("6/28/16"), 15d},
                {DateTime.Parse("6/29/16"), 18d}
            };

            double daytemp = hi_temp.Where(t => t.Key == DateTime.Parse("6/25/16")).FirstOrDefault().Value;

            Console.WriteLine(daytemp);
        }
    }
}
