using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Naxam.Controls.Forms;
using StudyNowMobileApp.ViewModels;

namespace StudyNowMobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : BottomTabbedPage
    {
        private BaseViewModel vm;

        public MainPage()
        {
            this.vm = new MainViewModel();
            InitializeComponent();
            BindingContext = this.vm;
        }

        protected override void OnAppearing()
        {
            this.vm.UpdatePropertyChanged();
            base.OnAppearing();
        }
    }
}
