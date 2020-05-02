namespace StudyNowMobileApp.Views.Course
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudyNowMobileApp.Models.CoursesList;
    using StudyNowMobileApp.ViewModels;
    using StudyNowMobileApp.ViewModels.Course;
    using StudyNowMobileApp.Views.BaseView;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Список курсов.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoursesListPage : BaseContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoursesListPage"/> class.
        /// </summary>
        /// <param name="coursesLists">Список курсов для отображения на странице.</param>
        public CoursesListPage(IList<CoursesListModel> coursesLists)
        {
            this.InitializeComponent();
            this.BindingContext = new CoursesListViewModel(coursesLists) { Navigation = this.Navigation };
        }
    }
}