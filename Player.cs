using System;
namespace Week5RolePlay
{
     class Player:Character
    {
        string classe;
        public Player(decimal currentPosition, int health, int strength, int armour):base(currentPosition, health, strength, armour)
        {
            classe = "Normal Person";
        }

    }
}