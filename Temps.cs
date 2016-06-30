using System;


namespace Temps
{
    public static class Convert
    {
        public static double ToFahrenheit(double value_celsius)
        {
            return value_celsius * (9d / 5d) + 32;
        }

    }

}