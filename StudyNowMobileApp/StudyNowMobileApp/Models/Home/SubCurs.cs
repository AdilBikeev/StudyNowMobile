namespace StudyNowMobileApp.Models.Home
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// Описывает под-курс на домашней странице
    /// </summary>
    public class SubCurs : INotifyPropertyChanged
    {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Возвращает или задает название под-курса.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задает путть к картинке под-курса относительно базовой дирриктории.
        /// </summary>
        public string SourceIcon { get; set; }
    }
}
