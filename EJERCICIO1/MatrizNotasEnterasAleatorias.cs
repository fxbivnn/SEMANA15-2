using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class MatrizNotasEnterasAleatorias
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMATRIZ NOTAS ENTERAS ALEATORIAS");
            Console.Write("INGRESE CANTIDAD DE FILAS: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("INGRESE CANTIDAD DE COLUMNAS: ");
            int columnas = int.Parse(Console.ReadLine());
            Random alea = new Random();
            int sumaDNotas = 0;
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = alea.Next(0, 21);
                    sumaDNotas=sumaDNotas+matriz[i, j];

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
            Console.WriteLine("LA SUMA DE NOTAS ALEATORIAS ES: " + sumaDNotas);
            Console.ReadKey();
        }
    }
}
