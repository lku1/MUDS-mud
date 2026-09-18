using System;

namespace MUD.Worlds
{
    public class Enemy1
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }
        public float ArmorRating { get; set; }
        public bool IsBoss { get; set; }
        public string LootItem { get; set; }

        public Enemy1(string name, int health, int strength, int damage, float armorRating, bool isBoss, string lootItem)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Damage = damage;
            ArmorRating = armorRating;
            IsBoss = isBoss;
            LootItem = lootItem;
        }
    }
}
