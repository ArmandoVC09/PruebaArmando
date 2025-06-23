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
    public partial class Huertos : Form
    {
        public Huertos()
        {
            InitializeComponent();
            llenarCombo();
            mostrarTabla();

        }
        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idHuerto AS ID, nombre AS Nombre, razonSocial AS [Proveedor], h.idProveedor FROM HUERTOS h INNER JOIN PROVEEDORES p on h.idProveedor = p.idProveedor WHERE h.estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgvHuertos = new DataTable();
            adapter.Fill(dgvHuertos);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Huertos.DataSource = dgvHuertos;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Huertos.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Huertos.Columns[0].Visible = false;
            dgv_Huertos.Columns[3].Visible = false;


        }//fin mostrarTabla

        private void llenarCombo()
        {
            SqlConnection con = ConexionBD.Instance.abrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT idProveedor, razonSocial FROM proveedores WHERE estatus =1", con);
            DataTable datatable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            datatable.Load(reader);
            cmb_Proveedor.DataSource = datatable;
            cmb_Proveedor.DisplayMember = "razonSocial";
            cmb_Proveedor.ValueMember = "idProveedor";
            cmb_Proveedor.SelectedIndex = -1;
            reader.Close();
            ConexionBD.Instance.cerrarConexion(con);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var frm_nuevo = new frm_Proveedores())
            {
                frm_nuevo.nuevoElemento += nuevoElemento;
                frm_nuevo.ShowDialog();

            }

        }

        private void nuevoElemento(object sender, EventArgs e)
        {
            llenarCombo();
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
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM HUERTOS WHERE nombre = @nombre AND idProveedor = @proveedor AND estatus = 1", con);
                checkcmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                checkcmd.Parameters.AddWithValue("@proveedor", cmb_Proveedor.SelectedValue);


                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT HUERTOS (nombre, idProveedor) VALUES (@nombre,@proveedor)", con);
                cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                cmd.Parameters.AddWithValue("@proveedor", cmb_Proveedor.SelectedValue);

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

                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM HUERTOS WHERE nombre = @nombre AND idProveedor = @proveedor", con);
                checkcmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                checkcmd.Parameters.AddWithValue("@proveedor", cmb_Proveedor.SelectedValue);


                //Comando para intertar datos en la BD


                SqlCommand cmd = new SqlCommand("UPDATE HUERTOS SET nombre = @nombre, idProveedor = @proveedor WHERE idHuerto = @idHuerto", con);
                cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                cmd.Parameters.AddWithValue("@proveedor", cmb_Proveedor.SelectedValue);
                cmd.Parameters.AddWithValue("@idHuerto", lb_id.Text);

                try
                {
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe un registro con la misma informacíon", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }// fin del if
                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }//del else                }
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

        private void dgv_Huertos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id.Text = dgv_Huertos.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre.Text = dgv_Huertos.CurrentRow.Cells[1].Value.ToString();
            cmb_Proveedor.SelectedValue = Convert.ToInt32(dgv_Huertos.CurrentRow.Cells[3].Value);
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

                SqlCommand cmd = new SqlCommand("UPDATE HUERTOS SET estatus = 0 WHERE idHuerto = @idHuerto", con);
                cmd.Parameters.AddWithValue("@idHuerto", lb_id.Text);

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

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noNumeros(sender, e);
        }
    }
}
