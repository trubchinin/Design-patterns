using System;

namespace VisitorDemo.Domain
{
    public class ConcreteVisitor : IVisitor
    {
        public void VisitElementA(ElementA a)
        {
            Console.WriteLine("Visitor processing ElementA");
            a.OperationA();
        }

        public void VisitElementB(ElementB b)
        {
            Console.WriteLine("Visitor processing ElementB");
            b.OperationB();
        }
    }
} 