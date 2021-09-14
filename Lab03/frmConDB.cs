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

namespace Lab03
{
    public partial class frmConDB : Form
    {
        SqlConnection conn;
        public frmConDB()
        {
            InitializeComponent();
        }

        private void frmConDB_Load(object sender, EventArgs e)
        {
            btnPersona.Enabled = false;
            btnCurso.Enabled = false;
            btnDesconectar.Enabled = false;
            btnEstado.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + bd + ";";

            // La cadena de conexion cambia en funcion del estado del checkbox
            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";

            // Abrir una conexion con el servidor, usando la cadena de conexion
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Satisfactoriamente");
                btnDesconectar.Enabled = true;
                btnCurso.Enabled = true;
                btnPersona.Enabled = true;
                btnEstado.Enabled = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor: \n"+ex.ToString());
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            // Intentamos obtener el estado de la conexion, y en caso este abierta,
            // recuperamos informacion de la misma
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\nVersion del Servidor: " + conn.ServerVersion +
                        "\nBase de Datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor:" + conn.State);
            }
            catch (Exception ex) {
                MessageBox.Show("Imposible determinar el estado del servidor: \n"+
                    ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            // Para cerrar la conexion verificamos que no este cerrada
            try {
                if (conn.State != ConnectionState.Closed) {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                    btnDesconectar.Enabled = false;
                    btnCurso.Enabled = false;
                    btnPersona.Enabled = false;
                } else {
                    MessageBox.Show("La conexion ya esta cerrada");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ocurrio un error al cerrar la conexion"+
                    ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked) {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            } else {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show(); 
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(conn);
            curso.Show();
        }
    }
}
