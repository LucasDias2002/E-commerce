using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ale = new Random();
            int n, m, somalinha = 0, somacoluna=0, diagonal = 0, diagonalsec= 0;

            Console.WriteLine("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
 
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = ale.Next(1, 10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                somalinha = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somalinha += matriz[i, j];
                    if (i == j)
                    {
                        diagonal += matriz[i, j];
                    }
                    if(i + j == n-1)
                    {
                        diagonalsec += matriz[i, j];
                    }
                }
                Console.WriteLine($"Soma da {i + 1}° linha: {somalinha}");
            }
            Console.WriteLine();

            for(int i = 0; i < matriz.GetLength(1); i++)
            {
                somacoluna = 0;
                for(int j = 0; j < matriz.GetLength(0); j++)
                {
                    somacoluna += matriz[j, i];
                }
                Console.WriteLine($"Soma da {i + 1}° coluna: {somacoluna}");
            }
            Console.WriteLine();

            Console.WriteLine($"Soma da diagonal principal: {diagonal}");
            Console.WriteLine($"Soma da diagonal secundaria: {diagonalsec}");
            Console.ReadLine();
        }
    }
}
