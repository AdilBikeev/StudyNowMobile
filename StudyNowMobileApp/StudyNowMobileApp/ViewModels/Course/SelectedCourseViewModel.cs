namespace StudyNowMobileApp.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Text;
    using StudyNowMobileApp.Models.CoursesList;

    /// <summary>
    /// Служит прослойкой для SelectedCourse.xaml.
    /// </summary>
    public class SelectedCourseViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedCourseViewModel"/> class.
        /// Инициализирует страницу подставляя все данные о курсе согласно пришедшему объекту.
        /// </summary>
        /// <param name="course">Объект выбранного курса.</param>
        public SelectedCourseViewModel(CoursesListModel course)
        {
            this.SelectedCours = course;
        }

        /// <summary>
        /// Gets выбранный курс.
        /// </summary>
        public CoursesListModel SelectedCours { get; private set; }

        /// <summary>
        /// Gets фоновая картинка курса.
        /// </summary>
        public string BacgroundCoursImage { get => this.SelectedCours.BacgroundCoursImage; }

        /// <inheritdoc/>
        public override string TitlePage { get => this.SelectedCours.DisplayName; }

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.TitlePage),
        };
    }
}
