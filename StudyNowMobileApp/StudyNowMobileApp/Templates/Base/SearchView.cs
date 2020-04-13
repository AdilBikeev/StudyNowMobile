using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StudyNowMobileApp.Templates.Base
{
    public class SearchView : ContentView
    {
        public SearchView()
        {
            Content = new Entry
            {
                Style = new Style(typeof(Entry))
                {
                    BaseResourceKey = "SearchTopBar"
                },
                Placeholder = "Поиск"
            };
        }
    }
}