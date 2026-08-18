using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo
        Circulo circulo = new Circulo
        {
            Nombre = "Círculo",
            Radio = 5
        };

        // Crear un rectángulo
        Rectangulo rectangulo = new Rectangulo
        {
            Nombre = "Rectángulo",
            Ancho = 8,
            Alto = 4
        };

        // Crear una lista de la clase base Forma
        List<Forma> formas = new List<Forma>();

        // Agregar las diferentes formas a la misma lista
        formas.Add(circulo);
        formas.Add(rectangulo);

        Console.WriteLine("=================================");
        Console.WriteLine("       FORMAS GEOMÉTRICAS");
        Console.WriteLine("=================================");
        Console.WriteLine();

        // Recorrer todas las formas
        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Forma: {forma.Nombre}");
            Console.WriteLine($"Área: {forma.CalcularArea():F2}");
            Console.WriteLine("---------------------------------");
        }
    }
}