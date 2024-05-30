

namespace Requerimiento_de_datos_de_personas
{
    public class Excepciones : Exception
    {
        public Excepciones(string message) : base(message)
        {
            this.Guardarlog(message);
            this.Enviarnotificacion(message);
        }
        private void Guardarlog(string message) { }
        private void Enviarnotificacion(string message) { }

    }


}

