using Sistema_de_estudiantes.Clases;
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

namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    public partial class Seleccionar_Materias_Form : Form
    {
        Materias_Model materias = new Materias_Model();
        Clases_Model clases = new Clases_Model();
        int creditos = 5;
        public Seleccionar_Materias_Form()
        {
            InitializeComponent();
        }


        private void Seleccionar_Materias_Form_Load(object sender, EventArgs e)
        {
            cargarData();
        }


        public void cargarData()
        {
            foreach (var materia in materias.getMaterias())
            {

                checkedListMaterias.Items.Add(materia.id);
                listBoxMateria.Items.Add(materia.nombre_materia);
                listBoxDia.Items.Add(materia.dia);
                listFecha.Items.Add(materia.fecha_inicio);
            }

        }

        private void checkedListMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            creditos--;
            lbcredito.Text = creditos.ToString();
            
            if(creditos <= 0)
            {
                lbcredito.Text = "0";
                MessageBox.Show("Ya no te quedan creditos");
            }
            else
            {
                clases.Id_Materia = Convert.ToInt32(checkedListMaterias.SelectedItem);
                clases.Id_Estudiante = UsuarioCache.Idusuario;
                clases.guardarClase();
            }
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados correctamente");
            this.Close();
        }
    }
}
