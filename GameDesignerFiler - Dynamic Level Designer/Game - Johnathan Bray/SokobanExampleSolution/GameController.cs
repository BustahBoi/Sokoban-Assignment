using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNS;
using FilerNS;
using Test;



namespace SokobanExampleSolution
{
     public class GameController
    {
        protected GameNS.Game GameModel;
        protected IView View;
        protected string File;
        protected string leveltext= "#########,#-------#,#---$---#,#---@---#,#---.---#,#-------#,#----$--#,#--.----#,#########";
        

        private List<MapItem> Map;

        public GameController(GameNS.Game gameModel, IView view)
        {
            GameModel = gameModel;
            View = view;
        }
        public void setMap(string level)
        {
            string[] map = level.Split(',');
            GameModel.SetLevel(map);
        }

        public GameNS.Game GetASave()
        {
            return GameModel;
        }

        public void Reset()
        {
            GameModel.Restart();
            Map = GameModel.GetMap().Items;
            View.UpdateMap(Map);
            GameModel.GetMap().Updates = new List<MapItem>();
            View.GetGameStats(GameModel.GetMoveCount(), GameModel.GetMoveHistory());

        }
        public void Undo()
        {
            GameModel.Undo();
            Map = GameModel.GetMap().Updates;
            View.UpdateMap(Map);
            GameModel.GetMap().Updates = new List<MapItem>();
            View.GetGameStats(GameModel.GetMoveCount(), GameModel.GetMoveHistory());
        }

        public void Move(Direction move)
        {
            if (GameModel.IsFinished() == false)
            {
                GameModel.Move(move);
                Map = GameModel.GetMap().Updates;
                View.UpdateMap(Map);
                GameModel.GetMap().Updates = new List<MapItem>();
                View.GetGameStats(GameModel.GetMoveCount(), GameModel.GetMoveHistory());
                if (GameModel.IsFinished() == true)
                {
                    View.DisplayMessage("Congrats You have won!");
                    View.UpdateMap(null);
                }
            }
        }

        public void MakeMap(string filename)
        {
            File = filename;
            MainForm.loadGameEvent();

            int col = GameModel.GetColumnCount();
            int row = GameModel.GetRowCount();

            Map = GameModel.MakeMap();
            View.MakeTable(col, row, Map);
        }

        public string getFileName()
        {
            return File;
        }

        public void SaveFile(string fileName, FilerNS.Game callMeBackforDetails)
        {
            File = fileName;
            MainForm.saveFileEvent();
        }

        public string GetSaveFile()
        {
            return File;
        }

        public GameNS.Game GetSave()
        {
            return GameModel;
        }

        public GameNS.Game getModel()
        {
            return GameModel;
        }

        public List<MapItem> getMap()
        {
            return GameModel.MakeMap();
        }

        public void TestMap()
        {
            int col = GameModel.GetColumnCount();
            int row = GameModel.GetRowCount();
            Map = GameModel.MakeMap();
            View.MakeTable(col, row, Map);
        }

    }
}
