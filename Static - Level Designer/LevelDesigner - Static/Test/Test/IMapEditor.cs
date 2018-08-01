using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IMapEditor
    {
        void setSize(int x, int y);
        void setItem(Parts item);
        void placeItem(int x, int y);
        string[] getErrors();

        char[,] getMap();
        void SetMap(char[,] map);
        

        //char[,] getMap();
        //char getItem(int x,int y);
    }
}
