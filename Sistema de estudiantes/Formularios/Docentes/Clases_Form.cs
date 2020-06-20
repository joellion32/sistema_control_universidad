using Sistema_de_estudiantes.Clases;
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
    public partial class Clases_Form : Form
    {
        public Clases_Form()
        {
            InitializeComponent();
        }

        Clases_Model clases = new Clases_Model();

        private void Clases_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label8;
            cargarDatos();
        }

        // para cargar los datos al datagrid
        public void cargarDatos()
        {
            dataGridView1.DataSource = clases.Mostrar();
        }


        //para animar el texbox
        private void Validar(TextBox tbx, String validacion1, String validacion2)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
            }
        }

        private void tbxBuscar_Enter(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "MATERIA", "");
        }

        private void tbxBuscar_Leave(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "", "MATERIA");
        }

        // Ver detalle de cada materia
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                lbNombreClase.Text = dataGridView1.CurrentRow.Cells["nombre_materia"].Value.ToString();
                tbxMateria.Text = dataGridView1.CurrentRow.Cells["dia"].Value.ToString();
                tbxDocente.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                tbxCarrera.Text = dataGridView1.CurrentRow.Cells["carrera"].Value.ToString();
                tbxFechaI.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_inicio"].Value.ToString());
                tbxFechaT.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_termino"].Value.ToString());
                tbxHora.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["hora"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un campo por favor");
            }

        }

        // buscar clases
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (tbxBuscar.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                clases.Id = UsuarioCache.Idusuario;
                clases.Materia = tbxBuscar.Text;
                dataGridView1.DataSource = clases.BuscarMaterias();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
