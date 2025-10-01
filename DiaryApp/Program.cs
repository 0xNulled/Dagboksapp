namespace Dagboksapp
{
    internal class Program
    {
        static int Main()
        {
            Entries entries = new Entries();
            bool running = true;

            while (running)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine(" 1: Skriv ny anteckning \n 2: lista anteckningar \n 3: Sök anteckning");
                Console.WriteLine(" 4: Spara till fil \n 5: Läs från fil \n 6: avsluta");
                string choice = Console.ReadLine();

                switch (choice.Trim())
                {
                    case "1": //Skriv ny anteckning
                        {
                            entries.NewEntry();
                            break;
                        }
                    case "2":
                        {
                            entries.ListEntries();
                            break;
                        }
                    case "3":
                        {
                            entries.SearchEntries();
                            break;
                        }
                    case "4":
                        {
                            entries.SaveToFile();
                            break;
                        }
                    case "5":
                        {
                            entries.ReadFromFile();
                            break;
                        }
                    case "6":
                        {
                            running = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input, försök igen");
                            break;
                        }
                }
            }
            return 0;
        }
    }
}