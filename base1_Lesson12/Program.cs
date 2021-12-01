using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write(" Введите радиус (целое число > 0) R= ");
                uint radius = Convert.ToUInt32(Console.ReadLine());
                Console.Write(" Введите координаты точки (целое число). x1= ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Введите координаты точки (целое число). y1= ");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ---Результаты расчета---");
                CircleCalc.TolenghtCircle(radius);
                CircleCalc.ToSquareCircle(radius);
                CircleCalc.ToinsideCircle(radius, x1, y1);
                Console.ReadKey();
        }
    }
    public class CircleCalc // Класс работы с окружностью
    {
        // Поля
        public static uint radius;
        public static int x1;
        public static int y1;
        public static double lengthCircle;
        public static double squareCircle;
        public static double lineLength;
        internal const int x0 = 0;
        internal const int y0 = 0;
        public static bool flag = true;
        public static uint Radius { get; set; }
        public static int X1 { get; set; }
        public static int Y1 { get; set; }
        // Свойства 3 шт
        static CircleCalc () // Конструктор
        {
            Radius = radius;
            X1 = x1;
            Y1 = y1;
        }
        public static void TolenghtCircle(uint radius) // Метод в радианы
        {
                lengthCircle = 2 * Math.PI * radius;
                Console.WriteLine(" Длина окружности L= {0:f3}", lengthCircle);
        }
        public static void ToSquareCircle(uint radius) // Метод в радианы
        {
                squareCircle = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine(" Длина окружности L= {0:f3}", squareCircle);
        }
        public static void ToinsideCircle(uint radius, int x1, int y1) // Метод в радианы
        {
                lineLength = Math.Sqrt(Math.Pow((Math.Abs(x1 - x0)), 2) + Math.Pow(Math.Abs(y1 - y0), 2));
                if (lineLength <= radius)
                {
                    Console.WriteLine(" Введенная точка {0}, {1} принадлежит кругу радиусом {2}!", x1, y1, radius);
                }
                else
                {
                    Console.WriteLine(" Введенная точка {0}, {1} не принадлежит кругу радиусом {2}!", x1, y1, radius);
                }
        }
    }
}