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
using Sistema_de_estudiantes.Formularios.Docentes;
using Sistema_de_estudiantes.Formularios.General;
using Sistema_de_estudiantes.Formularios.Estudiantes;
using Sistema_de_estudiantes.Formularios.Administrador;
using Sistema_de_estudiantes.Formularios;

namespace Sistema_de_estudiantes
{
    public partial class PanelAdministrador : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public PanelAdministrador()
        {
            InitializeComponent();
        }
        /* ----------------------------- VENTANA--------------------------------------*/

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestore_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestore.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestore.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora1.Text = DateTime.Now.ToLongTimeString();
            lbfecha1.Text = DateTime.Now.ToLongDateString();
        }
        /* ----------------------------- ANIMIMACIONES DE BOTONES --------------------------------------*/
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

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            Animacion(panel3, "hover");
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            Animacion(panel3, "leave");
        }

        private void btnDocentes_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnDocentes, "hover");
        }

        private void btnDocentes_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnDocentes, "leave");
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

        private void btnAcerca_MouseHover(object sender, EventArgs e)
        {
            Animacion(btnAcerca, "hover");
        }

        private void btnAcerca_MouseLeave(object sender, EventArgs e)
        {
            Animacion(btnAcerca, "leave");
        }
        /* ----------------------------- ANIMIMACIONES DE BOTONES --------------------------------------*/

        // cerrar sesion
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cerrado sesion");
            Application.Restart();
        }


        // buscar docentes
        private void button3_Click(object sender, EventArgs e)
        {
            Buscador_Docentes_Form Fbuscar = new Buscador_Docentes_Form();
            Fbuscar.ShowDialog();
        }

        // about form
        private void button1_Click(object sender, EventArgs e)
        {
            About_Form Fabout = new About_Form();
            Fabout.ShowDialog();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            About_Form Fabout = new About_Form();
            Fabout.ShowDialog();
        }
       
        // mostrar formulario de estudiantes
        private void panel3_Click(object sender, EventArgs e)
        {
            Estudiantes_CRUD_Form Festudiantes = new Estudiantes_CRUD_Form();
            Festudiantes.ShowDialog();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Docentes_CRUD_Form Fdocentes = new Docentes_CRUD_Form();
            Fdocentes.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este perfil es del administrador");
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias_CRUD_Form Fmaterias = new Materias_CRUD_Form();
            Fmaterias.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Carreras_Form Fcarreras = new Carreras_Form();
            Fcarreras.ShowDialog();
        }
    }
}
