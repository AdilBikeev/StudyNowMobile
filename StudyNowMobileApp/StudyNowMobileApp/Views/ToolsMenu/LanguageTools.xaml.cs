using StudyNowMobileApp.ViewModels;
using StudyNowMobileApp.ViewModels.Tools;
using StudyNowMobileApp.Views.BaseView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyNowMobileApp.Views.ToolsMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageTools : BaseContentPage
    {
        public LanguageTools(BaseViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = new LanguageToolsViewModel() { Navigation = this.Navigation };
            this.Vm = viewModel;
        }
    }
}