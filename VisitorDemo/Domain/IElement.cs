namespace VisitorDemo.Domain
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
} 