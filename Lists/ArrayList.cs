using System;

namespace Lists
{
    public class ArrayList
    {
        public int Length {get; private set;}

        private const int _minArrayLenght = 10;

        private int[] _array;

        public ArrayList()
        {

            Length = 0;
            _array = new int[_minArrayLenght];
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

        public void Add(int value)
        {
            value = _array[0];
        }

            private void MoveElementsForward()
        {
            Length++;
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i + 1];
            }
            
        }
    }
}
