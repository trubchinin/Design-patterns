namespace VisitorDemo.Domain
{
    public interface IVisitor
    {
        void VisitElementA(ElementA a);
        void VisitElementB(ElementB b);
    }
} 