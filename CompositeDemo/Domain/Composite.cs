using System;
using System.Collections.Generic;

namespace CompositeDemo.Domain
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new();
        private readonly string _name;
        public Composite(string name) => _name = name;

        public void Add(IComponent component) => _children.Add(component);
        public void Remove(IComponent component) => _children.Remove(component);

        public void Operation()
        {
            Console.WriteLine($"Composite {_name} operation start");
            foreach (var child in _children)
                child.Operation();
            Console.WriteLine($"Composite {_name} operation end");
        }
    }
} 