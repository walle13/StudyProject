using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace IspExample2   //接口隔离原则的 Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };

            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            
            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine(Sum(nums3));
            foreach (var n in nums3)
            {
                Console.WriteLine(n);
            }
            

        }

        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

    }

    class ReadOnlyCollection : IEnumerable 
    {
        private int[] _array;

        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
            //throw new NotImplementedException();
        }

        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collecton;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collecton = collection;
                _head = -1;
            }
        
            public object Current
            {
                get 
                { 
                    object o = _collecton._array[_head];
                    return o;
                }

            }

            public bool MoveNext()
            {
                if (++_head < _collecton._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
