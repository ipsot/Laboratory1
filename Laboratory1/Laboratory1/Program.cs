using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double x, y=0, a, b, p;
            double ctg;
            Console.WriteLine("Введите шаг");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите промежуток");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            x = a;
            ctg = 1 / Math.Tan(4*x);
            do
            {
                if (Math.Abs(x) < 2)
                {
                    y = Math.Pow(ctg, 2);
                }
                else if(Math.Abs(x)>=2)
                {
                    y = Math.Exp(2 * x);
                }
                Console.WriteLine($"x={x};f(x)={y}");
                x += p;

            } while (x <= b + p) ;

            Console.ReadKey();
        }
    }
}
