using System.Drawing;
using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using GameNS;


namespace FilerNS
{
    public class Filer : IFiler
    {
        
        public string LevelName;
        public Filer()
        {
        }

        public string Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] result = File.ReadAllLines(fileName);
                string myString = string.Join("", result);
                string text = myString.Replace("\"", "");
                return text;
            }
            else
            {
                throw (new Exception("The file don't exist!"));
            }

        }
       
        public void Save(string filename, GameNS.Game callMeBackforDetails)
        {
            int rowMax = callMeBackforDetails.GetRowCount();
            int colMax = callMeBackforDetails.GetColumnCount();
            List<MapItem> CurrentGame = callMeBackforDetails.GetMap().Items;
            List<char> parts = new List<char>();
            foreach(MapItem item in CurrentGame)
            {
                parts.Add(item.Sign);
            }
            char[] lines = parts.ToArray();
            string result = "";
            if (!File.Exists(filename))
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    string str = "";
                    foreach (char line in lines)
                    {
                        result += line;
                    }
                    int chunkSize = colMax;
                    int resultLength = result.Length;
                    for (int i = 0; i < resultLength; i += chunkSize)
                    {
                     str += result.Substring(i, chunkSize) + ",";
                    }
                    outputFile.WriteLine(str.TrimEnd(','));
                }
            }

        }
    }
}
