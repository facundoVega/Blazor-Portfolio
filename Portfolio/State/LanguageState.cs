namespace Portfolio.State
{
    public class LanguageState : ILanguageState
    {
        public string SelectedLanguage { get; private set; }

        public event Action OnChange;

        public void SetLanguage(string language)
        {
            SelectedLanguage = language;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
