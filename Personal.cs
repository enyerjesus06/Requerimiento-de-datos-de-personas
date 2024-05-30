

namespace Requerimiento_de_datos_de_personas
{
    public class Personal
    {
        List<Personal> personas;
        #region"Constructor"
        public Personal()
        {
            this.personas = new List<Personal>();
        }
        #endregion
        #region "Atributos"


        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _Telefono;
        private string _email;


        #endregion

        #region "Propiedades"
        public string Codpersonal { get; set; }

        public string Nombre
        {

            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }

        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                if (string.IsNullOrEmpty(this._apellido))
                {
                    throw new Excepciones("El apellido es requerido.");
                }
                if (this._apellido.Length > 50)
                {
                    throw new Excepciones("El apellido debe ser menor a 50 carácteres. ");
                }
                _apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string NombreCompleto
        {
            get { return this._nombre + " " + this._apellido; }

        }
        public int Telefono
        {
            get; set;
        }

        #endregion

        #region"Metodos"
        public void Save(Personal personal)
        {
            bool result = false;
            try
            {
                this.personas.Add(personal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void update(Personal personal)
        {
            bool result = false;
            try
            {
                var personal11 = this.personas.FirstOrDefault(personal => personal.Codpersonal == personal.Codpersonal);
                if (personal11 is null)
                {
                    throw new Excepciones("La persona que intenta actualizar no se encuentra Registrada.");
                }
                personas.Remove(personal11);
                personas.Add(personal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void remove(Personal personal)
        {
            bool result = false;
            try
            {
                var personal11 = this.personas.FirstOrDefault(personal => personal.Codpersonal == personal.Codpersonal);
                if (personal11 is null)
                {
                    throw new Excepciones("La persona que intenta actualizar no se encuentra Registrada.");
                }
                this.personas.Remove(personal11);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Personal> getpersonas()
        {
            return this.personas;

        }
        public Personal getpersona(string Codpersonal)
        
        {
            return this.personas.FirstOrDefault(personal11 => personal11.Codpersonal == Codpersonal);
        }
        #endregion

    }
}
