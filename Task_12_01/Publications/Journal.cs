using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Journal
    {
        #region Свойства 
        public DateTime ReleaseDate { get; set; }
        public string SubjectArea { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        #endregion
        #region Конструктор
        public Journal(DateTime releaseDate, string subjectArea, string title, int pageCount, int price)
        {
            ReleaseDate = releaseDate;
            SubjectArea = subjectArea;
            Title = title;
            PageCount = pageCount;
            Price = price;
        }
        #endregion
        #region Метод
        public override string ToString()
        {
            return $"Название: {Title}\n" +
                   $"Дата издания: {ReleaseDate.ToShortDateString()}\n" +
                   $"Предметно-тематическая направленность: {SubjectArea}\n" +
                   $"Количество страниц: {PageCount}\n" +
                   $"Цена: {Price:C}";
        }
        #endregion
    }
}
