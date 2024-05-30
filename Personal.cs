

namespace Requerimiento_de_datos_de_personas
{
    public class Personal
    {
        #region"Constructor"

        #endregion
        #region "Atributos"


        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _Telefono;
        private string _email;


        #endregion

        #region "Propiedades"
        public string Codpersonal {  get; set; }

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
        public bool Save(Personal personal)
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }
        #endregion

    }
}
