using Sistema_de_estudiantes.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Formularios.Docentes
{
    public partial class Asistencias_Form : Form
    {
        Estudiantes_Model estudiantes = new Estudiantes_Model();
        Asistencias_Model asistencias = new Asistencias_Model();
        public Asistencias_Form()
        {
            InitializeComponent();
        }

        private void Asistencias_Form_Load(object sender, EventArgs e)
        {
            cargarEstudiantes();
            cargarAsistencias();
        }


        private void comboEstudiantes_SelectedValueChanged(object sender, EventArgs e)
        {
            asistencias.Id = Convert.ToInt32(comboEstudiantes.SelectedValue);
            dataGridView1.DataSource = asistencias.getAsistencias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ( comboDias.Text == "" || comboAsistencia.Text == "")
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
            else
            {
                asistencias.Dia = comboDias.Text;
                asistencias.Id_Estudiante = Convert.ToInt32(comboEstudiante2.SelectedValue);
                asistencias.Fecha = dateFecha.Value;
                asistencias.Asistencia = comboAsistencia.Text;

                // guardar en DB
                asistencias.guardarAsistencias();

                // cargar dataGrid 
                cargarAsistencias();
            }
        }


        // funciones personalizadas
        public void cargarEstudiantes()
        {
            // combobox 1
            comboEstudiantes.DataSource = estudiantes.getEstudiantes();
            comboEstudiantes.DisplayMember = "Nombre";
            comboEstudiantes.ValueMember = "Id";

            // combobox 2
            comboEstudiante2.DataSource = estudiantes.getEstudiantes();
            comboEstudiante2.DisplayMember = "Nombre";
            comboEstudiante2.ValueMember = "Id";

        }


        public void cargarAsistencias()
        {
            asistencias.Id = Convert.ToInt32(comboEstudiantes.SelectedValue);
            dataGridView1.DataSource = asistencias.getAsistencias();
        }
    }
}
