using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameR5
{
    public class Encounters
    {
        static Random rand = new Random();

        //Encounter Generic


        //Encounters
        public static void FirstEncounter2()
        {
            Console.Clear();
            Console.WriteLine("You feel like you're in shock. You see a metal sword on the floor as your captor stares at you with a smile.");
            Console.WriteLine("You grab the sword but don't know what's going on. You feel scared and lost. ");
            Console.WriteLine("He moves toward you with a sickening smile...");
            Console.ReadKey();
            Combat(false, "Unknown Person", 1, 4);


        }

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("You turn around, and there is something coming your way....");
            Console.WriteLine();
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }
        public static void GodEncounter()
        {
            Console.Clear();
            Console.WriteLine("The hallway slowly cracks open to another world. As you look ahead, you see an unknown spirit dressed in");
            Console.WriteLine("shimmering red, white and gold, saying that it's time to beat your procrastination.");
            Console.ReadKey();
            Combat(false, " Self God ", 10, 30);
        }
        public static void LordEncounter()
        {
            Console.Clear();
            Console.WriteLine("You are still trying to figure out where you are until you hear a voice say");
            Console.WriteLine("\"You aren't supposed to be here.\" Then you feel an itching pain in your hands, but there nothing you see.");
            Console.WriteLine("You see three spirits that want to face you in this world you have awaken in.");
            Console.WriteLine("");
            Console.ReadKey();
            Combat(false, " God of Lost, Love, and Anger ", 10, 35);
        }
        public static void TimeEncounter()
        {
            Console.Clear();
            Console.WriteLine("A voice creeps into your mind, asking what will you do next. \"Will you become a god of your own? Will you wake up?\"");
            Console.WriteLine("The voice fades away, and someone comes toward you. You get this feeling that they are a spirit, and they ask you: \"Are you lost?\"");
            Console.ReadKey();
            Combat(false, " God of Wonder ", 10, 60);
        }
        public static void TheLostEncounter()
        {
            Console.Clear();
            Console.WriteLine("When you defeat each spirit you learn that this world belongs to you.");
            Console.WriteLine("You don't understand why this world is yours, but with each spirit you face you gain a better understanding of yourself.");
            Console.WriteLine("You blink in wonder at a spirit that appears to have a heavenly aura, and they look at you wondering why you are still alive.");
            Console.WriteLine("The spirit then says \"I'm sorry, my child, but you cannot be allowed to live.\" Suddenly, the feeling you get from this heavenly spirit is turned into fear.");
            Console.ReadKey();
            Combat(false, " Heaven Spirit ", 10, 60);
        }

        public static void TwinEncounter()
        {
            Console.Clear();
            Console.WriteLine("Each spirit you encounter shows how much they want you to be defeated. Some look at you and in shock you are alive. What are you to them?");
            Console.WriteLine("The God fears a normal person like you. Are you even a person? As more encounter grow you will get more understanding who you are");
            Console.WriteLine("When you beat the previous spirit you are transport in a hot land of a tropical feel you look around see a beach right in front of you");
            Console.WriteLine("An old man appears from the water and on the beach. Tell you oh my why would you be here. You should remember why this world was here.");
            Console.WriteLine("You look at the old man lost and confused. He say this it seem they really let you forget your position here in the world.");
            Console.WriteLine("Well I'm sorry my young friend ordered. He turn into a giant and his hand became sword and shield grow from his body and hover over him.");
            Console.ReadKey();
            Combat(false, " Old man", 10, 60);
        }

        public static void GivenEncounter()
        {
            Console.Clear();
            Console.WriteLine("You have defeated a lot of spirits and gods lately, so your learning again that they all don't want you around. You walk on an endless path of stones, and a " +
                "castle appears. The door opens slowly, and you hear a voice say \''Come in\". You walk in slowly and gather the power you have gained during your encounter. You see a person" +
                " surrounded by golems who look at you and says \"Hello my old friends. I can't allow you to live. The spirits you have faced will be reborn and come towards you again " +
                "with haste. Even if you defeat me, I will return for you. Probably by your side.\" He smiles and gives out a feeling of joy to see you. You feel that you are friends but then " +
                "again... The golems and the king start coming toward you.");
            Console.ReadKey();
            Combat(false, "The King of Hero and the Golem Army", 45, 89);
        }


        public static void LastEncounter()
        {
            Console.Clear();
            Console.WriteLine("You feel relaxed and the smile brought you to a flashback of your first encounter.");
            Console.WriteLine("You feel strength in your heart beat, and your eyes changed color. You feel powerful but still don't know your place in this world. " +
                "You feel proud that life is getting better. Then when you look around you hear three trumpets and a piano playing. You see the world you" +
                "walk on change into a throne, a throne for a god. You see a child looking at you with a smile,tThen transform into adult men then a transform into " +
                "a knight. He says \"Hello my old friend! Will you take my place to control this world?! Will you be a god again? Will you make things better just because of who" +
                " you were in the past?! You were nothing but evil! You changed your views to show the light how you first created this world. I want the old you! I want you " +
                "to be the good man you were centuries ago! Now face me! Take back your throne and I'll be back in your service as your knight once again! I was lost " +
                "and confused... and my mind is pounding! I feel pain, joy, and anger. No memory of who I am...\" He charges toward you with great haste but you dodge him. He says " +
                "\"Reclaim the throne or be sent back to the beginning.");
            Console.ReadKey();
            Combat(false, "Creator of the World", 30, 100);
        }

        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 12))
            {
                case 0:
                    FirstEncounter2();
                    break;
                case 1:
                    BasicFightEncounter();
                    break;
                case 2:
                    GodEncounter();
                    break;
                case 3:
                    LordEncounter();
                    break;
                case 4:
                    TimeEncounter(); 
                    break;
                case 5:
                    TheLostEncounter();
                    break;
                case 6:
                    TwinEncounter();
                    break;
                case 7:
                    GivenEncounter();
                    break;
                case 8:
                    LastEncounter();
                    break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();
                p = Program.currentPlayer.GetPower();
                h = Program.currentPlayer.GetHealth();

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)run   (H)eal   |");
                Console.WriteLine("=====================");
                Console.WriteLine("Ptions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("With haste you move forth, your sword flying on your hands! As you pass, the " + n + " strikes you as you pass");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4) + ((Program.currentPlayer.currentClass == Player.PlayerClass.Power) ? 2 : 0);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("As the" + n + " prepares to strike, you ready your sword in a defensive stance");
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }

                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //run
                    if (Program.currentPlayer.currentClass != Player.PlayerClass.Lost && rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the" + n + ", its strike catch you in the back, sending you sprawling on the floor");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose" + damage + " health and are unable to escape.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("You use your lost moves to evade the " + n + " and you successfully escape!");
                        Console.ReadKey();
                        Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == " heal ")
                {
                    //Heal
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("As you desperatly grab the potion in your bag, all the you feel is an empty flasks");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("The" + n + " strikes you with a mighty blow and you lose" + damage + " health!");
                    }
                    else
                    {
                        Console.WriteLine(" You reach into your bag and pull out a glowing, yellow flask. You take a long drink.");
                        int potionV = 5 + ((Program.currentPlayer.currentClass == Player.PlayerClass.Hope)?+4: 0);
                        Console.WriteLine(" You gain" + potionV + "health ");
                        Program.currentPlayer.health += potionV;
                        Console.WriteLine("As you were occupied, the " + n + " advanced and strike");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + "health");

                    }
                    Console.ReadKey();

                }
                if (Program.currentPlayer.health <= 0)
                {
                    //Death Code
                    Console.WriteLine("As the" + n + " stands tall and come down to strike. You have defeated by he" + n);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();

              
            }
            int c = Program.currentPlayer.GetCoins();
            int x = Program.currentPlayer.GetXP();
            Console.WriteLine("As you stand brave over your the " + n + ", its body dissoves into " + c + " gold coins! You have gained " + x + " XP!");
            Program.currentPlayer.coins += c;
            Program.currentPlayer.xp += x;
            if (Program.currentPlayer.CanLevelUp())
                Program.currentPlayer.LevelUp();

            Console.ReadKey();
        }
        public static string GetName()
        {


            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Spirit of Life";
                case 1:
                    return "Spirit of Hope ";
                case 2:
                    return "Anger spirit";
                case 3:
                    return "Person of unknown past";

            }
            return "Human";
        }

    }
}

