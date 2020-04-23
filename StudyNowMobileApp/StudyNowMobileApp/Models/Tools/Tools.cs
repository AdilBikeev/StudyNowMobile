using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StudyNowMobileApp.Models.Tools
{
    /// <summary>
    /// Настройка.
    /// </summary>
    public class Tool
    {
        /// <summary>
        /// Название настройки.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Страница с настройкой.
        /// </summary>
        public ContentPage typePage { get; set; }
    }
}
