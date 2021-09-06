using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        Dictionary<string, string> dictUsers = new Dictionary<string, string>()
        {
            { "John Doe", "jhon1234" },
            { "Jane Doe", "jane1234" },
            { "Joe Doe", "joe1234" },
            { "david", "david1234" }
        };
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // estu es un comentario
            string user = txtUsuario.Text;
            string contraseña = txtPassword.Text;
            bool verdad = false;

            foreach (KeyValuePair<string, string> usuario in dictUsers)
            {
                if (usuario.Key.Equals(user) && usuario.Value.Equals(contraseña))
                {
                    verdad = true;
                    break;
                }
            }

            if (verdad)
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else {
                string message = "El usuario o contraseña son incorrectos";
                string caption = "Error en el login";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
