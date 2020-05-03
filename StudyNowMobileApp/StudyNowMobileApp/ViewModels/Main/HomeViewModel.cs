﻿//------------------------------------------------------------------------------
// <auto-generated>
// MIT License
// 
// Copyright (c) 2020 Bikeev Adil Issaevich
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </auto-generated>
//------------------------------------------------------------------------------
namespace StudyNowMobileApp.ViewModels.Main
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Input;
    using StudyNowMobileApp.Localization;
    using StudyNowMobileApp.Models.Course;
    using StudyNowMobileApp.Models.Home;
    using StudyNowMobileApp.Views.Course;
    using StudyNowMobileApp.Views.ToolsMenu;
    using Xamarin.Forms;

    /// <summary>
    /// Служит прослойкой для Home.xaml.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        private IList<Cours> searcherCurs;
        private string querySearchBar = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel"/> class.
        /// </summary>
        public HomeViewModel()
        {
            this.NavigateToolsCommand = new Command(this.NavigateTools);
            this.ShowCoursListCommand = new Command<string>(this.ShowCoursList);
            this.searcherCurs = this.Curs = new List<Cours>
            {
#pragma warning disable SA1413 // Use trailing comma in multi-line initializers
                new Cours()
                {
                    Name = "ОГЭ", Description = "Подготовка к ОГЭ",
                    SubCurs = new List<CourseModel>
                    {
                        new CourseModel()
                        {
                            DisplayName = "Математика",
                            IconImage = "CoursesList_Math.png",
                            BacgroundCoursImage = "SelectedCourse_BgImg.png",
                            TaskPages = new List<CourseTask>()
                            {
                                new CourseTask()
                                {
                                    DisplayName = "1 задание",
                                    FullName = "1 задание",
                                    IsDone = true,
                                    CheckOffIcon = null,
                                    CheckOnIcon = "SelectedCourse_CheckOn.png"
                                },
                                new CourseTask()
                                {
                                    DisplayName = "2 задание",
                                    FullName = "2 задание",
                                    IsDone = false,
                                    CheckOffIcon =null,
                                    CheckOnIcon = "SelectedCourse_CheckOn.png"
                                }
                            }
                        }
                    }
                }
#pragma warning restore SA1413 // Use trailing comma in multi-line initializers
            };
            this.IsLoading = false;
        }

        /// <summary>
        /// Переходит на страницу для отображения всех под-курсов.
        /// </summary>
        /// <param name="coursName">Название курса.</param>
        private void ShowCoursList(string coursName)
        {
            var Cours = this.Curs.First(x => x.Name == coursName);
            this.Navigation.PushAsync(new CoursesListPage(Cours.SubCurs));
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
        public IList<Cours> SearcherCurs
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
        public IList<Cours> Curs { get; private set; }

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

        /// <summary>
        /// Команда для вывода списка под-курсов.
        /// </summary>
        public ICommand ShowCoursListCommand { get; }

        /// <summary>
        /// Действие при выборе курса.
        /// </summary>
        public ICommand SelectedCourseCommand { get; private set; }

        /// <inheritdoc/>
        protected override List<string> PropertyNames => new List<string>()
        {
            nameof(this.PlaceHolderText),
            nameof(this.TitlePage),
        };

        /// <summary>
        /// Переходит на страницу курса.
        /// </summary>
        public CourseModel SelectedCourse
        {
            get => null;
            set 
            {
                this.Navigation.PushAsync(new SelectedCours(value));
                this.NotifyPropertyChanged();
            }
        }

        private void NavigateTools()
        {
            this.Navigation.PushAsync(new ToolsPage(this));
        }
    }
}