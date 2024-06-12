namespace Comunidad_Itla
{


    public class Program
    {
        public static void Main()
        {
            List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>
        {
            new Estudiante { Nombre = "Juan", Edad = 18, Carrera = "Software", Matricula = 20240199 , EmailInstitucional = "20240199@itla.edu.do" , CantCreditos = 150 , FechaInicio = 2024  },
            new Docente { Nombre = "María", Edad = 45, Departamento = "Matemáticas", Asignatura = "Cálculo Diferencial", ID =150439  },
            new Administrativo { Nombre = "Luis", Edad = 35, Departamento = "Recursos Humanos", Puesto = "Gerente", ID =160711 },
            new Administrador { Nombre = "Ana", Edad = 50, Departamento = "Administración", Asignatura = "Gestión", AreaAdministrativa = "Finanzas", ID = 771123 },
            new ExAlumno { Nombre = "Carlos", Edad = 22, AñoGraduacion = "2023", Carrera = "Cibersecurity" }
        };

            for (var i = 0; i < miembros.Count; i++)
            {
                MiembroDeLaComunidad? miembro = miembros[i];
                miembro.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }

}