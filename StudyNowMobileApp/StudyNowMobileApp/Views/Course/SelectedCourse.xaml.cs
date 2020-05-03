namespace StudyNowMobileApp.Views.Course
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudyNowMobileApp.Models.Course;
    using StudyNowMobileApp.ViewModels.Course;
    using StudyNowMobileApp.Views.BaseView;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Страница выбранного курса.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedCours : BaseContentPage
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedCours"/> class.
        /// </summary>
        /// <param name="selectedCourse">Выбранный курсю</param>
        public SelectedCours(CourseModel selectedCourse)
        {
            this.InitializeComponent();
            this.BindingContext = new SelectedCourseViewModel(selectedCourse) { Navigation = this.Navigation };
        }
    }
}