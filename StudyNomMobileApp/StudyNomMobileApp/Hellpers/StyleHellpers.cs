using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StudyNomMobileApp.Hellpers
{
    /// <summary>
    /// Класс-помощник по заданию стилей.
    /// </summary>
    public static class StyleHellpers
    {
        /// <summary>
        /// Возвращает стиль для указанного элемента управления.
        /// </summary>
        /// <typeparam name="T">Тип контрола.</typeparam>
        /// <param name="baseResKey">Ключ словоря ресурсов, для автоматической подстанвоки стиля.</param>
        /// <returns></returns>
        public static Style GetStyle<T>(string baseResKey) => new Style(typeof(T))
        {
            BaseResourceKey = baseResKey
        };
    }
}
