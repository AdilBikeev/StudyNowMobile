using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyNowMobileApp.Hellpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion

        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        /// <summary>
        /// Возвращает значение настройки по заданному ключу.
        /// </summary>
        /// <param name="key">Ключ настройки.</param>
        public static string GetSettings(string key) => AppSettings.GetValueOrDefault(key, SettingsDefault);

        /// <summary>
        /// Добавляет заданный ключ в LocalStorage.
        /// </summary>
        public static void AddSettings(string key, string value)
        {
            AppSettings.AddOrUpdateValue(key, value);
        }

        /// <summary>
        /// Удаляет заданный ключ из LocalStorage.
        /// </summary>
        public static void Delete(string key)
        {
            AppSettings.Remove(key);
        }
    }
}
