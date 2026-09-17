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
            Console.WriteLine("Welcome the magical worlds of MUDs \nWho are you? \nWhat is your Name?");
            //pp.Name = Console.ReadLine();
            pp.Name = "lku";
            Console.WriteLine("What is your Age?");
            //pp.Age = int.Parse(Console.ReadLine());
            pp.Age = 18;

            Console.Clear();

            s.ShowGraphic();
            pp.CharacterClass = "Warrior";

            pp.Warrior();
            Console.ReadLine();
            Console.Clear();


            Random random = new Random();
            int num = random.Next(1, 7);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num <= 4)
            {
                s.ShowGraphic();
                Console.WriteLine("Du står på toppen av en klippkant.");
                Console.WriteLine("Och du blickar ut över det vackra havet.");
                Console.WriteLine("Och när du tittar bakom dig kan du se bergen.");
                Console.WriteLine("och där nere borde det finnas en stuga som du är menad att bo i en kort tid.");
                Console.WriteLine("\nDo you want to go to the mountain?");
                Console.WriteLine("------------------------------------------------------------------------");
                input = Console.ReadLine().ToLower().Trim();

                if (input == "mountain")
                {
                    Console.WriteLine("Du börjar lämna klippan och gå över till berget, genom att gå igenom skogen.");
                    Console.ReadKey();
                    forest.Forest(pp, it);
                }
                else
                {
                    Console.Clear();
                    s.ShowGraphic();
                    Console.WriteLine("Eftersom du inte gjorde något slags val stod du där och undrade vad du skulle göra härnäst.");
                    Console.WriteLine("och tittade ut på det vackra havet från den klippan du stod på. ");
                    Console.ReadKey();
                    Console.WriteLine("\nNär plötsligt klippan du står på brast sönder och du börjar falla mot din död.");
                    Console.ReadKey();
                    Console.WriteLine("The End");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                s.ShowGraphic();
                Console.WriteLine("På ett konstigt sätt och genom ödets vändning.");
                Console.WriteLine("Stenen du stod på sprack plötsligt sönder och du börjar falla mot din död.");
                Console.ReadKey();
                Console.WriteLine("The End");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}