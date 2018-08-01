using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
using FilerNS;

namespace FileHandlerNS
{
    public class FileHandlerController
    {
        //protected IFiler Filer;

        public FileHandlerController(ISaver saver, ILoader loader, IFiler filer , FilerNS.IFiler gameFiler, GameNS.Game game ,FilerForm view)
        {
            Saver = saver;
            Loader = loader;
            View = view;
            theGame = game;
            Filer = filer;
            FilerGame = gameFiler;
            FileHandled = new FileEventHandler(OnFileEvent);
            View.FileHandled += FileHandled;
            Filer.CreateSaveFolder();
            View.setDirectory(Filer.getSaveLocation());
        }

        protected ISaver Saver;
        protected GameNS.Game theGame;
        protected ILoader Loader;
        protected IFiler Filer;
        protected FilerNS.IFiler FilerGame;
        protected FilerForm View;
        protected FileEventHandler FileHandled;

        public Form Start()
        {
            return View;
        }

        public void ShowForm()
        {
            View.Show();
        }

        public void Ex_Save(char[,] map)
        {
            Saver.SetMap(map);
            View.disableLoad();
            View.enableSave();
        }

        public void Ex_Load()
         {
            View.disableSave();
            View.enableLoad();
        }
        /// <summary>
        /// //////////////////////////
        /// </summary>


        public void game_save(string filename, GameNS.Game callMeBackforDetails)
        {
            FilerGame.Save(filename, callMeBackforDetails);
        }

        public string game_load(string filename)
        {
            string file = FilerGame.Load(filename);
            return file;
        }




        public void OnFileEvent(object sender, FileEventArgs e)
        {
            string name;
            if(e.Save)
            {
                Saver.SaveMap(View.getFileName());
            }
            else if (e.Load)
            {
                name = View.getFileName();
                Loader.LoadFile(name);
                MainForm.SetLoadedMap();
            }
        }

        public char[,] ReturnMap()
        {
            char[,] map = Loader.GetMap();
            return map;
        }

        public string arrayToString(char[,] map)
        {
            Filer.SetMap(map);
            Filer.MapArrayToString();
            return Filer.getMapString();
        }
    }
}
