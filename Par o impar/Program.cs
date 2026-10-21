using System;

class program
{
    static bool Espar(int n)
    {
        if (n == 0) return true;

        return Esimpar(n - 1);
    }

    static bool Esimpar(int n)
    {  if (n == 0)
            return false;
                
    return Espar(n - 1);
                }
    static void Main()
    {
        Console.WriteLine("ingrese un numero");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000) 
        {
            Console.WriteLine("ingrese un numero entre 0 y 10000");
            return;
                }
        if (Espar(n))
            Console.WriteLine("el numero es par");
        else
            Console.WriteLine("el numero es impar");
    }

}
