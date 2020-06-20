using Sistema_de_estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    public partial class Perfil_Estudiante_Form : Form
    {
        public Perfil_Estudiante_Form()
        {
            InitializeComponent();
        }

        private void Perfil_Estudiante_Form_Load(object sender, EventArgs e)
        {
            tbxNombre.Text = UsuarioCache.Nombreusuario;
            tbxApellido.Text = UsuarioCache.Apellidousuario;
            tbxMatricula.Text = UsuarioCache.Cedulausuario;
            tbxFecha_Nac.Value = UsuarioCache.Fecha_Nac;
            tbxFecha_ing.Value = UsuarioCache.Fecha_Ing;
            tbxCarrera.Text = UsuarioCache.Carrera;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes permiso para editar tu usuario \n por favor contacta al administrador");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes permiso para eliminar tu usuario \n por favor contacta al administrador");
        }
    }
}
