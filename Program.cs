using System;
using System.Collections.Generic; //for lists

namespace Week5RolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Character> characters = new List<Character>();   

                 characters.Add (new Player(50m, 100, 22, 18));
                 characters.Add (new Monster(60m, 100, 22, 18));

                foreach (Character character in characters)
                {
                     Console.WriteLine($"Person is at {character.currentPosition} {character.Health} {character.Strength} {character.Armour} ");
                }




        }
    }
}
