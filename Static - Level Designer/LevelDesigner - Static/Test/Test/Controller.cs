using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sokoban_FileHandler;

namespace Test
{

    public delegate void MapChangedHandler(object sender, MapChangedEventArgs e);
    public class MapChangedEventArgs : EventArgs
    {
        public Parts Part { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool setting { get; set; }
        public bool clear { get; set; }
        public bool check { get; set; }
    }
	
    public class Controller : ILevelDesignController
    {
        protected MapChangedHandler MapChanged;
        
        protected ILevelDesignView View;
        protected IMapEditor Model;
        protected Form Parent;
        
        public Controller(ILevelDesignView view, IMapEditor model)
        {
            View = view;
            Model = model;
            MapChanged = new MapChangedHandler(setMap);
            View.MapChanged += MapChanged;
        }

        private void setMap(object sender, MapChangedEventArgs e)
        {
            if (e.setting)
            {
                Model.setSize(e.x, e.y);
            } else if (e.check)
            {
                View.setErrors(Model.getErrors());
            }
            else
            {
                Model.setItem(e.Part);
                Model.placeItem(e.x, e.y);
            }
        }

        public string GetName()
        {
            return View.GetName();
        }

        public void Start(Form parent)
        {
            View.Start(parent);
        }

        public void Stop()
        {
            View.Stop();
        }

        public char[,] GetMap()
        {
            return Model.getMap();
        }

        public void Load(char[,] map)
        {
            Model.SetMap(map);
            View.Loaded(map);
        }
    }
}
