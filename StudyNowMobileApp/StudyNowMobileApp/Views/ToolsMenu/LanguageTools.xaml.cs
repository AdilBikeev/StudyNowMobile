﻿namespace StudyNowMobileApp.Views.ToolsMenu
{
    using StudyNowMobileApp.ViewModels;
    using StudyNowMobileApp.ViewModels.Tools;
    using StudyNowMobileApp.Views.BaseView;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Страница "Настройки языка".
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageTools : BaseContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageTools"/> class.
        /// </summary>
        /// <param name="viewModel">ViewModel, которая использовалась на предыдущей странице.</param>
        public LanguageTools(BaseViewModel viewModel)
        {
            this.InitializeComponent();
            this.BindingContext = new LanguageToolsViewModel() { Navigation = this.Navigation };
            this.Vm = viewModel;
        }
    }
}