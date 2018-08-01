using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_FileHandler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IForm form = new FilerForm();
            ILoader load = new Filer();
            ISaver save = new Filer();
            FilerController ex = new FilerController(form, load, save);
            Application.Run(ex.Load_Form());
        }
    }
}
