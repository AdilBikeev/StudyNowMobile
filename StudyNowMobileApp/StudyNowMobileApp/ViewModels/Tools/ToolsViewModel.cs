﻿namespace StudyNowMobileApp.ViewModels.Tools
{
    using System;
    using System.Collections.Generic;
    using StudyNowMobileApp.Localization;
    using StudyNowMobileApp.Models.Tools;
    using StudyNowMobileApp.Views.ToolsMenu;

    /// <summary>
    /// Служит прослойкой для Tools.xaml.
    /// </summary>
    public class ToolsViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets список настроек приложения.
        /// </summary>
        public List<Tool> Tools => new List<Tool>()
        {
            new Tool() { Name = LocalizedText.ToolsLanguageTitle, TypePage = new LanguageTools(this) },
        };

        /// <summary>
        /// Gets or sets дейсвтия при выборе настройки.
        /// </summary>
        public Tool SelectedToolCommand
        {
            get => null;
            set
            {
                if (value != null)
                {
                    this.Navigation.PushAsync(value.TypePage);
                    this.UpdatePropertyChanged();
                }
            }
        }

        /// <inheritdoc/>
        public override string TitlePage => LocalizedText.ToolsPageTitle;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsViewModel"/> class.
        /// </summary>
#pragma warning disable SA1201 // Elements should appear in the correct order
        public ToolsViewModel()
#pragma warning restore SA1201 // Elements should appear in the correct order
        {
        }

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.TitlePage),
            nameof(this.Tools),
        };
    }
}
