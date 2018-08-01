using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilerNS;

namespace GameNS
{
    public class Game : IGame
    {
        private string[] Level { get; set; }
        private Map Map; 
        private List<Direction> PlayerMoves = new List<Direction>();
        private int MoveCount = 0;
        private List<bool> BoxMoved = new List<bool>();


        public Map GetMap()
        {
            return Map;
        }

        public void SetLevel(string[] level)
        {
            Level = level;
        }

        public MapItem FindPlayer()
        {
           return ( from x in Map.Items where (x.Sign == (char)Parts.Player || x.Sign == (char)Parts.PlayerOnGoal)  select x).FirstOrDefault();
        }

        public int GetColumnCount()
        {           
            return Level.Length;
        }

        public int GetRowCount()
        {
            return Level[0].Length;
        }

        public int GetMoveCount()
        {
            return MoveCount;
        }

        public string GetMoveHistory()
        {
            string MoveHistory = "";
            int length = PlayerMoves.Count();
            if (length <= 5)
            {
                MoveHistory = string.Join(",", PlayerMoves.ToArray());
            }
            else
            {
                
                MoveHistory = string.Join(",", PlayerMoves.GetRange(length - 5, 5).ToArray());
            }
            
            return MoveHistory;
        }

        public bool IsFinished() 
        {
            int boxOnGoalCount = Map.Items.Where( x => x.Sign.Equals('*')).Count();
            int GoalsCount = Map.Items.Where( x => x.Sign.Equals('.')).Count();
            int PlayerOnGoalCount = Map.Items.Where(x => x.Sign.Equals('+')).Count();

            return boxOnGoalCount >= 1 && GoalsCount == 0 && PlayerOnGoalCount == 0;          
        } 



        public void Move(Direction moveDirection) 
        {
            var player = this.FindPlayer();
            var x = player.CordX; 
            var y = player.CordY;
            int toX = 0; 
            int pastToX = 0; 
            int toY = 0; 
            int pastToY = 0;

            switch (moveDirection)
            {
                case Direction.Up:
                    toX = x - 1; 
                    pastToX = x - 2; 
                    toY = y; 
                    pastToY = y;
                    break;
                case Direction.Down:
                    toX = x + 1;
                    pastToX = x + 2;
                    toY = y;
                    pastToY = y;
                    break;
                case Direction.Right:
                    toX = x;
                    pastToX = x;
                    toY = y + 1;
                    pastToY = y + 2;
                    break;
                case Direction.Left:
                    toX = x;
                    pastToX = x;
                    toY = y - 1;
                    pastToY = y - 2;
                    break;
                default:
                    break;
            }
            this.MovePlayer(player, toX, pastToX, toY, pastToY);
            this.PlayerMoves.Add(moveDirection);
            


        }

        private void MovePlayer(MapItem player,int toX, int afterToX, int toY, int afterToY)
        {
            if (toX >= 0) 
            {
                if (this.WhatsAt(toX, toY) == Parts.Empty)
                {
                    if(player.Sign == '+')
                    {
                        this.Map.Update(player.CordX, player.CordY, (char)Parts.Goal);
                    }
                    else
                    {
                        this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty);
                    }
                    this.Map.Update(toX, toY, (char)Parts.Player);
                    this.BoxMoved.Add(false);
                }
                else if ((WhatsAt(toX, toY) == Parts.Block || WhatsAt(toX, toY) == Parts.BlockOnGoal) && (afterToX >= 0)) 
                {
                    if (WhatsAt(afterToX, afterToY) == Parts.Empty)
                    {
                        if (WhatsAt(toX, toY) == Parts.BlockOnGoal)
                        {
                            this.Map.Update(toX, toY, (char)Parts.PlayerOnGoal);
                        }
                        else
                        {
                            this.Map.Update(toX, toY, player.Sign);
                        }
                        this.Map.Update(afterToX, afterToY, (char)Parts.Block);
                        this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty); 
                    }
                    else if (WhatsAt(afterToX, afterToY) == Parts.Goal) 
                    {
                        if (WhatsAt(toX, toY) == Parts.BlockOnGoal)
                        {
                            this.Map.Update(toX, toY, (char)Parts.PlayerOnGoal);
                        }
                        else
                        {
                            this.Map.Update(toX, toY, player.Sign);
                        }
                        this.Map.Update(afterToX, afterToY, (char)Parts.BlockOnGoal);
                        this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty);
                    }
                    this.BoxMoved.Add(true);
                }
                else if (WhatsAt(toX, toY) == Parts.Goal) 
                {
                    this.Map.Update(toX, toY, (char)Parts.PlayerOnGoal);
                    this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty);
                    this.BoxMoved.Add(false);
                }
                this.MoveCount++;
            }
        }

        public void Restart()
        {
            this.Map.ResetMap(Level);
            PlayerMoves = new List<Direction> { };
            BoxMoved = new List<bool> { };
            MoveCount = 0;
        }

        public void Undo() 
        {
            var player = this.FindPlayer();
            var x = player.CordX; 
            int y = player.CordY;
            int newPosX; 
            int inFrontOfX; 
            int newPosY; 
            int inFrontOfY;

            if (PlayerMoves.Count >= 1)
            {
                Direction lastMove = PlayerMoves.Last(); 
                if (lastMove == Direction.Up)
                {
                    newPosX = x + 1;
                    inFrontOfX = x - 1;
                    newPosY = y;
                    inFrontOfY = y;
                    UndoMove(player, newPosX, newPosY, inFrontOfX, inFrontOfY);
                }
                else if (lastMove == Direction.Down) 
                {
                    newPosX = x - 1;
                    inFrontOfX = x + 1;
                    newPosY = y;
                    inFrontOfY = y;
                    UndoMove(player, newPosX, newPosY, inFrontOfX, inFrontOfY);
                }
                else if (lastMove == Direction.Left) 
                {
                    newPosY = y + 1;
                    inFrontOfY = y - 1;
                    newPosX = x;
                    inFrontOfX = x;
                    UndoMove(player, newPosX, newPosY, inFrontOfX, inFrontOfY);
                }
                else
                {
                    newPosY = y - 1;
                    inFrontOfY = y + 1;
                    newPosX = x;
                    inFrontOfX = x;
                    UndoMove(player, newPosX, newPosY, inFrontOfX, inFrontOfY); 
                }
                PlayerMoves.RemoveAt(PlayerMoves.Count - 1);
                BoxMoved.RemoveAt(BoxMoved.Count - 1);
                MoveCount -= 1; 
            }
        }

        private void UndoMove(MapItem player, int newX, int newY, int inFrontX, int inFrontY)
        {

            if (((BoxMoved[BoxMoved.Count() - 1] == false) && (this.WhatsAt(inFrontX, inFrontY) == Parts.Block || WhatsAt(inFrontX, inFrontY) == Parts.BlockOnGoal)) || this.WhatsAt(inFrontX, inFrontY) == Parts.Empty || this.WhatsAt(inFrontX, inFrontY) == Parts.Wall) //if no object infront of player, just move player back
            {
                if (WhatsAt(newX, newY) == Parts.Goal) 
                {
                    Map.Update(newX, newY, (char)Parts.PlayerOnGoal); 

                }
                else
                {
                    this.Map.Update(newX, newY, (char)Parts.Player); 
                }
                this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty); 
            }
            else if ((WhatsAt(inFrontX, inFrontY) == Parts.Block || WhatsAt(inFrontX, inFrontY) == Parts.BlockOnGoal) && (BoxMoved[BoxMoved.Count()-1] == true)) 
            {
                if (WhatsAt(player.CordX, player.CordY) == Parts.PlayerOnGoal) 
                {
                   
                    if (WhatsAt(newX, newY) == Parts.Goal) 
                    {
                        this.Map.Update(newX, newY, player.Sign);
                    }
                    else
                    {
                        this.Map.Update(newX, newY, (char)Parts.Player); 
                    }
                    if (WhatsAt(inFrontX, inFrontY) == Parts.Block)
                    {
                        this.Map.Update(inFrontX, inFrontY, (char)Parts.Empty); 
                    }
                    else
                    {
                        this.Map.Update(inFrontX, inFrontY, (char)Parts.Goal);
                    }
                    this.Map.Update(player.CordX, player.CordY, (char)Parts.BlockOnGoal); 
                }
                else 
                {
                    if (WhatsAt(newX, newY) == Parts.Goal) 
                    {
                        this.Map.Update(newX, newY, player.Sign); 
                    }
                    else
                    {
                        this.Map.Update(newX, newY, (char)Parts.Player); 
                    }
                    if (WhatsAt(inFrontX, inFrontY) == Parts.Block)
                    {
                        this.Map.Update(inFrontX, inFrontY, (char)Parts.Empty); 
                    }
                    else
                    {
                        this.Map.Update(inFrontX, inFrontY, (char)Parts.Goal);
                    }
                    this.Map.Update(player.CordX, player.CordY, (char)Parts.Block);

                }

            }
            else if (WhatsAt(inFrontX, inFrontY) == Parts.Goal)
            {
                if (WhatsAt(player.CordX, player.CordY) == Parts.PlayerOnGoal) 
                {

                    this.Map.Update(player.CordX, player.CordY, (char)Parts.Goal); 

                }
                else 
                {
                    this.Map.Update(player.CordX, player.CordY, (char)Parts.Empty); 
                }

                if (WhatsAt(newX, newY) == Parts.Goal) 
                {
                    this.Map.Update(newX, newY, (char)Parts.PlayerOnGoal);
                }
                else
                {
                    this.Map.Update(newX, newY, (char)Parts.Player); 
                }
            }
            
        }

        public Parts WhatsAt(int row, int column)  
        {
            int colCount = GetColumnCount();
            var item = Map.Items[row*colCount + column]; 
            switch (item.Sign)
            {
                case '#':
                    return Parts.Wall;
                            
                case '$':
                    return Parts.Block;
                            
                case '+':
                    return Parts.PlayerOnGoal;
                            
                case '@':
                    return Parts.Player;
                           
                case ' ':
                    return Parts.Empty;
                            
                case '.':
                    return Parts.Goal;
                            
                case '*':
                    return Parts.BlockOnGoal;

                default:
                    return Parts.Empty;                       
            }
             
        }

        public List<MapItem> MakeMap() 
        {
            this.Map = new Map(Level);
            return Map.Items;
        }
    }
}




