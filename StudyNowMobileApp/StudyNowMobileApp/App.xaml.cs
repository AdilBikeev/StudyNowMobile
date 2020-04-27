﻿namespace StudyNowMobileApp
{
    using System;
    using StudyNowMobileApp.Hellpers;
    using StudyNowMobileApp.Models.Tools;
    using StudyNowMobileApp.Views;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// MainClass.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            this.InitBaseSettings();
            this.InitializeComponent();

            this.MainPage = new NavigationPage(new MainPage());
        }

        /// <inheritdoc/>
        protected override void OnStart()
        {
        }

        /// <inheritdoc/>
        protected override void OnSleep()
        {
        }

        /// <inheritdoc/>
        protected override void OnResume()
        {
        }

        /// <summary>
        /// Инициализация настроек приложения, необохдимых до его запуска.
        /// </summary>
        private void InitBaseSettings()
        {
            string lang = SettingsHellper.GetSettings(nameof(lang));

            if (!string.IsNullOrEmpty(lang))
            {
                LocalizationHellper.SetLocalizationOrDefault(lang);
            }
        }
    }
}
