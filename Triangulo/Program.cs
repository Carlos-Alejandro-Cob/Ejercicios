using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Ingrese las medidas de los tres lados del triángulo:");

            Console.Write("Lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Usar métodos de la clase Triangulo para análisis
            if (Triangulo.EsValido(lado1, lado2, lado3))
            {
                string tipo = Triangulo.DeterminarTipo(lado1, lado2, lado3);
                Console.WriteLine($"El triángulo es: {tipo}");

                if (Triangulo.EsRectangulo(lado1, lado2, lado3))
                {
                    Console.WriteLine("Además, es un triángulo rectángulo.");
                }
                else
                {
                    Console.WriteLine("No es un triángulo rectángulo.");
                }
            }
            else
            {
                Console.WriteLine("Las medidas ingresadas no forman un triángulo válido.");
            }

            Console.WriteLine("¿Desea probar con otras medidas? (s/n)");
            continuar = Console.ReadLine()?.ToLower() == "s";
        }

        Console.WriteLine("Programa terminado. ¡Gracias!");
    }
}

class Triangulo
{
    // Método para verificar si las medidas forman un triángulo válido
    public static bool EsValido(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Método para determinar el tipo de triángulo
    public static string DeterminarTipo(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Equilátero";
        else if (a == b || a == c || b == c)
            return "Isósceles";
        else
            return "Escaleno";
    }

    // Método para verificar si es un triángulo rectángulo usando el Teorema de Pitágoras
    public static bool EsRectangulo(double a, double b, double c)
    {
        double[] lados = { a, b, c };
        Array.Sort(lados); // Ordenar los lados para que el mayor sea la hipotenusa
        return Math.Abs(Math.Pow(lados[0], 2) + Math.Pow(lados[1], 2) - Math.Pow(lados[2], 2)) < 0.0001;
    }
}