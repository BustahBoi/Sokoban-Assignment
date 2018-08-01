using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Test
{
    public partial class LevelDesignForm : Form, ILevelDesignView
    {
        public event MapChangedHandler MapChanged;

        protected Parts Part;
        protected Image Picture;
        protected int theWidth;
        protected int theHeight;
        protected Form FilerParent;
        protected Dictionary<char, Image> Items;

        public void Start(Form parent)
        {
            this.MdiParent = parent;
            FilerParent = parent;
            InitializeComponent();
            this.Show();
            Part = Parts.Empty;
            clear();
            Items = new Dictionary<char, Image>();
            Items.Add((char)Parts.Wall, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\wall.png"));
            Items.Add((char)Parts.Empty, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\empty.png"));
            Items.Add((char)Parts.Player, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\player.png"));
            Items.Add((char)Parts.Goal, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\goal.png"));
            Items.Add((char)Parts.Block, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\block.png"));
            Items.Add((char)Parts.PlayerOnGoal, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\playerOnGoal.png"));
            Items.Add((char)Parts.BlockOnGoal, Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\blockOnGoal.png"));
            Items.Add('\0', Image.FromFile(Directory.GetCurrentDirectory().ToString() + "\\Assets\\empty.png"));
            Picture = Items['-'];
        }

        public void Stop()
        {
            this.Hide();
        }

        private void sizeGenerate_Click(object sender, EventArgs e)
        {
            clear();
            this.Picture = Items['-'];
            int y = (int)this.ySize.Value;
            int x = (int)this.xSize.Value;
            theWidth = x;
            theHeight = y;
            MapChangedEventArgs MapChange = new MapChangedEventArgs();
            MapChange.x = x;
            MapChange.y = y;
            MapChange.Part = Part;
            MapChange.setting = true;
            OnMapChange(MapChange);
            setPanels(x, y);
            this.btnCheck.Enabled = true;
            this.BtnSave.Enabled = false;
            this.btnTest.Enabled = false;
        }

        private void setPanels(int x,int y)
        {
            for(int j = 0; j < x; j++)
            {
                for(int k = 0; k < y; k++)
                {
                    createPanel(j, k);
                }
            }
        }

        private void createPanel(int j, int k)
        {
            Panel Item = new System.Windows.Forms.Panel();
            Item.Location = new System.Drawing.Point(j * 22 + 10, k * 22 + 15);
            Item.Size = new System.Drawing.Size(21, 21);
            Item.BackgroundImage = Picture;
            Item.Click += new EventHandler(setBack);
            Item.Name = j.ToString() + "/" + k.ToString();
            Item.Click += (sender, e) => setItem(sender, e, Item.Name);
            this.MapContainer.Controls.Add(Item);
        }
        private void clear()
        {
            MapContainer.Controls.Clear();
        }
        public void setItem(object sender, EventArgs e,string name)
        {
            MapChangedEventArgs MapChange = new MapChangedEventArgs();
            Regex regex = new Regex("/");
            string[] location = regex.Split(name);
            MapChange.x = Int32.Parse(location[0]);
            MapChange.y = Int32.Parse(location[1]);
            MapChange.Part = Part;
            MapChange.setting = false;
            OnMapChange(MapChange);

        }

        protected void OnMapChange(MapChangedEventArgs e)
        {
            MapChanged(this, e);
        }

        public void setErrors(string[] errors)
        {
            this.Errors.Items.Clear();
            foreach(string error in errors)
            {
                if (error != null)
                {
                    this.Errors.Items.Add(error);
                }
            }            
        }

        private void setBack(object sender, EventArgs e)
        {
            ((Panel)sender).BackgroundImageLayout = ImageLayout.Stretch;
            ((Panel)sender).BackgroundImage = this.Picture;
        }

        public void Loaded(char[,] map)
        {
            clear();
            int count = 0;
            for(int j = 0; j < map.GetLength(0); j++)
            {
                for(int k = 0; k < map.GetLength(1); k++)
                {
                    createPanel(j, k);
                    MapContainer.Controls[count].BackgroundImage = Items[map[j,k]];
                    count++;
                }
            }
        }

        private void itemSelection_Enter(object sender, EventArgs e)
        {
            
        }

        private void wallButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.Wall;
            this.Picture = Items[(char)Part];
        }

        private void emptyButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.Empty;
            this.Picture = Items[(char)Part];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void playerButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.Player;
            this.Picture = Items[(char)Part];

        }

        private void goalButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.Goal;
            this.Picture = Items[(char)Part];
        }

        private void blockButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.Block;
            this.Picture = Items[(char)Part];
        }

        private void blockOnGoalButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.BlockOnGoal;
            this.Picture = Items[(char)Part];
        }

        private void playerOnGoalButton_CheckedChanged(object sender, EventArgs e)
        {
            Part = Parts.PlayerOnGoal;
            this.Picture = Items[(char)Part];
        }

        private void save_Click(object sender, EventArgs e)
        {
            MainForm.filerSave();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MapChangedEventArgs check = new MapChangedEventArgs();
            check.check = true;
            check.setting = false;
            OnMapChange(check);
            if(this.Errors.Items.Count < 1)
            {
                this.BtnSave.Enabled = true;
                this.btnTest.Enabled = true;
            }
        }


        private void Load_Click(object sender, EventArgs e)
        {
            this.btnCheck.Enabled = true;
            MainForm.filerLoad();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MainForm.testMap();
        }
    }
}
