using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Linq
{
    internal static class IntExtesntion
    {
        // Extesnion Method

        public static int Reverse(this int x)
        {
            int ReverseNumber = 0, newR;
            while (x > 0)
            {
                newR = x % 10;
                ReverseNumber = (ReverseNumber * 10) + newR;
                x /= 10;
            }

            return ReverseNumber;

        }
        ////////public static int Reverse(this int x)
        ////////{
        ////////    int ReverseNumber = 0, newR;
        ////////    while (x > 0)
        ////////    {
        ////////        newR = x % 10;
        ////////        ReverseNumber = (ReverseNumber * 10) + newR;
        ////////        x /= 10;
        ////////    }

        ////////    return ReverseNumber;

        ////////}
        ////////public static long Reverse(this long x)
        ////////{
        ////////    long ReverseNumber = 0, newR;
        ////////    while (x > 0)
        ////////    {
        ////////        newR = x % 10;
        ////////        ReverseNumber = (ReverseNumber * 10) + newR;
        ////////        x /= 10;
        ////////    }
        ////////    return ReverseNumber;
        ////////}
        ////////public static double Reverse(this double x)
        ////////{
        ////////    double ReverseNumber = 0, newR;
        ////////    while (x > 0)
        ////////    {
        ////////        newR = x % 10;
        ////////        ReverseNumber = (ReverseNumber * 10) + newR;
        ////////        x /= 10;
        ////////    }

        ////////    return ReverseNumber;

        ////////}
    }
}
