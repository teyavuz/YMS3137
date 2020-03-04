using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game(1, "Counter Strike", "Multiplayer", true);
            //Game g2 = new Game(1, "Counter Strike", "Multiplayer", true);
            Game g2 = (Game)g1.Clone();




        }
    }
}
