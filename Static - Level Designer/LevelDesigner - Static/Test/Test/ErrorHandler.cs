using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ErrorHandler : IErrorHandler
    {
        private string[] Errors { get; set; }
        private char[,] Map { get; set; }

        public void mapErrors(char[,] map)
        {
            //input the map array when implementing the class
            Map = map;
            Errors = new string[4];
        }

        private bool playerExist()
        {
            //if player count invalid return error message
            if((itemCount((char)Parts.Player) + (itemCount((char)Parts.PlayerOnGoal))) < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool playerTooMany()
        {
            if((itemCount((char)Parts.Player)+(itemCount((char)Parts.PlayerOnGoal))) > 1)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private bool goalsNotEnough()
        {
            //if there are enough blocks for goals then true
            if((itemCount((char)Parts.Goal)+(itemCount((char)Parts.PlayerOnGoal)) + (itemCount((char)Parts.BlockOnGoal))) > (itemCount((char)Parts.Block) + (itemCount((char)Parts.BlockOnGoal))))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int itemCount(char part)
        {
            int count = 0;
            foreach (char item in Map)
            {
                if (item == part)
                {
                    count += 1;
                }
            }
            return count;
        }

        private bool goalsNone()
        {
            if((itemCount((char)Parts.Goal)+(itemCount((char)Parts.PlayerOnGoal)) + (itemCount((char)Parts.BlockOnGoal))) < 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void errorCheck()
        {
            if(!playerExist())
            {
                Errors[0] = "No player present";
            }
            if(!playerTooMany())
            {
                Errors[1] = "Too many players exist";
            }
            if(!goalsNotEnough())
            {
                Errors[2] = "Not enough blocks";
            }
            if(goalsNone())
            {
                Errors[3] = "There are no goals";
            }

        }

        public string[] getErrors()
        {
            return Errors;
        }
        
    }
}
