using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    class CodeAlgorithmFactory
    {
        private static readonly CodeAlgorithmFactory instance = new CodeAlgorithmFactory();
        public static CodeAlgorithmFactory Instance
        {
            get { return instance; }
        }

        protected CodeAlgorithmFactory() { }

        public Code GetCodeAlgorithm(string name,int n)
        {
            Code result = null;

            switch(name)
            {
                case "Repetition code":
                    result = new RepetitionCode(n);
                    break;
                case "Even parity code":
                    result = new EvenParity();
                    break;
                case "Rectangular code":
                    result = new RectangularCode(n);
                    break;
                case "Triangular code":
                    result = new TriangularCode(n);
                    break;
            }

            return result;
        }
    }
}
