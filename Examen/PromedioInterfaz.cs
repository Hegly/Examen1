namespace Examen
{
    interface IPromedioInterfaz
    {
        string MostrarPromedio();
        string MostrarPromedio(double nota1, double nota2, double nota3);
        double CalcularPromedio();
        double CalcularPromedio(double nota1, double nota2, double nota3);
    }

}