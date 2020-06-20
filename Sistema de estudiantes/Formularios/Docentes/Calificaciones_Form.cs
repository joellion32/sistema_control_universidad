using Sistema_de_estudiantes.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Formularios.Docentes
{
    public partial class Calificaciones_Form : Form
    {
        Estudiantes_Model estudiantes = new Estudiantes_Model();
        Clases_Model clases = new Clases_Model();
        Calificaciones_Model calificaciones = new Calificaciones_Model();

        public Calificaciones_Form()
        {
            InitializeComponent();
        }

        private void Calificaciones_Form_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarMaterias();
        }


        private void comboEstudiante_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(comboEstudiante.Text == "")
            {
                MessageBox.Show("Por favor introduce un nombre de estudiante");
            }

            if (comboMateria.Text == "")
            {
                MessageBox.Show("Por favor introduce una materia");
            }

            if(comboCalificacion.Text == "")
            {
                MessageBox.Show("Por favor introduce una calificacion");
            }
            else
            {
                calificaciones.estudiante_id = Convert.ToInt32(comboEstudiante.SelectedValue);
                calificaciones.materia_id = Convert.ToInt32(comboMateria.SelectedValue);
                calificaciones.calificacion = comboCalificacion.Text;
                calificaciones.guardarCalificacion();
            }

          

        }

        // funciones personalizadas
        public void CargarEstudiantes()
        {
            comboEstudiante.DataSource = estudiantes.getEstudiantes();
            comboEstudiante.DisplayMember = "Nombre";
            comboEstudiante.ValueMember = "Id";
        }

        public void CargarMaterias()
        {

            clases.Id = Convert.ToInt32(comboEstudiante.SelectedValue);
            comboMateria.DataSource = clases.getMateriasEstudiantes();
            comboMateria.DisplayMember = "Materia";
            comboMateria.ValueMember = "Id";

        }
    }
}
