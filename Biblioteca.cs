using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComA_Grupo8
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();

        }

        // --- Búsquedas ---
        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
                i++;

            if (i != libros.Count)
                libroBuscado = libros[i];

            return libroBuscado;
        }

        private Lector buscarLector(int dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && lectores[i].getDni() != dni)
                i++;

            if (i != lectores.Count)
                lectorBuscado = lectores[i];

            return lectorBuscado;
        }

        // --- Métodos solicitados ---

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            if (buscarLibro(titulo) == null)
            {
                libros.Add(new Libro(titulo, autor, editorial));
                resultado = true;
            }
            return resultado;
        }

        public void altaLector(string nombre, int dni)
        {
            if (buscarLector(dni) == null)
            {
                lectores.Add(new Lector(nombre, dni));
                Console.WriteLine("Lector " + nombre + " registrado con éxito.");
            }
            else
            {
                Console.WriteLine("Error: El lector ya existe.");
            }
        }

        public string prestarLibro(string titulo, int dni)
        {
            // 1. Validar Lector
            Lector lector = buscarLector(dni);
            if (lector == null) return "LECTOR INEXISTENTE";

            // 2. Validar Tope
            if (lector.getLibrosPrestados().Count >= 3) return "TOPE DE PRESTAMO ALCAZADO";

            // 3. Validar Libro
            Libro libro = buscarLibro(titulo);
            if (libro == null) return "LIBRO INEXISTENTE";

            // 4. Ejecutar Préstamo
            libros.Remove(libro);
            lector.getLibrosPrestados().Add(libro);

            return "PRESTAMO EXITOSO";
        }

        public void listarLibros()
        {
            Console.WriteLine("\n--- Libros en Estantería ---");
            foreach (var l in libros) Console.WriteLine(l);
        }

    }
}