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
    class Carreras_Model
    {
        public int id;
        public string nombre_carrera;


        // getters y setters 
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public string Nombre_Carrera
        {
            get { return this.nombre_carrera; }
            set { this.nombre_carrera = value; }
        }


        // get carreras en lista
        public List<Carreras_Model> getCarrerasList()
        {
            List<Carreras_Model> lista = new List<Carreras_Model>();
            MySqlDataReader leer;

            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                // crear query
                cmd.CommandText = "SELECT * FROM carreras";
                cmd.CommandType = CommandType.Text;
                leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        Carreras_Model carrera = new Carreras_Model();
                        carrera.Id = leer.GetInt32(0);
                        carrera.Nombre_Carrera = leer.GetString(1);

                        lista.Add(carrera);
                    }

                    cn.Close();
                }

            }

            return lista;
        }


        // agregar Carrera
        public void agregarCarrera()
        {
            using (MySqlConnection cn = ConexionDB.getMySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;


                cmd.Parameters.AddWithValue("@nombre_carrera", Nombre_Carrera);
                cmd.CommandText = "INSERT INTO carreras VALUES(NULL, @nombre_carrera)";
                cmd.CommandType = CommandType.Text;

                // ejecutar query
                var agregar = cmd.ExecuteNonQuery();

                if(agregar > 0)
                {
                    MessageBox.Show("Carrera Agregada correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
