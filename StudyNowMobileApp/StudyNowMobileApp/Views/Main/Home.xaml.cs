namespace StudyNowMobileApp.Views.Main
{
    using StudyNowMobileApp.ViewModels.Main;
    using StudyNowMobileApp.Views.BaseView;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Страница "Домой".
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : BaseContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
            this.InitializeComponent();
            this.Vm = new HomeViewModel() { Navigation = this.Navigation };
            this.BindingContext = this.Vm;
        }
    }
}