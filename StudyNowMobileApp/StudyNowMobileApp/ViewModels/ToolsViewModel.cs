using StudyNowMobileApp.Localization;
using StudyNowMobileApp.Models.Base;
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
        ///// <summary>
        ///// Список настроек.
        ///// </summary>
        //public IList<NavItemPage> ToolsItem { get; private set; }

        //private NavItemPage navigateToolsSelectedItem = null;

        ///// <summary>
        ///// Взвращает или задает логику перехода на страницу с настройками. 
        ///// </summary>
        //public NavItemPage NavigateToolsSelectedItem 
        //{ 
        //    get { return navigateToolsSelectedItem; } 
        //    set 
        //    {
        //        if (value != null)
        //        {
        //            NotifyPropertyChanged(nameof(NavigateToolsSelectedItem));
        //            Page page = (Page)Activator.CreateInstance(value.Type);
        //            Navigation.PushAsync(page);
        //        }
        //    } 
        //}

        /// <summary>
        /// Словарь, сопоставляющий названию настройки, соответствующую ей страницу.
        /// </summary>
        private Dictionary<string, Type> pagesTools = new Dictionary<string, Type>()
        {
            [LocalizedText.ToolsLanguageTitle] = typeof(LanguageTools)
        };

        public ICommand NavigateToolsPageCommand { get; private set; }

        public ToolsViewModel()
        {
            NavigateToolsPageCommand = new Command<string>(NavigateToolsPage);
        }

        /// <summary>
        /// Производит переход по указанной странице настроек.
        /// </summary>
        /// <param name="typePage">Класс страницы, на которую нужно перейти.</param>
        private void NavigateToolsPage(string title)
        {
            Page page = (Page)Activator.CreateInstance(pagesTools[title]);
            Navigation.PushAsync(page);
        }
    }
}
