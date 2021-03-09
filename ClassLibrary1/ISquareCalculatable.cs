namespace ClassLibrary1
{
    /// <summary>
    /// Интерфейс. Фигуры классов, реализующих его, могут находить площадь
    /// </summary>
    public interface ISquareCalculatable
    {
        /// <summary>
        /// Находит площадь
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double CalculateSquare();
    }
}