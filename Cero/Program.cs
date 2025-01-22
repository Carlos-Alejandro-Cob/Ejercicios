using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa números (0 para finalizar):");
        int numero;
        int contador = 1;

        do
        {
            Console.Write($"Número {contador}: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                Console.WriteLine($"Leíste: {numero}");
                contador++;
            }
        }
        while (numero != 0);

        Console.WriteLine("Fin del programa.");
    }
}