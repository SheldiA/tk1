using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class BinaryArythmetic
    {
        public string AddBinaryNumber(string first, string second)
        {
            int size = Math.Max(first.Length, second.Length);
            first = AddZero(first, size);
            second = AddZero(second, size);
            string result = "";
            for (int i = 0; i < size; ++i)
                result += (first[i] == second[i]) ? '0' : '1';
            return result;
        }

        public string AddZero(string str, int length)
        {
            while (str.Length < length)
                str = '0' + str;
            return str;
        }
    }
}
