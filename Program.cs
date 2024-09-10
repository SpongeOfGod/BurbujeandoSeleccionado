using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burbujeado burbujeado = new Burbujeado();
            Seleccionado seleccionado = new Seleccionado();
            Stopwatch MrGameAndWatch = new Stopwatch();

            int?[] numeros = [5, 1, 4, 3, 2];

            Console.WriteLine("\n----------------------------------------------------------------------" +
                              "\n                       ORDENAMIENTO DE ARRAYS" +
                              "\n----------------------------------------------------------------------");

            MrGameAndWatch.Start();
            burbujeado.RunUpdate(numeros);
            MrGameAndWatch.Stop();
            Console.WriteLine($"Bubble Sort tardó: {MrGameAndWatch.ElapsedTicks} ticks");


            numeros = [5, 1, 4, 3, 2];
            MrGameAndWatch.Restart();
            seleccionado.RunUpdate(numeros);
            MrGameAndWatch.Stop();
            Console.WriteLine($"Selection Sort tardó: {MrGameAndWatch.ElapsedTicks} ticks");

            CheckSteps(burbujeado, seleccionado);

            numeros = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];
            MrGameAndWatch.Restart();
            burbujeado.RunUpdate(numeros);
            MrGameAndWatch.Stop();
            Console.WriteLine($"Bubble Sort tardó: {MrGameAndWatch.ElapsedTicks} ticks ");

            numeros = [1, 2, 12, 6, 3, 4, 9, 11, 5, 8, 7, 10, 13, 15, 14];
            MrGameAndWatch.Restart();
            seleccionado.RunUpdate(numeros);
            MrGameAndWatch.Stop();
            Console.WriteLine($"Selection Sort tardó: {MrGameAndWatch.ElapsedTicks} ticks");

            CheckSteps(burbujeado, seleccionado);
        }

        static public void CheckSteps(Burbujeado burbujeado, Seleccionado seleccionado)
        {
            Console.WriteLine($"\nBubble Sort: {burbujeado.steps} pasos.\nSelection Sort: {seleccionado.steps} pasos.");
            if (burbujeado.steps < seleccionado.steps)
            {
                Console.WriteLine($"\nBubble Sort tuvo la menor cantidad de pasos.");
            }
            else
            {
                Console.WriteLine($"\nSelection sort tuvo la menor cantidad pasos.");
            }
            Console.WriteLine("\n----------------------------------------------------------------------");
        }
    }
}
