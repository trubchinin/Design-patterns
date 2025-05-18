using System;

namespace PrototypeDemo.Domain
{
    /// <summary>
    /// Конкретний прототип A із одним полем State.
    /// </summary>
    public class ConcretePrototypeA : IPrototype<ConcretePrototypeA>
    {
        public string State { get; set; }

        public ConcretePrototypeA(string state)
        {
            State = state;
        }

        public ConcretePrototypeA Clone()
        {
            // Оскільки State — рядок (immutable), достатньо MemberwiseClone
            return (ConcretePrototypeA)MemberwiseClone();
        }
    }
} 