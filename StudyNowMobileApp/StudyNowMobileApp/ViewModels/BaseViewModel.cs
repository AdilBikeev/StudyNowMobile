namespace StudyNowMobileApp.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Xamarin.Forms;

    /// <summary>
    /// Базовое представление ViewModel.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets название страницы для отображения.
        /// </summary>
        public abstract string TitlePage { get; }

        /// <summary>
        /// Gets or sets список имен свойств ViewModel.
        /// </summary>
#pragma warning disable CA2227 // Свойства коллекций должны быть доступны только для чтения
        protected abstract List<string> PropertyNames { get; }
#pragma warning restore CA2227 // Свойства коллекций должны быть доступны только для чтения

        /// <summary>
        /// Gets or sets свойство поьзволяющие производить переход между представлениями.
        /// </summary>
#pragma warning disable SA1202 // Elements should be ordered by access
        public INavigation Navigation { get; set; }
#pragma warning restore SA1202 // Elements should be ordered by access

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

        /// <summary>
        /// Отправляет сигнал на View о том, что значение забиндигованного свойства изменилось и нужно его обновить на View.
        /// </summary>
        /// <param name="propertyName">Имя обновленного параметра.</param>
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
