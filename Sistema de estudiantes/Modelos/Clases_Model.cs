using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Modelos
{
    class Clases_Model
    {
        public int id;
        public String materia;
        public int id_materia;
        public int id_docente;
        public int id_estudiate;
        public MySqlConnection db;

        public void contructor()
        {
            this.db = ConexionDB.getMySqlConnection();
        }

        // getters y setters

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        public int Id_Materia
        {
            get { return this.id_materia; }
            set { this.id_materia = value; }
        }

        public int Id_Docente
        {
            get { return this.id_docente; }
            set { this.id_docente = value; }
        }

        public int Id_Estudiante
        {
            get { return this.id_estudiate; }
            set { this.id_estudiate = value; }
        }

        // mostrar todas las clases
        public DataTable Mostrar()
        {
            DataTable table = new DataTable();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@id", UsuarioCache.Idusuario);

                // ejecutar query
                cmd.CommandText = "SELECT materias.nombre_materia, materias.dia, materias.fecha_inicio, materias.fecha_termino, materias.hora, docentes.nombre, docentes.apellido, carreras.nombre_carrera AS carrera FROM materias INNER JOIN docentes ON docentes.id = materias.docente_id INNER JOIN carreras ON carreras.id = materias.id_carrera WHERE materias.docente_id = @id";
                cmd.CommandType = CommandType.Text;

                // leer query
                leer = cmd.ExecuteReader();

                // cargar datatable
                table.Load(leer);
                cn.Close();

                return table;
            }
        }


        // buscar materias
        public DataTable BuscarMaterias()
        {
            DataTable table = new DataTable();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@materia", Materia);
                cmd.Parameters.AddWithValue("id", Id);
                cmd.CommandText = "SELECT materias.nombre_materia, materias.dia, materias.fecha_inicio, materias.fecha_termino, materias.hora, docentes.nombre, docentes.apellido, carreras.nombre_carrera AS carrera FROM materias INNER JOIN docentes ON docentes.id = materias.docente_id INNER JOIN carreras ON carreras.id = materias.id_carrera WHERE materias.docente_id = @id && materias.nombre_materia = @materia";
                cmd.CommandType = CommandType.Text;

                // leer query
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    //cargar tabla con los datos
                    table.Load(leer);
                    cn.Close();
                }else
                {
                    MessageBox.Show("No hay registros");
                }

                

                return table;
            }


        }

        // mostrar materias por estudiante
        public List<Clases_Model> getMateriasEstudiantes()
        {
            List<Clases_Model> lista = new List<Clases_Model>();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandText = "SELECT materias.id, materias.nombre_materia FROM clases INNER JOIN materias ON materias.id = clases.id_materia WHERE id_estudiante = @id";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Clases_Model clases = new Clases_Model();
                        clases.Id = leer.GetInt32(0);
                        clases.Materia = leer.GetString(1);

                        lista.Add(clases);
                    }
                }

            }
            return lista;
        }


        // guardar clases
        public void guardarClase()
        {

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@id_materia", Id_Materia);
                cmd.Parameters.AddWithValue("@id_estudiante", Id_Estudiante);
                cmd.CommandText = "INSERT INTO clases VALUES(NULL, @id_materia, @id_estudiante)";
                cmd.CommandType = CommandType.Text;
                var save = cmd.ExecuteNonQuery();

                if(save > 0)
                {
                    MessageBox.Show("Clase guardada correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
