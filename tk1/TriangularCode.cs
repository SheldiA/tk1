﻿using System;
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
            int numberBlock = (message.Length % blockLength == 0) ? message.Length / blockLength : message.Length / blockLength + 1;
            for (int count = 0; count < numberBlock; ++count )
            {
                int length = (count == numberBlock - 1) ? message.Length - count * blockLength : blockLength;
                char[][] evenArr = GetTriangularArr(message.Substring(count * blockLength, length));
                result += GetStrFromArr(evenArr);
            }
            return result;
        }

        private char[][] GetTriangularArr(string str)
        {
            int numRow = GetRowNumber(str.Length) + 1;//если добавлять 0 в конец, можно удалить метод
            char[][] result = new char[numRow][];
            int curNumColumn = maxBlockLength;
            int curStrPos = 0;
            for (int i = 0; i < numRow; ++i )
            {
                result[i] = new char[curNumColumn + 1];
                string curStr = "";
                for (int j = 0; j < curNumColumn; ++j )
                {
                    result[i][j] = str[curStrPos];
                    curStr += str[curStrPos];
                    ++curStrPos;
                }
                for (int row = 0; row < i; ++row )
                    curStr += result[row][curNumColumn];
                result[i][curNumColumn] = evenParity.GetEven(curStr);
                --curNumColumn;
            }

            return result;
        }

        private string GetStrFromArr(char[][] arr)
        {
            string result = "";

            for(int i = 0; i < arr.GetLength(0); ++i)
                for(int j = 0; j < arr[i].Length; ++j)
                    result += arr[i][j];

            return result;
        }

        private int GetRowNumber(int length)
        {
            int result = 0;
            int sum = 0;

            for (int i = maxBlockLength; i > 0; --i)
            {
                ++result;
                sum += i;
                if (sum >= length)
                    break;
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

        public override string Decode(string codeWord)
        {
            string result = "";
            ++maxBlockLength;
            int blockLength = Sum(maxBlockLength);
            int numberBlock = (codeWord.Length % blockLength == 0) ? codeWord.Length / blockLength : codeWord.Length / blockLength + 1;
            for (int count = 0; count < numberBlock; ++count )
            {
                int length = (count == numberBlock - 1) ? codeWord.Length - count * blockLength : blockLength;
                string block = codeWord.Substring(count * blockLength, length);
                int numRow = GetRowNumber(length);
                char[][] evenArr = new char[numRow][];
                int numColumn = maxBlockLength;
                int curCodeWordPos = 0;
                for (int i = 0; i < numRow; ++i )
                {
                    evenArr[i] = new char[numColumn];
                    for (int j = 0; j < numColumn; ++j )
                    {
                        evenArr[i][j] = codeWord[curCodeWordPos];
                        ++curCodeWordPos;
                    }
                    --numColumn;
                }
                for(int i = 0;i < numRow; ++i)
                {
                    string currStr = "";
                    for (int j = 0; j < evenArr[i].Length - 1; ++j)
                        currStr += evenArr[i][j];
                    for (int j = 0; j < i; ++j)
                        currStr += evenArr[j][evenArr[i].Length - 1];
                    if(evenParity.GetEven(currStr) != evenArr[i][evenArr[i].Length - 1])
                        result += ("error in " + i + " row");
                }
            }

            return result;
        }
    }
}
