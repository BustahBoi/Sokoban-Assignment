using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sokoban_FileHandler;

namespace Test
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

            //view
            //ILevelForm designer = new LevelDesignForm();
            ILevelDesignView designView = new LevelDesignForm();
            //IView view = new WinFormView(designer);

            //model
            IErrorHandler designCheck = new ErrorHandler();
            IMapEditor designModel = new MapEditor(designCheck);

            //designController
            ILevelDesignController designController = new Controller(designView, designModel);

           
            //Sokoban_FileHandler
            IForm form = new FilerForm();
            ILoader load = new Filer();
            ISaver save = new Filer();
            FilerController filerControl = new FilerController(form, load, save);

            MainForm f = new MainForm(designController, filerControl);
            Application.Run(f);
        }
    }
}
