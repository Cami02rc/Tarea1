using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            int contador = 1;
            int total = 0;
            for (int f = 0; f < 3; f++) 
            {
                for (int c = 0; c < 3; c++)
                {
                    matriz[f, c] = contador++;
                    if (c == f || c==0)
                    {
                        total += matriz[f, c];
                    }
                    Console.Write(" " + matriz[f, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria de las esquinas es: {0}", total);
            Console.ReadLine();
        }
    }
}
