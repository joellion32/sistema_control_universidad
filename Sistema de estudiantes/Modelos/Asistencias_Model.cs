using MySql.Data.MySqlClient;
using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Modelos
{
    class Asistencias_Model
    {
        public int id;
        public string dia;
        public int id_estudiante;
        public DateTime fecha;
        public string asistencia;


        // getters y setters
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public string Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        public int Id_Estudiante
        {
            get { return this.id_estudiante; }
            set { this.id_estudiante = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public string Asistencia
        {
            get { return this.asistencia; }
            set { this.asistencia = value; }
        }

        // Mostrar Asistencias
        public DataTable getAsistencias()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandText = "SELECT asistencias.dia, asistencias.fecha, asistencias.asistencia, estudiantes.nombre FROM asistencias INNER JOIN estudiantes ON estudiantes.id = asistencias.id_estudiante WHERE id_estudiante = @id";
                cmd.CommandType = CommandType.Text;
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

        // Guardar Asistencias
        public void guardarAsistencias()
        {

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@dia", Dia);
                cmd.Parameters.AddWithValue("@id_estudiante", Id_Estudiante);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@asistencia", Asistencia);
                cmd.CommandText = "INSERT INTO asistencias VALUES(NULL, @dia, @id_estudiante, @fecha, @asistencia)";
                cmd.CommandType = CommandType.Text;
                var save = cmd.ExecuteNonQuery();

                if(save > 0)
                {
                    MessageBox.Show("Asistencia asignada correctamente");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
