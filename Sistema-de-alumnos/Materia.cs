using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    internal class Materia : IExportable
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }

        public Materia(int codigo,string nombre,int horas)
        {
            Horas = horas;
            Nombre = nombre;
            Horas = horas;
        }
        public string ExportarLinea()
        {
            return $"MATERIA;{Codigo};{Nombre};{Horas}";
        }

    }
}
