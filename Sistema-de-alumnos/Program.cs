//Creo los alumnos
using Sistema_de_alumnos;

Alumno alumno1 = new Alumno();
alumno1.nombre = "Juan";
alumno1.legajo = 1;
alumno1.nota1 = 1.3m;
alumno1.nota2 = 8.5m;

Alumno alumno2 = new Alumno();
alumno2.nombre = "Marcos";
alumno2.legajo = 2;
alumno2.nota1 = 6.0m;
alumno2.nota2 = 7.0m;

//Muestro en consola
Console.WriteLine($"El alumno {alumno1.nombre} tiene el legajo: {alumno1.legajo}");
Console.WriteLine($"El alumno {alumno2.nombre} tiene el legajo: {alumno2.legajo}");

//Cambio el nombre del primer alumno
alumno1.nombre = "Juanca";
Console.WriteLine($"El nombre del alumno con el legajo {alumno1.legajo}, fue cambiado a {alumno1.nombre}");