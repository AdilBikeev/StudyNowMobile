namespace StudyNowMobileApp.Models.Course
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Задание курса.
    /// </summary>
    public class CourseTask
    {
        /// <summary>
        /// Gets or sets Название задания для оторажения на странице курса.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets полное название заадния.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether, задание выполненым.
        /// </summary>
        public bool IsDone { get; set; }

        /// <summary>
        /// Gets картинку показывающая, что задание выполнено/нет в зависимости от статуса IsDone.
        /// </summary>
        public string CheckIcon => this.IsDone ? this.CheckOnIcon : this.CheckOffIcon;

        /// <summary>
        /// Gets or sets иконка, показывающая, что задание выполнено.
        /// </summary>
        public string CheckOnIcon { get; set; }

        /// <summary>
        /// Gets or sets иконка, показывающая, что задание не выполнено.
        /// </summary>
        public string CheckOffIcon { get; set; }
    }
}
