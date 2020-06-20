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
    public partial class Buscador_Docentes_Form : Form
    {
        Docentes_Model docente = new Docentes_Model();

        public Buscador_Docentes_Form()
        {
            InitializeComponent();
        }



        // funciones
        private void Validar(TextBox tbx, String validacion1, String validacion2)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
            }
        }

        private void Buscador_Docentes_Form_Load(object sender, EventArgs e)
        {
            MostrarDocentes();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "BUSCAR", "");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Validar(tbxBuscar, "", "BUSCAR");
        }


        // Mostrar Docentes
        public void MostrarDocentes()
        {
            DataGrid.DataSource = docente.getDocentes();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if(tbxBuscar.Text == "" || tbxBuscar.Text == "BUSCAR")
            {
                MessageBox.Show("Por favor introduce un nombre");
            }
            else
            {
                docente.Nombre = tbxBuscar.Text;
                DataGrid.DataSource = docente.buscarDocentes();
            }
              
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDocentes();
        }
    }
}
