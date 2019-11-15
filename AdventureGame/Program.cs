using System;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace AdventureGame
{    class Monster
    {
        public string userName;
        public int attack = 30;
        public int defense = 10;
        public int health = 100;
        public int EXP = 0;
    }


    class Program
    {
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
            Console.WriteLine("Here are your stats");
            var player = new Character(userId);
            player.PrintStats();
            
        }
    }
}
