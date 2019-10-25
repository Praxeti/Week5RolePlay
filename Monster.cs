using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Week5RolePlay
{
    public class Monster:GameObject
    {
        
 Random rnd = new Random();

        private int health;

        public Monster(int _positionX, int _positionY, string _sprite) : base(_positionX, _positionY, _sprite)
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

        public void Update()
        {
            int monstermovement = rnd.Next(1, 5);

            if (monstermovement == 1)
            {
                MoveLeft();
            }

            if (monstermovement == 2)
            {
                MoveRight();
            }

            if (monstermovement == 3)
            {
                MoveUp();
            }
            if (monstermovement == 4)
            {
                MoveDown();
            }
        }


    }
}
