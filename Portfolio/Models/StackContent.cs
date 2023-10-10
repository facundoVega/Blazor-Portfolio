namespace Portfolio.Models
{
    public class StackContent
    {
        public string HeaderTitle { get; set; }
        public string HeaderSubtitle { get; set; }
        public string HeaderInfo { get; set; }
        public string SectionTitle { get; set; }
        public List<string> Paragraphs { get; set; }
        public List<StackItem> StackItems { get; set; }
    }
}
