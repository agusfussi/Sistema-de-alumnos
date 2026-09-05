using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    internal class Persona
    {
        public string Nombre { set; get; }
        public int DNI {  set; get; }

        public Persona(string nombre, int dni)
        {
            nombre = Nombre;
            dni = DNI;
        }
    }
}
