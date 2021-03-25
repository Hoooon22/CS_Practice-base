using System;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }

        string Value
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
