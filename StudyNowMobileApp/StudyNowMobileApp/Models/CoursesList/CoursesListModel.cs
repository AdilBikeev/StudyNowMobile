namespace StudyNowMobileApp.Models.CoursesList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xamarin.Forms;

    /// <summary>
    /// Кнопка курса на странице CourseListPage.xaml.
    /// </summary>
    public class CoursesListModel
    {
        /// <summary>
        /// Gets or sets имя картинки.
        /// </summary>
        public string ImageSource { get; set; }

        /// <summary>
        /// Gets or sets имя курса.
        /// </summary>
        public string Displayname { get; set; }

        /// <summary>
        /// Gets or sets страница с настройкой.
        /// </summary>
        public ContentPage TypePage { get; set; }
    }
}