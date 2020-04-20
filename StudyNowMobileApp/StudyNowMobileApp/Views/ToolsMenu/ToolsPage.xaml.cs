using StudyNowMobileApp.ViewModels;
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
    public partial class ToolsPage : ContentPage
    {
        public ToolsPage()
        {
            InitializeComponent();
            BindingContext = new ToolsViewModel() { Navigation = this.Navigation };
        }
    }
}