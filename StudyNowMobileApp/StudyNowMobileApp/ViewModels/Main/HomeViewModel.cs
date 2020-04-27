namespace StudyNowMobileApp.ViewModels.Main
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Input;
    using StudyNowMobileApp.Localization;
    using StudyNowMobileApp.Models.Home;
    using StudyNowMobileApp.Views.ToolsMenu;
    using Xamarin.Forms;

    /// <summary>
    /// Служит прослойкой для Home.xaml.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        private IList<Curs> searcherCurs;
        private string querySearchBar = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel"/> class.
        /// </summary>
        public HomeViewModel()
        {
            this.NavigateToolsCommand = new Command(this.NavigateTools);
            this.searcherCurs = this.Curs = new List<Curs>
            {
#pragma warning disable SA1413 // Use trailing comma in multi-line initializers
                new Curs()
                {
                    Name = "Избранное", Description = "Описание",
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
#pragma warning restore SA1413 // Use trailing comma in multi-line initializers
            };
            this.IsLoading = false;
        }

        /// <summary>
        /// Gets строка, отображаемая, когда SearchBar не заполнен.
        /// </summary>
        public string PlaceHolderText => LocalizedText.SearchBarPlaceHolder;

        /// <inheritdoc/>
        public override string TitlePage => LocalizedText.HomeIconTitle;

        /// <summary>
        /// Gets or sets искомые курсы.
        /// </summary>
#pragma warning disable CA2227 // Свойства коллекций должны быть доступны только для чтения
        public IList<Curs> SearcherCurs
#pragma warning restore CA2227 // Свойства коллекций должны быть доступны только для чтения
        {
            get
            {
                return this.searcherCurs;
            }

            set
            {
                this.searcherCurs = value;
                this.NotifyPropertyChanged(nameof(this.SearcherCurs));
            }
        }

        /// <summary>
        /// Gets список курсов.
        /// </summary>
        public IList<Curs> Curs { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether нужно ли показывать Иконку с прогрузкой страницы.
        /// </summary>
        public bool IsLoading { get; set; } = true;

        /// <summary>
        /// Gets or sets строка вводимоя пользователем в строку поиска.
        /// </summary>
        public string QuerySearchBar
        {
            get
            {
                return this.querySearchBar;
            }

            set
            {
                this.querySearchBar = value;
                this.PerformSearch.Execute(this.querySearchBar);
                this.NotifyPropertyChanged(nameof(this.QuerySearchBar));
            }
        }

        /// <summary>
        /// Gets отфильтрованный список курсов по названию, кторый интересует пользователя.
        /// </summary>
        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            if (!string.IsNullOrEmpty(query))
            {
                this.SearcherCurs = this.Curs.Where(x => x.Name.ToLower(CultureInfo.CurrentCulture).IndexOf(query.ToLower(CultureInfo.CurrentCulture), StringComparison.CurrentCulture) != -1).ToList();
            }
            else
            {
                this.SearcherCurs = this.Curs;
            }
        });

        /// <summary>
        /// Gets or sets логику перехода на страницу с настройками.
        /// </summary>
        public ICommand NavigateToolsCommand { get; protected set; }

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.PlaceHolderText),
            nameof(this.TitlePage),
        };

        private void NavigateTools()
        {
            this.Navigation.PushAsync(new ToolsPage(this));
        }
    }
}