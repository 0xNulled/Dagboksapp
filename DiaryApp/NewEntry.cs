namespace Dagboksapp
{
    public class Entries
    {
        private List<DiaryEntry> EntryList = new List<DiaryEntry>();

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

    }
}