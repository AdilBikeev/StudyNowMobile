namespace StudyNowMobileApp.Models.Home
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// Описывает курс на домашней странице.
    /// </summary>
    public class Curs : INotifyPropertyChanged
    {
        /// <summary>
        /// Задает имя для кнопки "развернуть" на каждом курсе.
        /// </summary>
        public string DeployCurs { get; private set; } = "Развернуть";

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Возвращает или задает название курса.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задает описание курса.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Возвращает или задает список под-курсов по данному курсу.
        /// </summary>
        public IList<SubCurs> SubCurs { get; set; }
    }
}
