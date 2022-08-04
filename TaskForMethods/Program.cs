using System;

namespace TaskForMethods
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr = { 54, 56, 76, 17, 45, 756, 87 };
            Console.WriteLine( Min(arr));
        }
        static int Min( int[] arr ) 
        {
            int min,index=0;
            
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) 
                {
                    min = arr[i];
                    index=i;
                }

            }
            Console.Write( "The minimum element of array in index " + index + " equals to " );
            return min;
        }
    }
}
