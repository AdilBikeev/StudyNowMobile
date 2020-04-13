using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StudyNowMobileApp.Templates.Base
{
    public class MenuIconView : ContentView
    {
        public MenuIconView()
        {
            Content = new ImageButton()
            {
                Style = new Style(typeof(ImageButton))
                {
                    BaseResourceKey = "MenuTopBar"
                }
            };
        }
    }
}