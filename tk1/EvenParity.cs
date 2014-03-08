using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class EvenParity: Code
    {
        public override string GetCodeWord(string message)
        {
            string codeWord = "";            
            codeWord = message + GetEven(codeWord);
            return codeWord;
        }

        public override string Decode(string codeWord)
        {
            if (GetEven(codeWord) == '0')
                return "no error";
            else
                return "error";
        }

        public char GetEven(string str)
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

        private bool isOnlyZeroAndOne(string str)
        {
            bool result = true;

            for (int i = 0; i < str.Length; ++i )
                if(str[i] != '0' && str[i] != '1')
                {
                    result = false;
                    break;
                }
           return result;
        }
    }
}
