using System;

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get {return String.Format("{0:5d}", serial++);}
        }

        abstract public DateTime Productdate
        {
            get;
            set;
        }
    }

    class Myproduct : Product
    {
        public override DateTime Productdate
        {
            get;
            set;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}
