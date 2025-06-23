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
    public partial class frm_PresentacionPedidos : Form
    {
        public event EventHandler nuevoElemento;

        public frm_PresentacionPedidos()
        {
            InitializeComponent();
            mostrarTabla();
        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

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
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM PRESENTACION_PEDIDOS WHERE nombre = @nombre AND estatus = 1", con);
                checkcmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);

                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT PRESENTACION_PEDIDOS(nombre) VALUES (@nombre)", con);
                cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);


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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiezas.limpiarContenedor(gb_Informacion);
            lb_id.Text = string.Empty;
            bt_Eliminar.Enabled = false;
            bt_Guardar.Enabled = true;
        }

        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idPresentacionPedido AS ID, nombre AS [Nombre] FROM PRESENTACION_PEDIDOS WHERE estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgvPresentacion = new DataTable();
            adapter.Fill(dgvPresentacion);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Presentacion.DataSource = dgvPresentacion;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Presentacion.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Presentacion.Columns[0].Visible = false;

        }//fin mostrarTabla

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

                SqlCommand cmd = new SqlCommand("UPDATE PRESENTACION_PEDIDOS SET estatus = 0 WHERE idPresentacionPedido = @idPresentacion", con);
                cmd.Parameters.AddWithValue("@idPresentacion", lb_id.Text);

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

        private void dgv_Presentacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lb_id.Text = dgv_Presentacion.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dgv_Presentacion.CurrentRow.Cells[1].Value.ToString();
            bt_Eliminar.Enabled = true;
            bt_Guardar.Enabled = false;

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }
    }
}
