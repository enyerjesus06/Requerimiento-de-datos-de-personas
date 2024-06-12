

namespace Comunidad_Itla
{
    public class Empleado : MiembroDeLaComunidad
    {
        public int? ID { get; set; }

        public string? Departamento { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");

            Console.WriteLine($"ID: {ID}");
        }

    }

    public class Docente : Empleado
    {
        public string? Asignatura { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Asignatura: {Asignatura}");
        }
    }

    public class Administrativo : Empleado
    {
        public string? Puesto { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }

    public class Administrador : Docente
    {
        public string? AreaAdministrativa { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
        }
    }

    public class Maestro : Docente
    {
        public string? GradoAcademico { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Grado Académico: {GradoAcademico}");
        }
    }
}
