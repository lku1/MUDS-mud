namespace MUD.CCharacter
{
    public class CCharacter1
    {
        public string Name;
        public int Age;
        public string CharacterClass;
        public int Health;
        public int Strength;
        public int Gold;

        //public bool Dead;

        public void Yous()
        {
            Console.WriteLine("character:");
            Console.WriteLine("your name: " + Name);
            Console.WriteLine("year Age: " + Age);
            Console.WriteLine("Your class: " + CharacterClass);
            Console.WriteLine("You have HP: " + Health);
            Console.WriteLine("You have Strength: " + Strength);
            Console.WriteLine("You have Gold: " + Gold);
            Console.WriteLine("\nIf you want to see your character, please type character.");
            Console.WriteLine("------------------------------------------------------------------------");
        }

        public void Character()
        {
            Console.WriteLine("Character:");
            Console.WriteLine("name: " + Name);
            Console.WriteLine("old: " + Age);
            Console.WriteLine("class: " + CharacterClass);
            Console.WriteLine("HP: " + Health);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("------------------------------------------------------------------------");
        }

        //string character = $"Character: \nName: {Name} \nClass: {CharacterClass} \nHealth: {Health} \nStrength: {Strength} \nGold: {Gold}";
        //Console.WriteLine(character);

    }


}
