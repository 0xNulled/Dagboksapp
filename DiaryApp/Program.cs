namespace Dagboksapp
{
    internal class Program
    {
        static void Main()
        {
            const string DiaryFilePath = "text.txt";
            Entries entries = new Entries();

            while (true)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine(" 1: Skriv ny anteckning \n 2: lista anteckningar \n 3: Sök antekning");
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
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input, försök igen");
                            break;
                        }
                }
            }
        }
    }
}