using MUD.CCharacter;

namespace MUD.IItems
{
    internal class IItems1
    {
        public int sword;
        public int shield;
        public void Sword(CCharacter1 pp)
        {
            Console.WriteLine("Sword damage: " + sword);
            sword = 3;
            sword = sword + pp.Strength;
        }
        public void Shield(CCharacter1 pp)
        {
            Console.WriteLine("Shield Protect: " + shield);
            shield = 4;
            shield = shield + pp.Strength;
        }
    }
}
