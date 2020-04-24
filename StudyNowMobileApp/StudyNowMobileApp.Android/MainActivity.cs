﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Support.Design.Widget;
using Android.Content;
using StudyNowMobileApp.Views;
using StudyNowMobileApp.Droid;

[assembly: ExportRenderer(typeof(MainPage), typeof(MyTabbedPageRenderer))]
namespace StudyNowMobileApp.Droid
{
    [Activity(Label = "StudyNowMobileApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public class MyTabbedPageRenderer : TabbedPageRenderer
    {
        public MyTabbedPageRenderer(Context context) : base(context)
        {

        }

        /// <summary>
        /// Убирает скрытие иконок на навигационной панели.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null && e.NewElement != null)
            {
                for (int i = 0; i <= this.ViewGroup.ChildCount - 1; i++)
                {
                    var childView = this.ViewGroup.GetChildAt(i);
                    if (childView is ViewGroup viewGroup)
                    {
                        for (int j = 0; j <= viewGroup.ChildCount - 1; j++)
                        {
                            var childRelativeLayoutView = viewGroup.GetChildAt(j);
                            if (childRelativeLayoutView is BottomNavigationView)
                            {
                                ((BottomNavigationView)childRelativeLayoutView).ItemIconTintList = null;
                            }
                        }
                    }
                }
            }
        }
    }
}