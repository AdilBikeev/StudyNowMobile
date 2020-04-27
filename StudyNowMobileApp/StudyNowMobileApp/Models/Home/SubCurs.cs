﻿namespace StudyNowMobileApp.Models.Home
{
    /// <summary>
    /// Описывает под-курс на домашней странице.
    /// </summary>
    public class SubCurs
    {
        /// <summary>
        /// Gets or sets название под-курса.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets путь к картинке под-курса относительно базовой дирриктории.
        /// </summary>
        public string SourceIcon { get; set; }
    }
}
