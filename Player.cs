using System.Xml.Linq;

namespace Game
{
    public class Player
    {
        //We create and make the values public
        public String name;
        public String className;
        public int attackMod;
        public int health;
        public Player(String Name, String ClassName)
        {
            //We set the values
            name = Name;
            className = ClassName;

            //Depending on the players choice, some values will be different
            if (className == "Warrior" || className == "warrior")
            {
                attackMod = 2;
                health = 20;
            }
            else if (className == "Rogue" || className == "rogue")
            {
                attackMod = 5;
                health = 15;
            }
            else
            {
                Console.WriteLine("No such class exist");
                return;
            }
        }

    }
}
