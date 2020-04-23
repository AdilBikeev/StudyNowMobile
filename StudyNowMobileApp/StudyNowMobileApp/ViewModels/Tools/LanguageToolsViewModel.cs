﻿using StudyNowMobileApp.Hellpers;
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
        public string Title { get => LocalizedText.ToolsLanguageTitle; set => new NotImplementedException(); }

        //public ICommand ChooseLangCommand { get; private set; }
        public Language ChooseLangCommand 
        { 
            get => null;
            set => this.ChangeText(value);
        }

        protected override List<string> propertyNames { get; set; } = new List<string>()
        {
            nameof(Title),
            nameof(Languages)
        };

        /// <summary>
        /// Список доступных языков для локализации приложения.
        /// </summary>
        public List<Language> Languages 
        { 
            get => new List<Language>()
            {
                new Language(){ DisplayName = LocalizedText.LabelLangRuText, ShortName = "ru-RU", ImageSource = "Russian.png" },
                new Language(){ DisplayName = LocalizedText.LabelLangEnText, ShortName = "en-GB", ImageSource = "English.png" }
            };

            set => new NotImplementedException();
        }

        public LanguageToolsViewModel() { }

        private void ChangeText(Language lang)
        {
            if(lang != null)
            {
                CultureInfo.CurrentCulture = new CultureInfo(lang.ShortName);
                CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

                LocalizedText.Culture = CultureInfo.CurrentCulture;
                this.UpdatePropertyChanged();
            }
        }
    }
}