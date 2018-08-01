using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHandlerNS;
using SokobanExampleSolution;

namespace Test
{
    public delegate void FileHandled(object sender, EventArgs e);
    public partial class MainForm : Form
    {
        protected ILevelDesignController DesignController;
        protected FileHandlerController FilerControl;
        protected GameBoardForm GameBoard;
        protected static event FileHandled FileSave;
        protected static event FileHandled FileLoad;
        protected static event FileHandled SetFile;
        protected static event FileHandled LoadGame;
        protected static event FileHandled SaveGame;
        protected static event FileHandled SetSaveFile;
        protected static event FileHandled MapTest;
        protected FilerForm Filer;

       
        public MainForm(ILevelDesignController designControl, FileHandlerController filerControl, GameBoardForm gameBoard )
        {
            DesignController = designControl;
            FilerControl = filerControl;
            GameBoard = gameBoard;
            FileSave += new FileHandled(Save);
            FileLoad += new FileHandled(ToLoad);
            SetFile += new FileHandled(SetLoaded);
            LoadGame += new FileHandled(toLoadGame);
            SaveGame += new FileHandled(toSaveGame);
            SetSaveFile += new FileHandled(saveFile);
            MapTest += new FileHandled(levelToGame);
            InitializeComponent();
            GameBoard.setParent(this);
        }

        public static void saveFileEvent()
        {
            SetSaveFile(null, EventArgs.Empty);
        }

        public void saveFile(object sender, EventArgs e)
        {
            string file = GameBoard.GetSaveFile();
            GameNS.Game callMeBackforDetails = GameBoard.GetSave();
            FilerControl.game_save(file, callMeBackforDetails);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void levelDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesignController.Start(this);
        }

        public static void filerSave()
        {
            FileSave(null, EventArgs.Empty);
        }

        public static void filerLoad()
        {
            FileLoad(null, EventArgs.Empty);
        }

        public static void SetLoadedMap()
        {
            SetFile(null, EventArgs.Empty);
        }

        public static void loadGameEvent()
        {
            LoadGame(null, EventArgs.Empty);
        }

        public static void testMap()
        {
            MapTest(null, EventArgs.Empty);
        }

        public void toLoadGame(object sender, EventArgs e)
        {
            string file = GameBoard.getFileName();
            string level = FilerControl.game_load(file);
            GameBoard.setMap(level);

        }

        public static void saveGame(object sender, EventArgs e)
        {
            SaveGame(null, EventArgs.Empty);
        }

        public void toSaveGame(object sender, EventArgs e)
        {
            //string file = GameBoard.getMap();
            //game callback
        }

        public void Save(object sender, EventArgs e)
        {
            FilerControl.ShowForm();
            FilerControl.Ex_Save(DesignController.GetMap());
        }

        public void ToLoad(object sender, EventArgs e)
        {
            FilerControl.Ex_Load();
            FilerControl.ShowForm();
        }

        public void SetLoaded(object sender, EventArgs e)
        {
            char[,] map = FilerControl.ReturnMap();
            DesignController.Load(map);
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameBoard.Show();
        }

        private void levelToGame(object sender, EventArgs e)
        {
            GameBoard.Show();
            char[,] map = DesignController.GetMap();
            string mapString = FilerControl.arrayToString(map);
            GameBoard.setMap(mapString);
            GameBoard.makeMap();

        }
    }
}
