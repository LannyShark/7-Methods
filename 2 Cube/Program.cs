using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int v, s;
            CalcVolSquare(a, out v, out s);
            Console.WriteLine("Объем: {0} \nПлощадь: {1}",v,s);
            Console.ReadKey();
        }
        static void CalcVolSquare(int a, out int v, out int s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
    }
}
