namespace StudyNowMobileApp.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Text;
    using StudyNowMobileApp.Models.Course;

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
        public SelectedCourseViewModel(CourseModel course)
        {
            this.SelectedCours = course;
        }

        /// <summary>
        /// Gets выбранный курс.
        /// </summary>
        public CourseModel SelectedCours { get; private set; }

        /// <summary>
        /// Gets список заданий курса.
        /// </summary>
        public IList<CourseTask> CourseTasks => this.SelectedCours.TaskPages;

        /// <summary>
        /// Gets фоновая картинка курса.
        /// </summary>
        public string BacgroundCoursImage { get => this.SelectedCours.BacgroundCoursImage; }

        /// <summary>
        /// Gets иконку, отоюражаемая на каждом задании курса.
        /// </summary>
        public string TaskIcon => this.SelectedCours.IconImage;

        /// <inheritdoc/>
        public override string TitlePage { get => this.SelectedCours.DisplayName; }

        /// <summary>
        /// Gets кол-во заданий курса.
        /// </summary>
        public int TaskCount => this.SelectedCours.TaskPages.Count;

        /// <summary>
        /// Gets кол-во пройденных заданий курса.
        /// </summary>
        public int TaskComplete => this.SelectedCours.TaskPages.Count(x => x.IsDone == true);

        /// <summary>
        /// Gets процентное соотношение решенных заданий курса.
        /// </summary>
        public float ProgressCours => this.TaskComplete / this.TaskCount;

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.TitlePage),
        };
    }
}
