//Creo los alumnos
using Sistema_de_alumnos;

Alumno alumno1 = new Alumno("Juan", 1); //, 6.7m, 8.2m);
//alumno1.Nombre = "Juan";
//alumno1.Legajo = 1;
//alumno1.Nota1 = 1.3m;
//alumno1.Nota2 = 8.5m;

//Alumno alumno2 = new Alumno();
// Error: Faltan datos. Ya no se puede usar new Alumno() vacío porque definimos un constructor que pide el nombre, legajo y notas.
Alumno alumno2 = new Alumno("Marcos", 2); //, 4.7m, 8.2m);
//alumno2.Nombre = "Marcos";
//alumno2.Legajo = 2;
//alumno2.Nota1 = 6.0m;
//alumno2.Nota2 = 7.0m;

//Etapa 5
bool seCargaron = alumno1.CargarNotas(6.7m, 8.2m);

if (seCargaron == false)
{
    Console.WriteLine("Error: Las notas ingresadas no son válidas.");
}

//Muestro en consola
Console.WriteLine($"El alumno {alumno1.Nombre} tiene el legajo: {alumno1.Legajo}");
Console.WriteLine($"El alumno {alumno2.Nombre} tiene el legajo: {alumno2.Legajo}");

//Cambio el nombre del primer alumno
alumno1.Nombre = "Juanca";
Console.WriteLine($"El nombre del alumno con el legajo {alumno1.Legajo}, fue cambiado a {alumno1.Nombre}");

Console.WriteLine($"El promedio de {alumno1.Nombre} es {alumno1.Promedio()}");

Console.WriteLine($" {alumno1.Nombre} esta {alumno1.EstasAprobado()}");

alumno1.SubirNota();

Console.WriteLine($"Le subimos la nota a el alumno {alumno1.Nombre} es {alumno1.Promedio()}");

//Etapa 4

Console.WriteLine(alumno1);