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
            Console.WriteLine("You begin to walk into a forest.");
            Console.ReadKey();
            Console.Clear();

            Random random = new Random();
            int num1 = random.Next(1, 7);
            //Ifall du vill se texten inne sidskripten. Ta bort de första två: //
            //Console.WriteLine(num);
            if (num1 <= 0)
            {
                m.ShowGraphic();
                Console.WriteLine("You begin to think about your purpose in this part of the forest.");
                Console.WriteLine("go into a mine to mine some ores and defeat some monsters.");
                Console.WriteLine("so you can then sell your spoils to nearby town.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (num1 <= 0)
            {
                m.ShowGraphic();
                Console.WriteLine("Du lyckas hitta något konstigt vid sidan av vägen bakom några träd.");
                Console.WriteLine("Vill du gå över för att ta en bättre titt eller vill du fortsätta?");
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
                    Console.WriteLine("Synd bara att svärdet sitter för fast i en sten och skölden sitter för fast i ett träd.");
                    Console.WriteLine("Så du bestämde dig för att vända om och fortsätta gå på stigen.");
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
                Console.WriteLine("Du hör något bakom dig och när du tittar dig omkring ser du en");
                Console.WriteLine("fallen stock precis där du stod för bara en minut sedan.");
                Console.ReadKey();

                int logStrength = 12;
                int logWeaponDamage = 8;

                float playerArmorRating = CCharacter1.GetArmorRating(it);

                float finalDamage = CalculateDamageTaken(logStrength, logWeaponDamage, playerArmorRating);

                Console.WriteLine("\n--- STRIDS-LOGG ---");
                Console.WriteLine($"Stockens basstyrka: {logStrength}");
                Console.WriteLine($"Stockens rörelseskada: {logWeaponDamage}");
                Console.WriteLine($"Din Armor Rating: {playerArmorRating:0.00} (Blockerar {playerArmorRating * 100:0}%)");
                Console.WriteLine($"Total skada från attacken: {logStrength + logWeaponDamage}");
                Console.WriteLine($"Faktisk skada du tog: {finalDamage}");
                Console.WriteLine("--------------------\n");

                pp.Health -= (int)finalDamage;

                Console.WriteLine($"Du har nu {pp.Health} HP kvar.");
                Console.ReadKey();

                if (pp.Strength > 4)
                {
                    Console.WriteLine("\nDu lyckas höja din sköld och blockera det inkommande trädet. ");
                    Console.WriteLine("med hjälp av den lilla mängden \"Strength\" och \"sköld\" och \"rustning\". du har");
                    Console.WriteLine("And luckily for you it was a small tree.");
                    Console.ReadKey();
                }
                else if (pp.Magic > 4)
                {
                    Console.WriteLine("Magic");
                    Console.ReadKey();
                }
                else if (pp.Dexterity > 4)
                {
                    Console.WriteLine("Dexterity");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            m.ShowGraphic();
            Console.WriteLine("Efter lite mer vandring genom skogen kom du äntligen fram till stugan.");
            Console.ReadKey();
            Console.WriteLine("\nFör det är så sent och så mycket tid har gått sedan du gick ut till den där klippan och till den här stugan.");
            Console.ReadKey();

            Console.Clear();
            m.ShowGraphic();
            Console.WriteLine("Thank you for playing my game. \"This is the end\".");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private float CalculateDamageTaken(int strength, int weaponDamage, float armorRating)
        {
            int totalDamage = strength + weaponDamage;
            float damageTaken = totalDamage * (1.0f - armorRating);
            return damageTaken;
        }
    }
}