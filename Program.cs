using System;

namespace InsertionSort
{
    class Program
    {
        static void Main()
        {
            int []vetor = CreateRandomArray();
            InsertionSort(vetor);
            Console.ReadKey();
        }
        static void InsertionSort(int[] a)
        {
            int j, c =0;
            int i=0;
            int chave;
            Console.Write("\nOrdered numbers: ");
            while (i < a.Length)
            {
                j = i;
                while (j>0 && a[j] < a[j - 1])
                {
                    chave = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = chave;
                    j--;
                }
                i++;
            }
            while (c < a.Length)
            {
                Console.Write(a[c] + ";");
                c++;
            }
        }
        static int[] CreateRandomArray()
        {
            int[] array = new int[10];
            int i=0;
            Random rnd = new Random();
            while (i < array.Length)
            {
                array[i] = rnd.Next(1, 100);
                i++;
            }
            int j = 0;
            Console.Write("Random numbers: ");
            while (j < array.Length)
            {
                Console.Write(array[j] + ";");
                j++;
            }
            return array;
        }
    }
}