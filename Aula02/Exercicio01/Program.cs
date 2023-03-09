using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //2147483647 valor máximo suportado pelo tipo int
            int b = 0; //-2147483648 valor minímo suportado pelo tipo int
            int c = 1;
            //Console.WriteLine(a / b);
            Console.WriteLine("Máximo valor possivel: " + a);
            Console.WriteLine("Overflow: " + (a + 2)); // overflow -2147483648 +2
            Console.WriteLine("Minimo valor possivel: " + b);
            Console.WriteLine("Underflow: " + (b - 2)); // underflow 2147483647

            Console.WriteLine(double.MaxValue * c); // overflow: infinity (8)
            Console.WriteLine(double.MinValue * c); // overflow: -infinity (-8)
            Console.WriteLine(double.Epsilon / c); // underflow: 0.0
            Console.WriteLine(b/a);

            Console.ReadKey();
        }
    }
}
