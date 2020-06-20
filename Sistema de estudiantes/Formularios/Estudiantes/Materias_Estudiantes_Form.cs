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

namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    public partial class Materias_Estudiantes_Form : Form
    {
        Estudiantes_Model estudiantes = new Estudiantes_Model();
        Materias_Model materias = new Materias_Model();

        public Materias_Estudiantes_Form()
        {
            InitializeComponent();
        }

        private void Materias_Estudiantes_Load(object sender, EventArgs e)
        {
            lbNombre.Text = UsuarioCache.Nombreusuario + "" + UsuarioCache.Apellidousuario;
            cargarData();
        }


        private void cargarData()
        {
            dataGridView1.DataSource = estudiantes.mostrarMaterias();
        }

        // validar texbox
        private void Validar(TextBox tbx, String validacion1, String validacion2)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
            }
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
            if(dataGridView1.SelectedCells.Count > 0)
            {
                tbxMateria.Text = dataGridView1.CurrentRow.Cells["nombre_materia"].Value.ToString();
                tbxDocente.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                tbxDia.Text = dataGridView1.CurrentRow.Cells["dia"].Value.ToString() + " / " + dataGridView1.CurrentRow.Cells["hora"].Value.ToString();
                dateFecha_I.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_inicio"].Value.ToString());
                dateFecha_T.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_termino"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un campo por favor");
            }
        }

        // buscar materias
        private void button1_Click(object sender, EventArgs e)
        {
            materias.Materia = tbxBuscar.Text;
            dataGridView1.DataSource = materias.buscarMaterias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarData();
        }
    } // cierre clase
}
