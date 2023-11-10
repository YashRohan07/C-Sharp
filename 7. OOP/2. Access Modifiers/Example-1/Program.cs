using System;

namespace NS1
{
    public class A
    {
        public int x; // public variable accessible everywhere
        private int y; // private variable accessible only within the class A
        protected int z; // protected variable accessible within the class A and its derived classes
        internal int i; // internal variable accessible within the same assembly
        protected internal int j; // protected internal variable accessible within the same assembly and derived classes

        private class C : B
        {
            public void M2()
            {
                // Accessibility:
                // x: Accessible (public)
                // z: Accessible (protected)
                // i: Accessible (internal)
                // j: Accessible (protected internal)
            }
        }
    }

    public class B : A
    {
        internal int x1; // internal variable accessible within the same assembly
        public void M1()
        {
            // Accessibility:
            // x: Accessible (public)
            // y: Not accessible (private)
            // z: Accessible (protected)
            // i: Accessible (internal)
            // j: Accessible (protected internal)
            // x1: Accessible (internal)
        }
    }
}

namespace NS2
{
    using NS1;
    using System;

    public class D : B
    {
        private int x2; // private variable accessible only within the class D
        public virtual void M3()
        {
            // Accessibility:
            // x: Accessible (public)
            // y: Not accessible (private)
            // z: Accessible (protected)
            // i: Accessible (internal)
            // j: Accessible (protected internal)
            // x1: Accessible (internal)
            // x2: Accessible (private)
        }
    }

    public class E : D
    {
        public override void M3()
        {
            // Your implementation here
        }

        static void Main()
        {
            // In this context, you can access variables with the following accessibilities:
            // x: Accessible (public)
            // y: Not accessible (private)
            // z: Not accessible from this context
            // i: Accessible (internal)
            // j: Accessible (protected internal)
            // x1: Accessible (internal)
            // x2: Not accessible (private)
        }
    }
}
