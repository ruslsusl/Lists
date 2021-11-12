using System;
using Lists;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyList = new ArrayList();
            MyList.AddElement(5); 
            MyList.AddElement(7);
            MyList.AddElement(8);
            MyList.WriteToConsole();


            MyList.AddFirst(2);
            MyList.WriteToConsole();

            MyList.AddElement(4, 4);
            MyList.WriteToConsole();

            MyList.DeleteFirst();
            MyList.WriteToConsole();

            MyList.DeleteSeveralElements(1, 3);
            MyList.WriteToConsole();





        }
    }
}
