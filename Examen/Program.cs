using Examen;

    try
    {
        // Clase
        Clases claseObj = new()
        {
            NombreClase = "Programación II",
            HoraClase = "18:00 - 19:30",
            NombreCatedratico = "Ing. Roger Iván Gurdian",
            Nombre = "Hegly Beatriz Barahona Torres",
            NumeroCuenta = 32321219,
            Email = "heglyb@ceutec.edu"
        };

        claseObj.MostrarClase();
        claseObj.MostrarAlumno();

    // Para calcular el promedio
        Console.WriteLine("Ingrese la primera nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        
        Promedio promedioObj = new(nota1, nota2, nota3);

        Console.WriteLine(promedioObj.MostrarPromedio(nota1, nota2, nota3));
        Console.WriteLine(promedioObj.MostrarPromedio());
}
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }