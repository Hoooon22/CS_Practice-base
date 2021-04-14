using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountrate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) = > 0.05,
                _ => 0,
            };
        }

        static void Main(string[] args)
        {
        }
    }
}
