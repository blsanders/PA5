namespace PA5
{
    class Program
    {
        static void Main()
        {
            Character mario = new Mario();
            Character bowser = new Bowser();
            Character donkeyKong = new DonkeyKong();

            Console.Write("Player 1, enter your name: ");
            string player1Name = Console.ReadLine();
            Character player1Character = SelectCharacter.Chooser();

            Console.Write("Player 2, enter your name: ");
            string player2Name = Console.ReadLine();
            Character player2Character = SelectCharacter.Chooser();

            Console.WriteLine($"\n{player1Name}'s Attributes:");
            DisplayCharacterAttributes(player1Character);

            Console.WriteLine($"\n{player2Name}'s Attributes:");
            DisplayCharacterAttributes(player2Character);

            Console.WriteLine("\nGame Started!");
            Console.WriteLine($"{player1Name}'s {player1Character.Name} vs. {player2Name}'s {player2Character.Name}");

            bool TurnDeciderNum = new Random().Next(2) == 0;

            while (player1Character.Health > 0 && player2Character.Health > 0)
            {
                if (TurnDeciderNum)
                    TakeTurn(player1Character, player2Character);
                else
                    TakeTurn(player2Character, player1Character);
                TurnDeciderNum = !TurnDeciderNum;
            }

            Console.WriteLine("\nGame Over!");
            Console.WriteLine($"{(player1Character.Health <= 0 ? player2Character.Name : player1Character.Name)} wins!");
        }

        static void DisplayCharacterAttributes(Character character)
        {
            Console.WriteLine($"Name: {character.Name}");
            Console.WriteLine($"MaxAttackPower: {character.MaxAttackPower}");
            Console.WriteLine($"Health: {character.Health}");
            Console.WriteLine($"MaxDefensePower: {character.MaxDefensePower}");
            Console.Write("AttackType: ");
            character.AttackType.Do_Attack();
            Console.WriteLine();
        }

        static void TakeTurn(Character attacker, Character defender)
        {
            int attackPower = new Random().Next(1, attacker.MaxAttackPower + 1);
            int defensePower = new Random().Next(1, defender.MaxDefensePower + 1);
            int damageDealt = CalculateDamage(attacker, defender, attackPower, defensePower);

            Console.WriteLine($"{attacker.Name} attacks {defender.Name} with power {attackPower}, dealing {damageDealt} damage.");
            defender.Health -= damageDealt;
            Console.WriteLine($"{defender.Name}'s Stats For This Turn: Health = {defender.Health}, DefensePower = {defensePower}");
        }

        static int CalculateDamage(Character attacker, Character defender, int attackPower, int defensePower)
        {
            double typeBonus = CalculateTypeBonus(attacker, defender);
            int damage = (int)((attackPower - defensePower) * typeBonus);
            return Math.Max(1, damage);
        }

        static double CalculateTypeBonus(Character attacker, Character defender)
        {
            if ((attacker is Mario && defender is Bowser) || (attacker is DonkeyKong && defender is Mario))
            {
                return 1.2;
            }

            return 1.0;
        }
    }
}