using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_LDVP.Metodos
{
    internal class Ejercicios
    {
        public void Eje1()
        {
            
                int[] numeros = { 5, 10, 15, 20, 25 };

                Console.Write("Ingresa el número a buscar: ");
                int numeroBuscado = int.Parse(Console.ReadLine());

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == numeroBuscado)
                    {
                        Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {i}.");
                        return;
                    }
                }

                Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista.");
            
        }
        public void Eje2()
        {
            
                string[] cadenas = { "manzana", "banana", "cereza", "uva", "pera" };

                Console.Write("Ingresa la cadena a buscar: ");
                string cadenaBuscada = Console.ReadLine();

                for (int i = 0; i < cadenas.Length; i++)
                {
                    if (cadenas[i] == cadenaBuscada)
                    {
                        Console.WriteLine($"La cadena '{cadenaBuscada}' se encuentra en la posición {i}.");
                        return;
                    }
                }

                Console.WriteLine($"La cadena '{cadenaBuscada}' no se encuentra en el arreglo.");
        }

        public void Eje3()
        {
            int[] numeros = { 11, 13,6, 8, 10, 12, 14};

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"El primer número est'a en: {i}.");
                    return;
                }
            }

            Console.WriteLine("No se encontraron números pares.");
        }
        public void Eje4()
        {
            int[] numeros = { 3, 6, 2, 9, 8, 12, 4, 7, 10 };

            Console.WriteLine("Posiciones de números pares en la matriz:");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par {numeros[i]} encontrado en la posición {i}");
                }
            }
        }

        public int Eje5(int[] arreglo, int elemento)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                if (arreglo[medio] == elemento)
                {
                    return medio;
                }
                else if (arreglo[medio] < elemento)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1;
        }

        public void Eje5()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.Write("Ingresa el número a buscar: ");
            int numeroBuscado = int.Parse(Console.ReadLine());

            int posicion = Eje5(numeros, numeroBuscado);

            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no se encuentra en el arreglo.");
            }
        }
        public int Eje7(int[] arreglo)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int numeroMedio = arreglo[medio];

                if (numeroMedio % 2 == 0)
                {
                    return medio;
                }
                else if (numeroMedio % 2 != 0)
                {
                    izquierda = medio + 1;
                }
            }

            return -1; 
        }

        public void Eje7()
        {
            int[] numeros = { 1, 3, 5, 6, 8, 10, 12, 15, 17, 19 };

            int posicion = Eje7(numeros);

            if (posicion != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }

    }
}
