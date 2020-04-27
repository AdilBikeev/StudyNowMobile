namespace StudyNowMobileApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Xamarin.Forms;

    /// <summary>
    /// Базовое представление ViewModel.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets список имен свойств ViewModel.
        /// </summary>
#pragma warning disable CA2227 // Свойства коллекций должны быть доступны только для чтения
        protected abstract List<string> PropertyNames { get; set; }
#pragma warning restore CA2227 // Свойства коллекций должны быть доступны только для чтения

        /// <summary>
        /// Gets or sets свойство поьзволяющие производить переход между представлениями.
        /// </summary>
#pragma warning disable SA1202 // Elements should be ordered by access
        public INavigation Navigation { get; set; }
#pragma warning restore SA1202 // Elements should be ordered by access

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Получает или задает название страницы для отображения.
        /// </summary>
        public abstract string TitlePage { get; set; }

        /// <summary>
        /// Обновляет значения всех свойств на ViewModel.
        /// </summary>
        /// <param name="propertyNames">Список имен свойств ViewModel.</param>
        public void UpdatePropertyChanged()
        {
            foreach (var name in this.PropertyNames)
            {
                this.NotifyPropertyChanged(name);
            }
        }
    }
}
