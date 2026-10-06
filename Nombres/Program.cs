using System;

namespace Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] NombresDePersonas = new string[5];

            for (int i = 0; i < NombresDePersonas.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre {i + 1}: ");
                NombresDePersonas[i] = Console.ReadLine();
            }

            for (int x = 0; x < NombresDePersonas.Length; x++)
            {
                Console.WriteLine($"{x + 1}. {NombresDePersonas[x]}");
                        }
        }
    }
}
