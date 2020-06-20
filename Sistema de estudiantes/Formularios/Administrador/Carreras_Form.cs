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
    public partial class Carreras_Form : Form
    {
        Carreras_Model carreras = new Carreras_Model();
        public Carreras_Form()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tbxCarrera.Text == "")
            {
                MessageBox.Show("El campo esta vacio");
            }
            else
            {
                carreras.Nombre_Carrera = tbxCarrera.Text;
                carreras.agregarCarrera();
            }
        }
    }
}
