namespace StudyNowMobileApp.Views.BaseView
{
    using StudyNowMobileApp.ViewModels;
    using Xamarin.Forms;

    /// <summary>
    /// Базове представление страницы.
    /// </summary>
    public abstract class BaseContentPage : ContentPage
    {
        /// <summary>
        /// Gets or sets viewModel, с которой был произведен переход на заданное представление.
        /// </summary>
        protected BaseViewModel Vm { get; set; }

        /// <inheritdoc/>
        protected override void OnDisappearing()
        {
            if (this.Vm != null)
            {
                this.Vm.UpdatePropertyChanged();
            }

            base.OnDisappearing();
        }
    }
}
