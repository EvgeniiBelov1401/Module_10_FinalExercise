using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Modules
{
    internal interface ILogger
    {
        void Solve(IAddition addition);
        void CorrectData(ref long val);
    }
}
