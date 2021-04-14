using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int qoutient, out int remainder)
        {
            qoutient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
