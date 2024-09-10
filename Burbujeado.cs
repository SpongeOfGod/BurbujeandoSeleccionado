using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Burbujeado
    {
        int? numberoOrdenado = 0;
        public int steps = 0;


        public void RunUpdate(int?[] numeros) 
        {

            while(numberoOrdenado < numeros.Length) 
            {
                for (int i = 0; i < numeros.Length - numberoOrdenado; i++) 
                {
                    steps++;
                    if(i != numeros.Length - numberoOrdenado -1) 
                    {
                        var number1 = numeros[i];
                        var number2 = numeros[i + 1];

                        if(number1 > number2) 
                        {
                            Console.WriteLine($"'{numeros[i]}' (Posición {i} en Array) es mayor a '{numeros[i + 1]}' (Posición {i+1} en Array)...\nOrdenando...");
                            (numeros[i], numeros[i + 1]) = (numeros[i + 1], numeros[i]);
                        }
                    }
                    else
                    {
                        numberoOrdenado++;
                        break;
                    }
                }            
            }

            Console.WriteLine($"\nArray ordenado con Bubble Sort ({steps} checkeos)");

            foreach (int? i in numeros) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
