using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Sistema_de_estudiantes.Clases;
using MySqlX.XDevAPI;


namespace Sistema_de_estudiantes.Modelos
{
    class Estudiantes_Model
    {
        public int id;
        public String nombre;
        public String apellido;
        public String matricula;
        public String password;
        public int carrera_id;
        public DateTime fecha_nac;
        public DateTime fecha_ingreso;
   

        // getters y setters
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public String Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int Carrera_Id
        {
            get { return this.carrera_id; }
            set { this.carrera_id = value; }
        }

        public DateTime Fecha_Nac
        {
            get { return this.fecha_nac; }
            set { this.fecha_nac = value; }
        }

        public DateTime Fecha_Ingreso
        {
            get { return this.fecha_ingreso; }
            set { this.fecha_ingreso = value; }
        }

   


        // funciones
        public Object login()
        {
            string matricula = this.matricula;
            string password = this.password;

            
            // comprobar si existe el usuario            
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandText = "SELECT estudiantes.id, estudiantes.nombre, estudiantes.apellido, estudiantes.matricula, estudiantes.fecha_nac, estudiantes.fecha_ing, estudiantes.carrera_id, carreras.nombre_carrera AS carrera FROM estudiantes INNER JOIN carreras ON carreras.id = estudiantes.carrera_id WHERE estudiantes.matricula = @matricula && estudiantes.password = @password";
                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // guardar datos en memoria
                    while (reader.Read())
                    {
                        UsuarioCache.Idusuario = reader.GetInt32(0);
                        UsuarioCache.Nombreusuario = reader.GetString(1);
                        UsuarioCache.Apellidousuario = reader.GetString(2);
                        UsuarioCache.Cedulausuario = reader.GetString(3);
                        UsuarioCache.Fecha_Nac = reader.GetDateTime(4);
                        UsuarioCache.Fecha_Ing = reader.GetDateTime(5);
                        UsuarioCache.CarreraId = reader.GetString(6);
                        UsuarioCache.Carrera = reader.GetString(7);
                    }

                    MessageBox.Show("Has iniciado sesion");
                    PanelEstudiante panel = new PanelEstudiante();
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o  la contraseña son incorrectos");
                }

                return reader;
            }
        }

        // Mostrar Estudiantes select 

        public List<Estudiantes_Model> getEstudiantes()
        {
            MySqlDataReader leer;
            List<Estudiantes_Model> lista = new List<Estudiantes_Model>();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT id, nombre, apellido FROM estudiantes";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Estudiantes_Model estudiante = new Estudiantes_Model();
                        estudiante.Id = leer.GetInt32(0);
                        estudiante.Nombre = leer.GetString(1);
                        estudiante.Apellido = leer.GetString(2);

                        // agregar a la lista
                        lista.Add(estudiante);
                    }

                    cn.Close();
                }
            }

            return lista;
        }


        // Mostrar Estudiantes datagrid 

        public DataTable getEstudiantesall()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT estudiantes.id, estudiantes.nombre, estudiantes.apellido, estudiantes.matricula, estudiantes.fecha_nac, estudiantes.fecha_ing, carreras.nombre_carrera AS carrera FROM estudiantes INNER JOIN carreras ON carreras.id = estudiantes.carrera_id";
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


        // buscar estudiantes

        public DataTable buscarEstudiantes()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.CommandText = "SELECT estudiantes.nombre, estudiantes.apellido, estudiantes.matricula, estudiantes.fecha_nac, estudiantes.fecha_ing, carreras.nombre_carrera AS carrera FROM estudiantes INNER JOIN carreras ON carreras.id = estudiantes.carrera_id WHERE estudiantes.nombre = @nombre";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    table.Load(leer);

                    cn.Close();
                }
                else
                {
                    MessageBox.Show("No hay resultados");
                }
            }

            return table;
        }


        // mostrar las materias del cada estudiante 
        public DataTable mostrarMaterias()
        {
            MySqlDataReader leer;
            DataTable table = new DataTable();

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@id_estudiante", UsuarioCache.Idusuario);
                cmd.CommandText = "SELECT materias.nombre_materia, materias.docente_id, materias.dia, materias.fecha_inicio, materias.fecha_termino, materias.hora, docentes.nombre, docentes.apellido FROM clases INNER JOIN materias ON materias.id = clases.id_materia INNER JOIN docentes ON docentes.id = materias.docente_id WHERE clases.id_estudiante = @id_estudiante";
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

        // guardar Estudiantes 
        public void guardarEstudiantes()
        {
            

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@matricula", Matricula);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@carrera_id", Carrera_Id);
                cmd.Parameters.AddWithValue("@fecha_nac", Fecha_Nac);
                cmd.Parameters.AddWithValue("@fecha_ing", Fecha_Ingreso);
                cmd.CommandText = "INSERT INTO estudiantes VALUES(NULL, @nombre, @apellido, @matricula, @password, @carrera_id, @fecha_nac, @fecha_ing)";

                // ejecutar query
                cmd.CommandType = CommandType.Text;
                var estudiante = cmd.ExecuteNonQuery();

                if(estudiante > 0)
                {
                    MessageBox.Show("Estudiante registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        // actualizar estudiantes
        public void actualizarEstudiantes()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@carrera_id", Carrera_Id);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.CommandText = "UPDATE estudiantes SET nombre = @nombre, apellido = @apellido, carrera_id = @carrera_id WHERE id = @id";

                // ejecutar query
                cmd.CommandType = CommandType.Text;
                var estudiante = cmd.ExecuteNonQuery();

                if (estudiante > 0)
                {
                    MessageBox.Show("Estudiante actualizado correctamente");
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }


        // eliminar Estudiantes
        public void Eliminarestudiantes()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandText = "DELETE FROM estudiantes WHERE id = @id";
                cmd.CommandType = CommandType.Text;

                var eliminar = cmd.ExecuteNonQuery();

                if(eliminar > 0)
                {
                    MessageBox.Show("Estudiante eliminado correctamente");
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
