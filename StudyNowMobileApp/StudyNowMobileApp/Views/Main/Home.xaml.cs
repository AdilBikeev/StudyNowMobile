using StudyNowMobileApp.ViewModels;
using StudyNowMobileApp.Views.BaseView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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