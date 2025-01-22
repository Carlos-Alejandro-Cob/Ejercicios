using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = numero * 2;

        Console.WriteLine($"El resultado de multiplicar el número por 2 es: {resultado}");
    }
}