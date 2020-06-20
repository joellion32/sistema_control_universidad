using Sistema_de_estudiantes.Clases;
using Sistema_de_estudiantes.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    public partial class Calificaciones_Estudiantes_Form : Form
    {
        Calificaciones_Model calificaciones = new Calificaciones_Model();
        
        public Calificaciones_Estudiantes_Form()
        {
            InitializeComponent();
        }

        private void Calificaciones_Estudiantes_Form_Load(object sender, EventArgs e)
        {
            lbNombre.Text = UsuarioCache.Nombreusuario + " " + UsuarioCache.Apellidousuario;
            lbMatricula.Text = UsuarioCache.Cedulausuario;
            lbcarrera.Text = UsuarioCache.Carrera;
            cargarData();
           
        }

        private void cargarData()
        {
            calificaciones.estudiante_id = UsuarioCache.Idusuario;
            dataGridView1.DataSource = calificaciones.mostrarCalificaciones();
        }


        // imprimir calificaciones
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // configuarar metodo de impresion

            printDocument1 = new PrintDocument();
            PrinterSettings settings = new PrinterSettings();
            printDocument1.PrinterSettings = settings;
            printDocument1.PrintPage += GenerarImpresion;
            printDocument1.Print();
        }


        private void GenerarImpresion(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            Font font1 = new Font("Arial", 12);
            int ancho = 150;
            int posicion_y = 180;

            // dibujar en la pagina
            e.Graphics.DrawString("Nombre y Apellido: " + UsuarioCache.Nombreusuario + "" + UsuarioCache.Apellidousuario, font, Brushes.Black, new RectangleF(50, 20 + 20, 600, 50));
            e.Graphics.DrawString("Matricula: " +  UsuarioCache.Cedulausuario, font, Brushes.Black, new RectangleF(50, 60 + 20, 600, 50));
            e.Graphics.DrawString("Carrera: " + UsuarioCache.Carrera, font, Brushes.Black, new RectangleF(50, 80 + 40, 800, 50));
            e.Graphics.DrawString("Calificacion", font, Brushes.Black, new RectangleF(50, 100 + 80, ancho, 20));

            // traer datos de dataGridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                e.Graphics.DrawString("Materia: " + row.Cells[0].Value, font1, Brushes.Black, new RectangleF(50,  posicion_y += 40, 800, 50));
                e.Graphics.DrawString("Calificacion: " + row.Cells[2].Value, font1, Brushes.Black, new RectangleF(50, posicion_y += 30, 800, 50));
            }
        }

       
    }
}
