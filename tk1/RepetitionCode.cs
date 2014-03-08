using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class RepetitionCode:Code
    {
        private readonly int keyWordLength = 0;

        public RepetitionCode(int n)
        {
            keyWordLength = n;
        }

        public override string GetCodeWord(string message)
        {
            string result = "";

            for (int i = 0; i < message.Length; ++i)
                for (int j = 0; j < keyWordLength; ++j)
                    result += message[i];

            return result;
        }

        public override string Decode(string codeWord)
        {
            string result = "";
            int numBlocks = codeWord.Length / keyWordLength;

            for (int i = 0; i < numBlocks; ++i)
                result += GetMoreFrequentCharacter(codeWord.Substring(i*keyWordLength,keyWordLength));
            return result;
        }

        private char GetMoreFrequentCharacter(string str)
        {
            int num1 = 0;
            int num0 = 0;
            for (int i = 0; i < str.Length; ++i)
                if(str[i] == '0') 
                    ++num0;
                else
                    ++num1;
            return (num0 >= num1) ? '0' : '1';
        }
    }
}
