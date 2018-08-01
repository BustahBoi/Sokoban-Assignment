using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IErrorHandler
    {
        void mapErrors(char[,] map);
        void errorCheck();
        string[] getErrors();
    }
}
