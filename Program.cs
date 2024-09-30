using System.Numerics;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings!");

            //We set things such as name and class
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("Are you a Warrior or a Rogue?");
            String className = Console.ReadLine();

            //We create the player and the enemy
            Player player = new Player(name, className);
            Enemy enemy = new Enemy();

            //We create the random number generator
            Random rnd = new Random();

            //We add a sleep counter for dramatic effect and readability
            Console.WriteLine("A Goblin has appeared!");
            Thread.Sleep(1000);

            //As long as the player or the enemy is still alive, the battle continues
            while (player.health > 0 || enemy.health > 0)
            {

                Console.WriteLine("Press enter to attack!");
                Console.ReadLine();

                //We make the attack roll and run it through the attack function
                int attack = rnd.Next(1, 20);
                int damageDone = Attack(player.name, player.attackMod, attack, player.health);

                //We reduce the enemies health with the damage and display it
                enemy.health = enemy.health - damageDone;
                Thread.Sleep(2000);
                Console.WriteLine($"{enemy.monster} takes {damageDone} damage");
                Thread.Sleep(2000);

                //If the enemy has died, the loop breaks
                if (enemy.health < 1)
                {
                    Console.WriteLine($"{enemy.monster} Has died");
                    break;
                }

                //The enemy makes the attack roll and run it through the same function
                int enemyAttack = rnd.Next(1, 20);
                int damageTaken = Attack(enemy.monster, enemy.attackMod, enemyAttack, enemy.health);

                //We reduce the players health with the damage and display it
                player.health = player.health - damageTaken;
                Thread.Sleep(2000);
                Console.WriteLine($"{player.name} takes {damageTaken} damage");
                Thread.Sleep(2000);

                //If the player has died, the loop breaks
                if (player.health < 1)
                {
                    Console.WriteLine($"{player.name} Has died");
                    break;
                }
            }


        }
        static int Attack(string Name,int AttackMod, int Damage, int Health)
        {
            //We have made it so that the player and enemy can use the same function for attack
            Console.WriteLine($"{Name} health is at {Health}");
            Thread.Sleep(2000);
            Console.WriteLine($"{Name} attacks for {Damage + AttackMod} health");

            //We return the damage made
            return Damage + AttackMod;
        }
    }
}
