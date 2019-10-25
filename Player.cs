using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week5RolePlay
{
    public class Player:GameObject
    {
        
   private int health;
        //int x = 3, y = 2;
        private static Random rng = new Random();
        private int direction = 1;

        public Player(int _positionX, int _positionY, string _sprite): base (_positionX, _positionY, _sprite)
        {

            health = 100;
        }

        /* or this 
                public Player(int _positionX, int _positionY, string _sprite)
        {
            positionX = _positionX;
            positionY = _positionY;
            sprite = _sprite;
            health = 100;
        } */

        public void MoveLeft()
        {
            positionX -= 1;

        }

        public void MoveRight()
        {
            positionX += 1;
        }
        public void MoveUp()
        {
            positionY -= 1;
        }
        public void MoveDown()
        {
            positionY += 1;
        }

        public void Update(ConsoleKeyInfo keypressed, Map map)
        {
            if (keypressed.Key == ConsoleKey.LeftArrow)
            {
                if (positionX >= 1)
                {
                    if (map.loadedmap [positionX - 1, positionY] ==' ')
                    {
                         MoveLeft();
                    }
                   
                }
            }
            else if (keypressed.Key == ConsoleKey.RightArrow)
            {
                if (positionX < Console.WindowWidth - 20)
                {
                    if (map.loadedmap[positionX + 1, positionY] == ' ')
                    {
                        MoveRight();
                    }
                }
            }
            else if (keypressed.Key == ConsoleKey.UpArrow)
            {
                if (positionY >= 1)
                {
                    if (map.loadedmap[positionX , positionY - 1] == ' ')
                    {
                        MoveUp();
                    }
                }
            }
            else if (keypressed.Key == ConsoleKey.DownArrow)
            {
                if (positionY < Console.WindowHeight - 2)
                {
                    if (map.loadedmap[positionX, positionY + 1] == ' ')
                    {
                        MoveDown();
                    }
                }
            }

            //foreach (char Player in mapText)
            //{
            //    if (cell == 1)
            //    {

            //    }
            //}
        }

        public void Draw()
        {
            Console.SetCursorPosition(20, 1);
            Console.Write("Player position {0} {1}", positionX, positionY);

            Console.SetCursorPosition(20, 3);
            Console.Write("Next position {0} {1}", positionX+1, positionY+1);


            base.Draw();
        }

        public void Update()
        {
            direction = rng.Next(1, 5);
            switch (direction)
            {
                case 1:
                    if (positionY + 1 < 70) positionY++;
                    break;
                case 2:
                    if (positionY - 1 > 0) positionY--;
                    break;
                case 3:
                    if (positionX + 1 < 80) positionX++;
                    break;
                case 4:
                    if (positionX - 1 > 20) positionX--;
                    break;
                default:
                    break;
            }

        }
        }

}
