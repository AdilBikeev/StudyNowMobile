namespace StudyNowMobileApp.Models.Tools
{
    using Xamarin.Forms;

    /// <summary>
    /// Настройка.
    /// </summary>
    public class Tool
    {
        /// <summary>
        /// Gets or sets название настройки.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets страница с настройкой.
        /// </summary>
        public ContentPage TypePage { get; set; }
    }
}
