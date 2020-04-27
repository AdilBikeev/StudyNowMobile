namespace StudyNowMobileApp.ViewModels.Tools
{
    using System;
    using System.Collections.Generic;
    using StudyNowMobileApp.Hellpers;
    using StudyNowMobileApp.Localization;
    using StudyNowMobileApp.Models.Tools;

    /// <summary>
    /// Служит прослойкой для LanguageTools.xaml.
    /// </summary>
    public class LanguageToolsViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets дейсвтие при выборе языка.
        /// </summary>
        public Language ChooseLangCommand
        {
            get => null;
            set => this.ChangeText(value);
        }

        /// <summary>
        /// Gets список доступных языков для локализации приложения.
        /// </summary>
        public List<Language> Languages => LocalizationHellper.Languages;

        /// <inheritdoc/>
        public override string TitlePage => LocalizedText.ToolsLanguageTitle;

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.TitlePage),
            nameof(this.Languages),
        };

        private void ChangeText(Language lang)
        {
            if (lang != null)
            {
                LocalizationHellper.SetLocalization(lang);
                SettingsHellper.AddSettings(nameof(lang), lang.ShortName);
                this.UpdatePropertyChanged();
            }
        }
    }
}
