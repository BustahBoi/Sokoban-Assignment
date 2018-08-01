using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_FileHandler
{
    public interface ISaver
    {
        void SetUp(string name, int x, int y);
        void Get_LevelName(string Name);
        void File_Saver(string FileName);
        string File_Checker();
        void Get_MapArray(char[,] map);
    }
}
