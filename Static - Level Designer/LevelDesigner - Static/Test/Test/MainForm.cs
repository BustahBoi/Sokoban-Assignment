using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sokoban_FileHandler;

namespace Test
{
    public delegate void FileHandled(object sender, EventArgs e);
    public partial class MainForm : Form
    {
        protected ILevelDesignController DesignController;
        protected FilerController FilerControl;
        protected static event FileHandled FileSave;
        protected static event FileHandled FileLoad;
        protected static event FileHandled SetFile;
        protected FilerForm Filer;


        public MainForm(ILevelDesignController designControl, FilerController filerControl )
        {
            DesignController = designControl;
            FilerControl = filerControl;
            InitializeComponent();
            FileSave += new FileHandled(Save);
            FileLoad += new FileHandled(ToLoad);
            SetFile += new FileHandled(SetLoaded);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesignController.Stop();
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
            DesignController.Load(FilerControl.ReturnMap());
        }
    }
}
