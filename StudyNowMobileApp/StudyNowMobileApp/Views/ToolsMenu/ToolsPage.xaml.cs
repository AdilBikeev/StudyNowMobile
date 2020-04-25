using StudyNowMobileApp.ViewModels;
using StudyNowMobileApp.ViewModels.Tools;
using StudyNowMobileApp.Views.BaseView;
using Xamarin.Forms.Xaml;

namespace StudyNowMobileApp.Views.ToolsMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolsPage : BaseContentPage
    {
        public ToolsPage(BaseViewModel viewModel)
        {
            this.vm = viewModel;
            InitializeComponent();
            BindingContext = new ToolsViewModel() { Navigation = this.Navigation };
        }
    }
}