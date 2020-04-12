using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudyNomMobileApp.Models.Base
{
    /// <summary>
    /// Навиг. элементы.
    /// </summary>
    internal class NavItemImage
    {
        /// <summary>
        /// Описание навиг. элемента (его имя).
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Путь к картинке навиг. элемента.
        /// </summary>
        public string Path { get; set; }

        public NavItemImage (string title, string path)
        {
            this.Title = title;
            this.Path = path;
        }
    }
}
