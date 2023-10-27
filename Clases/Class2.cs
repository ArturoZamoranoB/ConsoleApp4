using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    internal class Class2
    {
        public void Ejercicio2()
        {
            // paso 1 a 3//
            int[] arreglo = new int[100] { 1, 6, 4, 6, 4, 6, 4, 9, 7, 5, 1, 5, 3, 8, 5, 4, 7, 7, 6, 2, 9, 8, 7, 10, 1, 0, 5, 3, 9, 5, 6, 6, 4, 6, 1, 6, 4, 6, 4, 6, 4, 9, 7, 5, 1, 5, 3, 8, 5, 4, 7, 7, 6, 2, 9, 8, 7, 10, 1, 0, 5, 3, 9, 5, 6, 6, 4, 6, 1, 6, 4, 6, 4, 6, 4, 9, 7, 5, 1, 5, 3, 8, 5, 4, 7, 7, 6, 2, 9, 8, 7, 10, 1, 0, 5, 3, 9, 5, 6, 6 };

            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
            }

            for(int i = 0; i < arreglo.Length- 1; i++)
            {
                int min = i;

                for(int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[min])
                    {
                        min = j;

                    }

                }
                if(min != i)
                {
                    int A = arreglo[i];
                    arreglo[i] = arreglo[min];
                    arreglo[min] = A;
                }

            }

            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] +",");
            }

            
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            
            
            // paso de 4 y 5//
            
            int[] arreglo = new int[100] { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10 };

            int inicio = 0;
            int fin = arreglo.Length - 1;
            int medio = (inicio + fin) / 2;
            int num = 75;
            bool encontrar = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[medio] == num)
                {
                    Console.WriteLine($"El numero {arreglo[medio]} se encuentra en la posicion {medio}");
                    encontrar = true;
                    break;
                }
                else if (arreglo[medio] > num)
                {
                    fin = medio - 1;
                    medio = (fin + medio) / 2;
                }
                else
                {
                    inicio = medio + 1;
                    medio = (fin + medio) / 2;
                }

            }
           
            if(!encontrar)
            {
                Console.WriteLine("El numero no se encuentra en la lista");
            }

        }
    }
}
