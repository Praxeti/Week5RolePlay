namespace Week5RolePlay
{
    abstract class Character
    {


       protected decimal currentPosition; 
       protected int health;

       protected int strength;

       protected int armour;

       public Character()
       {
           currentPosition = 0m;
           health = 0;
           strength = 0;
           armour = 0;
       }
 public decimal CurrentPosition
    {
        get
        {
            return currentPosition;
        }
    }

    }
}