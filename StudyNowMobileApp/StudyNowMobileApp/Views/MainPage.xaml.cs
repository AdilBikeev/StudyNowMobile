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
namespace StudyNowMobileApp.Views
{
    using System.ComponentModel;
    using StudyNowMobileApp.ViewModels;

    /// <summary>
    /// Главная страница.
    /// </summary>
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <inheritdoc/>
        protected override void OnDisappearing()
        {
            foreach (var item in this.Children)
            {
                if (item.BindingContext != null && item.BindingContext is BaseViewModel)
                {
                    (item.BindingContext as BaseViewModel).UpdatePropertyChanged();
                }
            }

            base.OnDisappearing();
        }
    }
}
