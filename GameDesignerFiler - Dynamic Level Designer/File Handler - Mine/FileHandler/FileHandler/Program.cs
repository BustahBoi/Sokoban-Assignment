using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SokobanExampleSolution;
using FilerNS;

namespace FileHandlerNS
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

            IFiler filer = new FileHandler();
            ISaver saver = (ISaver)filer;
            ILoader loader = (ILoader)filer;
            FilerNS.IFiler gameFiler = new FilerNS.Filer();
            
            FilerForm view = new FilerForm();
            //FileHandlerController controller = new FileHandlerController(saver, loader, filer, gameFiler, view);

            Application.Run(/*controller.Start()*/);
        }
    }
}
