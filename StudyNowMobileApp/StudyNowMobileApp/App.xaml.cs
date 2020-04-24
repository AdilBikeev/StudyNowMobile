using StudyNowMobileApp.Hellpers;
using StudyNowMobileApp.Models.Tools;
using StudyNowMobileApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyNowMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitBaseSettings();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        /// <summary>
        /// Инициализация настроек приложения, необохдимых до его запуска.
        /// </summary>
        private void InitBaseSettings()
        {
            string lang = Settings.GetSettings(nameof(lang));

            if (!string.IsNullOrEmpty(lang))
            {
                LocalizationHellper.SetLocalizationOrDefault(lang);
            }
        }
    }
}
