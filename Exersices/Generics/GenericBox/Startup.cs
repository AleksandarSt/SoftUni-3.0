using System;

namespace GenericBox
{
    class Startup
    {
        static void Main()
        {
            Box<int> test=new Box<int>(123123);

            Console.WriteLine(test);
        }
    }
}
