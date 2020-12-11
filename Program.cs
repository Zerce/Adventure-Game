/*
 * A text adventure game 
 * By Rigoberto Cervantes
 * 12/08/2020
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdventureGameR5
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;
        static void Main(string[] args)
        {
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }
            currentPlayer = Load(out bool newP);
            if (newP)
                Encounters.FirstEncounter2();
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }

        }

       
    
        static Player NewStart(int i)
        {
            Console.Clear();
            Player p = new Player();
            WriteLine("Relive");
            WriteLine("The adventure to the Unknow World of Spirit");
            WriteLine("Name");
            p.name = Console.ReadLine();
            Console.WriteLine("Class: Power  Hope  Lost");
            bool flag = false;
            while (flag == false)
            {
                flag = false;
                string input = Console.ReadLine().ToLower();
                if (input == "Power")
                    p.currentClass = Player.PlayerClass.Power;
                else if (input == "Hope")
                    p.currentClass = Player.PlayerClass.Hope;
                else if (input == "Lost")
                    p.currentClass = Player.PlayerClass.Lost;
                else
                {
                    Console.WriteLine("Choose your spirit.");
                    Console.ReadKey();
                    flag = true;
                }
            }
            p.id = i;
            Clear();
            WriteLine("You have just wokeup in the forset. You feel lost and having issue remebering ");
            WriteLine(" Who you are and where you came from. You know so far your name is, wait what's your name? ");
            if (p.name == "")
                WriteLine("You try to think and try to think a name for youself...");
            else
                WriteLine("You know your name is " + p.name);
            ReadKey();
            ReadKey();
            WriteLine("Yo walk around the forest you see a door. You feel some resistance as ");
            WriteLine("you wokeup again, you see your captor ");
            WriteLine("standing and looking at you ");
            return p;
        }

        public static void Quit()
        {
            Saves();
            Environment.Exit(0);
        }
        public static void Saves()
        {
            BinaryFormatter binForm = new BinaryFormatter();
            string path = "saves/" + currentPlayer.id.ToString() + ".level";
            FileStream file = File.Open(path, FileMode.OpenOrCreate);
            binForm.Serialize(file, currentPlayer);
            file.Close();
        }

        public static Player Load(out bool newP)
        {
            newP = false;
            Console.Clear();
            string[] paths = Directory.GetFiles("saves");
            List<Player> players = new List<Player>();
            int idCount = 0;

            BinaryFormatter binForm = new BinaryFormatter();
            foreach (string p in paths)
            {
                FileStream file = File.Open(p, FileMode.Open);
                Player player = (Player)binForm.Deserialize(file);
                file.Close();
                players.Add(player);
            }

            idCount = players.Count;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("choose your player:");

                foreach (Player p in players)
                {
                    Console.WriteLine(p.id + ":" + p.name);
                }
                Console.WriteLine("Please input player name or id (id:# or playername). Additionally, 'create' will start a new save!");
                string[] data = Console.ReadLine().Split(':');

                try
                {
                    if (data[0] == "id")
                    {
                        if (int.TryParse(data[1], out int id))
                        {
                            foreach (Player player in players)
                            {
                                if (player.id == id)
                                {
                                    return player;
                                }

                            }
                            Console.WriteLine("There is no player with that id!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your Id needs to be a number! Press any key to continue!");
                        }

                    }
                    else if (data[0] == "create")
                    { 
                            Player newPlayer = NewStart(idCount);
                            newP = true;
                            return newPlayer;

                    }
                    else
                    {
                        foreach (Player player in players)
                        {
                            if (player.name == data[0])
                            {
                                return player;
                            }
                        }
                        Console.WriteLine("There is no player with that name sadly");
                        Console.ReadKey();
                    }

                    
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your id needs to be a number! Press any key to continue!");
                    Console.ReadKey();

                }
            }

        }
    
    }
}
