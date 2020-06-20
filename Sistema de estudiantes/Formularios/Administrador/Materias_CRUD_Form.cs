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
    public partial class Materias_CRUD_Form : Form
    {
        Materias_Model materias = new Materias_Model();
        Carreras_Model carreras = new Carreras_Model();
        Docentes_Model docentes = new Docentes_Model();
        public Materias_CRUD_Form()
        {
            InitializeComponent();
        }

        private void Materias_CRUD_Form_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            

            datagridview.DataSource = materias.getMateriasall();
            tbxCarrera.DataSource = carreras.getCarrerasList();
            tbxDocente.DataSource = docentes.getDocentesList();


            tbxCarrera.DisplayMember = "Nombre_Carrera";
            tbxCarrera.ValueMember = "Id";

            tbxDocente.DisplayMember = "Nombre";
            tbxDocente.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tbxMateria.Text == "")
            {
                MessageBox.Show("El campo materia es requerido");
            }
            else
            {
                materias.Materia = tbxMateria.Text;
                materias.IdCarrera = Convert.ToInt32(tbxCarrera.SelectedValue);
                materias.DocenteId = Convert.ToInt32(tbxDocente.SelectedValue);
                materias.Dia = tbxDia.SelectedItem.ToString();
                materias.Fecha_Inicio = dateFecha_I.Value;
                materias.Fecha_Termino = dateFecha_T.Value;
                materias.Hora = dateHora.Value;

                materias.guardarMaterias();

                cargarData();
            }
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCarrera.Enabled = false;
            
            if(datagridview.SelectedCells.Count > 0)
            {
                tbxMateria.Text = datagridview.CurrentRow.Cells["nombre_materia"].Value.ToString();
                tbxDia.Text = datagridview.CurrentRow.Cells["dia"].Value.ToString();
                tbxCarrera.Text = datagridview.CurrentRow.Cells["carrera"].Value.ToString();
                tbxDocente.Text = datagridview.CurrentRow.Cells["docente"].Value.ToString();
                dateFecha_I.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["fecha_inicio"].Value);
                dateFecha_T.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["fecha_termino"].Value);
                dateHora.Value = Convert.ToDateTime(datagridview.CurrentRow.Cells["hora"].Value.ToString());
                tbxId.Text = datagridview.CurrentRow.Cells["id"].Value.ToString();
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
                materias.Materia = tbxMateria.Text;
                materias.Dia = tbxDia.Text;
                materias.IdCarrera = Convert.ToInt32(tbxCarrera.SelectedValue);
                materias.DocenteId = Convert.ToInt32(tbxDocente.SelectedValue);
                materias.Fecha_Inicio = dateFecha_I.Value;
                materias.Fecha_Termino = dateFecha_T.Value;
                materias.Hora = dateHora.Value;
                materias.Id = Convert.ToInt32(tbxId.Text);
                materias.actualizarMaterias();

                cargarData();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxMateria.Text = "";
            tbxCarrera.Enabled = true;
        }
    }
}
