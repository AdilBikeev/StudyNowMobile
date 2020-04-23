using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StudyNowMobileApp.ViewModels;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration;
using StudyNowMobileApp.Views.BaseView;

namespace StudyNowMobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        private BaseViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            
        }

        
        protected override void OnDisappearing()
        {
            foreach (var item in this.Children)
            {
                if(item.BindingContext != null && item.BindingContext is BaseViewModel)
                {
                    (item.BindingContext as BaseViewModel).UpdatePropertyChanged();
                }
            }
            base.OnDisappearing();
        }
        
    }
}
