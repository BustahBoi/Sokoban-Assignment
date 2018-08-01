using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Test;

namespace Sokoban_FileHandler
{
    public delegate void LoaderEvent(object sender, EventArgs e);
    public delegate void SaverEvent(object sender, EventArgs e);
    public class FilerController
    {
        protected IForm Form;
        protected ILoader Loader;
        protected ISaver Saver;
        protected LoaderEvent LoadControlEvent;
        protected SaverEvent SaveControlEvent;

        public FilerController(IForm form, ILoader loader, ISaver saver)
        {
            Form = form;
            Saver = saver;
            Loader = loader;
            // Load Event
            LoadControlEvent = new LoaderEvent(Load_Control);
            Form.LoadEvent += LoadControlEvent;
            // Save Event
            SaveControlEvent = new SaverEvent(Save_Control);
            Form.SaveEvent += SaveControlEvent;
        }
        public FilerForm Load_Form()
        {
            return Form.Init_Form();
        }
        public void Load_Control(object sender, EventArgs e)
        {
            Loader.File_Loader(Form.Return_FileName());
            Form.Update_ErrorLabel(Loader.File_Checker());
            MainForm.SetLoadedMap();
        }

        public char[,] ReturnMap()
        {
            return Loader.Loaded_Map();
        }
        
        
        public void Ex_Load()
        {
            Form.Disable_Save();
            Form.Enable_Load();
        }

        public void Ex_Save(char[,] map)
        {
            Saver.Get_MapArray(map);
            Form.Enable_Save();
            Form.Disable_Load();
        }

        public void ShowForm()
        {
            Form.Show_Form();
            
        }
        public void Save_Control(object sender, EventArgs e)
        {
            Saver.File_Saver(Form.Return_FileName());
        }
    }
}
