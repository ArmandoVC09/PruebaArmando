using Ejercicio.Clases;
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

namespace Ejercicio.Formularios.Ventas
{
    public partial class frm_OrdenesPedidos : Form
    {
        public frm_OrdenesPedidos()
        {
            InitializeComponent();
            llenarCombo();
            llenarCombo2();
            mostrarTabla();
        }
        private void llenarCombo()
        {
            SqlConnection con = ConexionBD.Instance.abrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT idCliente, nombre + ' ' + apellidoPaterno + ' ' + apellidoMaterno AS [nombre] FROM CLIENTES WHERE estatus = 1", con);
            DataTable datatable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            datatable.Load(reader);
            cmb_Cliente.DataSource = datatable;
            cmb_Cliente.DisplayMember = "nombre";
            cmb_Cliente.ValueMember = "idCliente";
            cmb_Cliente.SelectedIndex = -1;
            reader.Close();
            ConexionBD.Instance.cerrarConexion(con);
        }

        private void llenarCombo2()
        {
            SqlConnection con = ConexionBD.Instance.abrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT idPresentacionPedido, nombre FROM PRESENTACION_PEDIDOS WHERE estatus = 1", con);
            DataTable datatable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            datatable.Load(reader);
            cmb_Presentacion.DataSource = datatable;
            cmb_Presentacion.DisplayMember = "nombre";
            cmb_Presentacion.ValueMember = "idPresentacionPedido";
            cmb_Presentacion.SelectedIndex = -1;
            reader.Close();
            ConexionBD.Instance.cerrarConexion(con);
        }

        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idOrdenPedido AS ID, fechaCreacion AS [Fecha de creación], fechaEntrega AS [Fecha de entrega], c.nombre + ' ' + apellidoPaterno + ' ' + apellidoMaterno AS [Cliente], p.nombre AS [Presentación de pedido], cantidad AS [Cantidad], o.idCliente, o.idPresentacionPedido FROM ORDENES_PEDIDOS o INNER JOIN CLIENTES c ON c.idCliente = o.idCliente INNER JOIN PRESENTACION_PEDIDOS p ON p.idPresentacionPedido = o.idPresentacionPedido WHERE o.estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgv = new DataTable();
            adapter.Fill(dgv);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Ordenes.DataSource = dgv;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Ordenes.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Ordenes.Columns[0].Visible = false;
            dgv_Ordenes.Columns[6].Visible = false;
            dgv_Ordenes.Columns[7].Visible = false;

        }//fin mostrarTabla

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


                SqlCommand cmd = new SqlCommand("UPDATE ORDENES_PEDIDOS SET idCliente = @cliente, idPresentacionPedido = @presentacion, cantidad = @cantidad, fechaEntrega = @fechaEntrega, fechaCreacion = @fechaCreacion WHERE idOrdenPedido = @idOrden", con);
                cmd.Parameters.AddWithValue("@cliente", cmb_Cliente.SelectedValue);
                cmd.Parameters.AddWithValue("@presentacion", cmb_Presentacion.SelectedValue);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_Cantidad.Text));
                cmd.Parameters.AddWithValue("@idOrden", lb_id.Text);
                cmd.Parameters.AddWithValue("fechaCreacion", dtp_Creacion.Value);
                cmd.Parameters.AddWithValue("fechaEntrega", dtp_Entrega.Value);



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

                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT ORDENES_PEDIDOS (idCliente, idPresentacionPedido, cantidad, fechaEntrega, fechaCreacion ) VALUES (@cliente,@presentacion,@cantidad,@fechaEntrega,@fechaCreacion)", con);
                cmd.Parameters.AddWithValue("@cliente", cmb_Cliente.SelectedValue);
                cmd.Parameters.AddWithValue("@presentacion", cmb_Presentacion.SelectedValue);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_Cantidad.Text));
                cmd.Parameters.AddWithValue("@fechaCreacion", dtp_Creacion.Value);
                cmd.Parameters.AddWithValue("@fechaEntrega", dtp_Entrega.Value);




                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.numeroEntero(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiezas.limpiarContenedor(gb_Informacion);
            lb_id.Text = string.Empty;
            bt_Eliminar.Enabled = false;
            bt_Guardar.Enabled = true;
            bt_Modificar.Enabled = false;
        }

        private void dgv_Ordenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id.Text = dgv_Ordenes.CurrentRow.Cells[0].Value.ToString();
            dtp_Creacion.Value = Convert.ToDateTime(dgv_Ordenes.CurrentRow.Cells[1].Value);
            dtp_Entrega.Value = Convert.ToDateTime(dgv_Ordenes.CurrentRow.Cells[2].Value);
            txt_Cantidad.Text = dgv_Ordenes.CurrentRow.Cells[5].Value.ToString();
            cmb_Cliente.SelectedValue = Convert.ToInt32(dgv_Ordenes.CurrentRow.Cells[6].Value);
            cmb_Presentacion.SelectedValue = Convert.ToInt32(dgv_Ordenes.CurrentRow.Cells[7].Value);

            bt_Eliminar.Enabled = true;
            bt_Modificar.Enabled = true;
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

                SqlCommand cmd = new SqlCommand("UPDATE ORDENES_PEDIDOS SET estatus = 0 WHERE idOrdenPedido = @id", con);
                cmd.Parameters.AddWithValue("@id", lb_id.Text);

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
    }
}
