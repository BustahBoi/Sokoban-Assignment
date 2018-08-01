using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sokoban_FileHandler
{
    public class Filer : ILoader, ISaver
    {
        public string LevelName { get; protected set;  }
        public char[,] Map { get; protected set; }
        public string MapString { get; protected set; }
        public string[] Contents { get; protected set; }
        private int MapHeight { get; set; }
        private int MapWidth { get; set; }

        // SET UP FUNCTION
        public void SetUp(string Name, int x, int y)
        {
            Get_LevelName(Name);
            Set_MapXY(x, y);
        }

        public void Get_LevelName(string Name)
        {
            LevelName = Name;
        }
        private void Set_MapXY(int x, int y)
        {
            Map = new char[y, x];
        }

        // Get Map Array - Used to get array from leveldesigner
        public void Get_MapArray(char[,] map)
        {
            Map = map;
        }

        // SET UP LOAD -- 
        public void File_Loader(string FileName)
        {
            Load_FileContents(FileName);
            Load_Array(FileName);
        }
        private void Load_FileContents(string FileName)
        {
            Contents = File.ReadAllLines(FileName);
            MapHeight = Contents.GetLength(0);
            MapWidth = Contents[0].Split(',').Length;
            string[] LevelSplit = FileName.Split('\\');
            string Level = LevelSplit.Last().ToString();
            string[] LevelExtSplit = Level.Split('.');
            string LevelExt = LevelExtSplit.First().ToString();
            SetUp(LevelExt, MapWidth, MapHeight);
        }
        private void Load_Array(string FileName)
        {
            int YCounter = 0;
            int XCounter = 0;
            // Thing == each line
            foreach (string Lines in Contents)
            {
                string[] SplitLine = Lines.Split(',');
                // s == each character
                foreach (string Character in SplitLine)
                {
                    Map.SetValue(Convert.ToChar(Character), YCounter, XCounter);
                    XCounter++;
                    // X length, reset when x == map(x)
                    if (XCounter == MapWidth)
                    {
                        XCounter = 0;
                        YCounter++;
                    }
                }
            }
        }

        // SET UP SAVE --
        public void File_Saver(string FileName)
        {
            // START TEST -- Sample Map Array --
            // Loads the contents of the previously saved level file
            // Would normally be recieved with GetMapArray()
            // From a level designer class
            //string Tester = Environment.CurrentDirectory + "\\Levels\\Level_1.txt";
           // File_Loader(Tester);
            // END TEST -- Sample Map Array --
            Convert_ArrayToString();
            Save_ArrayToFile(FileName);
        }

        public char[,] Loaded_Map()
        {
            return this.Map;
        }
        private void Convert_ArrayToString()
        {
            int count = -1;
            MapHeight = Map.GetLength(0);
            MapWidth = Map.GetLength(1);
            foreach (char Thing in Map)
            {
                count++;
                if (MapWidth == count)
                {
                    count = 0;
                    MapString += Environment.NewLine;
                }
                MapString += Thing;
                if (MapWidth != count + 1)
                {
                    MapString += ",";
                }
            }
        }
        private void Save_ArrayToFile(string FileName)
        {
            System.IO.File.WriteAllText(FileName, MapString);
            string RecentSave = Directory.GetParent(Environment.CurrentDirectory).ToString();
            RecentSave += "\\RecentSave.txt";
            System.IO.File.WriteAllText(RecentSave, FileName);
        }
        public string File_Checker()
        {
            string Result = String.Empty;
            int GoalCount = Count_Goal();
            string PlayerError = Check_PlayerCount();
            bool ValidCharError = Check_ValidChars();
            bool GoalError = Check_Goal();
            Result = "Goals: " + GoalCount.ToString();
            if (PlayerError != "No Errors")
            {
                Result += Environment.NewLine + PlayerError;
            }
            if (ValidCharError == false)
            {
                Result += Environment.NewLine + "ERROR: Level file contains invalid characters";
            }
            if (GoalError == false)
            {
                Result += Environment.NewLine + "ERROR: Level must not contain more boxes than goals";
            }
            return Result;
        }
        private int Count_Goal()
        {
            int result = 0;
            foreach (char Thing in Map)
            {
                if (Thing == '.' || Thing == '+')
                {
                    result++;
                }
            }
            return result;
        }
        private string Check_PlayerCount()
        {
            string result = "No Errors";
            int count = 0;
            foreach (char Thing in Map)
            {
                if (Thing == '@' || Thing == '+')
                {
                    count++;
                }
            }
            if (count > 1)
            {
                result = "ERROR: Level must only contain one player";
            }
            else if (count < 1)
            {
                result = "ERROR: Level must contain at least one player";
            }
            return result;
        }
        private bool Check_ValidChars()
        {
            char[] ValidChars = new char[8] { '#', '@', '.', '$', '+', '*', ' ', (char)13 };
            foreach (char Thing in Map)
            {
                int CharCount = 0;
                int Count = 0;
                while (Count == 0 && CharCount <= 7)
                {
                    if (Thing == ValidChars[CharCount])
                    {
                        Count++;
                    }
                    else
                    {
                        CharCount++;
                    }
                }
                if (Count == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool Check_Goal()
        {
            int GoalCount = 0;
            int BoxCount = 0;
            foreach (char Thing in Map)
            {
                if (Thing == '.' || Thing == '+')
                {
                    GoalCount++;
                }
                if (Thing == '$')
                {
                    BoxCount++;
                }
                if (Thing == '*')
                {
                    GoalCount++;
                    BoxCount++;
                }
            }
            if (GoalCount > BoxCount)
            {
                return false;
            }
            return true;
        }
    }
}
