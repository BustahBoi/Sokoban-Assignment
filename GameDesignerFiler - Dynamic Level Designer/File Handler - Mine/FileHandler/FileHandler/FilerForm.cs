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

namespace FileHandlerNS
{
    public partial class FilerForm : Form, IFilerFormView
    {
        
        public FilerForm()
        {
            InitializeComponent();
            this.lnkRecent.Enabled = false;
            getFileList();
        }
        public event FileEventHandler FileHandled;
        protected string FileName;
        protected string theDirectory;

        public void disableLoad()
        {
            this.btnLoad.Enabled = false;
        }

        public void enableLoad()
        {
            this.btnLoad.Enabled = true;
        }

        public void disableSave()
        {
            this.btnSave.Enabled = false;
        }

        public void enableSave()
        {
            this.btnSave.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            SaveFileDialog SaveDialog = new SaveFileDialog();

            SaveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveDialog.FilterIndex = 2;
            SaveDialog.InitialDirectory = theDirectory;
            SaveDialog.DefaultExt = "txt";

            string RecentSaveFile = Directory.GetParent(theDirectory).ToString();
            RecentSaveFile += @"\RecentSave.txt";

            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = SaveDialog.FileName;
            }
            else
            {
                return;
            }
            string[] LevelPath = FileName.Split('\\');
            recentFile(RecentSaveFile);

            string LevelName = LevelPath.Last().ToString();
            lblSaveItem.Text = LevelName;
            FileEventArgs FileEvent = new FileEventArgs();
            FileEvent.Save = true;
            FileEvent.Load = false;
            OnFileEvent(FileEvent);
            FileExistsSaved();
            getFileList();
        }

        public void OnFileEvent(FileEventArgs e)
        {
           FileHandled(this, e);
        }

        private void recentFile(string RecentSaveFile)
        {
            if(!File.Exists(RecentSaveFile))
            {
                File.WriteAllText(RecentSaveFile, String.Empty);
            }
            string[] readLines = File.ReadAllLines(RecentSaveFile);
            List<string> writeLines = new List<string>();
            foreach (string line in readLines)
            {
                if (line != FileName)
                {
                    writeLines.Add(line);
                }
            }
            writeLines.Add(FileName + Environment.NewLine);
            this.lblRecentPath.Text = FileName;
            File.AppendAllText(RecentSaveFile, FileName + Environment.NewLine);
            setRecentLink();
        }

        public void FileExistsSaved()
        {
            if (File.Exists(FileName))
            {
                lstMessages.Items.Add("File saved successfully");
            }
            else
            {
                lstMessages.Items.Add("Error: File not saved");
            }
            
        }

        public void FileExistsLoaded()
        {
            if (File.Exists(FileName))
            {
                lstMessages.Items.Add("File Loaded Successfully");
            }
            else
            {
                lstMessages.Items.Add("Error: File not loaded");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog LoadDialog = new OpenFileDialog();
            lstMessages.Items.Clear();
            LoadDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            LoadDialog.FilterIndex = 2;
            LoadDialog.InitialDirectory = theDirectory;
            string RecentSaveFile = Directory.GetParent(theDirectory).ToString();
            RecentSaveFile += @"\RecentSave.txt";
            if (File.Exists(RecentSaveFile))
            {
                string RecentSave = String.Join(",", File.ReadAllLines(RecentSaveFile));
                string[] RecentLevelSplit = RecentSave.Split('\\');
                string RecentLevel = RecentLevelSplit.Last().ToString();
            }
            else
            {
                File.Create(RecentSaveFile);
            }

            if (LoadDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = LoadDialog.OpenFile()) != null)
                {
                    FileName = LoadDialog.FileName;
                }
            } else {return;}
            recentFile(RecentSaveFile);
            string[] LevelPath = FileName.Split('\\');
            string Level = LevelPath.Last().ToString();
            lblLoadItem.Text = Level;
            FileEventArgs FileEvent = new FileEventArgs();
            FileEvent.Save = false;
            FileEvent.Load = true;
            OnFileEvent(FileEvent);
            FileExistsLoaded();
            getFileList();
        }

        private void getFileList()
        {
            this.lstFiles.Items.Clear();
            string location = Path.Combine(Directory.GetCurrentDirectory(), "MapSaves");
            string[] files = Directory.GetFiles(location);
            foreach(string file in files)
            {
                string[] fileSplit = file.Split('\\');
                string filename = fileSplit.Last().ToString();
                this.lstFiles.Items.Add(filename);
            }
            
        }

        private string getLastFile()
        {
            string RecentSaveFile = Directory.GetParent(theDirectory).ToString();
            RecentSaveFile += @"\RecentSave.txt";
            string path;
            path = "no file";
            if (File.Exists(RecentSaveFile))
            {
                 path = File.ReadLines(RecentSaveFile).Last();

            }
            if(path != "no file")
            {
                this.lnkRecent.Enabled = true;
                this.lblRecentPath.Text = path;
            }
            return path;
        }

        public string getFileName()
        {
            return FileName;
        }

        public void setDirectory(string directory)
        {
            theDirectory = directory;
            setRecentLink();
        }

        public void setRecentLink()
        {
            string path = getLastFile();
            string[] sep = new string[] { "\\" };
            string[] pathData = path.Split(sep, StringSplitOptions.None);
            this.lnkRecent.Text = pathData.Last().ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnkRecent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FileName = getLastFile();
            FileEventArgs FileEvent = new FileEventArgs();
            FileEvent.Save = false;
            FileEvent.Load = true;
            OnFileEvent(FileEvent);
            FileExistsLoaded();
        }

        private void FilerForm_Load(object sender, EventArgs e)
        {

        }


    }

    public delegate void FileEventHandler(object sender, FileEventArgs e);

    public class FileEventArgs : EventArgs
    {
        public bool Save;
        public bool Load;
    }
}
