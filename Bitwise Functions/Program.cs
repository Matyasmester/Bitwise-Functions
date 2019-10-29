using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Functions
{
    class Program
    {
        static void Main(string[] args)         // All of this just works.
        {
            Console.WriteLine(BitwiseUtil.SHIFT('r', 64, 3));
            Console.WriteLine(BitwiseUtil.XOR(11111, 10000));
            Console.WriteLine(BitwiseUtil.OR(11111, 10000));
            Console.WriteLine(BitwiseUtil.AND(11111, 10000));
            Console.WriteLine(BitwiseUtil.COMPLEMENT(10101));
            Console.Read();

        }
    }
}
