using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   
    public class MapEditor : IMapEditor
    {

        private char[,] Map { get; set; }
        private char Item { get; set; } 
        internal protected IErrorHandler Check;
        public MapEditor(IErrorHandler check)
        {
            Check = check;
        }
        public void setSize(int x, int y)
        {
            Map = new char[x,y];
        }

        public void setItem(Parts item)
        {
            Item = (char)item;
        }
        
         public void placeItem(int x, int y)
        {
            Map[x, y] = Item;
        }

        public string[] getErrors()
        {
            Check.mapErrors(Map);
            Check.errorCheck();
            return Check.getErrors();
        }

        public void SetMap(char[,] map)
        {
            Map = map;
        }

        public char[,] getMap()
        {
            return Map;
        } 
        
    }
}
