using WarriorWars.Enum;
namespace WarriorWars.Equipment
{
    class Armor
    {
        private int armorPoints;
        private const int GOOD_GUY_ARMOR = 4;
        private const int BAD_GUY_ARMOR = 4;
        private const int ORC_ARMOR = 3;

        public int ArmorPoints 
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                case Faction.Orc:
                    armorPoints = ORC_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}