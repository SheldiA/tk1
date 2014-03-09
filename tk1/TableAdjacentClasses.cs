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
        private BinaryArythmetic binaryArythmetic;
  
        public string[,] Table
        {
            get
            {
                return table;
            }
        }
        public TableAdjacentClasses(int n,int k)
        {
            binaryArythmetic = new BinaryArythmetic();
            EvenParity evenParity = new EvenParity();
            table = new string[(int)Math.Pow(2,k),(int)Math.Pow(2,n - k)];
            List<string> allCombinationForK = binaryArythmetic.GenerateAllBinaryByLength(k);
            List<string> allCombinationForN = binaryArythmetic.GenerateAllBinaryByLength(n);
            for(int j = 0; j < table.GetLength(1);++j)
            {
                string value = allCombinationForK[j];
                while (value.Length < n)
                    value += evenParity.GetEven(value);
                table[0, j] = value;
                allCombinationForN.RemoveAt(allCombinationForN.IndexOf(value));
            }
            for(int i = 1; i < table.GetLength(0); ++i)
            {
                table[i,0] = GetElementWithMinWeight(allCombinationForN);
                allCombinationForN.RemoveAt(allCombinationForN.IndexOf(table[i,0]));
                for(int j = 1; j < table.GetLength(1); ++j)
                {
                    string element = binaryArythmetic.Xor(table[0, j], table[i, 0]);
                    table[i, j] = element;
                    allCombinationForN.RemoveAt(allCombinationForN.IndexOf(element));
                }
            }
        }

        private string GetElementWithMinWeight(List<string> elements)
        {
            int minWeight = Int32.MaxValue;
            string min = "";
            int weight;
            foreach(string element in elements)
                if((weight = GetWeight(element)) < minWeight)
                {
                    minWeight = weight;
                    min = element;
                }
            return min;
        }

        private int GetWeight(string str)
        {
            int weight = 0;
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == '1')
                    ++weight;
            return weight;
        }

        public string Decode(string message)
        {
            string result = "";

            for (int i = 0; i < table.GetLength(0); ++i )
                for(int j = 0; j < table.GetLength(1); ++j)
                    if(table[i,j] == message)
                        return binaryArythmetic.Xor(message, GetLeaderOfAdjacentClass(i, j));
            return result;
        }

        private string GetLeaderOfAdjacentClass(int row,int column)
        {
            List<string> elements = new List<string>();
            for (int j = 0; j < table.GetLength(1); ++j)
                if (j != column)
                    elements.Add(table[row, j]);

            return GetElementWithMinWeight(elements);
        }

        
    }
}
