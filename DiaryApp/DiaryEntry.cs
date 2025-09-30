namespace Dagboksapp
{
    public class DiaryEntry
    {
        public DateTime Date { get; }
        public string Text { get; set; }
        public DiaryEntry(string Text)
        {
            this.Text = Text;
            Date = DateTime.Now;
        }

        public void PrintDiaryEntry()
        {
            Console.WriteLine($" {Date}: \n {Text}");
        }
    }
}