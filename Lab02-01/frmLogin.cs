using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        /*Dictionary<string, string> dictUsers = new Dictionary<string, string>()
        {
            { "John Doe", "jhon1234" },
            { "Jane Doe", "jane1234" },
            { "Joe Doe", "joe1234" },
            { "david", "david1234" }
        };*/
        SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string servidor = @"DESKTOP-A8SP04K\LOCAL";
            string bd = "db_lab03";
            string username = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            string str = "Server=" + servidor + ";Database=" + bd + ";" + "Integrated Security=true";
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

                String sql = "SELECT usuario_nombre, usuario_password FROM tbl_usuario WHERE usuario_nombre='"+
                    txtUsuario.Text + "' AND usuario_password='" + txtPassword.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("login exitoso");
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtUsuario.Clear();
                    txtPassword.Clear();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor: \n" + ex.ToString());
            }



            /*string username = txtUsuario.Text;
            string contraseña = txtPassword.Text;
            bool verdad = false;

            foreach (KeyValuePair<string, string> usuario in dictUsers)
            {
                if (usuario.Key.Equals(username) && usuario.Value.Equals(contraseña))
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
            }*/
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
