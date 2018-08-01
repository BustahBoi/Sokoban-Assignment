using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameNS;
using FilerNS;
using System.IO;

namespace SokobanExampleSolution
{
    
    public partial class GameBoardForm : Form
    {
        protected GameController GameControl;
        protected IView View;
        protected FilerNS.Game callMeBackforDetails;
        
        public GameBoardForm()
        {
            
            InitializeComponent();
        }

        public string GetSaveFile()
        {
            return GameControl.GetSaveFile();
        }

        public GameNS.Game GetSave()
        {
            return GameControl.GetASave();
        }

        public void setParent(Form parent)
        {
            this.MdiParent = parent;
        }

        public string getFileName()
        {
            return GameControl.getFileName();
        }

        public void setMap(string level)
        {
            GameControl.setMap(level);
        }

        

        public GameBoardForm(IView view, GameController gController)
        {
            GameControl = gController;
            View = view;
            InitializeComponent();
            View.SetMain(this);
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            CheckState state = staticGameCheckBox.CheckState;
            if (state != CheckState.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    string filename = openFileDialog1.FileName;

                    GameControl.MakeMap(filename);

                    LoadGameButton.Enabled = false;

                }
            }
            else
            {
                GameControl.MakeMap(null);
            }

            ResetButton.Enabled = false;
            undoButton.Enabled = false;
            StartGameButton.Enabled = true;
            gameMap.Visible = true;
        }



 
        public void MakeTable(int col, int row, List<MapItem> theMap)
        {
            this.gameMap.ColumnCount = col;
            this.gameMap.RowCount = row;
            int length = theMap.Count();
            foreach(MapItem m in theMap)
            {
                this.gameMap.Controls.Add(CreatePic(m), m.CordY, m.CordX);
            }
        }
        private PictureBox CreatePic(MapItem m)
        {
            PictureBox pic = new PictureBox()
            {
                Name = "Icon" + m.CordX.ToString() + m.CordY.ToString(),
                Size = new System.Drawing.Size(49, 49),
                Image = GetImageForSign(m.Sign),
                SizeMode = PictureBoxSizeMode.Zoom
            };
        return pic;
        }

        private Bitmap GetImageForSign(char sign)
        {
            switch (sign)
            {
                case '#':
                    return Properties.Resources.wall;

                case '$':
                    return Properties.Resources.block;

                case '+':
                    return Properties.Resources.playerOnGoal;

                case '@':
                    return Properties.Resources.player;

                case ' ':
                    return Properties.Resources.empty;

                case '.':
                    return Properties.Resources.goal;

                case '*':
                    return Properties.Resources.blockOnGoal;

                default:
                    return Properties.Resources.empty;
            }
        }


        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(Control_PreviewKeyDown);
            }
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void GameBoardForm_KeyDown(object sender, KeyEventArgs e)
        {
            Direction Move = Direction.Up;
            if (StartGameButton.Enabled == false)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            Move = Direction.Up;
                            break;
                        case Keys.Down:
                            Move = Direction.Down;
                            break;
                        case Keys.Right:
                            Move = Direction.Right;
                            break;
                        case Keys.Left:
                            Move = Direction.Left;
                            break;
                    }
                    GameControl.Move(Move);
                }
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Enabled = false;
            ResetButton.Enabled = true;
            undoButton.Enabled = true;
            ActiveControl = this.gameMap;
        }

        public void AddMoveCount(string message)
        {
            this.MoveCountNumber.Text = message;
        }

        public void AddMoveHistory(string moveHistory)
        {
            this.PlayerMoveHistory.Text = moveHistory;
        }


        public void UpdateMap(List<MapItem> Map)
        {
            if(Map != null)
            {
                foreach (var obj in Map)
                {
                    var test = this.gameMap.GetControlFromPosition(obj.CordY, obj.CordX);
                    this.gameMap.Controls.Remove(test);
                    this.gameMap.Controls.Add(CreatePic(obj), obj.CordY, obj.CordX);
                }
            }
            else
            {
                ResetButton.Enabled = true;                
            }           
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            GameControl.Reset();
            ResetButton.Enabled = false;
            StartGameButton.Enabled = true;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            GameControl.Undo();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.DefaultExt = "txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                
                GameControl.SaveFile(filename, callMeBackforDetails);
                MessageBox.Show("You file is save as " + saveFileDialog1.FileName);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void makeMap()
        {
            GameControl.TestMap();
        }
    }
}
