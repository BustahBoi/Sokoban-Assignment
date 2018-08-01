using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerNS
{
    public interface ISaver
    {
        void SetMap(char[,] map);
        void SaveMap(string name);
    }
}
