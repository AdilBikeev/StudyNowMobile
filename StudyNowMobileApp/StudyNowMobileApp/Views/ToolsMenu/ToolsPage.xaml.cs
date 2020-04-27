﻿namespace StudyNowMobileApp.Views.ToolsMenu
{
    using StudyNowMobileApp.ViewModels;
    using StudyNowMobileApp.ViewModels.Tools;
    using StudyNowMobileApp.Views.BaseView;
    using Xamarin.Forms.Xaml;

    /// <summary>
    /// Страница "Настройки".
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolsPage : BaseContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPage"/> class.
        /// </summary>
        /// <param name="viewModel">ViewModel предыдущей страницы.</param>
        public ToolsPage(BaseViewModel viewModel)
        {
            this.Vm = viewModel;
            this.InitializeComponent();
            this.BindingContext = new ToolsViewModel() { Navigation = this.Navigation };
        }
    }
}