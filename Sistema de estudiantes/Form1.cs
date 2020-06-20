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
using Sistema_de_estudiantes.Modelos;

namespace Sistema_de_estudiantes
{
   
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Docentes_Model docente = new Docentes_Model();
        Estudiantes_Model estudiantes = new Estudiantes_Model();
        Administrador_Model administrador = new Administrador_Model();

        // variables globales

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbtitulo;

        }
        /***--------------------------CONFIGURACION DEL FORMULARIO-------------------***/
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            Validar1(tbxUsuario, "USUARIO", "");
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            Validar1(tbxUsuario, "", "USUARIO");
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
           Validar2(tbxPassword, "CONTRASEÑA", "", false);
          
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            Validar2(tbxPassword, "", "CONTRASEÑA", true);
        }


        private void Validar1(TextBox tbx, String validacion1, String validacion2)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
            }
        }

        private void Validar2(TextBox tbx, String validacion1, String validacion2, bool password)
        {
            if (tbx.Text == validacion1)
            {
                tbx.Text = validacion2;
                tbx.UseSystemPasswordChar = password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboxRoles.Text == "")
            {
                MessageBox.Show("PORFAVOR INGRESE UN ROL");
            }


            if (cboxRoles.Text == "DOCENTE")
            {
             
                docente.cedula = tbxUsuario.Text;
                docente.password = tbxPassword.Text;

                if(docente.result == true)
                {
                    docente.login();
                    this.Close();



                }
                else
                {
                    docente.login();
                }

               
            }

            else if (cboxRoles.Text == "ESTUDIANTE")
            {
                estudiantes.matricula = tbxUsuario.Text;
                estudiantes.password = tbxPassword.Text;
                estudiantes.login();
            }

            else if (cboxRoles.Text == "ADMINISTRADOR")
            {
                administrador.nombre = tbxUsuario.Text;
                administrador.password = tbxPassword.Text;
                administrador.login();
            }
        }

    }
}
