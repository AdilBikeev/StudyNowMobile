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

namespace StudyNowMobileApp.ViewModels
{
    public class HomeViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Список курсов.
        /// </summary>
        public IList<Curs> Curs { get; private set; }

        private IList<Curs> searcherCurs;

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

        public HomeViewModel()
        {
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
        }


        private string querySearchBar = string.Empty;

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
    }
}