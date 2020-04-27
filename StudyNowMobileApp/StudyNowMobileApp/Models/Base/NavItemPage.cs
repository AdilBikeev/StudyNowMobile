namespace StudyNowMobileApp.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// Навиг. элементы.
    /// </summary>
    public class NavItemPage
    {
        /// <summary>
        /// Описание навиг. элемента (его имя).
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Тип страницы.
        /// </summary>
        public Type Type { get; set; }
    }
}
