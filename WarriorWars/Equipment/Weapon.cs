using System;
using WarriorWars.Enum;
namespace WarriorWars.Equipment
{
    class Weapon
    {
        private int damage;
        private int GOOD_GUY_DAMAGE;
        private int BAD_GUY_DAMAGE;
        private int ORC_DAMAGE;
        static Random rng = new Random();

        public int Damage 
        {
            get 
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    int randNum = rng.Next(6, 9);
                    GOOD_GUY_DAMAGE = randNum;
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    randNum = rng.Next(6, 9);
                    BAD_GUY_DAMAGE = randNum;
                    damage = BAD_GUY_DAMAGE;
                    break;
                case Faction.Orc:
                    randNum = rng.Next(5, 11);
                    ORC_DAMAGE = randNum;
                    damage = ORC_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
