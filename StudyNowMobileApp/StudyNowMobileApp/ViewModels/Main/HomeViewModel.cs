using StudyNowMobileApp.Models.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using StudyNowMobileApp.Views.ToolsMenu;
using StudyNowMobileApp.Localization;

namespace StudyNowMobileApp.ViewModels.Main
{
    public class HomeViewModel: BaseViewModel
    {
        private IList<Curs> searcherCurs;
        private string querySearchBar = string.Empty;

        public override string TitlePage
        {
            get => LocalizedText.HomeIconTitle;
            set => new NotImplementedException();
        }

        /// <summary>
        /// Искомые курсы.
        /// </summary>
        public IList<Curs> SearcherCurs
        {
            get
            {
                
                return searcherCurs;
            }
            set
            {
                searcherCurs = value;
                NotifyPropertyChanged(nameof(SearcherCurs));
            }
        }

        /// <summary>
        /// Список курсов.
        /// </summary>
        public IList<Curs> Curs { get; private set; }

        public HomeViewModel()
        {
            NavigateToolsCommand = new Command(NavigateTools);
            searcherCurs = Curs = new List<Curs>
            {
                new Curs(){ Name = "Избранное", Description = "Описание", 
                            SubCurs = new List<SubCurs>
                            {
                                new SubCurs()
                                {
                                    Name = "С#",
                                    SourceIcon = "TopBar_Profile.png"
                                },

                                new SubCurs()
                                {
                                    Name = "С++",
                                    SourceIcon = "TopBar_Profile.png"
                                },

                                new SubCurs()
                                {
                                    Name = "С",
                                    SourceIcon = "TopBar_Profile.png"
                                }
                            }
                }
            };
            this.IsLoading = false;
        }

        /// <summary>
        /// Указывает нужно ли показывать Иконку с прогрузкой страницы.
        /// </summary>
        public bool IsLoading { get; set; } = true;

        /// <summary>
        /// Строка вводимоя пользователем в строку поиска.
        /// </summary>
        public string QuerySearchBar
        {
            get
            {
                return querySearchBar;
            }
            set
            {
                querySearchBar = value;
                PerformSearch.Execute(querySearchBar);
                NotifyPropertyChanged(nameof(QuerySearchBar));
            }
        }

        /// <summary>
        /// Строка, отображаемая, когда SearchBar не заполнен.
        /// </summary>
        public string PlaceHolderText
        {
            get => LocalizedText.SearchBarPlaceHolder;
            set => new NotImplementedException();
        }

        /// <summary>
        /// Фильрует список курсов по названию, кторый интересует пользователя.
        /// </summary>
        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            if (!string.IsNullOrEmpty(query))
            {
                SearcherCurs = Curs.Where(x => x.Name.ToLower().IndexOf(query.ToLower()) != -1).ToList();
            }else
            {
                SearcherCurs = Curs;
            }
        });

        /// <summary>
        /// Взвращает или задает логику перехода на страницу с настройками. 
        /// </summary>
        public ICommand NavigateToolsCommand { get; protected set; }
        protected override List<string> PropertyNames 
        {
            get => new List<string>()
            {
                nameof(PlaceHolderText),
                nameof(TitlePage)
            };
            set => throw new NotImplementedException(); 
        }

        private void NavigateTools()
        {
            Navigation.PushAsync(new ToolsPage(this));
        }
    }
}