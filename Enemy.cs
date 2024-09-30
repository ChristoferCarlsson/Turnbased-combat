using System.Xml.Linq;

namespace Game
{
    public class Enemy
    {
        //We create and make the values public
        public String monster;
        public int attackMod;
        public int health;
        public Enemy()
        {
            //We set the values
            monster = "Goblin";
            attackMod = 2;
            health = 15;
        }

    }
}
