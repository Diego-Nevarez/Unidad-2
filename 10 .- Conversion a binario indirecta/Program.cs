//Convertir un numero entero no negativo a su representacion binaria usando dos metodos que se llaman mutuamente
using System;

class program
{
    // Método de recursividad mutua A: imprime la conversión a binario llamando a BinarioB
    static void BinarioA(int n)
    {
        // Caso base: si el número es menor a 2 (0 o 1), se imprime directamente
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        // Paso recursivo mutuo: procesa la mitad entera del número mediante BinarioB
        BinarioB(n / 2);

        // Imprime el residuo (0 o 1) correspondiente al bit actual al regresar de la recursividad
        Console.Write(n % 2);
    }

    // Método de recursividad mutua B: imprime la conversión a binario llamando a BinarioA
    static void BinarioB(int n)
    {
        // Caso base: si el número es menor a 2 (0 o 1), se imprime directamente
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        // Paso recursivo mutuo: procesa la mitad entera del número mediante BinarioA
        BinarioA(n / 2);

        // Imprime el residuo (0 o 1) correspondiente al bit actual al regresar de la recursividad
        Console.Write(n % 2);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar un número entero positivo al usuario
        Console.Write("ingresa un numero entero");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número ingresado no sea negativo
        if (n < 0)
        {
            Console.WriteLine("ingresa un numero no negativo");
            return;
        }

        Console.Write("Binario:");

        // Imprimir 0 directamente si el número es 0, o iniciar la conversión mediante BinarioA
        if (n == 0)
            Console.Write("0");
        else
            BinarioA(n);

        Console.WriteLine();
    }
}
