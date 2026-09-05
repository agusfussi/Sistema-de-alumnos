//Creo los alumnos
using Sistema_de_alumnos;
//Etapa 6
List<Alumno> alumnos = new List<Alumno>();

while (true) 
{
    Console.WriteLine("--------Haz tu lista de alumnos------");
    Console.WriteLine("1. Agrega un alumno");
    Console.WriteLine("2. Mostrar lista de alumnos");
    Console.WriteLine("3. Buscar un alumno por legajo");
    Console.WriteLine("4. Mostrar el promedio general");
    Console.WriteLine("5. Mostrar cuántos están aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elegí una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Escribe el nombre del alumno:");
            string nombre = Console.ReadLine();
            Console.Write("Escribe su legajo:");
            int legajo = int.Parse(Console.ReadLine());
            Alumno nuevoAlumno = new Alumno(nombre, legajo);
            Console.Write("Ahora escribe la primer nota del alumno:");
            decimal nota1 = decimal.Parse(Console.ReadLine());
            Console.Write("Ahora escribe la segunda nota del alumno:");
            decimal nota2 = decimal.Parse(Console.ReadLine());
            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine($"{nombre} fue añadido con exito");
            }
            else
            {
                Console.WriteLine("Error en a carga del alumno");
            }
            break;
////////////////////////////////////////////////////////////////////
        case "2":
            Console.WriteLine("Esta es la lista de alumnos:");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno);
            }
            break;
///////////////////////////////////////////////////////////////////
        case "3":
            Console.Write("Escribe el numero de legajo del alumno que queres:");
            int legajo1 = int.Parse(Console.ReadLine());
            bool encontrado = false;
            foreach(Alumno alumno in alumnos)
            {
                if(alumno.Legajo == legajo1) 
                {  
                    encontrado = true;
                    Console.WriteLine(alumno);
                    break;
                }
                if (encontrado == false)
                {
                    Console.WriteLine("No existe ningún alumno con ese legajo.");
                }
            }
            break;
///////////////////////////////////////////////////////////////////
        case "4":
            if(alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados");
            }
            else
            {
                decimal suma = 0;
                foreach(Alumno alumno in alumnos)
                {
                    suma += alumno.Promedio();
                }
                decimal PromedioGeneral = suma / alumnos.Count;
                Console.WriteLine($"El promedio general es: {PromedioGeneral}");
            }
            break;
//////////////////////////////////////////////////////////////////
        case "5":
            int cantidadAprobados = 0;
            foreach(Alumno alumno in alumnos)
            {
                if (alumno.EstasAprobado()) 
                {
                    cantidadAprobados++;
                }
            }
            Console.WriteLine($"Esta es la cantidad de aprobados:{cantidadAprobados}");
            break;
/////////////////////////////////////////////////////////////////
        case "6":
            Console.WriteLine("Saliendo del programa...");
            return;
////////////////////////////////////////////////////////////////
    }
    Console.WriteLine();
}

//Alumno alumno1 = new Alumno("Juan", 1); //, 6.7m, 8.2m);
//alumno1.Nombre = "Juan";
//alumno1.Legajo = 1;
//alumno1.Nota1 = 1.3m;
//alumno1.Nota2 = 8.5m;

//Alumno alumno2 = new Alumno();
// Error: Faltan datos. Ya no se puede usar new Alumno() vacío porque definimos un constructor que pide el nombre, legajo y notas.
//Alumno alumno2 = new Alumno("Marcos", 2); //, 4.7m, 8.2m);
//alumno2.Nombre = "Marcos";
//alumno2.Legajo = 2;
//alumno2.Nota1 = 6.0m;
//alumno2.Nota2 = 7.0m;

//Etapa 5
//bool seCargaron = alumno1.CargarNotas(6.7m, 8.2m);

//if (seCargaron == false)
//{
  //  Console.WriteLine("Error: Las notas ingresadas no son válidas.");
//}

//Muestro en consola
//Console.WriteLine($"El alumno {alumno1.Nombre} tiene el legajo: {alumno1.Legajo}");
//Console.WriteLine($"El alumno {alumno2.Nombre} tiene el legajo: {alumno2.Legajo}");

//Cambio el nombre del primer alumno
//alumno1.Nombre = "Juanca";
//Console.WriteLine($"El nombre del alumno con el legajo {alumno1.Legajo}, fue cambiado a {alumno1.Nombre}");

//Console.WriteLine($"El promedio de {alumno1.Nombre} es {alumno1.Promedio()}");

//Console.WriteLine($" {alumno1.Nombre} esta {alumno1.EstasAprobado()}");

//alumno1.SubirNota();

//Console.WriteLine($"Le subimos la nota a el alumno {alumno1.Nombre} es {alumno1.Promedio()}");

//Etapa 4

//Console.WriteLine(alumno1);