using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    public interface IExportable
    {
        string ExportarLinea();

        // Experimento Etapa 9: Al agregar ExportarEncabezado() a la interfaz, aparecen 3 errores de compilación (CS0535).
        // El mensaje dice que 'Alumno', 'Profesor' y 'Materia' no implementan el miembro de interfaz 'IExportable.ExportarEncabezado()'.
        //string ExportarEncabezado();

    }
}
