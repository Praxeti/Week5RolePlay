using System;
using System.Collections.Generic; //for lists

namespace Week5RolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
    List<Character> person = new List<Character>();   

    person.Add (new Player(50m));

foreach (Player people in person)
{
    Console.WriteLine($"Person is at {people.currentPosition} ");
}


     }
    }
}
