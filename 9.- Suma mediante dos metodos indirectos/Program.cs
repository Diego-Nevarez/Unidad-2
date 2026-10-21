//Calcular la suma de los numeros desde 1 hasta n utilizando dos metodos que se llaman mutuamente
using System;
class program
{
    static int sumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + sumaB(n - 1);
    }
    static int sumaB(int n)
    {
        if (n <= 0)
            return 0;

        return n + sumaA(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre y 10000 ");
            return;
        }
        Console.WriteLine("La suma es: " + sumaA(n));
    }
}