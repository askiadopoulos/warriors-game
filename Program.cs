using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initiate the objects
            Warrior maximus = new Warrior("Maximus", 100, 80, 40);
            Warrior spartacus = new Warrior("Spartacus", 100, 80, 40);

            // Initiate the fight
            Battle.StartFight(maximus, spartacus);
        }
    }
}
