using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace StudyNowMobileApp.Templates.Base
{
    public class ProfileIconView : ContentView
    {
        public ProfileIconView()
        {
            Content = new CircleImage()
            {
                Style = new Style(typeof(ImageButton))
                {
                    BaseResourceKey = "ProfileTopBar"
                }
            };
        }
    }
}