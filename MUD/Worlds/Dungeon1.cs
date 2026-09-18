using MUD.CCharacter;
using MUD.IItems;

namespace MUD.Worlds
{
    public class Dungeon1
    {
        private List<string> inventory = new List<string>();
        private IItems1 it;

        private LevelSystem1 levelSystem = new LevelSystem1();

        internal void EnterDungeon(CCharacter1 player, IItems.IItems1 it)
        {
            this.it = it;
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("          YOU ENTER THE DUNGEON         ");
            Console.WriteLine("========================================");
            Console.ReadKey();
            Console.WriteLine("As you're walking deeper into the cave system,");
            Console.WriteLine("you can feel that it's more like a cave than an actual dungeon");
            Console.ReadKey();
            Console.WriteLine("\nAs you're exploring and going deeper and deeper,");
            Console.WriteLine("you didn't really find that many monsters around, or that many oars.");
            Console.WriteLine("But you continued to walk deeper.");
            Console.ReadKey();


            List<Enemy1> enemies = new List<Enemy1>()
            {
                new Enemy1("Small Wolf", 15, 3, 5, 0.05f, false, "Health Potion"),
                new Enemy1("Goblin", 25, 5, 6, 0.15f, false, "Vassare Svärd"),
                new Enemy1("Goblin Warrior (BOSS)", 30, 7, 6, 0.25f, true, "Drakguld")
            };

            for (int room = 1; room <= 4; room++)
            {
                if (player.Health <= 0) break;

                Console.Clear();
                Console.WriteLine($"--- RUM {room} ---");

                Enemy1 currentEnemy = (room == 1) ? enemies[0] : (room == 3) ? enemies[1] : (room == 4) ? enemies[2] : null;

                if (room == 1)
                {
                    Console.WriteLine("A bit further down, you can see that the corner is turning right.");
                    Console.WriteLine("You peek around the corner and you can see almost complete darkness.");
                    Console.ReadKey();

                    Console.WriteLine($"When suddenly A wild {currentEnemy.Name} leaps out of the shadows!");
                    Console.ReadKey();

                }
                if (room == 2)
                {
                    Console.WriteLine("You feel a bit sad killing that small wolf. But you're glad you find the three healing potions.");
                    Console.WriteLine("After walking a bit further in in the cave, you stumble upon a small hole in the wall,");
                    Console.WriteLine("and you peek through, finding a dead body. You say a small prayer and begin to look through his pockets.");
                    Console.ReadKey();
                    Console.WriteLine("You should be glad he's been here a long time, because he's only bones.");
                    Console.WriteLine("You find on the dead body 20 Gold and a Heavy Shield!");

                    player.Gold += 20;
                    inventory.Add("Heavy Shield");
                    Console.WriteLine($"Your gold is now: {player.Gold}");
                    Console.ReadKey();
                    continue;
                }
                if (room == 3)
                {
                    Console.WriteLine("You begin to stand up and keep on moving. And seeing another corner a bit further ahead.");
                    Console.WriteLine("Learning from your previous mistake, you be a bit more cautious looking through this corner.");
                    Console.ReadKey();

                    Console.WriteLine($"You begin to see a {currentEnemy.Name} And it begins to see you as well,");
                    Console.WriteLine($"and you both begin to fight.");
                    Console.ReadKey();
                }
                if (room == 4)
                {
                    Console.WriteLine("You are glad that you managed to kill that small goblin.");
                    Console.WriteLine("And now you know what happened to the dead guy.");
                    Console.ReadKey();
                    Console.WriteLine("\nYou begin to look a bit closer at the goblin's weapon");
                    Console.WriteLine("and realize it's a better sword than what you currently have.");
                    Console.WriteLine("\nAnd seeing how your own sword is almost broken,");
                    Console.WriteLine("so we decided to equip the goblin sword.");
                    Console.ReadKey();

                    Console.WriteLine("\nAs you're looking over your new sword,");
                    Console.WriteLine("you can hear something coming from behind you.");
                    Console.WriteLine("You drew your new sword and get ready to fight whatever creature it might be.");
                    Console.ReadKey();
                    Console.WriteLine("You get a bit terrifying looking at the massive new creature.");
                    Console.WriteLine($"It was a. {currentEnemy.Name} and it's already beginning to attack you.");
                    Console.ReadKey();
                }

                StartCombat(player, currentEnemy);
            }

            Console.Clear();
            if (player.Health <= 0)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("               GAME OVER                ");
                Console.WriteLine("      Ditt HP nådde 0. Du förlorade!    ");
                Console.WriteLine("========================================");
            }
            else
            {
                Console.WriteLine("=========================================");
                Console.WriteLine($"             GRATTIS! {player.Name}!    ");
                Console.WriteLine("Du har besegrat bossen och klarat spelet!");
                Console.WriteLine("=========================================");

                Console.WriteLine("\nDitt slutgiltiga Inventory:");
                foreach (var item in inventory)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine($"Total mängd guld: {player.Gold}");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine($"             GRATTIS! {player.Name}!    ");
            Console.WriteLine("Du har besegrat bossen och klarat spelet!");
            Console.WriteLine("=========================================");
            Console.WriteLine("The End");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private void StartCombat(CCharacter1 player, Enemy1 enemy)
        {
            Random combatDice = new Random();

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine($" YOUR TURN! VS {enemy.Name.ToUpper()}");
                Console.WriteLine("========================================");
                Console.WriteLine($"Your HP: {player.Health}  |  {enemy.Name} HP: {enemy.Health}");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. [ATTACK] - Strike the enemy with your sword");
                Console.WriteLine("2. [DEFEND] - Raise your shield (Significantly reduces incoming damage)");
                Console.WriteLine("3. [HEAL]   - Drink a Healing Potion (Restores 20 HP)");
                Console.WriteLine("----------------------------------------");
                Console.Write("Your choice (1-3): ");

                string choice = Console.ReadLine().Trim();
                bool isDefending = false;

                if (choice == "1")
                {
                    int minPlayerDamage = 4;
                    int maxPlayerDamage = 6 + player.Strength;

                    int playerRolledDamage = combatDice.Next(minPlayerDamage, maxPlayerDamage + 1);

                    float damageToEnemy = CalculateDamageTaken(playerRolledDamage, enemy.ArmorRating);

                    enemy.Health -= (int)damageToEnemy;
                    Console.WriteLine($"\n⚔️ You strike! You rolled {playerRolledDamage} damage.");
                    Console.WriteLine($"After the enemy's armor, {enemy.Name} takes {(int)damageToEnemy} damage!");
                }
                else if (choice == "2")
                {
                    isDefending = true;
                    Console.WriteLine($"\n🛡️ You raise your shield and prepare for the incoming blow!");
                }
                else if (choice == "3")
                {
                    int potionCount = inventory.FindAll(x => x == "Health Potion").Count;
                    if (potionCount > 0)
                    {
                        if (player.Health >= player.MaxHealth)
                        {
                            Console.WriteLine($"\n❌ You already have full HP ({player.Health}/{player.MaxHealth})!");
                        }
                        else
                        {
                            player.Health += 20;
                            if (player.Health > player.MaxHealth) player.Health = player.MaxHealth;
                            inventory.Remove("Health Potion");
                            Console.WriteLine($"\n🧪 You drink a Health Potion and restore 20 HP!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n❌ You have no more Health Potions!");
                    }
                }
                else
                {
                    Console.WriteLine("\n🤔 You hesitate and don't know what to do. You stand completely exposed!");
                }

                Console.ReadKey();

                if (enemy.Health <= 0) break;

                Console.WriteLine($"\n----------------------------------------");
                Console.WriteLine($"{enemy.Name} goes for an attack!");

                int enemyBaseDamage = enemy.Damage + enemy.Strength;
                float damageToPlayer = 0;

                if (isDefending)
                {
                    damageToPlayer = 0;
                    Console.WriteLine("🛡️ Perfect block! Your shield absorbs 100% of the impact.");
                }
                else
                {
                    int minEnemyDamage = 1;
                    int maxEnemyDamage = enemy.Damage + enemy.Strength;
                    int enemyRolledDamage = combatDice.Next(minEnemyDamage, maxEnemyDamage + 1);

                    float currentArmorRating = CCharacter1.GetArmorRating(it);
                    damageToPlayer = (int)CalculateDamageTaken(enemyRolledDamage, currentArmorRating);

                    Console.WriteLine($"🎲 {enemy.Name} rolled a base attack for {enemyRolledDamage} damage.");
                }

                player.Health -= (int)damageToPlayer;

                Console.WriteLine($"💥 {enemy.Name} deals {(int)damageToPlayer} damage to you!");
                Console.ReadKey();
            }

            if (player.Health > 0)
            {
                Console.WriteLine($"\n🎉 You defeated {enemy.Name}!");
                levelSystem.EnemyKilled(player);

                if (enemy.Name == "Small Wolf" || enemy.Name == "Slemklump")
                {
                    Console.WriteLine("You search the area and find a total of 3 Health Potions!");

                    for (int i = 0; i < 3; i++)
                    {
                        inventory.Add("Health Potion");
                    }
                }
                else
                {
                    Console.WriteLine($"You found a: {enemy.LootItem}!");
                    inventory.Add(enemy.LootItem);

                    if (enemy.LootItem == "Vassare Svärd")
                    {
                        player.Strength += 6;
                        Console.WriteLine("Your new sword increases your Strength by +6!");
                    }
                    if (enemy.LootItem == "Drakguld")
                    {
                        player.Gold += 100;
                        Console.WriteLine($"Your gold increased by 100! You now have {player.Gold} gold.");
                    }
                }
                Console.ReadKey();
            }
        }
        private float CalculateDamageTaken(int baseDamage, float armorRating)
        {
            float finalDamage = baseDamage * (1.0f - armorRating);
            return finalDamage;
        }
    }
}