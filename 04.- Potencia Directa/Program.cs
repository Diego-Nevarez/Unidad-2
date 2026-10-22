using System;

class program
{
    static long Potencia(int baseNum, int exponentes)
    {
        if (exponentes == 0)
            return 1;
        return baseNum * Potencia(baseNum, exponentes - 1);
    }
    static void Main()
    {
        Console.WriteLine("ingrese la base");
        int baseNum = int.Parse(Console.ReadLine());

        Console.WriteLine("ingresa el exponente (0 a 30):");
        int exponentes = int.Parse(Console.ReadLine());

        if (exponentes < 0 || exponentes > 30) ;
        {
            Console.WriteLine("exponente fuera de rango");
            return;
        }
        Console.WriteLine("resultado:" + Potencia(baseNum, exponentes));
    }
}
