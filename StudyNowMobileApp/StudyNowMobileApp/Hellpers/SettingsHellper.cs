﻿//------------------------------------------------------------------------------
// <auto-generated>
// MIT License
// 
// Copyright (c) 2020 Bikeev Adil Issaevich
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </auto-generated>
//------------------------------------------------------------------------------
namespace StudyNowMobileApp.Hellpers
{
    using PluginSetting = Plugin.Settings;

    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters.
    /// </summary>
    public static class SettingsHellper
    {
        private const string KeySettings = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private static PluginSetting.Abstractions.ISettings AppSettings => PluginSetting.CrossSettings.Current;

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
