using System;
namespace Week5RolePlay
{
     class Player:Character
    {
        string classe;
        public Player(decimal currentPosition):base(currentPosition)
        {
            classe = "Normal Person";
        }

    }
}