using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_ComA_Grupo8
{
    internal class Lector
    {
        private string nombre;
        private int dni;
        private List<Libro> librosPrestados;

        public Lector(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosPrestados = new List<Libro>();
        }

        public int getDni()
        {
            return dni;
        }

        public List<Libro> getLibrosPrestados()
        {
            return librosPrestados;
        }

        public override string ToString()
        {
            return "Lector: " + nombre + " (DNI: " + dni + ")";
        }

    }
}