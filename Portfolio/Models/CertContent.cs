namespace Portfolio.Models
{
    public class CertContent
    {
        public string HeaderTitle { get; set; }
        public string HeaderSubtitle { get; set; }
        public string HeaderInfo { get; set; }

        public List<CertItemContent> CertItems { get; set; }
    }
}
