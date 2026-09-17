using MUD.Art;
using MUD.CCharacter;
using MUD.IItems;


namespace MUD.Worlds
{
    internal class Forest1
    {
        private string input;
        public void Forest(CCharacter1 pp)
        {
            Mountains m = new Mountains();

            Console.Clear();
            m.ShowGraphic();
            Console.WriteLine("You begin to walk into a forest.");
            Console.ReadKey();
            Console.Clear();

            Random random = new Random();
            int num1 = random.Next(1, 7);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num1 <= 2)
            {
                Console.WriteLine("Du hör något bakom dig och när du tittar dig omkring ser du en");
                Console.WriteLine("fallen stock precis där du stod för bara en minut sedan.");
                Console.ReadKey();
                Console.Clear();
            }
            else if(num1 <= 3)
            {
                m.ShowGraphic();
                Console.WriteLine("Marcus");
                Console.WriteLine("123");
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    Console.WriteLine("111");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("222");
                    Console.ReadKey();
                }
            }
            else
            {
                m.ShowGraphic();
                Console.WriteLine("You are however, dead?");
                Console.WriteLine("exit");
                Console.ReadKey();
                if (pp.Strength > 4)
                {
                    Console.WriteLine("Strength");
                    Console.ReadKey();
                }
                else if (pp.Magic > 4)
                {
                    Console.WriteLine("Magic");
                    Console.ReadKey();
                }
                else if (pp.Dexterity > 4)
                {
                    Console.WriteLine("Dexterity");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nMMM");
            Console.ReadKey();

            Console.WriteLine("\nAAA");
            Console.ReadKey();
        }
    }
}