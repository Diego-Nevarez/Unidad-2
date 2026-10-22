using System;

class Program
{
    // Método recursivo para calcular la suma de los números desde 1 hasta n
    static int Suma(int n)
    {
        // Caso base: si el número es menor o igual a 0, la suma se detiene y regresa 0
        if (n <= 0)
            return 0;

        // Paso recursivo: suma el número actual (n) con la suma del número anterior (n - 1)
        return n + Suma(n - 1);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar un número al usuario
        Console.WriteLine("ingresa un numero");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número ingresado esté dentro del rango permitido (0 a 10000)
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 10000");
            return;
        }

        // Llamar al método recursivo e imprimir el resultado de la suma
        Console.WriteLine("La suma es :" + Suma(n));
    }
}
