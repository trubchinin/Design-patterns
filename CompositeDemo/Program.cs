using CompositeDemo.Domain;

namespace CompositeDemo
{
    class Program
    {
        static void Main()
        {
            var root = new Composite("Root");
            var leaf1 = new Leaf("A");
            var leaf2 = new Leaf("B");
            root.Add(leaf1);
            root.Add(leaf2);

            var subtree = new Composite("Subtree");
            subtree.Add(new Leaf("C"));
            root.Add(subtree);

            root.Operation();
        }
    }
} 