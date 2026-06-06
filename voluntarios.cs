using System;

public class Voluntarios : Personas
{
    private int horasTrabajadas;

    public int HorasTrabajadas
    {
        get { return this.horasTrabajadas; }
        set { this.horasTrabajadas = value; }
    }

    public Voluntarios(string nombre, string dni, int horasTrabajadas)
        : base(nombre, dni)
    {
        HorasTrabajadas = horasTrabajadas;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("VOLUNTARIO: ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Horas trabajadas: {HorasTrabajadas}");
    }
}
