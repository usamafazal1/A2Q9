using System;
using System.Linq;

namespace A2Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            //A has ascending; B has descending; 
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = { 10, 9, 8, 7, 6 };

            //print A and B
            Console.WriteLine("Array A is: ");
            for (int i=0; i<A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            
            Console.WriteLine("\n\nArray B is: ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }


            //reverse the B array, so it is also in ascending order
            Array.Reverse(B);

            //add array A and B to form array C; use concatenate command present in Linq

            int[] C = A.Concat(B).ToArray();

            //print C

            Console.WriteLine("\n\nCombining A and B (has been reversed to make it ascending), the array C in ascending order is: ");
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write(C[i] + " ");
            }

        }
    }
}
