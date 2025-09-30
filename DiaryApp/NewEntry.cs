namespace Dagboksapp
{
    public class Entries
    {
        private List<DiaryEntry> ListEntries;

        public void NewEntry()
        {
            Console.WriteLine("Vad vill du säga till din dagbok?");
            string Entry = Console.ReadLine();

            if (Entry == null)
            {
                Console.WriteLine("Ditt inlägg kan inte vara tomt");
                return;
            }
            
            ListEntries.Add(new DiaryEntry(Entry));
        }

    }
}