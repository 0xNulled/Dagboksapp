namespace Dagboksapp
{
    public class DiaryEntry
    {
        public DateTime Date { get; }
        public string Text { get; set; }
        public DiaryEntry(string Text)
        {
            this.Text = Text;
        }
    }
}