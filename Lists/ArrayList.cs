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
        public ArrayList(int[] array)
        {
            if (array.Length < _minArrayLength)
            {
                _array = new int[_minArrayLength];
            }
            else
            {
                _array = new int[array.Length];
            }
            Length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }
            

        public void AddElement(int value)
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


        public void AddFirst(int value)
        {
            if (Length==_array.Length)
            {
                UpArraySize();
            }
            Shift(0, Length);
            _array[0] = value;
        }
        public void Shift(int start, int end)
        {
            //end = Length;
            //start = 0;
        Length++;
            
            while(end>start)
            {
                _array[end] = _array[end-1];
                end--;
            }
        }
        public void ReversedShift(int start, int end)
        {
            Length--;
            while (end > start)
            {
                _array[start] = _array[start+1];
                start++;
            }
        }
        public void AddElement(int index, int value)
        {
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            Shift(index, Length);
            _array[index] = value;
        }
        
        private void ReduceArrayList()
        {
            if ((int)(Length * 0.7) > _minArrayLength && Length <= (_array.Length / 2))
            {
                int[] tmpArray = new int[(int)(Length * 0.7)];

                for (int i = 0; i < _array.Length; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
            }

        }
        public void DeleteLast()
        {
            if (Length > 0)
            {
                Length--;
                ReduceArrayList();
            }
            
        }
        public void DeleteFirst() //Test???
        {
            if (Length > 0)
            {
                
                ReversedShift(0, Length);
                ReduceArrayList();
                
            }
        }
        public void DeleteElement(int index)
        {
            if (Length > 0)
            {

                ReversedShift(index, Length);

            }
        }
        public void DeleteSeveralElements(int index, int s)
        {
            if (Length > 0)
            {
                for( int i=index; i<index+s; i++)
                ReversedShift(i, Length);
            }
        }

        #region // штука для теста
        public override bool Equals(object obj)
        {
            int i;

            ArrayList array = (ArrayList)obj;
            if (Length != array.Length)
                return false;
            i = 0;
            while (i < Length)
            {
                if (array._array[i] != _array[i])
                    return false;
                i++;
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }
            return s;
        }
        #endregion



    }
}
