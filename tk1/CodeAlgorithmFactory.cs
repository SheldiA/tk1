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

        private RepetitionCode repetitionCode = null;
        private EvenParity evenParityCode = null;
        private RectangularCode rectangularCode = null;
        private TriangularCode triangularCode = null;

        public Code GetCodeAlgorithm(string name)
        {
            Code result = null;

            switch(name)
            {
                case "Repetition code":
                    if (repetitionCode == null)
                        repetitionCode = new RepetitionCode();
                    result = repetitionCode;
                    break;
                case "Even parity code":
                    if (evenParityCode == null)
                        evenParityCode = new EvenParity();
                    result = evenParityCode;
                    break;
                case "Rectangular code":
                    if (rectangularCode == null)
                        rectangularCode = new RectangularCode();
                    result = rectangularCode;
                    break;
                case "Triangular code":
                    if (triangularCode == null)
                        triangularCode = new TriangularCode();
                    result = triangularCode;
                    break;
            }

            return result;
        }
    }
}
