using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHandlerNS
{
    public class WinFormView
    {
        protected Form Parent;
        public WinFormView()
        {

        }

        public void setParent(Form parent)
        {
            Parent = parent;
        }
    }
}
