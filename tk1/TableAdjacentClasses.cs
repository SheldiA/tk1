using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class TableAdjacentClasses
    {
        private string[,] table;
        public string[,] Table
        {
            get
            {
                return table;
            }
        }
        public TableAdjacentClasses(List<string> codewords,List<string> errorVector)
        {
            table = new string[errorVector.Count, codewords.Count];
            for (int i = 0; i < errorVector.Count;++i )
                table[i, 0] = errorVector[i];
            for (int i = 0; i < codewords.Count; ++i)
                table[0,i] = codewords[i];
            for(int i = 1; i < errorVector.Count; ++i)
                for(int j = 1; j < codewords.Count; ++j)
                    table[i,j] = AddBinaryNumber(errorVector[i],codewords[j]);
        }

        public string Decode(string message)
        {
            string result = "";

            for (int i = 0; i < table.GetLength(0); ++i )
                for(int j = 0; j < table.GetLength(1); ++j)
                    if(table[i,j] == message)
                        return AddBinaryNumber(message,GetLeaderOfAdjacentClass(i,j));
            return result;
        }

        private string GetLeaderOfAdjacentClass(int row,int column)
        {
            int min = Int32.MaxValue;
            string result = "";
            for(int j = 0; j < table.GetLength(1); ++j)
            {
                int number1 = 0;
                if(j != column)
                {
                    for (int k = 0; k < table[row, j].Length; ++k)
                        if (table[row, j][k] == '1')
                            ++number1;
                    if(number1 < min)
                    {
                        min = number1;
                        result = table[row,j];
                    }
                }
            }
            return result;
        }

        private string AddBinaryNumber(string first,string second)
        {
            int size = Math.Min(first.Length,second.Length);
            first.Reverse();
            second.Reverse();
            string result = "";
            for (int i = 0; i < size; ++i)
                result += (first[i] == second[i]) ? '0' : '1';
            result.Reverse();
            return result;
        }
    }
}
