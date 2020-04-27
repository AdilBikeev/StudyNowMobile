namespace StudyNowMobileApp.Hellpers
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Расширения.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Преобразовывает коллекцию в ObservableCollection.
        /// </summary>
        /// <typeparam name="T">Типы элементво коллекции.</typeparam>
        /// <param name="col">Коллекция.</param>
        /// <returns>Возвращает преобразованную коллекцию в ObservableCollection.</returns>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> col)
        {
            return new ObservableCollection<T>(col);
        }
    }
}
