using System;

class Program
{
    // Método recursivo para calcular la potencia de un número
    static long Potencia(int baseNum, int exponentes)
    {
        // Caso base: cualquier número elevado a la potencia 0 es 1
        if (exponentes == 0)
            return 1;

        // Paso recursivo: multiplica la base por el resultado de la función con exponente decrementado
        return baseNum * Potencia(baseNum, exponentes - 1);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar la base al usuario
        Console.WriteLine("ingrese la base");
        int baseNum = int.Parse(Console.ReadLine());

        // Solicitar el exponente al usuario
        Console.WriteLine("ingresa el exponente (0 a 30):");
        int exponentes = int.Parse(Console.ReadLine());

        // Validar que el exponente esté dentro del rango permitido (0 a 30)
        if (exponentes < 0 || exponentes > 30)
        {
            Console.WriteLine("exponente fuera de rango");
            return;
        }

        // Llamar a la función recursiva de potencia e imprimir el resultado
        Console.WriteLine("resultado:" + Potencia(baseNum, exponentes));
    }
}
