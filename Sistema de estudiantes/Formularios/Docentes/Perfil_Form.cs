using Sistema_de_estudiantes.Clases;
using Sistema_de_estudiantes.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Formularios
{
    public partial class Perfil_Form : Form
    {
        Docentes_Model docente = new Docentes_Model();

        public Perfil_Form()
        {
            InitializeComponent();
        }

        private void Perfil_Form_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos() 
        {
            tbxNombre.Text = UsuarioCache.Nombreusuario;
            tbxApellido.Text = UsuarioCache.Apellidousuario;
            tbxCedula.Text = UsuarioCache.Cedulausuario;
            tbxFecha_ing.Value = UsuarioCache.Fecha_Ing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxNombre.Enabled = false;
            tbxApellido.Enabled = false;
            tbxCedula.Enabled = false; 
            tbxFecha_ing.Enabled = false;
            btnGuardar.Enabled = false;

            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No puede eliminar su usuario por favor contacte al administrador");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            docente.Id = UsuarioCache.Idusuario;   
            docente.Nombre = tbxNombre.Text;
            docente.Apellido = tbxApellido.Text;
            docente.Cedula = tbxCedula.Text;
            docente.fecha_ingreso = tbxFecha_ing.Value;

            docente.actualizarDocente();

            if (MessageBox.Show("Para poder aplicar los cambios debe cerrar sesion e iniciar de nuevo", "cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
               
            }
            else
            {
                MessageBox.Show("Cancelado (No se aplicaran los cambios)");
            }
        }
    }
}
