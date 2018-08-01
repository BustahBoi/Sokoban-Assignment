using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNS
{
    public enum Direction { Up, Down, Left, Right };
    //Filaable cant use t 
    public interface IGame
    {
        void Move(Direction moveDirection);
        int GetMoveCount();
        void Undo();
        void Restart();
        bool IsFinished();
       // void Load(string newLevel);
    }
}
