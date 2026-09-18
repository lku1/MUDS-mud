using MUD.CCharacter;

namespace MUD.IItems
{
    internal class IItems1
    {
        public int sword;
        public int shield;
        public int Armor;

        public void Sword(CCharacter1 pp)
        {
            sword = 3;
            sword = sword + pp.Strength;

            Console.WriteLine("Sword damage: " + sword);
        }

        public void Shield(CCharacter1 pp)
        {
            shield = 4;
            shield = shield + pp.Strength;

            Console.WriteLine("Shield Protect: " + shield);
        }

        public void Armor1(CCharacter1 pp)
        {
            Armor = 7;
            Armor = Armor + pp.Strength;

            Console.WriteLine("Armor Protect: " + Armor);
        }
    }
}
