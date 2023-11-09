using System;
namespace Examen
{
    internal abstract class Alumno
    {
        public string? Nombre { get; set; }
        public int NumeroCuenta { get; set; }
        public string? Email { get; set; }

        // Métod
        public abstract void MostrarAlumno();
    }
}

