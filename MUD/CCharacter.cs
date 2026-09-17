using MUD.IItems;

namespace MUD.CCharacter
{
    public class CCharacter1
    {
        public string Name;
        public int Age;
        public int Level;
        public string CharacterClass;
        public int Health;
        public int Strength;
        public int Magic;
        public int Dexterity;
        public int Gold;
        public string Items;

        //public bool Dead;
        public void Warrior()
        {
            Level = 1;
            Health = 30;
            Strength = 5;
            Magic = 3;
            Dexterity = 3;
            Gold = 10;
            Items = "Sword, Shield";
            Console.WriteLine("========================================");
            Console.WriteLine("              Character                 ");
            Console.WriteLine("========================================");
            Console.WriteLine("your name: " + Name);
            Console.WriteLine("year Age: " + Age);
            Console.WriteLine("your level is: " + Level);
            Console.WriteLine("Your class: " + CharacterClass);
            Console.WriteLine("You have HP: " + Health);
            Console.WriteLine("You have Strength: " + Strength + " \nYou have magic: " + Magic + " \nYou have dexterity: " + Dexterity);
            Console.WriteLine("You have Gold: " + Gold);
            Console.WriteLine("You have the items: " + Items);
            //Console.WriteLine("\nIf you want to see your character, please type Character.");
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void Dexterity1()
        {
            Level = 1;
            Health = 30;
            Strength = 3;
            Magic = 3;
            Dexterity = 5;
            Gold = 10;
            Items = "Sword, Shield";
            Console.WriteLine("========================================");
            Console.WriteLine("              Character                 ");
            Console.WriteLine("========================================");
            Console.WriteLine("your name: " + Name);
            Console.WriteLine("year Age: " + Age);
            Console.WriteLine("your level is: " + Level);
            Console.WriteLine("Your class: " + CharacterClass);
            Console.WriteLine("You have HP: " + Health);
            Console.WriteLine("You have Strength: " + Strength + " \nYou have magic: " + Magic + " \nYou have dexterity: " + Dexterity);
            Console.WriteLine("You have Gold: " + Gold);
            Console.WriteLine("You have the items: " + Items);
            //Console.WriteLine("\nIf you want to see your character, please type Character.");
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void Magic1()
        {
            Level = 1;
            Health = 30;
            Strength = 3;
            Magic = 5;
            Dexterity = 3;
            Gold = 10;
            Items = "Sword, Shield";
            Console.WriteLine("========================================");
            Console.WriteLine("              Character                 ");
            Console.WriteLine("========================================");
            Console.WriteLine("your name: " + Name);
            Console.WriteLine("year Age: " + Age);
            Console.WriteLine("your level is: " + Level);
            Console.WriteLine("Your class: " + CharacterClass);
            Console.WriteLine("You have HP: " + Health);
            Console.WriteLine("You have Strength: " + Strength + " \nYou have magic: " + Magic + " \nYou have dexterity: " + Dexterity);
            Console.WriteLine("You have Gold: " + Gold);
            Console.WriteLine("You have the items: " + Items);
            //Console.WriteLine("\nIf you want to see your character, please type Character.");
            Console.WriteLine("------------------------------------------------------------------------");
        }

        public void CharacterSheets()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("              Character                 ");
            Console.WriteLine("========================================");
            Console.WriteLine("name: " + Name);
            Console.WriteLine("old: " + Age);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("class: " + CharacterClass);
            Console.WriteLine("HP: " + Health);
            Console.WriteLine("Strength: " + Strength + " magic: " + Magic + " dexterity: " + Dexterity);
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("Items: " + Items);
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}