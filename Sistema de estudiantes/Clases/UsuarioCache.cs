using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estudiantes.Clases
{
    public static class UsuarioCache
    {
        public static int Idusuario { get; set; }
        public static string Nombreusuario { get; set; }
        public static string Apellidousuario { get; set; }
        public static string Cedulausuario { get; set; }

        public static string Carrera { get; set; }

        public static string CarreraId { get; set; }
        public static DateTime Fecha_Nac { get; set; }

        public static DateTime Fecha_Ing { get; set; }

    }
}
