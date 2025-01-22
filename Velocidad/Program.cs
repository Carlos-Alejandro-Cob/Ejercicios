﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa el tiempo de cada corredor (minutos, segundos), usa 0,0 para finalizar:");
        double minutos, segundos;

        while (true)
        {
            Console.Write("Minutos: ");
            minutos = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segundos: ");
            segundos = Convert.ToDouble(Console.ReadLine());

            if (minutos == 0 && segundos == 0)
                break;

            // Calcular tiempo total en segundos
            double tiempoTotalSegundos = (minutos * 60) + segundos;

            // Calcular velocidad en m/s
            double velocidad = 1500 / tiempoTotalSegundos;

            Console.WriteLine($"Tiempo total: {minutos} minutos y {segundos} segundos.");
            Console.WriteLine($"Velocidad: {velocidad:F2} m/s\n");
        }

        Console.WriteLine("Fin del programa.");
    }
}