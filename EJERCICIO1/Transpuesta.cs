using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class Transpuesta
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE EL ORDEN DE LA MATRIZ TRANSPUESTA: ");
            int orden = int.Parse(Console.ReadLine());
            int sumadMatrices=0;

            int[,] matriz = new int[orden, orden];
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write("DIGITE EL NUMERO PARA LA POSICION [" + i + " " + j + "] ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    sumadMatrices=sumadMatrices+matriz[i, j];
                }
            }
            Console.WriteLine("LA MATRIZ ORIGINAL ES: ");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("LA MATRIZ TRANSPUETA ES: ");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write(matriz[j,i] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("LA SUMA DE LAS MATRICES ES: "+sumadMatrices);
            Console.ReadKey();
            
            
        }
    }
}
