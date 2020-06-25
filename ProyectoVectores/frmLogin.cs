using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(login(this.txtUsuario.Text, this.txtPassword.Text))
            {
                this.Visible = true;
                frmMenu frm1 = new frmMenu();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrectos...");
            }
        }
        private bool login(string usuario, string clave)
        {
            return (usuario == "admin" && clave == "123");
        }
    }
}
