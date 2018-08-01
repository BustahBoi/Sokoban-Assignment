using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNS
{
   public class MapItem
    {
        public int CordX;
        public int CordY;
        public char Sign;

        // Each item in the Map should have these values
        // This includes Player / Wall / 
        public MapItem(int x, int y, char sign )
        {
            CordX = x;
            CordY = y;
            Sign = sign;
        }

       
    }
}
