using System.Diagnostics;
namespace Deber02_Ordenamiento;
//Dueñas Mateo
class QuicksortOrdenamiento
{
    static void Main(string[] args)
    {
        float[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };
        int n = 12;
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Console.WriteLine(" ");
        QuickSort(A, 0, n - 1);
        Console.WriteLine("Arreglo Ordenado por quicksort: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        stopwatch.Stop();
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
    static void QuickSort(float[] a, int primero, int ultimo)
    {
        int i, j, central;
        float pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                float tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */
        for (int k = 0; k < a.Length; k++)
        {
            Console.Write(a[k] + " ");
        }
        Console.WriteLine(" ");
    }
}