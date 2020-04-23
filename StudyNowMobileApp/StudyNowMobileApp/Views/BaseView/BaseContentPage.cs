using StudyNowMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StudyNowMobileApp.Views.BaseView
{
    /// <summary>
    /// Базове представление страницы.
    /// </summary>
    public abstract class BaseContentPage: ContentPage 
    {
        /// <summary>
        /// ViewModel, с которой был произведен переход на заданное представление.
        /// </summary>
        protected BaseViewModel vm;

        protected override void OnDisappearing()
        {
            this.vm.UpdatePropertyChanged();
            base.OnDisappearing();
        }
    }
}
