using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    class Preseptor : Persona
    {
        string Curso {  get; set; }
    
    public Preseptor(string nombre, int dni, string curso) : base(nombre, dni)
        {
           
            Curso = curso;
            
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, y estoy a cargo de {Curso}.";
        }
    }
}
