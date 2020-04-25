using StudyNowMobileApp.ViewModels.Main;
using StudyNowMobileApp.Views.BaseView;
using Xamarin.Forms.Xaml;

namespace StudyNowMobileApp.Views.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : BaseContentPage
    {
        public Home()
        {
            InitializeComponent();
            this.vm = new HomeViewModel() { Navigation = this.Navigation };
            BindingContext = this.vm;
        }
    }
}