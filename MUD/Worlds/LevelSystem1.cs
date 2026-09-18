using System;
using MUD.CCharacter;

namespace MUD.Worlds
{
    public class LevelSystem1
    {
        private int enemiesDefeated = 0;

        public void EnemyKilled(CCharacter1 player)
        {
            enemiesDefeated++;
            Console.WriteLine($"\n[SYSTEM] Enemies defeated: {enemiesDefeated}");

            if (player.Level == 1 && enemiesDefeated >= 2)
            {
                LevelUp(player);
            }
        }

        private void LevelUp(CCharacter1 player)
        {
            player.Level = 2;
            player.MaxHealth += 5;
            //player.Health = player.MaxHealth;
            player.Health += 15;
            player.Strength += 2;
            player.Dexterity += 1;

            Console.WriteLine("\n========================================");
            Console.WriteLine("✨🎉 LEVEL UP! TO LEVEL 2! 🎉✨");
            Console.WriteLine("========================================");
            Console.WriteLine($"Your Max HP is now: {player.MaxHealth}");
            Console.WriteLine($"Your Strength is now: {player.Strength}");
            Console.WriteLine("Your Health has been fully restored!");
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
