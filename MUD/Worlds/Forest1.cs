using MUD.Art;
using MUD.CCharacter;
using MUD.IItems;

namespace MUD.Worlds
{
    internal class Forest1
    {
        private string input;
        public void Forest(CCharacter1 pp, IItems1 it)
        {
            Mountains m = new Mountains();

            Console.Clear();
            m.ShowGraphic();
            Console.WriteLine("You begin to walk into a forest that should lead you to a cabin.");
            Console.WriteLine("Where you are gonna stay for a short time on your quest.");
            Console.ReadKey();
            Console.Clear();

            Random random = new Random();
            int num1 = random.Next(1, 7);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num1 <= 3)
            {
                m.ShowGraphic();
                Console.WriteLine("You begin to think about your purpose in this part of the forest.");
                Console.WriteLine("Go into the dungeon, defeat some monsters, and mine some ores.");
                Console.WriteLine("So you then can finish up your quest and sell some of " +
                    "\nthe things you have gathered in this mountain.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (num1 <= 4)
            {
                m.ShowGraphic();
                Console.WriteLine("You find something strange by the side of the path behind some trees.");
                Console.WriteLine("Do you want to go over to take a better look or do you want to continue?");
                Console.WriteLine("Do you want to take a look, then press. \"y\"");
                Console.WriteLine("If you want to keep on moving, press. \"n\"");
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    Console.Clear();
                    m.ShowGraphic();
                    Console.WriteLine("As you are beginning to move in between the trees away from the path. " +
                    "\nyou can see what it is laying there on the ground.");
                    Console.WriteLine("You can see it's clearly a better sword and shield than what you currently have.");
                    Console.WriteLine("It's just a shame that the sword is stuck too hard in a stone and the shield is stuck too hard in a tree.");
                    Console.WriteLine("So you decided to turn around and continue walking on the path.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    m.ShowGraphic();
                    Console.WriteLine("You didn't really feel to walk towards that weird thing in the middle of the forest.");
                    Console.WriteLine("Maybe it's a trap, maybe it's something else.");
                    Console.WriteLine("You don't really know, but you ignore it and you keep on moving.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                m.ShowGraphic();
                Console.WriteLine("Suddenly you can hear something crackering to your right and");
                Console.WriteLine("when you look you can see a small tree beginning to fall towards you");
                Console.ReadKey();

                int logStrength = 12;
                int logWeaponDamage = 8;

                float playerArmorRating = CCharacter1.GetArmorRating(it);

                float finalDamage = CalculateDamageTaken(logStrength, logWeaponDamage, playerArmorRating);

                Console.WriteLine("\n--- STRIDS-LOGG ---");
                Console.WriteLine($"Din Armor Rating: {playerArmorRating:0.00} (Blockerar {playerArmorRating * 100:0}%)");
                Console.WriteLine($"Total skada från attacken: {logStrength + logWeaponDamage}");
                Console.WriteLine($"Faktisk skada du tog: {finalDamage}");
                Console.WriteLine("--------------------\n");

                pp.Health -= (int)finalDamage;

                Console.WriteLine($"Du har nu {pp.Health} HP kvar.");

                if (pp.Strength > 4)
                {
                    Console.WriteLine("\nYou manage to raise your shield and block the incoming tree.");
                    Console.WriteLine("with the help of the small amount of \"Strength\" and \"Shield\" and \"Armor\". you have");
                    Console.WriteLine("managed to survive the attack barely.");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            m.ShowGraphic();
            Console.WriteLine("After a little more hiking through the forest, you finally arrived at the cabin.");
            Console.WriteLine("where you can relax and recuperate your strength for the dungeon");
            Console.WriteLine("Opening the door to the cabin And peeking inside, you can see the bare minimum living conditions.");
            Console.WriteLine("A small cooking station, one table with three chairs, and a bunk bed in one of the corners.");
            Console.ReadKey();
            Console.WriteLine("\nYou immediately walk over to the bunk bed and laying down in the bottom one to Sleep.");
            Console.WriteLine("You fall into a deep sleep to the sound of the wind outside...");

            Console.Clear();
            m.ShowGraphic();
            pp.Health = pp.MaxHealth;
            Console.WriteLine($"You wake up refreshed the next morning! Your HP has been restored to {pp.Health}.");
            Console.WriteLine("You stretch your arms and begin to eat some breakfast. Afterward you go outside to look at the (Dungeon).");
            Console.ReadKey();
            Console.WriteLine("\nThe dungeon gate is a bit smaller than you thought it's supposed to be,");
            Console.WriteLine("but still you begin to walk inside and you find out it's more like a cave system.");
            Console.ReadKey();

            Dungeon1 dungeon = new Dungeon1();
            dungeon.EnterDungeon(pp, it);
        }

        private float CalculateDamageTaken(int strength, int weaponDamage, float armorRating)
        {
            int totalDamage = strength + weaponDamage;
            float damageTaken = totalDamage * (1.0f - armorRating);
            return damageTaken;
        }
    }
}