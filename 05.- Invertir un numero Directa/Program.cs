using System;

class program
{
    // Método recursivo para invertir un número acumulando el resultado
    static long invertir(long n, long resultado = 0)
    {
        // Caso base: cuando el número llega a 0, se devuelve el resultado final
        if (n == 0)
            return resultado;

        // Paso recursivo: quita el último dígito (n / 10) y lo agrega al acumulador (resultado * 10 + n % 10)
        return invertir(n / 10, resultado * 10 + n % 10);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar al usuario un número positivo
        Console.WriteLine("Ingrese un numero positivo");
        long n = long.Parse(Console.ReadLine());

        // Validar que el número no sea negativo
        if (n < 0)
        {
            Console.WriteLine("El numero debe ser positivo");
            return;
        }

        // Llamar a la función recursiva e imprimir el número invertido
        Console.WriteLine("Numero invertido " + invertir(n));
    }
}
