namespace StudyNowMobileApp.Hellpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters.
    /// </summary>
    public static class Settings
    {
        private const string KeySettings = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private static ISettings AppSettings => CrossSettings.Current;

        /// <summary>
        ///  Gets or sets настройки по умолчанию.
        /// </summary>
#pragma warning disable SA1202 // Elements should be ordered by access
        public static string GeneralSettings
#pragma warning restore SA1202 // Elements should be ordered by access
        {
            get
            {
                return AppSettings.GetValueOrDefault(KeySettings, SettingsDefault);
            }

            set
            {
                AppSettings.AddOrUpdateValue(KeySettings, value);
            }
        }

        /// <summary>
        /// Возвращает настройки.
        /// </summary>
        /// <param name="key">Ключ настройки.</param>
        /// <returns>Возвращает значение настройки по заданному ключу.</returns>
        public static string GetSettings(string key) => AppSettings.GetValueOrDefault(key, SettingsDefault);

        /// <summary>
        /// Добавляет заданный ключ в LocalStorage.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        public static void AddSettings(string key, string value)
        {
            AppSettings.AddOrUpdateValue(key, value);
        }

        /// <summary>
        /// Удаляет заданный ключ из LocalStorage.
        /// </summary>
        /// <param name="key">Ключ элемента, котоорый нужно удалить.</param>
        public static void Delete(string key)
        {
            AppSettings.Remove(key);
        }
    }
}
