﻿namespace StudyNowMobileApp.Models.Tools
{
    /// <summary>
    /// Язык.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Gets or sets название языка для отображения.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets короткое навзание языка (Например: ru-RU).
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets путь к картинке для заданного языка.
        /// </summary>
        public string ImageSource { get; set; }
    }
}
