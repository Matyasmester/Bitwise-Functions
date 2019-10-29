using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            void COMPLEMENT(uint value)
            {
                string result = "";
                uint[] valArray = ConvertToArray(value);
                for (int i = 0; i < valArray.Length; i++)
                {
                    if (valArray[i] == 1)
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "1";
                    }
                }
                Console.WriteLine(result);

            }

            void AND(uint x, uint y)
            {
                string result = "";
                uint[] xArray = ConvertToArray(x);
                uint[] yArray = ConvertToArray(y);
                for (int i = 0; i < xArray.Length; i++)
                {
                    if (xArray[i] == 1 && yArray[i] == 1)
                    {
                        result += "1";
                    }
                    else
                    {
                        result += "0";
                    }
                }
                Console.WriteLine(result);

            }

            void OR(uint x, uint y)
            {
                string result = "";
                uint[] xArray = ConvertToArray(x);
                uint[] yArray = ConvertToArray(y);
                for (int i = 0; i < xArray.Length; i++)
                {
                    if (xArray[i] == 0 && yArray[i] == 0)
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "1";
                    }
                }
                Console.WriteLine(result);

            }

            void XOR(uint x, uint y)
            {
                string result = "";
                uint[] xArray = ConvertToArray(x);
                uint[] yArray = ConvertToArray(y);
                for (int i = 0; i < xArray.Length; i++)
                {
                    if ((xArray[i] == 1 && yArray[i] == 1) || (xArray[i] == 0 && yArray[i] == 0))
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "1";
                    }
                }
                Console.WriteLine(result);

            }

            void SHIFT(char mode, double value, double amount)
            {
                double power = Math.Pow(2, amount);
                switch (mode)
                {
                    case 'l':
                        Console.WriteLine(ConvertToBinary(value * power));
                        break;
                    case 'r':
                        Console.WriteLine(ConvertToBinary(value / power));
                        break;
                    default:
                        Console.WriteLine("You are dumb.");
                        break;
                }
                
            }
            string ConvertToBinary(double value)
            {
                string result = "";
                uint valueAsInt = Convert.ToUInt32(value);
                while (valueAsInt > 1)
                {
                    uint remainder = valueAsInt % 2;
                    result = Convert.ToString(remainder) + result;
                    valueAsInt /= 2;
                }
                result = Convert.ToString(valueAsInt) + result;
                return result;
            }

            uint[] ConvertToArray(uint value)
            {
                return value.ToString().Select(t => uint.Parse(t.ToString())).ToArray();
            }

            SHIFT('r', 64, 3);
            XOR(11111, 10000);
            OR(11111, 10000);
            AND(11111, 10000);
            COMPLEMENT(10101);
            Console.Read();

        }
    }
}
