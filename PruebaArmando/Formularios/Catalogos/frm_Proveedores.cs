using Ejercicio.Clases;
using Ejercicio.Formularios.Menus;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio.Formularios.Catalogos
{
    public partial class frm_Proveedores : Form
    {
        public event EventHandler nuevoElemento;
        public frm_Proveedores()
        {
            InitializeComponent();
            mostrarTabla();

        }

        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idProveedor AS ID, razonSocial AS [Razón Social] FROM PROVEEDORES WHERE estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgv = new DataTable();
            adapter.Fill(dgv);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Proveedores.DataSource = dgv;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Proveedores.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Proveedores.Columns[0].Visible = false;

        }//fin mostrarTabla

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.controlLleno(gb_Informacion))
            {
                //si hay algun campo vacío
                MessageBox.Show("Ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }//fin if
            else
            {
                //establecer conexion con bd
                SqlConnection con = ConexionBD.Instance.abrirConexion();

                //Comando para contar registros existentes con los datos ingresados
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM PROVEEDORES WHERE razonSocial = @razonSocial AND estatus = 1", con);
                checkcmd.Parameters.AddWithValue("@razonSocial", txt_RazonSocial.Text);

                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT PROVEEDORES(razonSocial) VALUES (@nombre)", con);
                cmd.Parameters.AddWithValue("@nombre", txt_RazonSocial.Text);


                try
                {
                    //Ejecutar el comando de conteo y guardar el resultado en variable
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe un registro con la misma informacíon", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }// fin del if
                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//del else
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //cerrar conexion de bd
                    ConexionBD.Instance.cerrarConexion(con);
                    limpiezas.limpiarContenedor(gb_Informacion);
                    mostrarTabla();
                    nuevoElemento?.Invoke(this, EventArgs.Empty);
                }
            }

        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiezas.limpiarContenedor(gb_Informacion);
            lb_id.Text = string.Empty;
            bt_Eliminar.Enabled = false;
            bt_Guardar.Enabled = true;
        }

        private void dgv_Proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id.Text = dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
            txt_RazonSocial.Text = dgv_Proveedores.CurrentRow.Cells[1].Value.ToString();
            bt_Eliminar.Enabled = true;
            bt_Guardar.Enabled = false;
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.controlLleno(gb_Informacion))
            {
                //si hay algun campo vacío
                MessageBox.Show("Ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }//fin if
            else
            {
                //establecer conexion con bd
                SqlConnection con = ConexionBD.Instance.abrirConexion();

                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("UPDATE PROVEEDORES SET estatus = 0 WHERE idProveedor = @idProveedor", con);
                cmd.Parameters.AddWithValue("@idProveedor", lb_id.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //cerrar conexion de bd
                    ConexionBD.Instance.cerrarConexion(con);
                    bt_Eliminar.Enabled = false;
                    bt_Guardar.Enabled = true;
                    limpiezas.limpiarContenedor(gb_Informacion);
                    mostrarTabla();
                }
            }
        }

        private void txt_RazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }
    }
}
