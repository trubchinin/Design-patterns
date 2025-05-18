namespace VisitorDemo.Domain
{
    public class ElementB : IElement
    {
        public int Value { get; }
        public ElementB(int value) => Value = value;
        public void Accept(IVisitor visitor) => visitor.VisitElementB(this);
        public void OperationB() => System.Console.WriteLine($"ElementB: {Value}");
    }
} 