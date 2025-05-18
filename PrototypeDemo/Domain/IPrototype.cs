namespace PrototypeDemo.Domain
{
    /// <summary>
    /// Інтерфейс прототипу, що визначає метод Clone().
    /// </summary>
    public interface IPrototype<T>
    {
        /// <summary>
        /// Метод для створення копії поточного об'єкта.
        /// </summary>
        /// <returns>Новий екземпляр з аналогічними властивостями.</returns>
        T Clone();
    }
} 