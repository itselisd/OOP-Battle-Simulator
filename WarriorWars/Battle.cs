using System;
using System.Threading;

namespace WarriorWars
{
    static class Battle
    {
        static Random rng = new Random();

        public static void startBattle(Warrior warrior1, Warrior warrior2) 
        {
            while(warrior1.IsAlive && warrior2.IsAlive) 
            {
                if(rng.Next(0, 10) < 5)
                {
                    warrior1.Attack(warrior2);
                }
                else 
                {
                    warrior2.Attack(warrior1);
                }
                Thread.Sleep(150);
            }     
        }
    }
}
