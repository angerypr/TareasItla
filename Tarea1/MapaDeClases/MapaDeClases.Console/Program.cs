using System;

public class MiembroDeLaComunidad
{
    public string Nombre { get; set; } = string.Empty;
    public string ID { get; set; } = string.Empty;

    public virtual void DatosMiembro()
    {
        Console.WriteLine($"Nombre: {Nombre}, ID: {ID}");
    }
}

public class Empleado : MiembroDeLaComunidad
{
    public string Cargo { get; set; } = string.Empty;

    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Cargo: {Cargo}");
    }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; } = string.Empty;

    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Carrera: {Carrera}");
    }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public string AnoDeGraduacion { get; set; } = string.Empty;

    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Año de Graduación: {AnoDeGraduacion}");
    }
}

public class Docente : Empleado
{
    public string Materia { get; set; } = string.Empty;

    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Materia: {Materia}");
    }
}

public class Administrativo : Empleado
{
    public string Departamento { get; set; } = string.Empty;

    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

public class Administrador : Docente
{
    public string Area { get; set; } = string.Empty;
    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Área: {Area}");
    }
}

public class Maestro : Docente
{
    public string Aula { get; set; } = string.Empty;
    public override void DatosMiembro()
    {
        base.DatosMiembro();
        Console.WriteLine($"Aula: {Aula}");
    }
}

class Program
{
    public static void Main()
    {
        Estudiante estudiante = new Estudiante
        {
            Nombre = "Angery Payamps",
            ID = "0215",
            Carrera = "Desarrollo de Software"
        };
        estudiante.DatosMiembro();

        Maestro maestro = new Maestro
        {
            Nombre = "Starling Germosén",
            ID = "2093",
            Cargo = "Docente",
            Materia = "Programación 2",
            Aula = "Virtual"
        };

        maestro.DatosMiembro();

        ExAlumno exAlumno = new ExAlumno
        {
            Nombre = "Carla Cepeda",
            ID = "0234",
            AnoDeGraduacion = "2024"
        };

        exAlumno.DatosMiembro();
    }
}

