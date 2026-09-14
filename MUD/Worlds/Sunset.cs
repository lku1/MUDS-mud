using MUD.Art;
using MUD.CCharacter;
using System.Xml.Linq;

namespace MUD.Worlds
{
    public class Sunset
    {
        public string Name;
        public int age;
        public string CharacterClass;
        public int Health;
        public int Strength;
        public int Gold;
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
            age = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is your CharacterClass?");
            CharacterClass = "Warrior";
            Console.Clear();
            s = new Sea();
            s.ShowGraphic();
            //Console.WriteLine("What is your HP?"); int.Parse(Console.ReadLine());
            Health = 10;
            //Console.WriteLine("What is your Strength?");
            Strength = 7;
            //Console.WriteLine("What is your Gold?");
            Gold = 5;
            Console.Clear();
            s = new Sea();
            s.ShowGraphic();
            //CCharacter1 cc = new CCharacter1();
            //cc.Character();
            Console.WriteLine("character:");
            Console.WriteLine("your name: " + Name);
            Console.WriteLine("year old: " + age);
            Console.WriteLine("Your class: " + CharacterClass);
            Console.WriteLine("You have HP: " + Health);
            Console.WriteLine("You have Strength: " + Strength);
            Console.WriteLine("You have Gold: " + Gold);
            //Console.WriteLine("");
            //Console.WriteLine("If you want to see your character, please type character.");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadLine();
            Console.Clear();

            Random random = new Random();
            int num = random.Next(1, 7);

            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);

            if (num <= 4)
            {
                s = new Sea();
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