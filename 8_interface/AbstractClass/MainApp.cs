using System;

namespace AbstractClass
{
    abstract class AbstactBase
    { 
        protected void PrivatMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstactBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivatMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstactBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
