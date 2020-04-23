using StudyNowMobileApp.Localization;
using StudyNowMobileApp.Models.Base;
using StudyNowMobileApp.Models.Tools;
using StudyNowMobileApp.Views.ToolsMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudyNowMobileApp.ViewModels
{
    public class ToolsViewModel: BaseViewModel
    {
        public string Title { get => LocalizedText.ToolsPageTitle; set => throw new NotImplementedException(); }

        /// <summary>
        /// Список настроек приложения.
        /// </summary>
        public List<Tool> Tools
        {
            get => new List<Tool>()
            {
                new Tool() { Name = LocalizedText.ToolsLanguageTitle, typePage = new LanguageTools(this) }
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
                    //Page page = (Page)Activator.CreateInstance(value.typePage);
                    //Navigation.PushAsync(page);
                    Navigation.PushAsync(value.typePage);
                    this.UpdatePropertyChanged();
                }
            }
        }

        protected override List<string> propertyNames 
        {
            get => new List<string>()
            {
                nameof(Title),
                nameof(Tools)
            };
            set => throw new NotImplementedException(); 
        }

        public ToolsViewModel() { }
    }
}
