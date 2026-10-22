using System;

class program
{
    // Método de recursividad mutua A: suma 'n' al resultado devuelto por sumaB
    static int sumaA(int n)
    {
        // Caso base: se detiene si el número es menor o igual a 0
        if (n <= 0)
            return 0;

        // Paso recursivo mutuo: suma el valor actual de 'n' y llama a sumaB enviando (n - 1)
        return n + sumaB(n - 1);
    }

    // Método de recursividad mutua B: suma 'n' al resultado devuelto por sumaA
    static int sumaB(int n)
    {
        // Caso base: se detiene si el número es menor o igual a 0
        if (n <= 0)
            return 0;

        // Paso recursivo mutuo: suma el valor actual de 'n' y llama a sumaA enviando (n - 1)
        return n + sumaA(n - 1);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar un número al usuario
        Console.WriteLine("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número esté dentro del rango permitido (0 a 10000)
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre y 10000 ");
            return;
        }

        // Iniciar la suma alternada llamando al método sumaA e imprimir el resultado
        Console.WriteLine("La suma es: " + sumaA(n));
    }
}
