using System.IO;
using System.Text;

namespace Dagboksapp
{
    public class Entries
    {
        private List<DiaryEntry> EntryList = new List<DiaryEntry>();
        private const string DiaryFilePath = "text.txt";


        public void NewEntry()
        {
            Console.WriteLine("Vad vill du säga till din dagbok?");
            string Entry = Console.ReadLine();

            if (Entry == null)
            {
                Console.WriteLine("Ditt inlägg kan inte vara tomt");
                return;
            }

            EntryList.Add(new DiaryEntry(Entry));
            Console.WriteLine("Din anteckning har lagts till");
        }

        public void ListEntries()
        {
            Console.WriteLine("Dina anteckningar: ");
            foreach (DiaryEntry entry in EntryList)
            {
                entry.PrintDiaryEntry();
            }
        }
        public void SearchEntries()
        {
            Console.WriteLine("Vad söker du efter?");
            string search = Console.ReadLine();
            if (search == null)
            {
                Console.WriteLine("Du måste söka efter något");
                return;
            }

            var result = EntryList.FindAll(entry => entry.Text.Contains(search));
            foreach (var entry in result)
            {
                entry.PrintDiaryEntry();
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public void SaveToFile()
        {
            if (!File.Exists(DiaryFilePath))
            {
                using (FileStream fs = File.Create(DiaryFilePath))
                {
                    foreach (DiaryEntry entry in EntryList)
                    {
                        AddText(fs, $"{entry.Date}: {entry.Text} \n");
                    }
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(DiaryFilePath))
                {
                    foreach (DiaryEntry entry in EntryList)
                    {
                        sw.WriteLine($"{entry.Date}: {entry.Text} \n");
                    }
                }
            }
            Console.WriteLine("Anteckningar sparade på hårddisk \n");
        }

        public void ReadFromFile()
        {
            
        }
    }
}