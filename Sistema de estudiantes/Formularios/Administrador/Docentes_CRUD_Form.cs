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

namespace Sistema_de_estudiantes.Formularios.Administrador
{
    public partial class Docentes_CRUD_Form : Form
    {
        Docentes_Model docentes = new Docentes_Model();
        public Docentes_CRUD_Form()
        {
            InitializeComponent();
        }

        private void Docentes_CRUD_Form_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            datagridview.DataSource = docentes.getDocentes();
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

            if (datagridview.SelectedCells.Count > 0)
            {
                tbxId.Text = datagridview.CurrentRow.Cells["id"].Value.ToString();
                tbxNombre.Text = datagridview.CurrentRow.Cells["nombre"].Value.ToString();
                tbxApellido.Text = datagridview.CurrentRow.Cells["apellido"].Value.ToString();
                tbxCedula.Text = datagridview.CurrentRow.Cells["cedula"].Value.ToString();

          
                dateFecha_I.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["fecha_ingreso"].Value);

                btnGuardar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text == "" && tbxApellido.Text == "" && tbxCedula.Text == "")
            {
                MessageBox.Show("Los campos estan vacios");
            }
            else
            {
                docentes.Nombre = tbxNombre.Text;
                docentes.Apellido = tbxApellido.Text;
                docentes.Cedula = tbxCedula.Text;
                docentes.password = tbxCedula.Text;
                docentes.Fecha_Ingreso = dateFecha_I.Value;


                docentes.agregarDocentes();
                cargarData();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(tbxId.Text == "")
            {
                MessageBox.Show("Seleccione un campo por favor");
            }
            else
            {
                docentes.Id = Convert.ToInt32(tbxId.Text);
                docentes.Nombre = tbxNombre.Text;
                docentes.Apellido = tbxApellido.Text;
                docentes.Cedula = tbxCedula.Text;
                docentes.Fecha_Ingreso = dateFecha_I.Value;

                docentes.actualizarDocente();
                cargarData();
            }

           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tbxId.Text == "")
            {
                MessageBox.Show("Seleccione un campo por favor");
            }
            else
            {
                docentes.Id = Convert.ToInt32(tbxId.Text);
                docentes.Eliminardocentes();

                cargarData();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxId.Text = "";
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxCedula.Text = "";

            btnGuardar.Enabled = true;
        }
    }
}
