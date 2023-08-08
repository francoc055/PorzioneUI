using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porzioneUI
{
    public partial class FrmLogin : Form
    {
        string url;
        public FrmLogin()
        {
            InitializeComponent();
            url = "http://localhost:5109/api/Usuario/Autenticar";
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AutorizacionResponse autorizacion = Autenticacion.AutenticarUsuario(txtCorreo.Text, txtClave.Text, url);
            if (autorizacion == null)
                return;

            FrmAdmin frmAdmin = new(autorizacion);

            Task.Run(frmAdmin.ShowDialog);
        }
    }
}
