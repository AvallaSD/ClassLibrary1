using System;
using ClassLibrary1;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование круга\nВведите радиус круга");
            Circle circle = new Circle(ReadDouble());
            Console.WriteLine($"Площадь круга равна {CalculateFigureSquare(circle)}");

            Console.WriteLine("Тестирование треугольника\nВведите стороны треугольника");
            Triangle triangle = new Triangle(ReadDouble(), ReadDouble(), ReadDouble());
            Console.WriteLine($"Площадь Треугольника равна {CalculateFigureSquare(triangle)}");
        }

        /// <summary>
        /// Метод, находящий площадь фигуры, реализующей интерфейс ISquareCalculatable
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        static public double CalculateFigureSquare(ISquareCalculatable figure)
        {
            return figure.CalculateSquare();
        }


        /// <summary>
        /// Чтение дробных числел с консоли. В случае ошибки генерирует исключение
        /// </summary>
        /// <returns>Введенное с консоли число</returns>
        static public double ReadDouble()
        {
            if (double.TryParse(Console.ReadLine(), out double rez))
            {
                return rez;
            }
            throw (new Exception("Неверный ввод"));
        }
    }
}
