using System;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace AdventureGame
{
    class Character
    {
        string userName;
        int attack = 30;
        int defense = 10;
        int health = 100;
        object Armor;
        object Weapon;
        object SkillOne;
        object SkillTwo;
        object SkillThree;
        int EXP = 0;
        int Level = 1;
        Character(string name)
        {
            this.userName = name;

        }
    }

    class Monster
    {

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
            Console.WriteLine("Please Enter your username or Id");
            var userId = Console.ReadLine();
            Console.WriteLine(userId);
        }
    }
}
