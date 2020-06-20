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
using Sistema_de_estudiantes.Formularios;
using Sistema_de_estudiantes.Formularios.Docentes;
using Sistema_de_estudiantes.Formularios.General;
using Sistema_de_estudiantes.Formularios.Estudiantes;

namespace Sistema_de_estudiantes
{
    /*------------------PANTALLA-----------------------------------*/
    public partial class btnAsistencias : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public btnAsistencias()
        {
            InitializeComponent();
        }
        private void PanelDocente_Load(object sender, EventArgs e)
        {
            lbNombre.Text = UsuarioCache.Nombreusuario + " " + UsuarioCache.Apellidousuario;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestore.Visible = true;
            btnMaximizar.Visible = false;

        }


        private void btnrestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestore.Visible = false;
            btnMaximizar.Visible = true;
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*------------------PANTALLA-----------------------------------*/
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

        private void btnCalificar_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnCalificar, "leave");
        }

        private void btnCalificar_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnCalificar, "hover");
        }

        private void btnEstudiante_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnEstudiante, "hover");
        }

        private void btnEstudiante_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnEstudiante, "leave");
        }

        private void btnMaterias_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnMaterias, "hover");
        }

        private void btnMaterias_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnMaterias, "leave");
        }

        private void btnClases_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnClases, "hover");
        }

        private void btnClases_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnClases, "leave");
        }

        private void btnConfiguracion_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnConfiguracion, "hover");
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnConfiguracion, "leave");
        }

        private void btnAcerca_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnAcerca, "hover");
        }

        private void btnAcerca_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnAcerca, "leave");
        }

        // reloj
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora1.Text = DateTime.Now.ToLongTimeString();
            lbfecha1.Text = DateTime.Now.ToLongDateString();
        }


        // ver perfil del usuario
        private void button2_Click(object sender, EventArgs e)
        {
            Perfil_Form perfil = new Perfil_Form();
            perfil.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cerrado sesion");
            Application.Restart();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Perfil_Form perfil = new Perfil_Form();
            perfil.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscador_Docentes_Form buscador = new Buscador_Docentes_Form();
            buscador.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clases_Form clases = new Clases_Form();
            clases.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About_Form about = new About_Form();
            about.ShowDialog();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            About_Form about = new About_Form();
            about.ShowDialog();
        }

        // mostrar calificaciones
        private void btnCalificar_Click(object sender, EventArgs e)
        {
            Calificaciones_Form calificaciones = new Calificaciones_Form();
            calificaciones.ShowDialog();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            Asistencias_Form asistencias = new Asistencias_Form();
            asistencias.ShowDialog();
        }

        private void btnEstudiante_MouseClick(object sender, MouseEventArgs e)
        {
            Estudiantes_Form estudiantes = new Estudiantes_Form();
            estudiantes.ShowDialog();
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            Clases_Form clases = new Clases_Form();
            clases.ShowDialog();
        }
    }
}
