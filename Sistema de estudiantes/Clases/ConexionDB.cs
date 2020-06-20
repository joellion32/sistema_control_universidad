using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_estudiantes.Clases
{
    class ConexionDB
    {

        // variables globales


        public static MySqlConnection getMySqlConnection()
        {
            try
            {
                String conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=sistema_colegio;UID=root;PASSWORDS=;";
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ha ocurrido un error al conectar", ex);
            }
        }

    }
}
