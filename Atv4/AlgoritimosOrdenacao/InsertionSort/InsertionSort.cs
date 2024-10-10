using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(array[i]>array[j])
                    {
                        
                    }
                }
            }
        }
    }
}