using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class SumaDeElementos
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE CANTIDAD DE FILAS: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("INGRESE CANTIDAD DE COLUMNAS: ");
            int columnas = int.Parse(Console.ReadLine());
            int sumadMatrices = 0;

            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("DIGITE EL NUMERO PARA LA POSICION [" + i + " " + j + "] ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    
                }
            }
            Console.WriteLine("LA MATRIZ ORIGINAL ES: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("LA SUMA DE LA MATRIZ ES: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    sumadMatrices=sumadMatrices + matriz[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine("LA SUMA DE LAS MATRICES ES: " + sumadMatrices);
            Console.ReadKey();


        }
    }
}
