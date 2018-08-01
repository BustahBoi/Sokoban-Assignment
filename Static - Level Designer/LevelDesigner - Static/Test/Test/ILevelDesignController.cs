using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public interface ILevelDesignController
    {
        void Start(Form parent);
        void Stop();

        char[,] GetMap();

        string GetName();
        void Load(char[,] map);
    }
}
