using System;
class program
{
    static int fibonacci(int n)
    {
        if (n <= 1)
          return n;
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
    static void Main()
    {
        Console.WriteLine("ingrese la posicion");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 40)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 40");
            return;
        }
        Console.WriteLine("Fibonacci" + fibonacci);

    }


}