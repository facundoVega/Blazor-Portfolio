using System.Security.Cryptography;

namespace Portfolio.State
{
    public interface ILanguageState
    {
        string SelectedLanguage { get; }
        void SetLanguage(string language);
        event Action OnChange;

    }
}
