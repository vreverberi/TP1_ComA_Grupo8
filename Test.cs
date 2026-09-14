using System;

namespace TP1_ComA_Grupo8
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            
            // Carga de datos ---
            biblioteca.agregarLibro("Libro1", "Autor1", "Ed1");
            biblioteca.agregarLibro("Libro2", "Autor2", "Ed2");
            biblioteca.agregarLibro("Libro3", "Autor3", "Ed3");
            biblioteca.agregarLibro("Libro4", "Autor4", "Ed4");

            biblioteca.altaLector("Maria Lopez", 12345678);

            // Pruebas de lógica ---
            Console.WriteLine("--- Simulacro de Préstamos ---");
            Console.WriteLine(biblioteca.prestarLibro("Libro1", 12345678)); // EXITOSO
            Console.WriteLine(biblioteca.prestarLibro("Libro2", 12345678)); // EXITOSO
            Console.WriteLine(biblioteca.prestarLibro("Libro3", 12345678)); // EXITOSO
            Console.WriteLine(biblioteca.prestarLibro("Libro4", 12345678)); // TOPE ALCANZADO

            biblioteca.listarLibros();
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}