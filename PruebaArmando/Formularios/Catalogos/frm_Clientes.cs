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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idCliente AS ID, nombre AS Nombre, apellidoPaterno AS [Apellido Paterno], apellidoMaterno AS [Apellido Materno], rfc AS [RFC] FROM CLIENTES WHERE estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgvClientes = new DataTable();
            adapter.Fill(dgvClientes);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Clientes.DataSource = dgvClientes;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Clientes.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Clientes.Columns[0].Visible = false;

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
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM CLIENTES WHERE rfc = @rfc AND estatus = 1", con);
                checkcmd.Parameters.AddWithValue("@rfc", txt_Rfc.Text);

                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT CLIENTES(nombre, apellidoPaterno, apellidoMaterno, rfc) VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @rfc)", con);
                cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                cmd.Parameters.AddWithValue("@apellidoPaterno", txt_ApellidoPaterno.Text);
                cmd.Parameters.AddWithValue("@apellidoMaterno", txt_ApellidoMaterno.Text);
                cmd.Parameters.AddWithValue("@rfc", txt_Rfc.Text);

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
                }
            }

        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dgv_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id.Text = dgv_Clientes.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dgv_Clientes.CurrentRow.Cells[1].Value.ToString();
            txt_ApellidoPaterno.Text = dgv_Clientes.CurrentRow.Cells[2].Value.ToString();
            txt_ApellidoMaterno.Text = dgv_Clientes.CurrentRow.Cells[3].Value.ToString();
            txt_Rfc.Text = dgv_Clientes.CurrentRow.Cells[4].Value.ToString();
            bt_Eliminar.Enabled = true;
            bt_Modificar.Enabled = true;
            bt_Guardar.Enabled = false;
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("UPDATE CLIENTES SET nombre = @nombre, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, rfc = @rfc WHERE idCliente = @idCliente", con);
                cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                cmd.Parameters.AddWithValue("@apellidoPaterno", txt_ApellidoPaterno.Text);
                cmd.Parameters.AddWithValue("@apellidoMaterno", txt_ApellidoMaterno.Text);
                cmd.Parameters.AddWithValue("@rfc", txt_Rfc.Text);
                cmd.Parameters.AddWithValue("@idCliente", lb_id.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    bt_Modificar.Enabled = false;
                    bt_Guardar.Enabled = true;
                    limpiezas.limpiarContenedor(gb_Informacion);
                    mostrarTabla();
                }
            }
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

                SqlCommand cmd = new SqlCommand("UPDATE CLIENTES SET estatus = 0 WHERE idCliente = @idCliente", con);
                cmd.Parameters.AddWithValue("@idCliente", lb_id.Text);

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
                    bt_Modificar.Enabled = false;
                    bt_Guardar.Enabled = true;
                    limpiezas.limpiarContenedor(gb_Informacion);
                    mostrarTabla();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiezas.limpiarContenedor(gb_Informacion);
            lb_id.Text = string.Empty;
            bt_Eliminar.Enabled = false;
            bt_Modificar.Enabled = false;
            bt_Guardar.Enabled = true;
        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }

        private void txt_ApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }

        private void txt_ApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }

        private void txt_Rfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noSimbolos(sender, e);
        }

        private void gb_Informacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
