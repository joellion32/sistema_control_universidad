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
    public partial class Estudiantes_CRUD_Form : Form
    {
        Estudiantes_Model estudiantes = new Estudiantes_Model();
        Carreras_Model carreras = new Carreras_Model();
        public Estudiantes_CRUD_Form()
        {
            InitializeComponent();
        }

        private void Estudiantes_CRUD_Form_Load(object sender, EventArgs e)
        {
            cargarData();
        }


        // cargar la data en el data GRID
        public void cargarData()
        {
            datagridview.DataSource = estudiantes.getEstudiantesall();
            tbxCarrera.DataSource = carreras.getCarrerasList();
            tbxCarrera.DisplayMember = "Nombre_Carrera";
            tbxCarrera.ValueMember = "Id";
        }

        // registrar estudiantes
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tbxNombre.Text == "" && tbxApellido.Text == "" && tbxMatricula.Text == "")
            {
                MessageBox.Show("Los campos estan vacios");
            }
            else
            {
                estudiantes.Nombre = tbxNombre.Text;
                estudiantes.Apellido = tbxApellido.Text;
                estudiantes.Matricula = tbxMatricula.Text;
                estudiantes.Password = tbxMatricula.Text;
                estudiantes.Carrera_Id = Convert.ToInt32(tbxCarrera.SelectedValue);
                estudiantes.Fecha_Nac = dateFecha_N.Value;
                estudiantes.Fecha_Ingreso = dateFecha_I.Value;

                estudiantes.guardarEstudiantes();

                cargarData();
            }

         
        }

        // editar data 
        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMatricula.Enabled = false;
            dateFecha_I.Enabled = false;
            dateFecha_N.Enabled = false;

            if (datagridview.SelectedCells.Count > 0)
            {
                tbxId.Text = datagridview.CurrentRow.Cells["id"].Value.ToString();
                tbxNombre.Text = datagridview.CurrentRow.Cells["nombre"].Value.ToString();
                tbxApellido.Text = datagridview.CurrentRow.Cells["apellido"].Value.ToString();
                tbxMatricula.Text = datagridview.CurrentRow.Cells["matricula"].Value.ToString();
                tbxCarrera.Text = datagridview.CurrentRow.Cells["carrera"].Value.ToString();
                dateFecha_N.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["fecha_nac"].Value);
                dateFecha_I.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["fecha_ing"].Value);

                btnGuardar.Enabled = false;
            }
        }

        // actualizar estudiante
        private void btnActualizar_Click(object sender, EventArgs e)
        {


            if (tbxId.Text == "")
            {
                MessageBox.Show("Seleccione un estudiante de la lista porfavor");
            }
            else
            {
                estudiantes.Id = Convert.ToInt32(tbxId.Text);
                estudiantes.Nombre = tbxNombre.Text;
                estudiantes.Apellido = tbxApellido.Text;
                estudiantes.Carrera_Id = Convert.ToInt32(tbxCarrera.SelectedValue);

                estudiantes.actualizarEstudiantes();
                cargarData();

            }
        }

        // eliminar estudiante
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(tbxId.Text == "")
            {
                MessageBox.Show("Seleccione un estudiante de la lista porfavor");
            }
            else
            {
                estudiantes.Id = Convert.ToInt32(tbxId.Text);
                estudiantes.Eliminarestudiantes();

                cargarData();
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxId.Text = "";
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxMatricula.Text = "";

            btnGuardar.Enabled = true;

        }
    }
}
