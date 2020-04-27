using StudyNowMobileApp.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyNowMobileApp.ViewModels.Main
{
    /// <summary>
    /// Главная страница приложения.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Описание кнопки "Домой" на навигационной панели.
        /// </summary>
        public string HomeTitle
        {
            get => LocalizedText.HomeIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Описание кнопки "Тренироваться" на навигационной панели.
        /// </summary>
        public string WorkoutTitle
        {
            get => LocalizedText.WorkoutIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Описание кнопки "Тренироваться" на навигационной панели.
        /// </summary>
        public string NewsTitle
        {
            get => LocalizedText.NewsIconTitle;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Описание кнопки "Статистика" на навигационной панели.
        /// </summary>
        public string StatsTitle
        {
            get => LocalizedText.StatsIconTitle;
            set => throw new NotImplementedException();
        }

        public override string TitlePage => throw new NotImplementedException();

        protected override List<string> PropertyNames  => new List<string>()
        {
            nameof(HomeTitle),
            nameof(WorkoutTitle),
            nameof(NewsTitle),
            nameof(StatsTitle)
        };
    }
}
