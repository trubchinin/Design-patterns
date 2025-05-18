using System;

namespace CompositeDemo.Domain
{
    public class Leaf : IComponent
    {
        private readonly string _name;
        public Leaf(string name) => _name = name;
        public void Operation() => Console.WriteLine($"Leaf {_name} operation");
    }
} 