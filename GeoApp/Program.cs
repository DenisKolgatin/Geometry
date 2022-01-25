using System;
using GeoLib;

namespace GeoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Будем считать площадь круга или треугольника? (введите цифру)");
            Console.WriteLine("1. Круга");
            Console.WriteLine("2. Треугольника");
            int f = Int32.Parse(Console.ReadLine()); //Получаем цифру для определения фигуры
            if (f == 1) //Вычисление площади круга
            {
                Console.Clear();
                Console.WriteLine("Введите радиус");
                double r = Double.Parse(Console.ReadLine());
                if (r>0) //проработка исключений
                {
                    double s1 = GeoLib.GeoLibClass.Circle(r);
                    Console.WriteLine("Площадь круга " + s1);
                    Console.ReadLine();
                } else
                {
                    Console.WriteLine("Радиус должен быть больше 0 ");
                }
            }
            else if (f == 2) //Вычисление площади треугольника
            {
                Console.Clear();
                Console.WriteLine("Введите первую сторону");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третью сторону");
                double c = Double.Parse(Console.ReadLine());

                if (a > 0 && b > 0 &&  c > 0) //проработка исключений
                {
                    int i = GeoLib.GeoLibClass.Pifagor(a, b, c);
                    double s2 = GeoLib.GeoLibClass.Triangle(a, b, c);
                    String Pifagor;
                    if (i == 1)
                        Pifagor = "Треугольник не прямоугольный";
                    else if (i == 2)
                        Pifagor = "Треугольник прямоугольный";
                    else Pifagor = "Треугольник невозможен";
                    Console.WriteLine("Площадь треугольника " + s2 + " " + Pifagor);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Стороны треугольника не могут быть меньше 0");
                }

                

            }
            else Console.WriteLine("Вы ввели неверный символ");
        }
    }
}
