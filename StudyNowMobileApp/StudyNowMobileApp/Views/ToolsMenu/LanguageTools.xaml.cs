using StudyNowMobileApp.ViewModels.Tools;
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
    public partial class LanguageTools : ContentPage
    {
        public LanguageTools()
        {
            InitializeComponent();
            BindingContext = new LanguageToolsViewModel() { Navigation = this.Navigation };
        }
    }
}