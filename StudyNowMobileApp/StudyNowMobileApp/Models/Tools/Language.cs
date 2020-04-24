using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudyNowMobileApp.Models.Tools
{
    /// <summary>
    /// Язык
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Название языка для отображения.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Короткое навзание языка (Например: ru-RU).
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Путь к картинке для заданного языка.
        /// </summary>
        public string ImageSource { get; set; }
    }
}
