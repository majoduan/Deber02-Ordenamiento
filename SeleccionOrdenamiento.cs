using System.Diagnostics;
namespace Deber02_Ordenamiento;
//Dueñas Mateo
class SeleccionOrdenamiento
{
    static void Main1(string[] args)
    {
        float[] A = { 51, 21, 39, 80, 36 };
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Comienza ord. por seleccion: ".PadRight(40) + "cambio".PadRight(15) + "pasada");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Seleccion(A, 5);
        Console.WriteLine("Arreglo Ordenado por seleccion: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }
        stopwatch.Stop();
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
    static void Seleccion(float[] A, int n)
    {
        int i, j, indiceMenor;
        float auxiliar;
        for (i = 0; i < n - 1; i++)
        {
            indiceMenor = i; // posición del menor
            for (j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j; // nueva posición del menor
                }
            }
            auxiliar = A[indiceMenor]; // intercambia posiciones
            A[indiceMenor] = A[i];
            A[i] = auxiliar;
            for (int k = 0; k < n; k++)
            {
                Console.Write(A[k] + " ");
            }
            Console.WriteLine("".PadRight(25) + A[indiceMenor] + " " + A[i] + " ".PadRight(10) + i);
        }
    }
}