using MUD.Art;
using MUD.CCharacter;
using MUD.IItems;

namespace MUD.Worlds
{
    public class Sunset1
    {
        private string input;
        private string input1;

        public void StartGame()
        {
            Sea s = new Sea();
            CCharacter1 pp = new CCharacter1();
            Forest1 forest = new Forest1();
            IItems1 it = new IItems1();

            s.ShowGraphic();
            Console.WriteLine("Welcome the magical worlds of MUDs \nWho are you? \nWhat is your Name?");
            //pp.Name = Console.ReadLine();
            pp.Name = "lku";
            Console.WriteLine("What is your Age?");
            //pp.Age = int.Parse(Console.ReadLine());
            pp.Age = 18;

            Console.Clear();

            s.ShowGraphic();
            Console.WriteLine("What is your CharacterClass? \nWarrior \nDexterity1 \nMagic1");
            pp.CharacterClass = Console.ReadLine().ToLower().Trim();
            //pp.CharacterClass = "Magic1";
            if (input1 == "Warrior")
            {
                pp.Warrior();
                Console.ReadLine();
                Console.Clear();
            }
            else if (input1 == "Dexterity1")
            {
                pp.Dexterity1();
                Console.ReadLine();
                Console.Clear();
            }
            else if (input1 == "Magic1")
            {
                pp.Magic1();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a valid character class.");
                StartGame(); // Restart the game if invalid input
                return;
            }

            Random random = new Random();
            int num = random.Next(1, 4);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num <= 4)
            {
                s.ShowGraphic();
                Console.WriteLine("You are alive? Good!");
                Console.WriteLine("Do you want to go to the mountain?");
                Console.WriteLine("------------------------------------------------------------------------");
                input = Console.ReadLine().ToLower().Trim();

                if (input == "mountain")
                {
                    Console.WriteLine("Du börjar lämna klippan och gå över till berget, genom att gå igenom skogen.");
                    Console.ReadKey();
                    forest.Forest(pp);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You are however, dead?");
                    Console.WriteLine("exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("You are however, dead?");
                Console.WriteLine("exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}