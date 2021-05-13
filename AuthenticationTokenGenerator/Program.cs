using System;

namespace AuthenticationTokenGenerator
{
    class Program
    {
        private static void Menu()
        {
            Console.WriteLine("Type the number of your option:");
            Console.WriteLine("1) Generate random GUID and its token");
            Console.WriteLine("2) Enter a existing GUID and generate its token");
            Console.WriteLine("0) Exit program");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Menu();

                bool validNumber = int.TryParse(Console.ReadLine(), out choice);

                if (!validNumber)
                {
                    Console.WriteLine($"Invalid option, please try again");
                    Console.WriteLine();
                    choice = -1;
                    continue;
                }

                string guid;
                string token;
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        guid = Generator.StringGuidGenerator();
                        token = Generator.StringTokenGenerator(guid);
                        break;
                    case 2:
                        guid = Console.ReadLine();
                        token = Generator.StringTokenGenerator(guid);
                        break;
                    default:
                        Console.WriteLine($"Invalid option, please try again");
                        Console.WriteLine();
                        continue;
                }

                Console.WriteLine();
                Console.WriteLine($"GUID: {guid}");
                Console.WriteLine($"Token: {token}");
                Console.WriteLine();
            }
        }
    }
}
