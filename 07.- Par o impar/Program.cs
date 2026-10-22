using System;

class program
{
    // Método recursivo mutuo para determinar si un número es par
    static bool Espar(int n)
    {
        // Caso base: 0 es un número par
        if (n == 0) return true;

        // Paso recursivo mutuo: si (n) no es 0, evalúa si (n - 1) es impar
        return Esimpar(n - 1);
    }

    // Método recursivo mutuo para determinar si un número es impar
    static bool Esimpar(int n)
    {
        // Caso base: 0 no es un número impar
        if (n == 0)
            return false;

        // Paso recursivo mutuo: si (n) no es 0, evalúa si (n - 1) es par
        return Espar(n - 1);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar un número al usuario
        Console.WriteLine("ingrese un numero");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número esté dentro del rango permitido (0 a 10000)
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("ingrese un numero entre 0 y 10000");
            return;
        }

        // Evaluar la paridad mediante la función recursiva mutua
        if (Espar(n))
            Console.WriteLine("el numero es par");
        else
            Console.WriteLine("el numero es impar");
    }
}
