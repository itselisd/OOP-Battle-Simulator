using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joe", Faction.BadGuy);
            Battle.startBattle(goodGuy, badGuy);

            goodGuy = new Warrior("Dingo", Faction.GoodGuy);
            Warrior orc = new Warrior("Teenus", Faction.Orc);
            Battle.startBattle(goodGuy, orc);
        }
    }
}
