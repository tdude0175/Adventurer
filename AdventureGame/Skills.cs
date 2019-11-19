using System;


namespace AdventureGame
{
    public class Skill{
        public static int Attack(int attackStat , int defenseStat)
        {
            if(attackStat - defenseStat > 0)
            return(attackStat - defenseStat);
            else
            {
                return(0);
            }
        }
        public static int Defend(int defenseStat , int attackStat)
        {
            if(attackStat - (defenseStat+ defenseStat/2) > 0)
            {
                return(attackStat - (defenseStat+ defenseStat/2));
            }
            else
            {
                return(0);
            }
            
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