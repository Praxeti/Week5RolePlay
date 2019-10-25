using System;
namespace Week5RolePlay
{
     class Monster:Character
    {
        string fur;

        public Monster(decimal currentPosition, int health, int strength, int armour):base(currentPosition, health, strength, armour)
        {
            fur = "Brown";
        }

    }
}