using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace StudyNowMobileApp.ViewModels
{
    public abstract class BaseViewModel: INotifyPropertyChanged
    {
        /// <summary>
        /// Список имен свойств ViewModel.
        /// </summary>
        protected abstract List<string> propertyNames { get; set; }

        public INavigation Navigation { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Обновляет значения всех свойств на ViewModel.
        /// </summary>
        /// <param name="propertyNames">Список имен свойств ViewModel.</param>
        public void UpdatePropertyChanged()
        {
            foreach (var name in this.propertyNames)
            {
                this.NotifyPropertyChanged(name);
            }
        }
    }
}
