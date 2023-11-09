using System;
namespace Examen
{
    internal class Clases : Alumno
    {
        public string? NombreClase { get; set; }
        public string? HoraClase { get; set; }
        public string? NombreCatedratico { get; set; }

        // Métod para clase
        public void MostrarClase()
        {
            Console.WriteLine($"Nombre de la Clase: {NombreClase}");
            Console.WriteLine($"Horario: {HoraClase}");
            Console.WriteLine($"Catedrático: {NombreCatedratico}");
        }

        // Métod para alumno
        public override void MostrarAlumno()
        {
            Console.WriteLine($"Nombre del Alumno: {Nombre}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electrónico: {Email}");
        }
    }
}
