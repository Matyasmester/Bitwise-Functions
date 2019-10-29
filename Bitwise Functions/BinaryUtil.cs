using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Functions
{
    static class BinaryUtil
    {
        public static string ConvertToBinary(double value)
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
    }
}
