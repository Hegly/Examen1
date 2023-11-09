using System;
namespace Examen
{
    class Promedio : IPromedioInterfaz
    {
        private readonly double nota1;
        private readonly double nota2;
        private readonly double nota3;

        public Promedio(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public string MostrarPromedio(double nota1, double nota2, double nota3)
        {
            return $"Promedio utilizando el método calcularPromedio con parámetros: {CalcularPromedio(nota1, nota2, nota3)}";
        }

        public string MostrarPromedio()
        {
            return $"Promedio utilizando el método calcularPromedio sin parámetros: {CalcularPromedio()}";
        }

        public double CalcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3.0;
        }

        public double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3.0;
        }
    }
}
