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

namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    public partial class Estudiantes_Form : Form
    {
        Estudiantes_Model estudiantes = new Estudiantes_Model();

        public Estudiantes_Form()
        {
            InitializeComponent();
        }

        private void Estudiantes_Form_Load(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }


        private void tbxBuscar_Enter(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "BUSCAR", "");
        }

        private void tbxBuscar_Leave(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "", "BUSCAR");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pintar datos en el panel
            if(dataGridView1.SelectedCells.Count > 0)
            {
                lbNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                tbxMatricula.Text = dataGridView1.CurrentRow.Cells["matricula"].Value.ToString();
                tbxCarrera.Text = dataGridView1.CurrentRow.Cells["carrera"].Value.ToString();
                dateFecha_N.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_nac"].Value);
                dateFecha_I.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_ing"].Value);

            }
        }
        // buscar estudiantes
        private void button1_Click(object sender, EventArgs e)
        {
            estudiantes.Nombre = tbxBuscar.Text;
            dataGridView1.DataSource = estudiantes.buscarEstudiantes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }


        // funciones 
        private void Validar(TextBox tbx, String validacion1, String validacion2)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
            }
        }

        private void cargarEstudiantes()
        {
            dataGridView1.DataSource = estudiantes.getEstudiantesall();
        }

       
    }
}
