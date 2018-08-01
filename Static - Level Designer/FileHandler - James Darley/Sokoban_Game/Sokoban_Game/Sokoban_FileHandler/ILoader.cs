using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_FileHandler
{
    public interface ILoader
    {
        void SetUp(string Name, int x, int y);
        void File_Loader(string FileName);
        string File_Checker();

        char[,] Loaded_Map();
    }
}
