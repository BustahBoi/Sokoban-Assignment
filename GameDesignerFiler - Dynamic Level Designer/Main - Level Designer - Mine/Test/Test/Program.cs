using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHandlerNS;
using SokobanExampleSolution;
using FilerNS;
using GameNS;


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

            ILevelDesignView designView = new LevelDesignForm();
            IErrorHandler designCheck = new ErrorHandler();
            IMapEditor designModel = new MapEditor(designCheck);

            ILevelDesignController designController = new Controller(designView, designModel);
            FileHandlerNS.IFiler filer = new FileHandler();
            ISaver saver = (ISaver)filer;
            ILoader loader = (ILoader)filer;

            IView gameView = new WindowsFormView();
            GameNS.Game gameModel = new GameNS.Game();
            GameController gControl = new GameController(gameModel, gameView);
            GameBoardForm gameBoard = new GameBoardForm(gameView, gControl);

            FilerForm filerView = new FilerForm();
            FilerNS.IFiler gameFiler = new FilerNS.Filer(); 
            FileHandlerController filerControl = new FileHandlerController(saver, loader, filer, gameFiler, gameModel , filerView);

            MainForm f = new MainForm(designController, filerControl, gameBoard);
            Application.Run(f);
        }
    }
}
