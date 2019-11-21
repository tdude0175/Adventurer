using System;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace AdventureGame
{    class Monster
    {
        public string monsterName;
        public int attack = 30;
        public int defense = 10;
        public int health = 100;
        public int EXP = 0;

        public Monster(string Name, int EXP, int att, int def , int hp)
        {
            this.monsterName = Name;
            this.attack = att;
            this.defense = def;
            this.EXP = EXP;
            this.health = hp;
        }

        public void MonsterStats()
        {
            Console.WriteLine(this.monsterName);
            Console.WriteLine($"Monster Health:{this.health}");
            Console.WriteLine($"Attack:{this.attack} Defense:{this.defense}");
            Console.WriteLine("");

        }
    }


    class Program
    {
        public static bool Battling = false;
        static void Main(string[] args)
        {

           
            /*
            This Code is for connecting to the database where we are going to save the data for the game info. 
            REMEMBER TO PUT PASSWORD IN BEFORE YOU USE THIS. 

            MySqlConnection conn = new MySqlConnection("server=localhost;user=thomas;password=;Database=Adventurer;");
            conn.Open();
            MySqlCommand query = new MySqlCommand("Select * from Adventurers",conn);
            MySqlDataReader runIt = query.ExecuteReader();
            while(runIt.Read())
            {
                Console.WriteLine(runIt[0]);
            }
            conn.Close();
            */

            Console.WriteLine("Welcome To Adventurer");
            Console.WriteLine("Please Enter your username");
            var userId = Console.ReadLine();
            // ToDo Make switch case for skills to show off and use, Can you use an array/List?
            // Console.WriteLine("Pick your Skills");
            // Console.ReadLine();
            Console.WriteLine("Here are your stats");
            var player = new Character(userId);
            player.PrintStats();
            Console.ReadLine();
            Console.Clear();

            for(int i = 0; i < 10; i++)
            {
                var randMon = new Random();
                int whichMon = randMon.Next(3);
                Console.WriteLine(whichMon);
                 var monsterOne = new Monster("bat",2,5,3,40);
                // Fighting a monster function to run while fighting a monster
            Console.WriteLine($"you Encounter a {monsterOne.monsterName}!");
            Battling = true;
            while(Battling)
            {
                var defending = false;
                player.PrintStats();
                monsterOne.MonsterStats();
                Console.WriteLine("what do you do?");
                Console.WriteLine("1:Attack 2:Defend 3: Run");
                var action = Console.ReadLine();
                if(action == "1")
                {
                    // Console.WriteLine("attacking");
                    int damage = Skill.Attack(player.attack,monsterOne.defense);
                    Console.WriteLine($" You Dealt {damage} Damage!");
                    monsterOne.health = monsterOne.health - damage;
                }
                else if(action == "2")
                {
                    defending = true;
                }
                else if (action == "3")
                {
                    Console.WriteLine("Running");
                    bool madeit = Skill.Run();
                    if(madeit == true)
                    {
                        Console.WriteLine("You got away!");
                        Battling = false;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("They Caught up!");
                    }
                }
                 if(monsterOne.health <= 0)
                {
                    Console.WriteLine("You Won!");
                    player.EXP = player.EXP + monsterOne.EXP;
                    Console.WriteLine($" Exp points:{player.EXP}");
                    Console.ReadLine();
                    Console.Clear();
                    Battling = false;
                }
                else{
                if(defending)
                {
                    // Console.WriteLine("defending");
                    int monsterDamage = Skill.Defend(player.defense, monsterOne.attack);
                    Console.WriteLine($" you took {monsterDamage} points of damage!");
                    player.health = player.health - monsterDamage;
                    Console.ReadLine();
                    Console.Clear();
                }else
                {
                    int monsterDamage = Skill.Attack(monsterOne.attack,player.defense);
                    Console.WriteLine($" you took {monsterDamage} points of damage!");
                    player.health = player.health - monsterDamage;
                    Console.ReadLine();
                    Console.Clear();
                }
                if(player.health <= 0)
                {
                    Console.WriteLine("game over!");
                    Battling = false;
                    Console.ReadLine();
                }
                }
            }

            if(player.health <= 0)
            {
                break;
            }
            }   
        }
    }
}
