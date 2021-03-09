using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс треугольника. Содержит стороны, находит площадь по формуле герона. Реализует интерфейс нахождения площади
    /// </summary>
    public class Triangle : ISquareCalculatable
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        private double ASide { get; set; }

        /// <summary>
        /// Сторона В
        /// </summary>
        private double BSide { get; set; }

        /// <summary>
        /// Сторона С
        /// </summary>
        private double CSide { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="aSide">Сторона А</param>
        /// <param name="bSide">Сторона В</param>
        /// <param name="cSide">Сторона С</param>
        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        /// <summary>
        /// Находит площадь
        /// </summary>
        /// <returns></returns>
        public double CalculateSquare()
        {
            double p = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }
    }
}    
