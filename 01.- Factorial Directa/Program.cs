using System;

class program
{
    // Método recursivo para calcular el n-ésimo número de Fibonacci
    static int fibonacci(int n)
    {
        // Caso base: si la posición es 0 o 1, devuelve el mismo número
        if (n <= 1)
            return n;

        // Paso recursivo: suma los dos números anteriores de la serie
        return fibonacci(n - 1) + fibonacci(n - 2);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar al usuario la posición deseada
        Console.WriteLine("ingrese la posicion");
        int n = int.Parse(Console.ReadLine());

        // Validar que la posición esté dentro del rango permitido (0 a 40)
        if (n < 0 || n > 40)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 40");
            return;
        }

        // Llamar a la función recursiva e imprimir el resultado
        Console.WriteLine("Fibonacci" + fibonacci(n));
    }
}
