using VisitorDemo.Domain;
using System.Collections.Generic;

namespace VisitorDemo
{
    class Program
    {
        static void Main()
        {
            var elements = new List<IElement>
            {
                new ElementA("Alpha"),
                new ElementB(123)
            };

            var visitor = new ConcreteVisitor();

            foreach (var e in elements)
                e.Accept(visitor);
        }
    }
} 