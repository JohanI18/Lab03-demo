using System.Diagnostics;

namespace Lab03_search;
class binarySearch
{
    static void Main(string[] args)
    {
        DateTime startTime = DateTime.Now;
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Busqueda binaria");
        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60 };
        Array.Resize(ref A, 20);
        for (int i = 9; i < 20; i++)
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
        Array.Sort(A);
        Console.WriteLine("Arreglo ordenado: ");
        printArray(A);
        Console.Write("Ingrese el elemento a buscar: ");
        int clave = int.Parse(Console.ReadLine());
        stopwatch.Start();
        int posicionEncontrada = binarySearchID(A, n, clave);
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

    static int binarySearchID(int[] A, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            valorCentral = A[central];
            if (A[central] == clave)
                return central;
            else if (clave < A[central])
                alto = central - 1;
            else
                bajo = central + 1;
        }
        return -1;
    }
    static int BinarySearchID(int[] A, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = -1;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (A[central] == clave)
                encontrado = true;
            else if (clave < A[central])
                alto = central - 1;
            else
                bajo = central + 1;

        }
        return encontrado ? central : -1;
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
