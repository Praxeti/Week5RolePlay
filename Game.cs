using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Week5RolePlay
{
    public class Game
    {
      GameObject backgroundObject01 = new GameObject(4, 5, "x");
        Player player1 = new Player(0, 0, "█");
        Monster monster1 = new Monster(12, 15, "^");
 
        Map map1 = new Map();

        private bool playing = true;

        public void Run()
        {
            Initialise();

            while (playing)
            {
                Update();
                Draw();
            }
        }

        public void Initialise()
        {
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey(); //Anything which is teal is a class/method */



        }

        public void Update()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keypressed = Console.ReadKey(true);
                player1.Update(keypressed, map1);
            }

            monster1.Update();
        }

        public void Draw()
        {
            Console.CursorVisible = false;
            Console.Clear();
            map1.Test();
            backgroundObject01.Draw();
            player1.Draw();
            //enemy1.Draw();
            Thread.Sleep(50);

        }
    }
}
