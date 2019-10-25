namespace Week5RolePlay
{
    abstract class Character
    {


       public decimal currentPosition; 
       protected int health;

       protected int strength;

       protected int armour;

       public Character(decimal currentPosition, int health, int strength, int armour)
       {
           this.currentPosition = currentPosition;
           this.health = health;
           this.strength = strength;
           this.armour = armour;
       }
 public decimal CurrentPosition
    {
        get
        {
            return currentPosition;
        }
    }

public int Health
    {
        get
        {
            return health;
        }
    }

public int Strength
    {
        get
        {
            return strength;
        }
    }

public int Armour
{
    get
    {
        return armour;
    }
}
    }
}