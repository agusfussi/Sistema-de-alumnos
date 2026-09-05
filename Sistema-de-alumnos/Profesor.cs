using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    class Profesor : Persona
    {
        public string Materia { set; get; }

        public Profesor(string nombre, int dni, string materia) : base(nombre, dni)//decimal nota1, decimal nota2)
        {
            //Nombre = nombre;
            Materia = materia;
            //DNI = dni;
            //Nota1 = nota1;
            //Nota2 = nota2;
        }
    }
}