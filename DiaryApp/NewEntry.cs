using System.IO;
using System.Text;
using System;

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
            DateTime DateSearch;
            Console.WriteLine("När skrevs anteckningen? (åååå-mm-dd):");
            string search = Console.ReadLine();

            try
            {
                DateSearch = Convert.ToDateTime(search);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sökning misslyckades: {ex}");
                return;
            }

            if (search == null)
            {
                Console.WriteLine("Du måste söka efter något");
                return;
            }

            var result = EntryList.FindAll(entry => entry.Date.Date.Equals(DateSearch));
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
            string[] seperator = { ": " };
            foreach (string line in File.ReadLines(DiaryFilePath))
            {
                if (line == "")
                {
                    continue;
                }
                var a = line.Split(seperator, StringSplitOptions.None);
                EntryList.Add(new DiaryEntry(String.Join(seperator[0], a[1..a.Length]), a[0]));
            }
        }
    }
}