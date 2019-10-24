using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsGame
{
    // Utility class that includes static methods
    class Battle
    {
        // TODO

        // Start the fight between the two warriors
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            // Loop giving each warrior a chance to attack
            // and block each turn until someone dies

            // We don't know when the loop is going to end
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over" || GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // Calculate one warrior's attack and the other's block
        private static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            // Get random values for attack and block
            double warriorA_attackAmount = warriorA.Attack();
            double warriorB_blockAmount = warriorB.Block();

            // calculate the net damage of a warrior by subtracting
            // the amount of block from the amount of attack
            double damage2WarriorB = warriorA_attackAmount - warriorB_blockAmount;

            // If there was any damage, update warrior's health
            warriorB.Health -= damage2WarriorB > 0 ? damage2WarriorB : damage2WarriorB = 0;

            // Print out info on who attacked whom and for how much damage
            Console.WriteLine($"{warriorA.Name} Attacks {warriorB.Name} and Deals {damage2WarriorB} Damage");

            // Provide output on the change in health
            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

            // Check if warrior's health fell below 0 and if so, print a
            // message and then send a respond that will end the loop (fight)
            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has Died and {warriorA.Name} is Victorious\n");
                return "Game Over";
            }
            else
                return "Fight Again";
        }

    }
}
