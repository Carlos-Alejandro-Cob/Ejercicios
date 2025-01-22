using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa la calificación de las prácticas: ");
        double practicas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la calificación del examen: ");
        double examen = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la calificación de las tareas: ");
        double tareas = Convert.ToDouble(Console.ReadLine());

        double calificacionTotal = (practicas * 0.55) + (examen * 0.30) + (tareas * 0.15);

        Console.WriteLine($"La calificación total del alumno es: {calificacionTotal:F2}");
    }
}