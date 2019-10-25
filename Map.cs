using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Week5RolePlay
 
{
  public  class Map
    {

        public char[,] loadedmap = new char[121, 121];
        public void Test()
        {
            string mapText = System.IO.File.ReadAllText("map1.txt");

            Console.WriteLine(mapText);

          
            int x = 0;
            int y = 0;

            foreach (char cell in mapText)
            {
    

                if (cell == '\r')
                {
                    //Do nothing
                }
                else if (cell == '\n')
                {
                    y++;
                    x = 0;
                }


                else
                {


                    loadedmap[x, y] = Convert.ToChar(cell.ToString());
                    x++;
                }
            }





        }
    }
}
