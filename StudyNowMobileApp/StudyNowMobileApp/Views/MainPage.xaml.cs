namespace StudyNowMobileApp.Views
{
    using System.ComponentModel;
    using StudyNowMobileApp.ViewModels;

    /// <summary>
    /// Главная страница.
    /// </summary>
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <inheritdoc/>
        protected override void OnDisappearing()
        {
            foreach (var item in this.Children)
            {
                if (item.BindingContext != null && item.BindingContext is BaseViewModel)
                {
                    (item.BindingContext as BaseViewModel).UpdatePropertyChanged();
                }
            }

            base.OnDisappearing();
        }
    }
}
