using System.Diagnostics;
namespace Deber02_Ordenamiento;
//Dueñas Mateo
class BurbujaOrdenamiento
{
    static void Main1(string[] args)
    {
        float[] A = {50, 20, 40, 80, 30};
    Console.WriteLine("Arreglo desordenado: ");
    for(int i=0; i<5; i++)
    {
        Console.Write( A[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("Comienza Burbuja: ".PadRight(30) + "cambio".PadRight(10) + "pasada");
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    Burbuja(A, 5);
    Console.WriteLine("Arreglo Ordenado: ");
    for(int i=0; i<5; i++){
        Console.Write( A[i] + " ");
    }
    stopwatch.Stop();
    Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
}
static void Burbuja(float[] A, int n)
{
    float auxiliar;
    for (int i = 0; i < n-1; i++) {             //n–1 pasadas
        for (int j=0; j < n - 1 - i; j++) { // burbujeo de datos
            if (A[j] > A[j + 1]) {          //comparación de elementos contiguos para intercambio
                auxiliar = A[j];
                A[j] = A[j + 1];
                A[j + 1] = auxiliar;
            }
            for(int k=0; k<n; k++){
                Console.Write(A[k] + " ");
            }
            Console.WriteLine("".PadRight(15) + A[j] + " " + A[j+1] + "".PadRight(10)+ i);
        }
    }
}
}

