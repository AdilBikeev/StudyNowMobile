// <copyright file="Curs.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StudyNowMobileApp.Models.Home
{
    using StudyNowMobileApp.Models.CoursesList;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Xamarin.Forms;

    /// <summary>
    /// Описывает курс на домашней странице.
    /// </summary>
    public class Curs
    {
        /// <summary>
        /// Gets задает имя для кнопки "развернуть" на каждом курсе.
        /// </summary>
        public string DeployCurs { get; private set; } = "Развернуть";

        /// <summary>
        /// Gets or sets название курса.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets описание курса.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets список под-курсов по данному курсу.
        /// </summary>
#pragma warning disable CA2227 // Свойства коллекций должны быть доступны только для чтения
        public IList<CoursesListModel> SubCurs { get; set; }
#pragma warning restore CA2227 // Свойства коллекций должны быть доступны только для чтения
    }
}
