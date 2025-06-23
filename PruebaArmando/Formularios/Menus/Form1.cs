using Ejercicio.Clases;
using Ejercicio.Formularios.Catalogos;
using Ejercicio.Formularios.Menus;
using Microsoft.Data.SqlClient;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.controlLleno(groupBox1))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = ConexionBD.Instance.abrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE nombre = @nombre AND contraseña = @contraseña AND estatus = 1", con);
                cmd.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                if(cmd.ExecuteScalar() != null)
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        frm_MenuPrincipal frm_MenuPrincipal = new frm_MenuPrincipal();
                        frm_MenuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al verificar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
