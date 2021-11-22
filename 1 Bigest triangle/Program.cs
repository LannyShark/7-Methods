using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Bigest_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            double c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника");
            double a2 = Convert.ToInt32(Console.ReadLine());
            double b2 = Convert.ToInt32(Console.ReadLine());
            double c2 = Convert.ToInt32(Console.ReadLine());
            if (CalcSquare(a1, b1, c1) > CalcSquare(a2, b2, c2))
                Console.WriteLine("Площадь первого треуголника больше и равна {0:F2}", CalcSquare(a1, b1, c1));
            else if (CalcSquare(a1, b1, c1) < CalcSquare(a2, b2, c2))
                Console.WriteLine("Площадь второго треуголника больше и равна {0:F2}", CalcSquare(a2, b2, c2));
            else
                Console.WriteLine("Площадь треуголников одинаковая и равна {0:F2}", CalcSquare(a1, b1, c1));
            Console.ReadKey();
        }
        static double CalcSquare(double a, double b, double c)
        {
            double s = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
            return s;
        }
    }
}
