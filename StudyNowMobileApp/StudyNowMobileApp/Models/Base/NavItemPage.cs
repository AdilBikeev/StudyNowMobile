﻿namespace StudyNowMobileApp.Models.Base
{
    using System;

    /// <summary>
    /// Навиг. элементы.
    /// </summary>
    public class NavItemPage
    {
        /// <summary>
        /// Gets or sets описание навиг. элемента (его имя).
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets тип страницы.
        /// </summary>
        public Type Type { get; set; }
    }
}
