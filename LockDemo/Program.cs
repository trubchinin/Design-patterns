using System;
using System.Threading;
using LockDemo.Domain;

namespace LockDemo
{
    class Program
    {
        static void Main()
        {
            var resource = new SharedResource();
            var threads = new Thread[5];

            // Створюємо 5 потоків, кожен робить по 1000 інкрементів
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        resource.Increment();
                    }
                });
                threads[i].Start();
            }

            // Чекаємо завершення
            foreach (var t in threads) t.Join();

            Console.WriteLine($"Final counter = {resource.GetCount()}");
        }
    }
} 