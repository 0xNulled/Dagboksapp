namespace Dagboksapp
{
    public class DiaryEntry
    {
        public DateTime Date { get; }
        public string Text { get; set; }
        public DiaryEntry(string Text, string date = "")
        {
            this.Text = Text;
            if (date == "")
            {
                Date = DateTime.Now;
            }
            else
            {
                Date = DateTime.Parse(date);
            }
        }

        public void PrintDiaryEntry()
        {
            Console.WriteLine($" {Date}: {Text}");
        }
    }
}