using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    class Profesor : Persona, IExportable
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

        //Etapa 8
        public override string Presentarse() 
        {
            return $"Hola, soy {Nombre} y dicto la materia {Materia}.";
        }
        //Etapa 9
        public string ExportarLinea()
        {
            return $"PROFESOR;{Nombre};{Materia}";
        }
    }
}