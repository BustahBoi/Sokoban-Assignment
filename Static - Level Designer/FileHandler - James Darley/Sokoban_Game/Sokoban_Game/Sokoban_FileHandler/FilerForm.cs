using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sokoban_FileHandler
{
    public partial class FilerForm : Form, IForm
    {
        public event LoaderEvent LoadEvent;
        public event SaverEvent SaveEvent;
        public string strFileName = null;
        public FilerForm()
        {
            InitializeComponent();
        }
        public FilerForm Init_Form()
        {
            Populate_ComboBox();
            return this;
        }
        public void Disable_Load()
        {
            this.LoadBtn.Enabled = false;
        }

        public void Enable_Load()
        {
            this.LoadBtn.Enabled = true;
        }

        public void Disable_Save()
        {
            this.SaveBtn.Enabled = false;
        }

        public void Enable_Save()
        {
            this.SaveBtn.Enabled = true;
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string Path = Environment.CurrentDirectory + "\\Levels\\";
            Stream myStream = null;
            OpenFileDialog LoadFileDialog1 = new OpenFileDialog();

            LoadFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            LoadFileDialog1.FilterIndex = 2;
            LoadFileDialog1.InitialDirectory = Path;
            //LoadFileDialog1.RestoreDirectory = true;

            // Set Recently Saved File As Default
            string RecentSaveFile = Directory.GetParent(Environment.CurrentDirectory).ToString();
            RecentSaveFile += "\\RecentSave.txt";
            if (File.Exists(RecentSaveFile))
            {
                string RecentSave = String.Join(",", File.ReadAllLines(RecentSaveFile));
                string[] RecentLevelSplit = RecentSave.Split('\\');
                string RecentLevel = RecentLevelSplit.Last().ToString();
                LoadFileDialog1.FileName = RecentLevel;
            }

            if (LoadFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = LoadFileDialog1.OpenFile()) != null)
                {
                    strFileName = LoadFileDialog1.FileName;
                }
            }
            else
            {
                return;
            }
            // Change LoadLabel
            LoadLabel.Text = "File Loaded Successfully";
            // Get Level Name
            string[] LevelPath = strFileName.Split('\\');
            string LevelName = LevelPath.Last().ToString();
            // Change LoadedFileLabel
            LoadedFileLabel.Text = "Level: " + LevelName;
            // Launch Load Event
            On_LoadEvent(e);
        }
        protected void On_LoadEvent(EventArgs e)
        {
            LoadEvent(this, e);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Path = Environment.CurrentDirectory + "\\Levels\\";
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.InitialDirectory = Path;
            SaveFileDialog1.DefaultExt = "txt";
            //SaveFileDialog1.RestoreDirectory = true;

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileName = SaveFileDialog1.FileName;
            }
            else
            {
                return;
            }
            // Change SaveLabel
            SaveLabel.Text = "File Saved Successfully";
            // Get Level Name
            string[] LevelPath = strFileName.Split('\\');
            string LevelName = LevelPath.Last().ToString();
            // Change SavedFileLabel
            SavedFileLabel.Text = "Level: " + LevelName;
            // Launch Save Event
            On_SaveEvent(e);
        }
        protected void On_SaveEvent(EventArgs e)
        {
            SaveEvent(this, e);
        }
        public string Return_FileName()
        {
            return strFileName;
        }
        public void Update_ErrorLabel(string ErrorResult)
        {
            if (ErrorResult == string.Empty)
            {
                return;
            }
            else
            {
                ErrorLabel.Text = ErrorResult;
            }
        }
        private void Populate_ComboBox()
        {
            DirectoryInfo DefaultSave = new DirectoryInfo(Environment.CurrentDirectory + "\\Levels\\");
            FileInfo[] Files = DefaultSave.GetFiles("*.txt");
            foreach (FileInfo File in Files)
            {
                LevelComboBox.Items.Add(File.Name);
            }
        }

        public void Show_Form()
        {
            this.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
