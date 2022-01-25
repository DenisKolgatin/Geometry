using System;

namespace GeoLib
{
    public class GeoLibClass
    {
        public static double Circle(double Radius)
        {

                return 3.14 * Radius * Radius;

        }
        public static double Triangle(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c)); //вычисляем площадь
        }
        public static int Pifagor(double a, double b, double c)
        {

            //Найдем гипотенузу

            double max = a;
            double min1 = b;
            double min2 = c;
            if (b > max)
            {
                min1 = max;
                max = b;
            }
            if (c > max)
            {
                min2 = max;
                max = c;
            }

            //Проверим на прямоугольность

            int S = 1;
            double Pif = min1 * min1 + min2 * min2;
            if (Pif == max * max)
                S = 2;
            return S;
        }
    }
}
