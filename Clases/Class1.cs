using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    internal class Class1
    {
        public void ejercicio1()
        {
            int[,] arreglo = new int[4,5] { { 500, 1000, 250, 400, 60 }, { 3000, 150, 1800, 130, 20 }, { 100, 200, 2900, 90, 4000 }, { 400, 500, 300, 2400, 3600 } };

            int producto1 = 0;
            int producto2 = 0;
            int producto3 = 0;
            int producto4 = 0;
            int producto5 = 0;

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {


                for (int j = 0; j < arreglo.GetLength(1); i++)
                {
                 producto1 = producto1 + arreglo[0,j];
                 producto1 = producto1 + arreglo[1, j];
                 producto1 = producto1 + arreglo[2, j];
                 producto1 = producto1 + arreglo[3, j];
                 producto1 = producto1 + arreglo[4, j];
                }

                
            }

            Console.WriteLine(producto1);
        }
    }
}
