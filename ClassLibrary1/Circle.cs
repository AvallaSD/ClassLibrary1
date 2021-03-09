using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс круга. Содержит радиус и метод нахождения площади. Реализует интерфейс нахождения площади
    /// </summary>
    public class Circle : ISquareCalculatable
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private double Radius { get; set; }

        /// <summary>
        /// Конструктор, инициализирующий нахождение площади
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }  

        /// <summary>
        /// Находит площадь
        /// </summary>
        /// <returns></returns>
        public double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
