using MySql.Data.MySqlClient;
using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Modelos
{
    class Materias_Model
    {
        public int id;
        public String nombre_materia;
        public int docente_id;
        public int id_carrera;
        public string dia;
        public DateTime fecha_inicio;
        public DateTime fecha_termino;
        public DateTime hora;


        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Materia
        {
            get { return this.nombre_materia; }
            set { this.nombre_materia = value; }
        }


        public int IdCarrera
        {
            get { return this.id_carrera; }
            set { this.id_carrera = value; }
        }


        public int DocenteId
        {
            get { return this.docente_id; }
            set { this.docente_id = value; }
        }

        public string Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        public DateTime Fecha_Inicio
        {
            get { return this.fecha_inicio; }
            set { this.fecha_inicio = value; }
        }

        public DateTime Fecha_Termino
        {
            get { return this.fecha_termino; }
            set { this.fecha_termino = value; }
        }

        public DateTime Hora
        {
            get { return this.hora; }
            set { this.hora = value; }
        }



        // obtener todas las materias para lista
        public List<Materias_Model> getMaterias()
        {
            List<Materias_Model> lista = new List<Materias_Model>();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@carrera_id", UsuarioCache.CarreraId);
                cmd.CommandText = "SELECT id, nombre_materia, dia, fecha_inicio FROM materias WHERE id_carrera = @carrera_id";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Materias_Model materias = new Materias_Model();
                        materias.Id = leer.GetInt32(0);
                        materias.Materia = leer.GetString(1);
                        materias.Dia = leer.GetString(2);
                        materias.Fecha_Inicio = leer.GetDateTime(3);

                        lista.Add(materias);
                    }
                }

            }
            return lista;
        }


        // obtener todas las materias para datatable
        public DataTable getMateriasall()
        {
            DataTable table = new DataTable();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "SELECT materias.*, docentes.nombre AS docente, carreras.nombre_carrera AS carrera FROM materias INNER JOIN docentes ON docentes.id = materias.docente_id INNER JOIN carreras ON carreras.id = materias.id_carrera";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    table.Load(leer);
                    cn.Close();
                }

            }
            return table;
        }


        // buscar materias 
        public DataTable buscarMaterias()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@id_estudiante", UsuarioCache.Idusuario);
                cmd.Parameters.AddWithValue("@materia", Materia);
                cmd.CommandText = "SELECT materias.nombre_materia, materias.dia, materias.docente_id, materias.fecha_inicio, materias.fecha_termino, materias.hora, docentes.nombre, docentes.apellido FROM clases INNER JOIN materias ON materias.id = clases.id_materia INNER JOIN docentes ON docentes.id = materias.docente_id WHERE clases.id_estudiante = @id_estudiante && materias.nombre_materia = @materia";
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


        // guardar Materias
        public void guardarMaterias()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                //crear query
                cmd.Parameters.AddWithValue("@materia", Materia);
                cmd.Parameters.AddWithValue("@id_carrera", IdCarrera);
                cmd.Parameters.AddWithValue("@docente_id", DocenteId);
                cmd.Parameters.AddWithValue("@dia", Dia);
                cmd.Parameters.AddWithValue("@fecha_inicio", Fecha_Inicio);
                cmd.Parameters.AddWithValue("@fecha_termino", Fecha_Termino);
                cmd.Parameters.AddWithValue("@hora", Hora);
                
                // crear query
                cmd.CommandText = "INSERT INTO materias VALUES(NULL, @materia, @id_carrera, @docente_id, @dia, @fecha_inicio, @fecha_termino, @hora)";
                cmd.CommandType = CommandType.Text;

                var registrar = cmd.ExecuteNonQuery();

                if(registrar > 0)
                {
                    MessageBox.Show("Materia registrada exitosamente");
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar materias");
                }

            }
        }


        // actualizar materias
        public void actualizarMaterias()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@materia", Materia);
                cmd.Parameters.AddWithValue("@id_carrera", IdCarrera);
                cmd.Parameters.AddWithValue("@docente_id", DocenteId);
                cmd.Parameters.AddWithValue("@dia", Dia);
                cmd.Parameters.AddWithValue("@fecha_inicio", Fecha_Inicio);
                cmd.Parameters.AddWithValue("@fecha_termino", Fecha_Termino);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.CommandText = "UPDATE materias SET nombre_materia = @materia, id_carrera = @id_carrera, docente_id = @docente_id, dia = @dia, fecha_inicio = @fecha_inicio, fecha_termino = @fecha_termino, hora = @hora WHERE id = @id";
                cmd.CommandType = CommandType.Text;

                // ejecutar query
                var actualizar = cmd.ExecuteNonQuery();

                if(actualizar > 0)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }


    } // cierre de la clase
}

