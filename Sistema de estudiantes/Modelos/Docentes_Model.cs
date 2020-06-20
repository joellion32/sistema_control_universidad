using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Modelos
{
    class Docentes_Model
    {
        public int id;
        public String nombre;
        public String apellido;
        public String cedula;
        public String password;
        public DateTime fecha_ingreso;
     

        // otras variables
        public bool result;
         



        public void constructor()
        {
            this.result = true;
        }

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

        public String Cedula
        {
            get { return this.cedula; }
            set { this.cedula = value; }
        }

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

     
        public DateTime Fecha_Ingreso
        {
            get { return this.fecha_ingreso; }
            set { this.fecha_ingreso = value; }
        }


        // login Docentes
        public void login()
        {
            String cedula = this.cedula;
            String password = this.password;
            btnAsistencias panel = new btnAsistencias();

            // comprobar si existe el usuario            
            using (MySqlConnection cn = ConexionDB.getMySqlConnection()) 
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandText = "SELECT * FROM docentes WHERE cedula = @cedula && password = @password";
                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();
              
                if(reader.HasRows)
                {
                    // guardar datos en memoria
                    while (reader.Read())
                    {
                        UsuarioCache.Idusuario = reader.GetInt32(0);
                        UsuarioCache.Nombreusuario = reader.GetString(1);
                        UsuarioCache.Apellidousuario = reader.GetString(2);
                        UsuarioCache.Cedulausuario = reader.GetString(3);
                        UsuarioCache.Fecha_Ing = reader.GetDateTime(5);
                    }

                        MessageBox.Show("Has iniciado sesion");
                        panel.Show();
                }
                else
                {
                    this.result = false;
                    MessageBox.Show("El usuario o  la contraseña son incorrectos");
                }

                cn.Close();
                 
            }

        } // cierre de la funcion

        // para agregar docentes a la BD
        public void agregarDocentes()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@cedula", Cedula);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@fecha_ing", Fecha_Ingreso);
                cmd.Parameters.AddWithValue("@status", "ACTIVO");
                cmd.CommandText = "INSERT INTO docentes VALUES(NULL, @nombre, @apellido, @cedula, @password, @fecha_ing, @status)";

                // ejecutar query
                cmd.CommandType = CommandType.Text;
                var docente = cmd.ExecuteNonQuery();

                if (docente > 0)
                {
                    MessageBox.Show("Docente registrado correctamente");
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }



        // mostrar todos los docentes
        public DataTable getDocentes() 
        {
            // variables
            DataTable tabla = new DataTable();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // ejecutar query
                cmd.CommandText = "SELECT id, nombre, apellido, cedula, fecha_ingreso FROM docentes WHERE status = 'ACTIVO'";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                // cargar datatable
                tabla.Load(leer);
                cn.Close();

                return tabla;
            }
        }



        // mostrar todos los docentes en lista
        public List<Docentes_Model> getDocentesList()
        {
            // variables
            List<Docentes_Model> lista = new List<Docentes_Model>();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // ejecutar query
                cmd.CommandText = "SELECT id, nombre FROM docentes WHERE status = 'ACTIVO'";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                // cargar datatable
                if (leer.HasRows)
                {
                    while (leer.Read()) 
                    {
                        Docentes_Model docente = new Docentes_Model();
                        docente.id = leer.GetInt32(0);
                        docente.nombre = leer.GetString(1);

                        lista.Add(docente);
                    
                    }

                    cn.Close();
                }

                return lista;
            }
        }

        // buscar docentes

        public DataTable buscarDocentes()
        {
            DataTable tabla = new DataTable();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                // ejecutar query
                cmd.CommandText = "SELECT nombre, apellido, cedula, fecha_ingreso FROM docentes WHERE nombre = @nombre";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    tabla.Load(leer);
                }
                else
                {
                    MessageBox.Show(Nombre +  " no encontrado");
                }

                // cargar datatable
                cn.Close();

                return tabla;
            }
        }


        // actualizar Docente
        public void actualizarDocente()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@cedula", Cedula);
                cmd.Parameters.AddWithValue("@fecha_ingreso", Fecha_Ingreso);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.CommandText = "UPDATE docentes SET nombre = @nombre, apellido = @apellido, cedula = @cedula, fecha_ingreso = @fecha_ingreso WHERE id = @id";
                cmd.CommandType = CommandType.Text;
                var actualizar = cmd.ExecuteNonQuery();

                if (actualizar > 0)
                {
                    MessageBox.Show("Docente Actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                cn.Close();
            }
        }


        // eliminar Estudiantes
        public void Eliminardocentes()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.CommandText = "UPDATE docentes SET status = 'DESPEDIDO' WHERE id = @id";
                cmd.CommandType = CommandType.Text;

                var eliminar = cmd.ExecuteNonQuery();

                if (eliminar > 0)
                {
                    MessageBox.Show("Docente eliminado correctamente");
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
