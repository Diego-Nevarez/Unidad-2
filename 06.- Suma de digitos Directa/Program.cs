using System;

class program
{
    // Método recursivo para calcular la suma de los dígitos de un número
    static int SumarDigitos(int n)
    {
        // Caso base: cuando el número llega a 0, la suma finaliza y devuelve 0
        if (n == 0)
            return 0;

        // Paso recursivo: obtiene el último dígito (n % 10) y lo suma con la llamada recursiva del resto del número (n / 10)
        return n % 10 + SumarDigitos(n / 10);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar un número al usuario
        Console.WriteLine("Ingrese un numero:");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número ingresado sea positivo
        if (n < 0)
        {
            Console.WriteLine("ingrese un numero positivo ");
            return; // Se agrega return para evitar calcular la suma si el número es negativo
        }

        // Llamar a la función recursiva e imprimir la suma de sus dígitos
        Console.WriteLine("Suma de digitos: " + SumarDigitos(n));
    }
}
