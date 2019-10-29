using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bitwise_Functions.BitwiseUtil;

namespace Bitwise_Functions
{
    class Program
    {
        static void Main(string[] args)         // All of this just works.
        {
            Console.WriteLine(SHIFT('r', 64, 3));
            Console.WriteLine(XOR(11111, 10000));
            Console.WriteLine(OR(11111, 10000));
            Console.WriteLine(AND(11111, 10000));
            Console.WriteLine(COMPLEMENT(10101));
            Console.Read();

        }
    }
}
