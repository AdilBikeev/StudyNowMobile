using StudyNomMobileApp.Hellpers;
using StudyNomMobileApp.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace StudyNomMobileApp.Templates.Base
{
    /// <summary>
    /// Навигационная панель в нижней части приложения.
    /// </summary>
    class BottomNavigationBarView: ContentView
    {
        /// <summary>
        /// Путь к каталогу с картинками.
        /// </summary>
        private const string pathImages = "Images/NavigationBar";

        /// <summary>
        /// Список элементов навигации.
        /// </summary>
        List<NavItemImage> navItemImages = new List<NavItemImage>()
        {
            new NavItemImage("Домой", "Nav_Home.png"),
            new NavItemImage("Тренироваться", "Nav_Workout.png"),
            new NavItemImage("Новости", "Nav_News.png"),
            new NavItemImage("Статистика", "Nav_Stats.png")
        };

        public BottomNavigationBarView()
        {
            Content = this.GetContent();
        }

        /// <summary>
        /// Возвращает контент для предсавления.
        /// </summary>
        /// <returns></returns>
        private FlexLayout GetContent()
        {
            FlexLayout navBar = new FlexLayout()
            {
                Style = StyleHellpers.GetStyle<StackLayout>("NavFlex")
            };

            var Items = GetNavItems();
            foreach (var view in Items)
            {
                navBar.Children.Add(view);
            }

            return navBar;
        }

        /// <summary>
        /// Вовраащает список навигационных элементов в представлении StackLayout.
        /// </summary>
        private List<StackLayout> GetNavItems()
        {
            List<StackLayout> stackLayouts = new List<StackLayout>();

            int n = this.navItemImages.Count;

            foreach (var image in this.navItemImages)
            {
                StackLayout stackLayout = new StackLayout()
                {
                    Style = StyleHellpers.GetStyle<StackLayout>("NavStack")
                };

                stackLayout.Children.Add(new Image()
                {
                    Style = StyleHellpers.GetStyle<StackLayout>("NavBtns"),
                    Source = Path.Combine(pathImages, image.Path)
                });

                stackLayout.Children.Add(new Label()
                {
                    Style = StyleHellpers.GetStyle<StackLayout>("NavLabels"),
                    Text = image.Title
                });

                stackLayouts.Add(stackLayout);
            }

            return stackLayouts;
        }
    }
}
