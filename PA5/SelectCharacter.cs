namespace PA5
{
    public static class SelectCharacter
    {
        public static Character Chooser()
        {
            Character selectedCharacter = null;
            while (selectedCharacter == null)
            {
                Console.WriteLine("\nChoose your character:");
                Console.WriteLine("1. Mario");
                Console.WriteLine("2. Bowser");
                Console.WriteLine("3. Donkey Kong");

                Console.Write("Enter the number or name of your chosen character: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "one":
                    case "One":
                        return new Mario();
                    case "2":
                    case "two":
                    case "Two":
                        return new Bowser();
                    case "3":
                    case "three":
                    case "Three":
                        return new DonkeyKong();
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            return selectedCharacter;
        }
    }
}