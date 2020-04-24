using StudyNowMobileApp.Hellpers;
using StudyNowMobileApp.Localization;
using StudyNowMobileApp.Models.Tools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudyNowMobileApp.ViewModels.Tools
{
    public class LanguageToolsViewModel: BaseViewModel
    {
        //public ICommand ChooseLangCommand { get; private set; }
        public Language ChooseLangCommand 
        { 
            get => null;
            set => this.ChangeText(value);
        }

        protected override List<string> propertyNames { get; set; } = new List<string>()
        {
            nameof(TitlePage),
            nameof(Languages)
        };

        /// <summary>
        /// Список доступных языков для локализации приложения.
        /// </summary>
        public List<Language> Languages 
        {
            get => LocalizationHellper.Languages;

            set => new NotImplementedException();
        }
        public override string TitlePage { get => LocalizedText.ToolsLanguageTitle; set => new NotImplementedException(); }

        public LanguageToolsViewModel() { }

        private void ChangeText(Language lang)
        {
            if(lang != null)
            {
                LocalizationHellper.SetLocalization(lang);
                Settings.AddSettings(nameof(lang), lang.ShortName);
                this.UpdatePropertyChanged();
            }
        }
    }
}
