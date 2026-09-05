using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
     class Alumno: Persona
    {
        //public string Nombre { get; set; }
        public int Legajo { get; private set; }
        public decimal Nota1 { get; private set; }
        public decimal Nota2 { get; private set; }

        public Alumno(string nombre, int dni , int legajo)  : base(nombre, dni)//decimal nota1, decimal nota2)
        {
            //Nombre = nombre;
            Legajo = legajo;
            //DNI = dni;
            //Nota1 = nota1;
            //Nota2 = nota2;
        }

        public bool CargarNotas(decimal nota1, decimal nota2)
        {
            if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
            {
                Nota1 = nota1;
                Nota2 = nota2;
                return true;
            }
            else 
            {  
                return false; 
            }
            
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
