using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bitwise_Functions.BinaryUtil;

namespace Bitwise_Functions
{
    static class BitwiseUtil            // S T A T I C .
    {
        public static string COMPLEMENT(uint value)
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
            return result;

        }

        public static string AND(uint x, uint y)
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
            return result;

        }

        public static string OR(uint x, uint y)
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
            return result;

        }

        public static string XOR(uint x, uint y)
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
            return result;

        }

        public static string SHIFT(char mode, double value, double amount)
        {
            string result = "";
            double power = Math.Pow(2, amount);
            switch (mode)
            {
                case 'l':
                    result = BinaryUtil.ConvertToBinary(value * power);
                    break;
                case 'r':
                    result = BinaryUtil.ConvertToBinary(value / power);
                    break;
                default:
                    result = "You are dumb.";
                    break;
            }
            return result;

        }
    }
}
