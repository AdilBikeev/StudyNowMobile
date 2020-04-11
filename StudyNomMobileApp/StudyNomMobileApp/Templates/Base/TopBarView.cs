using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StudyNomMobileApp.Templates.Base
{
    /// <summary>
    /// Верхняя панель приложения.
    /// </summary>
    public class TopBarView : ContentView
    {
        private FlexLayout layout = new FlexLayout();

        public TopBarView()
        {
            layout.Children.Add(new MenuIconView());
            layout.Children.Add(new SearchView());
            layout.Children.Add(new ProfileIconView());

            layout.Style = new Style(layout.GetType())
            {
                BaseResourceKey = "FlexTopBar"
            };

            Content = layout;
        }
    }
}