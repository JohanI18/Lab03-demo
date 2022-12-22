using System.Diagnostics;

namespace Lab03_search;
class Program
{
    static void Main1(string[] args)
    {
        DateTime startTime = DateTime.Now;
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Algoritmo de busqueda lineal");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };
        Array.Resize(ref A, 20);
        for (int i = 12; i < 20; i++)
        {
            Console.Write("ingrese un elementos mas al array: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                A[i] = int.Parse(input);
            }
            else
            {
                Console.WriteLine("Valor ingresado no valido intente denuevo.");
                i--;
            }
        }
        int n = A.Length;
        Console.WriteLine("Arreglo desordenado: ");
        printArray(A);
        Console.Write("Ingrese el elemento a buscar: ");
        int clave = int.Parse(Console.ReadLine());
        stopwatch.Start();
        int posicionEncontrada = linealSearchID(A, n, clave);
        if (posicionEncontrada != -1)
        {
            Console.WriteLine(clave + " encontrado en posicion: " + (posicionEncontrada + 1));
        }
        else
        {
            Console.WriteLine("No se a encontrado el elemento " + clave);
        }
        stopwatch.Stop();
        DateTime finishTime = DateTime.Now;
        int milliseconds = (finishTime - startTime).Milliseconds;
        Console.WriteLine("La hora de inicio de ejecucion fue {0:T}", startTime);
        Console.WriteLine("La hora de fin de ejecucion fue {0:T}", finishTime);
        Console.WriteLine("El tiempo tomado de ejecucion fue de: {0} milisegundos", milliseconds);
    }

    static int linealSearchID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
        {
            if (A[i] == clave)
                return i;
        }
        return -1;
    }

    public static void printArray(int[] A)
    {
        Console.Write("A = {");
        foreach (int i in A)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("}");
    }
}
