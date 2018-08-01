using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerNS
{
    public interface ILoader
    {
        void LoadFile(string fileName);
        char[,] GetMap();
    }
}
