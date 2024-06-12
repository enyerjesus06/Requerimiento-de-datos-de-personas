

namespace Comunidad_Itla
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public string? AñoGraduacion { get; set; }

        public string? Carrera { get; set; }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
            Console.WriteLine($"Carrera Cursada: {Carrera}");
        }
    }
}
