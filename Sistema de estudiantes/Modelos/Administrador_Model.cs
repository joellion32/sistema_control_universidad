using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Sistema_de_estudiantes.Clases;

namespace Sistema_de_estudiantes.Modelos
{
    class Administrador_Model
    {
        public String nombre;
        public String password;
        public MySqlConnection db;

        public void constructor()
        {
            this.db = ConexionDB.getMySqlConnection();
        }


        // getters y setters 

        public String Nombre
        {
            get { return nombre; }
            set { this.nombre = value;}
        }

        public String Password
        {
            get { return password; }
            set { this.password = value; }
        }


        // login 
        public Object login()
        {
            String nombre = this.nombre;
            String password = this.password;

            // comprobar si existe el usuario            
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandText = "SELECT * FROM administradores WHERE usuario = @nombre && password = @password";
                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Has iniciado sesion");
                    PanelAdministrador panel = new PanelAdministrador();
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o  la contraseña son incorrectos");
                }

                return reader;
            }
        }

    }
}
