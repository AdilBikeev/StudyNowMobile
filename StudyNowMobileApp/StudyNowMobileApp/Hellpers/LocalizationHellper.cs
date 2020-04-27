﻿namespace StudyNowMobileApp.Hellpers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using StudyNowMobileApp.Localization;
    using StudyNowMobileApp.Models.Tools;
    using StudyNowMobileApp.Views.ToolsMenu;

    /// <summary>
    /// Класс-помощник в локализации приложения.
    /// </summary>
    public static class LocalizationHellper
    {
        /// <summary>
        /// Gets список языков.
        /// </summary>
        public static List<Language> Languages => new List<Language>()
        {
            new Language() { DisplayName = LocalizedText.LabelLangRuText, ShortName = "ru-RU", ImageSource = "Tools_Lang_Russian.png" },
            new Language() { DisplayName = LocalizedText.LabelLangEnText, ShortName = "en-GB", ImageSource = "Tools_Lang_English.png" },
        };

        private static Language DefaultLang => Languages.First();

        /// <summary>
        /// Устанавливает локализацию приложения.
        /// </summary>
        /// <param name="lang">Язык приложения.</param>
        public static void SetLocalization(Language lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang?.ShortName);
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
            LocalizedText.Culture = CultureInfo.CurrentCulture;
        }

        /// <summary>
        /// Устанавливает локализацию приложения, если есть  соответствующий ему короткое имя в Languages.
        /// В ином случаи задает язык по умолчанию.
        /// </summary>
        /// <param name="lang">Короткое название языка.</param>
        public static void SetLocalizationOrDefault(string lang)
        {
            Language language = DefaultLang;

            foreach (var item in Languages)
            {
                if (item.ShortName == lang)
                {
                    language = item;
                    break;
                }
            }

            SetLocalization(language);
        }
    }
}
