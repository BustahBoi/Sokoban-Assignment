using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlerNS
{
    public class FileHandler : IFiler, ISaver, ILoader
    {

        public string SaveLocation { get; private set; }
        public char[,] MapArray { get; set; }
        public string MapArrayString { get; private set; }
        public string FileString { get; private set; }

        public void SetMap(char[,] map)
        {
            MapArray = map;
        }

        public string getMapString()
        {
            return MapArrayString;
        }

        public string GetCurrentDir()
        {
            return Directory.GetCurrentDirectory();
        }
        public void CreateSaveFolder()
        {
            string folderName = "MapSaves";
            string CurrentFolder = GetCurrentDir();
            string pathString = System.IO.Path.Combine(CurrentFolder, folderName);
            if (!Directory.Exists(pathString))
            {
                Directory.CreateDirectory(pathString);
            }
            SetSaveLocation();
        }

        public void SetSaveLocation()
        {
            string CurrentFolder = GetCurrentDir();
            SaveLocation = System.IO.Path.Combine(CurrentFolder, "MapSaves");
        }

        public string getSaveLocation()
        {
            return SaveLocation;
        }

        public void MapArrayToString()
        {
            string result = "";
            for(int y = 0; y < MapArray.GetLength(0); y++)
            {
                for(int x = 0; x < MapArray.GetLength(1); x++)
                {
                    result += MapArray[y,x].ToString();
                }

                if (y != MapArray.GetLength(0) - 1)
                {
                    result += ",";
                }
            }
            MapArrayString = result;
        }

        public void SaveMap(string name)
        {
            SetSaveLocation();
            MapArrayToString();
            System.IO.File.WriteAllText(System.IO.Path.Combine(SaveLocation, name), MapArrayString);
        }

        public string ReadFile(string fileName)
        {
            return System.IO.File.ReadAllText(System.IO.Path.Combine(SaveLocation, fileName));
        }

        public void SetFileString(string map)
        {
            FileString = map;
        }

        public int GetColSize()
        {
            string map = FileString;
            int count = 0;
            for(int x = 0; x <= map.Length-1; x++)
            {
                if(map[x] == ','|| map.Length-1 == x)
                {
                    count++;
                }
            }
            
            return count;
        }

        public int GetRowSize()
        {
            string map = FileString;
            int count = 0;
            foreach (char item in map)
            {
                if (item == ',')
                {
                   break;
                }
                count++;
            }
            return count;            
        }

        public void StringToArray()
        {
            string map = FileString;
            int col = GetRowSize();
            int row = GetColSize();
            char[,] mapArr = new char[row, col];
            int count = 0;
            for(int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (map[count] == ',')
                    {
                        count++;
                    }
                    mapArr[x, y] = map[count];
                    count++;
                }
            }
            this.MapArray = mapArr;
        }
        public bool CheckValidChar(char check)
        {
            Array Items = Enum.GetValues(typeof(Parts));
            foreach(Parts item in Items)
            {
                if(check == (char)item || check == ',' || check == '\0')
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckValidString(string check)
        {
            foreach(char item in check)
            {
                if(CheckValidChar(item) != true)
                {
                    return false;
                }
            }
            return true;
        }

       

        public bool CheckFileExists(string name)
        {
            return File.Exists(name);
        }
        
        public void LoadFile(string fileName)
        {
            SetSaveLocation();
            string LoadString;
            if(CheckFileExists(fileName))
            {
                LoadString = ReadFile(fileName);
                if(CheckValidString(LoadString))
                {
                    SetFileString(LoadString);
                    StringToArray();
                }
            }
        }
        public char[,] GetMap()
        {
            char[,] map = this.MapArray;
            return map;
        }


    }
}
