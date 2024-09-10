using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Seleccionado
    {
        public int steps = 0;
        int? minimumValue = 0;

        public void RunUpdate(int?[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                int indexMin = i;

                for (int j = i + 1; j < numeros.Length; j++) 
                {
                    steps++;

                    if (numeros[j] < numeros[indexMin]) 
                    {
                        indexMin = j;
                    }    
                }

                if(numeros[i] != numeros[indexMin]) 
                {
                    Console.WriteLine($"\n'{numeros[i]}' (Posición {i} en Array) es mayor a '{numeros[i + 1]}' (Posición {i + 1} en Array)...\nOrdenando...");
                    (numeros[i], numeros[indexMin]) = (numeros[indexMin], numeros[i]);
                }
            }

            Console.WriteLine($"\nArray ordenado con Selection Sort ({steps} checkeos)");

            foreach (int? numero in numeros)
            {
                Console.Write(numero + " ");
            }

        }
    }
}