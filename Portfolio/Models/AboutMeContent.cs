using Portfolio.Components;
using System.Security.Cryptography.X509Certificates;

namespace Portfolio.Models
{
    public class AboutMeContent
    {
        public string HeaderTitle { get; set; }
        public string HeaderSubtitle { get; set; }
        public string HeaderInfo { get; set; }
        public string SectionTitle { get; set; }
        public string SectionSubtitle { get; set; }
        public List<string> Paragraphs { get; set; }
    }
}
