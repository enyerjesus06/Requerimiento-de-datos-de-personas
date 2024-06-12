
namespace Comunidad_Itla
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        #region Propiedades
        public string? EmailInstitucional {  get; set; }
        public int? Matricula { get; set; }
        public string? Carrera { get; set; }
        public int FechaInicio {  get; set; }
        public int CantCreditos { get; set; }

        #endregion
        #region Metodos
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");

            Console.WriteLine($"Matricula: {Matricula}");

            Console.WriteLine($"Fecha de Inicio: {FechaInicio}");

            Console.WriteLine($"Cantidad de Creditos: {CantCreditos}");

            Console.WriteLine($"Email Institucional: {EmailInstitucional}");

          
        }

        #endregion


    }
}
