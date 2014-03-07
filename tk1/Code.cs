using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tk1
{
    abstract class Code
    {
        public abstract string GetCodeWord(string message);
        public abstract string Decode(string codeWord);
    }
}
