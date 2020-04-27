﻿namespace StudyNowMobileApp.ViewModels.Main
{
    using System;
    using System.Collections.Generic;
    using StudyNowMobileApp.Localization;

    /// <summary>
    /// Главная страница приложения.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets описание кнопки "Домой" на навигационной панели.
        /// </summary>
        public string HomeTitle
        {
            get => LocalizedText.HomeIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets описание кнопки "Тренироваться" на навигационной панели.
        /// </summary>
        public string WorkoutTitle
        {
            get => LocalizedText.WorkoutIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets описание кнопки "Тренироваться" на навигационной панели.
        /// </summary>
        public string NewsTitle
        {
            get => LocalizedText.NewsIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets описание кнопки "Статистика" на навигационной панели.
        /// </summary>
        public string StatsTitle
        {
            get => LocalizedText.StatsIconTitle;
            set => throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string TitlePage => LocalizedText.HomeIconTitle;

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.HomeTitle),
            nameof(this.WorkoutTitle),
            nameof(this.NewsTitle),
            nameof(this.StatsTitle),
        };
    }
}
