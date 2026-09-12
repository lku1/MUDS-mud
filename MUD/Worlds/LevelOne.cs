using MUD.Art;

namespace MUD.Worlds
{
    public class LevelOne
    {
        public string Name;
        public string age;
        public string CharacterClass;
        public int Health;
        public bool Dead;

        public void StartGame()
        {
            Sea s = new Sea();
            s.ShowGraphic();
            Console.WriteLine("Welcome the magical worlds of MUDs");
            Console.WriteLine("Who are you?");
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
            Console.WriteLine("What is your CharacterClass?");
            CharacterClass = Console.ReadLine();
            Console.Clear();
            s = new Sea();
            s.ShowGraphic();
            Console.WriteLine("Welcome " + Name);
            Console.WriteLine("You are a " + age + " year old " + CharacterClass + ".");
            Health = 10;
            Console.WriteLine("You have " + Health + " HP");

            Random random = new Random();
            int num = random.Next(1, 7);

            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num); 

            if (num <= 4)
            {
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("You are alive? Good!");
                Console.WriteLine("Do you want to go to the mountain?");
                Console.ReadKey();
            }

            else
            {
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("You are however, dead?");
                Console.ReadKey();
            }

        }
    }
}