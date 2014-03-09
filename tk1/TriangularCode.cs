using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class TriangularCode:Code
    {
        public int maxBlockLength;
        public readonly EvenParity evenParity;

        public TriangularCode(int n)
        {
            maxBlockLength = n;
            evenParity = new EvenParity();
        }

        public override string GetCodeWord(string message)
        {
            string result = "";
            int blockLength = Sum(maxBlockLength);
            message = AlignStrByBlock(message, blockLength);
            int numberBlock = message.Length / blockLength;
            for (int count = 0; count < numberBlock; ++count)
            {
                string block = message.Substring(count * blockLength, blockLength);
                char[][] evenArr = GetTriangularArr(block,true);
                evenArr = AddEven(evenArr);
                result += GetStrFromArr(evenArr,false);
            }
            return result;
        }

        public override string Decode(string codeWord)
        {
            string result = "";
            int blockLength = Sum(maxBlockLength + 1);
            codeWord = AlignStrByBlock(codeWord, blockLength);
            int numberBlock = codeWord.Length / blockLength;
            for (int count = 0; count < numberBlock; ++count)
            {
                string block = codeWord.Substring(count * blockLength, blockLength);
                char[][] evenArr = GetTriangularArr(block, false);
                evenArr = FixErrorInBlock(evenArr);
                result += GetStrFromArr(evenArr,true);
            }

            return result;
        }


        private char[][] GetTriangularArr(string str, bool needAdditionElem)
        {
            int numRow = maxBlockLength + 1;
            char[][] result = new char[numRow][];
            int curNumColumn = maxBlockLength;
            int curStrPos = 0;
            for (int i = 0; i < numRow; ++i)
            {
                result[i] = new char[curNumColumn + 1];
                for (int j = 0; j < curNumColumn; ++j)
                {
                    result[i][j] = str[curStrPos];
                    ++curStrPos;
                }
                if (!needAdditionElem)
                {
                    result[i][curNumColumn] = str[curStrPos];
                    ++curStrPos;
                }
                --curNumColumn;
            }

            return result;
        }

        private char[][] AddEven(char[][] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                string curStr = "";
                for (int j = 0; j < arr[i].Length - 1; ++j)
                    curStr += arr[i][j];
                for (int row = 0; row < i; ++row)
                    curStr += arr[row][arr[i].Length - 1];
                arr[i][arr[i].Length - 1] = evenParity.GetEven(curStr);
            }

            return arr;
        }

        private string GetStrFromArr(char[][] arr,bool isDeleteEven)
        {
            string result = "";
            int numRow = (isDeleteEven) ? arr.GetLength(0) - 1 : arr.GetLength(0);
            for (int i = 0; i < numRow; ++i)
            {
                int numColumn = (isDeleteEven) ? arr[i].Length - 1 : arr[i].Length;
                for (int j = 0; j < numColumn; ++j)
                    result += arr[i][j];
            }

            return result;
        }

        private int Sum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; ++i)
                sum += i;
            return sum;
        }

        private string AlignStrByBlock(string str,int lengthBlock)
        {
            while (str.Length % lengthBlock != 0)
                str = "0" + str;
            return str;
        }

        private char[][] FixErrorInBlock(char[][] block)
        {
            int firstErr = -1;
            for (int i = 0; i < block.GetLength(0); ++i)
            {
                string currStr = "";
                for (int j = 0; j < block[i].Length - 1; ++j)
                    currStr += block[i][j];
                for (int j = 0; j < i; ++j)
                    currStr += block[j][block[i].Length - 1];
                if (evenParity.GetEven(currStr) != block[i][block[i].Length - 1])
                {
                    if (firstErr == -1)
                        firstErr = i;
                    else
                    {
                        block[firstErr][block[i].Length - 1] = (block[firstErr][block[i].Length - 1] == '0') ? '1' : '0';
                        break;
                    }
                }
            }

            return block;
        }
    }
}
