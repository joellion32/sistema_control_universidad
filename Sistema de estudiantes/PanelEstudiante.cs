using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema_de_estudiantes.Clases;
using Sistema_de_estudiantes.Formularios.Estudiantes;
using Sistema_de_estudiantes.Formularios;
using Sistema_de_estudiantes.Formularios.General;

namespace Sistema_de_estudiantes
{

    public partial class PanelEstudiante : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public PanelEstudiante()
        {
            InitializeComponent();
        }
        private void PanelEstudiante_Load(object sender, EventArgs e)
        {
            lbNombre.Text = UsuarioCache.Nombreusuario + " " + UsuarioCache.Apellidousuario;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestore.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestore.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*--------------------------------------PANTALLA------------------------------------------*/
        private void Animacion(Panel panel, String evento)
        {
            if (evento == "hover")
            {
                panel.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (evento == "leave")
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // reloj
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora1.Text = DateTime.Now.ToLongTimeString();
            lbfecha1.Text = DateTime.Now.ToLongDateString();
        }

        private void btnCalificar_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnCalificar, "hover");
        }

        private void btnCalificar_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnCalificar, "leave");
        }

        private void btnCalificaciones_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnCalificaciones, "hover");
        }

        private void btnCalificaciones_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnCalificaciones, "leave");
        }

        private void btnConfiguracion_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnConfiguracion, "hover");
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnConfiguracion, "leave");
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
           //
        }

        private void PanelEstudiante_Click(object sender, EventArgs e)
        {
            Materias_Estudiantes_Form Fmaterias_estudiantes = new Materias_Estudiantes_Form();
            Fmaterias_estudiantes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cerrado sesion");   
            Application.Restart();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Calificaciones_Estudiantes_Form Fcalificaciones = new Calificaciones_Estudiantes_Form();
            Fcalificaciones.ShowDialog();
        }
        // mostrar perfil del usuario
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil_Estudiante_Form Fperfil = new Perfil_Estudiante_Form();
            Fperfil.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias_Estudiantes_Form Fmaterias_estudiantes = new Materias_Estudiantes_Form();
            Fmaterias_estudiantes.ShowDialog();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            About_Form Fabout = new About_Form();
            Fabout.ShowDialog();
        }

        // mostrar Materias

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Seleccionar_Materias_Form Fseleccionar = new Seleccionar_Materias_Form();
            Fseleccionar.ShowDialog();
        }
     

    }

}
