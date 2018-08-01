using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilerNS;
using GameNS;
using System.Windows.Forms;

namespace SokobanExampleSolution
{
    class Program //this should inistialise the controller
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IView View = new WindowsFormView();
            IFiler Filer = new Filer();
            GameController gControl = new GameController(new GameNS.Game(), View);
            GameBoardForm gameBoard = new GameBoardForm( View, gControl);

           Application.Run(gameBoard);
        }
    }
}
