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
        public int MaxHealth = 30;
        public int Strength;
        public int Magic;
        public int Dexterity;
        public int Gold;
        public string Items;
        public void Warrior()
        {
            Level = 1;
            Health = 30;
            Strength = 5;
            Magic = 3;
            Dexterity = 3;
            Gold = 10;
            Items = "Sword, Shield, Armor";
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
            Console.WriteLine("------------------------------------------------------------------------");
        }
        internal static float GetArmorRating(IItems1 items)
        {
            float totalProtection = items.shield + items.Armor;
            float rating = totalProtection / 100f;

            if (rating > 1.0f) rating = 1.0f;

            return rating;
        }
    }
}