using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class Identidad
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL ORDEN DE LA MATRIZ IDENTIDAD: ");
            int orden = int.Parse(Console.ReadLine());         

            int[,] matriz = new int[orden, orden];
            for (int i = 0; i <orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    matriz[i, j] = 0;
                    if (i == j)
                    {
                        matriz[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("LA MATRIZ ES: ");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
