using System;
using Lists;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.AddElementToTheBeginning(2);
           

            arrayList.WriteToConsole();
        }
    }
}
