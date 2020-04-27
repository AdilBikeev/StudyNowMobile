namespace StudyNowMobileApp
{
    using System;
    using StudyNowMobileApp.Hellpers;
    using StudyNowMobileApp.Models.Tools;
    using StudyNowMobileApp.Views;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

#pragma warning disable SA1601 // Partial elements should be documented
    public partial class App : Application
#pragma warning restore SA1601 // Partial elements should be documented
    {
#pragma warning disable SA1600 // Elements should be documented
        public App()
#pragma warning restore SA1600 // Elements should be documented
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
