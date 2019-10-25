using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Week5RolePlay
{
    public class GameObject
    {
     protected int positionX;
        protected int positionY;
        protected string sprite;

        public GameObject(int _positionX, int _positionY, string _sprite) //Constructor
        {
            this.positionX = _positionX;
            this.positionY = _positionY;
            this.sprite = _sprite;
        }

        public void Draw()
        {

                Console.SetCursorPosition(positionX, positionY);
                Console.Write(sprite);
        }


            /*public void Draw(int positionX, int positionY, string sprite, ConsoleColor colour)
            {
                Console.ForegroundColor = colour;
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(sprite);
                Console.ForegroundColor = ConsoleColor.Gray;
            }*/
        }
    }

