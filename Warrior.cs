using System;

namespace WarriorsGame
{
    class Warrior
    {
        // Properties initiated with default values
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // TODO

        // Random numbers
        private readonly Random rnd = new Random();

        // Parameter Constructor
        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Attack
        // Generate random attack from one to the maximum attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        // Block
        // Generate random block from one to the maximum block value
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
