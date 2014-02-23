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
            for(int i = 0; i < errorVector.Count; ++i)
                for(int j = 0; j < codewords.Count; ++j)
                    table[i,j] = AddBinaryNumber(errorVector[i],codewords[j]);
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
