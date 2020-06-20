using MySql.Data.MySqlClient;
using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Modelos
{

    class Calificaciones_Model
    {
        public int id;
        public int materia_id;
        public int estudiante_id;
        public string calificacion;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Materia_Id
        {
            get { return this.materia_id; }
            set { this.materia_id = value; }
        }

        public int Estudiante_Id
        {
            get { return this.estudiante_id; }
            set { this.estudiante_id = value; }
        }

        public string Calificacion
        {
            get { return this.calificacion; }
            set { this.calificacion = value; }
        }


        // guardar calificacion
        public void guardarCalificacion()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@materia_id", Materia_Id);
                cmd.Parameters.AddWithValue("@estudiante_id", Estudiante_Id);
                cmd.Parameters.AddWithValue("@calificacion", Calificacion);
                cmd.CommandText = "INSERT INTO calificaciones VALUES(NULL, @materia_id, @estudiante_id, @calificacion)";
                cmd.CommandType = CommandType.Text;

               var guardar = cmd.ExecuteNonQuery();

                if(guardar > 0)
                {
                    MessageBox.Show("Califacion guardada exitosamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        // mostrar las calificaciones de cada estudiante
        public DataTable mostrarCalificaciones()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@estudiante_id", Estudiante_Id);
                cmd.CommandText = "SELECT materias.nombre_materia, materias.fecha_inicio AS fecha, calificaciones.calificacion FROM calificaciones INNER JOIN materias ON materias.id = calificaciones.materia_id WHERE calificaciones.estudiante_id = @estudiante_id";
                cmd.CommandType = CommandType.Text;
               
                // ejecutar query
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    table.Load(leer);
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("No hay registros");
                }
            }

            return table;
        }
    }
}
