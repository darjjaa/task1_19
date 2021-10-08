using System;

namespace Task_1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы:");
            int N = Int32.Parse(Console.ReadLine());
            int[,] A = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = i-j;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    A[i, j] = i+j;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        A[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Конечная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j]);
                    if (A[i, j]<10)
                    Console.Write("  ");
                    else
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        } 
    }
}