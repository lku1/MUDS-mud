using DocumentFormat.OpenXml.Spreadsheet;
using MUD.Art;
using MUD.CCharacter;
using MUD.IItems;

namespace MUD.Worlds
{
    public class Sunset1
    {
        private string input;

        public void StartGame()
        {
            Sea s = new Sea();
            CCharacter1 pp = new CCharacter1();
            Forest1 forest = new Forest1();
            IItems1 it = new IItems1();

            s.ShowGraphic();
            Console.WriteLine("Welcome to the magical world of \"MUDs\" " +
                "\nWhat is your Name?");
            pp.Name = Console.ReadLine();
            //pp.Name = "lku";
            Console.WriteLine("What is your Age?");
            //pp.Age = int.Parse(Console.ReadLine());
            while (true)
            {
                string ageInput = Console.ReadLine();
                int temporaryAge;

                if (int.TryParse(ageInput, out temporaryAge))
                {
                    if (temporaryAge >= 18)
                    {
                        pp.Age = temporaryAge;
                        break;
                    }
                    else
                    {
                        pp.Age = 18;
                        break;
                    }
                }
                else
                {
                    pp.Age = 18;
                    break;
                }
            }

            //pp.Age = 18;
            Console.Clear();
            s.ShowGraphic();
            Console.WriteLine("You got a mission from the guild to go to this mountain and live on ");
            Console.WriteLine("it for a short time and explore its surroundings and its dungeons");
            Console.ReadLine();


            Console.Clear();
            s.ShowGraphic();
            pp.CharacterClass = "Warrior";
            pp.Warrior();
            it.Sword(pp);
            it.Shield(pp);
            it.Armor1(pp);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadLine();
            Console.Clear();



            Random random = new Random();
            int num = random.Next(1, 7);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num <= 4)
            {
                s.ShowGraphic();
                Console.WriteLine("You walk near a beach, up a small cliff.");
                Console.WriteLine("You are standing on top of a cliff edge, ");
                Console.WriteLine("and you look out over the beautiful sea.");
                Console.ReadKey();
                Console.WriteLine("\nAnd when you look behind you, you can see the mountains.");
                Console.WriteLine("And down there in the forest, there should be a cabin that you are meant to live in for a short time.");
                Console.WriteLine("\nDo you want to go to the mountain?");
                Console.WriteLine("------------------------------------------------------------------------");
                input = Console.ReadLine().ToLower().Trim();

                if (input == "mountain")
                {
                    Console.WriteLine("When your decision has been made to go to the cabin, you begin" +
                        "\nto turn around and leave the cliff's edge and walk into the forest.");
                    Console.ReadKey();
                    forest.Forest(pp, it);
                }
                else
                {
                    Console.Clear();
                    s.ShowGraphic();
                    Console.WriteLine("Since you didn't make any kind of choice, you stood there wondering what to do next.");
                    Console.WriteLine("and looked out at the beautiful sea from the cliff you were standing on.");
                    Console.ReadKey();
                    Console.WriteLine("\nWhen suddenly the cliff you are standing on breaks apart and you start falling towards your death.");
                    Console.ReadKey();
                    Console.Clear();
                    s.ShowGraphic();
                    Console.WriteLine("========================================");
                    Console.WriteLine("               GAME OVER                ");
                    Console.WriteLine("========================================");
                    Console.WriteLine("The End");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                s.ShowGraphic();
                Console.WriteLine("For some strange reason and through the turns of fate.");
                Console.ReadKey();
                Console.WriteLine("When the cliff you were standing on begins to fall apart, and you begin to fall to your death.");
                Console.ReadKey();
                Console.Clear();
                s.ShowGraphic();
                Console.WriteLine("========================================");
                Console.WriteLine("               GAME OVER                ");
                Console.WriteLine("========================================");
                Console.WriteLine("The End");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}