using System;


namespace AdventureGame
{
    public class Skill{
        public static int Attack(int attackStat , int defenseStat)
        {
            return(attackStat - defenseStat);
        }
        public static int Defend(int defenseStat , int attackStat)
        {
            return((defenseStat+ defenseStat/2) - attackStat);
        }

        public static bool Run()
        {
            var runChance = new Random();
            int didYouMakeIt = runChance.Next(100);
            if(didYouMakeIt > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}