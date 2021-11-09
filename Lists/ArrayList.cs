using System;

namespace Lists
{
    public class ArrayList
    {
        public int Length {get; private set;}

        private const int _minArrayLength = 10;

        private int[] _array;

        public ArrayList()
        {

            Length = 0;
            _array = new int[_minArrayLength];
        }
        
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpArraySize();
            }

            _array[Length] = value;
            Length++;
        }

        public void WriteToConsole()
        {
            for(int i=0; i< Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
    
        private void UpArraySize()
        {
            int[] tmpArray = new int[(int)(Length * 1.5)];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }


        public void AddElementToTheBeginning(int value)
        {
            if (Length==_array.Length)
            {
                UpArraySize();
            }
            Shift(0, Length, 1);
            _array[0] = value;
        }
        static void Shift(int a, int b, int c)
        {
            
        }

            
            
        }
    }
}
