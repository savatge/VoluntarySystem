using System;
using System.Collections.Generic;

class VoluntarySystem
{
    static void Main()
    {
        Console.WriteLine("BIENVENIDO AL SISTEMA DE VOLUNTARIADO.");

        List<Personas> personas = new List<Personas>();
        personas.Add(new Voluntarios("Ana Perez", "12345678", 120));
        personas.Add(new Coordinadores("Luis Gomez", "87654321", "Educación", 5));

        Console.WriteLine();
        foreach (var p in personas)
        {
            p.MostrarInformacion();
            Console.WriteLine();
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}

public class Coordinadores : Personas
{
    public string AreasAsignadas { get; set; }
    public int CantidadPersonasACargo { get; set; }

    public Coordinadores(string nombre, string dni, string areasAsignadas, int cantidadPersonasACargo)
        : base(nombre, dni)
    {
        AreasAsignadas = areasAsignadas;
        CantidadPersonasACargo = cantidadPersonasACargo;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("COORDINADOR: ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Áreas asignadas: {AreasAsignadas}");
        Console.WriteLine($"Cantidad de personas a cargo: {CantidadPersonasACargo}");
    }
}