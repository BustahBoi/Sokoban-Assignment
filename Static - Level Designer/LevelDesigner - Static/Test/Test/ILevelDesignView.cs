using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public interface ILevelDesignView
    {
        void Start(Form parent);
        void Stop();
        event MapChangedHandler MapChanged;
        void setErrors(string[] errors);
        void setText(string thing);
        string GetName();
        void Loaded(char[,] map);
    }
}
