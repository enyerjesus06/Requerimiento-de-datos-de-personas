
namespace Comunidad_Itla
{
    public abstract class MiembroDeLaComunidad
    {
        // Propiedades comunes
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        // Método común
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");

            
        }
    }
}