using MUD.CCharacter;


namespace MUD.Worlds
{
    internal class Forest1
    {
        public void Forest()
        {
            CCharacter1 pp = new CCharacter1();

            Console.Clear();
            Console.WriteLine("You begin to walk into a forest.");
            Console.ReadKey();

            Random random = new Random();
            int num1 = random.Next(1, 4);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num1 <= 1)
            {
                Console.WriteLine("Du hör något bakom dig och när du tittar dig omkring ser du en");
                Console.WriteLine("fallen stock precis där du stod för bara en minut sedan.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You are however, dead?");
                Console.WriteLine("exit");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("\nMMM");
            Console.ReadKey();

            Console.WriteLine("\nAAA");
            Console.ReadKey();
        }
    }
}
