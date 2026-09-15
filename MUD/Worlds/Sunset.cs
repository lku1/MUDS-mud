using MUD.Art;
using MUD.CCharacter;

namespace MUD.Worlds
{
    public class Sunset
    {
        public CCharacter1 Player;

        public void StartGame()
        {
            Sea s = new Sea();
            Player = new CCharacter1();

            s.ShowGraphic();
            Console.WriteLine("Welcome the magical worlds of MUDs \nWho are you? \nWhat is your Name?");
            Player.Name = Console.ReadLine();
            Console.WriteLine("What is your Age?");
            Player.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is your CharacterClass?");
            Player.CharacterClass = "Warrior";
            Console.Clear();

            s.ShowGraphic();
            //Console.WriteLine("What is your HP?"); int.Parse(Console.ReadLine());
            Player.Health = 10;
            //Console.WriteLine("What is your Strength?");
            Player.Strength = 7;
            //Console.WriteLine("What is your Gold?");
            Player.Gold = 5;
            Console.Clear();


            s.ShowGraphic();
            Player.Yous();
            Console.ReadLine();
            Console.Clear();

            Random random = new Random();
            int num = random.Next(1, 7);

            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);

            if (num <= 4)
            {
                s.ShowGraphic();
                Console.WriteLine("You are alive? Good!");
                Console.WriteLine("Do you want to go to the mountain?");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are however, dead?");
                Console.ReadKey();
            }

        }

    }

}