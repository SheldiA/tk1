using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class RectangularCode:Code
    {
        
        private int rowLength;
        private int blockSize;
        private EvenParity evenParity;

        public RectangularCode(int n)
        {
            rowLength = n;
            blockSize = n * n;
            evenParity = new EvenParity();
        }

        public override string GetCodeWord(string message)
        {
            string result = "";

            message = AlignStrByBlock(message,blockSize);
            int numBlock = message.Length / blockSize;
            char[,] evenArr = new char[rowLength + 1, rowLength + 1];
            for (int k = 0; k < numBlock; ++k)
            {
                string block = message.Substring(k * blockSize,blockSize);
                evenArr = GetMatrixFromStr(block,rowLength + 1,true);
                evenArr = FillEven(evenArr);
                result += GetStrFromArr(evenArr,true);
            }

            return result;
        }

        public override string Decode(string codeWord)
        {
            string result = "";

            ++rowLength;
            blockSize = rowLength * rowLength;

            codeWord = AlignStrByBlock(codeWord,blockSize);
            int numBlock = codeWord.Length / blockSize;
            char[,] evenArr;

            for (int k = 0; k < numBlock; ++k)
            {
                evenArr = GetMatrixFromStr(codeWord.Substring(k * blockSize,blockSize),rowLength,false);
                for (int i = 0; i < rowLength - 1; ++i)
                {
                    string currCodeWord = "";
                    for (int j = 0; j < rowLength; ++j)
                        currCodeWord += evenArr[i, j];
                    if (evenParity.GetEven(currCodeWord) != '0')
                    {
                        int column = FindErrorInColumn(evenArr);
                        if (column != -1)
                        {
                            evenArr[i, column] = (evenArr[i, column] == '0') ? '1' : '0';                            
                            break;
                        }
                    }
                }
                result += GetStrFromArr(evenArr, false);
            }
            return result;
        }

        private char[,] GetMatrixFromStr(string str,int lengthRow, bool needAdditionElem)
        {
            char[,] result = new char[lengthRow,lengthRow];
            int length = (needAdditionElem) ? lengthRow - 1 : lengthRow;
            for (int i = 0; i < length; ++i)
                for (int j = 0; j < length; ++j)
                    result[i,j] = str[i * length + j];
            return result;
        }

        private string AlignStrByBlock(string str, int lengthBlock)
        {
            while (str.Length % lengthBlock != 0)
                str = "0" + str;
            return str;
        }

        private string GetStrFromArr(char[,] arr,bool isShowEven)
        {
            string result = "";

            int numRow = (isShowEven) ? arr.GetLength(0) : arr.GetLength(0) - 1;
            int numColumn = (isShowEven) ? arr.GetLength(1) : arr.GetLength(1) - 1;
            for (int i = 0; i < numRow; ++i)
                for (int j = 0; j < numColumn; ++j)
                    result += arr[i, j];

            return result;
        }

        private char[,] FillEven(char[,] arr)
        {
            for (int i = 0; i < rowLength; ++i)
            {
                string currStr = "";
                for (int j = 0; j < rowLength; ++j)
                    currStr += arr[i, j];
                arr[i, rowLength] = evenParity.GetEven(currStr);
            }

            for (int j = 0; j <= rowLength; ++j)
            {
                string currStr = "";
                for (int i = 0; i < rowLength; ++i)
                    currStr += arr[i, j];
                arr[rowLength, j] = evenParity.GetEven(currStr);
            }

            return arr;
        }

        private int FindErrorInColumn(char[,] evenArr)
        {
            int column = -1;

            for (int j = 0; j < evenArr.GetLength(1) - 1; ++j )
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
