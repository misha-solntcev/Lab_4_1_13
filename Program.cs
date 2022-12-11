using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*13.Заданы два массива А и В. Написать программу 
    нахождения элементов, общих для А и В.*/

namespace Lab_4_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] B = new int[] { 0, 8, 0, 0, 5, 0, 0, 1, 0 };

            for (int i = 0; i < A.Length; i++)            
                for (int j = 0; j < B.Length; j++)                
                    if (A[i] == B[j])
                        Console.Write(A[i] + " ");
            Console.WriteLine("\n");

            // Linq
            var res = A.Intersect(B);
            foreach (var item in res)            
                Console.Write(item + " ");

            Console.ReadKey();            
        }
    }
}
