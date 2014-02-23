using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class EvenParity
    {
        public string GetCodeWord(string message)
        {
            string codeWord = "";
            for (int i = 0; i < message.Length; ++i)
                codeWord += Convert.ToString((int)message[i], 2);
            codeWord += GetEven(codeWord);
            return codeWord;
        }

        public string Decode(string codeWord)
        {
            if (GetEven(codeWord) == '0')
                return "no error";
            else
                return "error";
        }

        private char GetEven(string str)
        {
            int count1 = 0;
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == '1')
                    ++count1;
            if (count1 % 2 == 0)
                return '0';
            else
                return '1';
        }
    }
}
