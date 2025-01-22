using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int N = int.Parse(Console.ReadLine());

        if (EsPrimo(N))
        {
            Console.WriteLine($"{N} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{N} no es un número primo.");
        }
    }

    static bool EsPrimo(int N)
    {
        // Un número menor o igual a 1 no es primo
        if (N <= 1)
        {
            return false;
        }

        // Verificar divisores desde 2 hasta la raíz cuadrada de N
        for (int i = 2; i <= Math.Sqrt(N); i++)
        {
            if (N % i == 0)
            {
                return false; // Si se encuentra un divisor, no es primo
            }
        }

        return true; // Si no hay divisores, es primo
    }
}
