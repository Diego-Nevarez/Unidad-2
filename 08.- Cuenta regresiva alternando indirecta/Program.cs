//Mostrar una cuenta regresiva desde un numero hasta cero utilizando dos metodos que se llaman entre si
using System;

class program
{
    // Método de recursividad mutua A: imprime el valor actual de 'n' marcado con 'A' y llama a CuentaB
    static void CuentaA(int n)
    {
        // Caso base: se detiene si el número es negativo
        if (n < 0)
            return; 

        Console.WriteLine("A:" + n);
        
        // Paso recursivo mutuo: decrementa 'n' y llama al método CuentaB
        CuentaB(n - 1);
    }

    // Método de recursividad mutua B: imprime el valor actual de 'n' marcado con 'B' y llama a CuentaA
    static void CuentaB(int n)
    {
        // Caso base: se detiene si el número es negativo
        if (n < 0)
            return;

        Console.WriteLine("B:" + n);

        // Paso recursivo mutuo: decrementa 'n' y llama al método CuentaA
        CuentaA(n - 1);
    }

    // ===============================================
    // Programa Principal
    // ===============================================
    static void Main()
    {
        // Solicitar al usuario el número inicial para el conteo regresivo
        Console.WriteLine("Ingresa el numero inicial:");
        int n = int.Parse(Console.ReadLine());
        
        // Validar que el número ingresado esté dentro del rango permitido (0 a 1000)
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 100.");
            return;
        }

        // Iniciar la secuencia de conteo regresivo alternado llamando a CuentaA
        CuentaA(n); 
    }
}
