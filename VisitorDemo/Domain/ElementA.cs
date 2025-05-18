namespace VisitorDemo.Domain
{
    public class ElementA : IElement
    {
        public string Name { get; }
        public ElementA(string name) => Name = name;
        public void Accept(IVisitor visitor) => visitor.VisitElementA(this);
        public void OperationA() => System.Console.WriteLine($"ElementA: {Name}");
    }
} 