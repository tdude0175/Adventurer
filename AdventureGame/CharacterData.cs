using System;

namespace AdventureGame
{
    
    public class Character
    {
        public string userName;
        public int attack = setStats(10,20);
        public int defense = setStats(0,5);
        public int health = setStats(50,100);

        public int currentHealth ;
        public object Armor;
        public object Weapon;
        public object SkillOne;
        public object SkillTwo;
        public object SkillThree;
        public int EXP = 0;
        public int Level = 1;
        public Character(string name)
        {
            this.userName = name;
            this.currentHealth = this.health;

        }
        public static int setStats(int minimum_num,int maximum_num)
        {
            var randStat = new Random();
            int returnNumber = randStat.Next(minimum_num,maximum_num+1);
            return(returnNumber);
        }
        public void PrintStats()
        {
            Console.WriteLine(this.userName);
            Console.WriteLine($"Level:{this.Level} Exp:{this.EXP}");
            Console.WriteLine($"Attack:{this.attack} Defense:{this.defense} Health:{this.currentHealth}/{this.health}");
            Console.WriteLine($"Skill One:{this.SkillOne} Skill Two:{this.SkillTwo} Skill Three:{this.SkillThree}");
            Console.WriteLine("");
        }
    }
}