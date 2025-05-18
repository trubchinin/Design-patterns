using System;
using PrototypeDemo.Domain;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо оригінал
            var original = new ConcretePrototypeA("Original");
            // Клонуємо
            var copy = original.Clone();
            // Модифікуємо стан копії
            copy.State = "Modified";

            Console.WriteLine($"Original.State = {original.State}");
            Console.WriteLine($"Copy.State     = {copy.State}");
        }
    }
} 