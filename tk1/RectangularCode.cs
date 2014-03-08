using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class RectangularCode:Code
    {
        private char[,] evenArr;
        private int blockSize;
        private EvenParity evenParity;

        public RectangularCode(int n)
        {
            blockSize = n;
            evenParity = new EvenParity();
        }
        public override string GetCodeWord(string message)
        {
            string result = "";

            int numBlock = message.Length / (blockSize * blockSize);
            if (message.Length % (blockSize * blockSize) != 0)
                ++numBlock;
            evenArr = new char[blockSize + 1, blockSize + 1];
            for (int k = 0; k < numBlock; ++k)
            {
                FillEntityArr(message);
                for(int i = 0; i <= blockSize; ++i)
                    for(int j = 0; j <= blockSize; ++j)
                        result += evenArr[i,j];
            }

            return result;
        }

        private void FillEntityArr(string str)
        {
            for (int i = 0; i < blockSize; ++i)
            {
                string currBlock = "";
                for (int j = 0; j < blockSize; ++j)
                {
                    evenArr[i, j] = (i * blockSize + j < str.Length) ? str[i * blockSize + j] : '0';
                    currBlock += evenArr[i, j];
                }
                evenArr[i, blockSize] = evenParity.GetEven(currBlock);
            }

            for(int j = 0; j < (blockSize + 1); ++j)
            {
                string currBlock = "";
                for (int i = 0; i < blockSize; ++i)
                    currBlock += evenArr[i,j];
                evenArr[blockSize, j] = evenParity.GetEven(currBlock);
            }
        }

        public override string Decode(string codeWord)
        {
            string result = "";
            int numBlock = codeWord.Length / ((blockSize + 1) * (blockSize + 1));
            if (codeWord.Length % ((blockSize + 1) * (blockSize + 1)) != 0)
                ++numBlock;
            evenArr = new char[blockSize + 1, blockSize + 1];
            for(int i = 0; i < evenArr.GetLength(0);++i)
            {
                for(int j = 0; j < evenArr.GetLength(1); ++j)
                    evenArr[i, j] = (i * (blockSize + 1) + j < codeWord.Length) ? codeWord[i * (blockSize + 1) + j] : '0'; 
            }
            for(int k = 0; k < numBlock; ++k)
            {
                for(int i = 0; i < evenArr.GetLength(0) - 1; ++i)
                {
                    string currCodeWord = "";
                    for (int j = 0; j < evenArr.GetLength(1); ++j)
                        currCodeWord += evenArr[i, j];
                    if(evenParity.GetEven(currCodeWord) != '0')
                    {
                        int column = FindErrorInColumn();
                        if(column != -1)
                        {
                            result += ("error in " + (k * (blockSize + 1) * (blockSize + 1) + i * (blockSize + 1) +  column) + "position");
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private int FindErrorInColumn()
        {
            int column = -1;

            for (int j = 0; j < evenArr.GetLength(1); ++j )
            { 
                string currCodeWord = "";
                for (int i = 0; i < evenArr.GetLength(0); ++i)
                    currCodeWord += evenArr[i, j];
                if(evenParity.GetEven(currCodeWord) == '1')
                {
                    column = j;
                    break;
                }
            }

            return column;
        }
    }
}
