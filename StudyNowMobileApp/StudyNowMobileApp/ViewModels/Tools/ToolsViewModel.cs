using StudyNowMobileApp.Localization;
using StudyNowMobileApp.Models.Base;
using StudyNowMobileApp.Models.Tools;
using StudyNowMobileApp.Views.ToolsMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudyNowMobileApp.ViewModels.Tools
{
    public class ToolsViewModel: BaseViewModel
    {
        /// <summary>
        /// Список настроек приложения.
        /// </summary>
        public List<Tool> Tools
        {
            get => new List<Tool>()
            {
                new Tool() { Name = LocalizedText.ToolsLanguageTitle, TypePage = new LanguageTools(this) }
            };
            set => throw new NotImplementedException();
        }

        public Tool SelectedToolCommand
        {
            get => null;
            set
            {
                if(value != null)
                {
                    Navigation.PushAsync(value.TypePage);
                    this.UpdatePropertyChanged();
                }
            }
        }

        protected override List<string> PropertyNames  => new List<string>()
        {
            nameof(TitlePage),
            nameof(Tools)
        };

        public override string TitlePage => LocalizedText.ToolsPageTitle;

        public ToolsViewModel() { }
    }
}
