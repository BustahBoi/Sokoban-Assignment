using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerNS
{
    public interface IFiler
    {
        void SaveMap(string name);
        void LoadFile(string fileName);
        char[,] GetMap();
        void SetMap(char[,] map);
        void CreateSaveFolder();
        string getSaveLocation();

        string getMapString();
        void MapArrayToString();
    }
}
