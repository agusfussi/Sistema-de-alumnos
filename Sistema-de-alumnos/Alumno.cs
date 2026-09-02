using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }

        public Alumno(string nombre, int legajo, decimal nota1, decimal nota2)
        {
            Nombre = nombre;
            Legajo = legajo;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public decimal Promedio()
        {
            decimal promedio = (Nota1 +  Nota2) / 2;
            return promedio;
            Console.WriteLine($"El promedio de las notas es{promedio}");
        }
        public bool EstasAprobado()
        {
            if (Promedio() >= 6)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        public void SubirNota()
        {
            if (Nota1 + 1m > 10m)
            {
                Nota1 = 10m;
            }
            else
            {
                Nota1++;
            }

            if (Nota2 + 1m > 10m)
            {
                Nota2 = 10m;
            }
            else
            {
                Nota2++;
            }
        }

        //Etapa 4
        public override string ToString() 
        {
            return $"{Legajo} - {Nombre} (Promedio:{Promedio()})";
        }
        // Advertencia: Si le sacamos el 'override', C# nos avisa que estamos ocultando el ToString() original en lugar de reemplazarlo correctamente.
    }
}
