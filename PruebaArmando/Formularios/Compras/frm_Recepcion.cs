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

namespace Ejercicio.Formularios.Compras
{
    public partial class frm_Recepcion : Form
    {
        public frm_Recepcion()
        {
            InitializeComponent();
            llenarCombo();
            llenarCombo2();
            mostrarTabla();
        }

        private void llenarCombo()
        {
            SqlConnection con = ConexionBD.Instance.abrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT idHuerto, nombre FROM HUERTOS WHERE estatus =1", con);
            DataTable datatable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            datatable.Load(reader);
            cmb_Huerto.DataSource = datatable;
            cmb_Huerto.DisplayMember = "nombre";
            cmb_Huerto.ValueMember = "idHuerto";
            cmb_Huerto.SelectedIndex = -1;
            reader.Close();
            ConexionBD.Instance.cerrarConexion(con);
        }

        private void llenarCombo2()
        {
            SqlConnection con = ConexionBD.Instance.abrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT idTipoMadera, nombre FROM TIPOS_MADERA WHERE estatus =1", con);
            DataTable datatable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            datatable.Load(reader);
            cmb_Madera.DataSource = datatable;
            cmb_Madera.DisplayMember = "nombre";
            cmb_Madera.ValueMember = "idTipoMadera";
            cmb_Madera.SelectedIndex = -1;
            reader.Close();
            ConexionBD.Instance.cerrarConexion(con);
        }

        private void mostrarTabla()
        {
            //Establecer conexion con BD
            SqlConnection con = ConexionBD.Instance.abrirConexion();

            //Consulta de tabla Clientes
            SqlCommand cmd = new SqlCommand("SELECT idRecepcionMadera AS ID, fechaRecepcion AS [Fecha de recepción], h.nombre AS [Huerto], t.nombre AS [Tipo de Madera], ROUND(pesoPromIndividual,2) AS [Peso Promedio Individual], cantidad AS [Cantidad], ROUND(pesoTotal,2) AS [PESO TOTAL], r.idHuerto, r.idTipoMadera FROM RECEPCION r INNER JOIN HUERTOS h ON h.idHuerto = r.idHuerto INNER JOIN TIPOS_MADERA t ON t.idTipoMadera = r.idTipoMadera WHERE r.estatus = 1", con);
            //Toma datos del comando en un Adaptador
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Crea un dataTable para poner los datos del adaptador
            DataTable dgv = new DataTable();
            adapter.Fill(dgv);
            //Asigna lo datos de la dataTable a la dataGridView del formulario
            dgv_Recepcion.DataSource = dgv;
            //Establecer tabla como lectura y evitar modificaciones
            dgv_Recepcion.ReadOnly = true;

            //cerrar la conexion con la bd
            ConexionBD.Instance.cerrarConexion(con);

            dgv_Recepcion.Columns[0].Visible = false;
            dgv_Recepcion.Columns[7].Visible = false;
            dgv_Recepcion.Columns[8].Visible = false;

        }//fin mostrarTabla


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

                float pesoIndividual = float.Parse(txt_individual.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                float pesoTotal = pesoIndividual * cantidad;
                //Comando para intertar datos en la BD

                SqlCommand cmd = new SqlCommand("INSERT RECEPCION (idHuerto, pesoPromIndividual, cantidad, idTipoMadera, pesoTotal, fechaRecepcion ) VALUES (@huerto,@pesoIndividual,@cantidad,@madera,@pesoTotal,@fechaRecepcion)", con);
                cmd.Parameters.AddWithValue("@huerto", cmb_Huerto.SelectedValue);
                cmd.Parameters.AddWithValue("@madera", cmb_Madera.SelectedValue);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                cmd.Parameters.AddWithValue("@pesoIndividual", float.Parse(txt_individual.Text));
                cmd.Parameters.AddWithValue("@pesoTotal", pesoTotal);
                cmd.Parameters.AddWithValue("@fechaRecepcion", dtp_Recepcion.Value);




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



                float pesoIndividual = float.Parse(txt_individual.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                float pesoTotal = pesoIndividual * cantidad;
                //Comando para intertar datos en la BD


                SqlCommand cmd = new SqlCommand("UPDATE RECEPCION SET idHuerto = @huerto, idTipoMadera = @madera, cantidad = @cantidad, pesoPromIndividual = @pesoIndividual, pesoTotal = @pesoTotal, fechaRecepcion = @fechaRecepcion WHERE idRecepcionMadera = @idRecepcion", con);
                cmd.Parameters.AddWithValue("@huerto", cmb_Huerto.SelectedValue);
                cmd.Parameters.AddWithValue("@madera", cmb_Madera.SelectedValue);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                cmd.Parameters.AddWithValue("@pesoIndividual", float.Parse(txt_individual.Text));
                cmd.Parameters.AddWithValue("@pesoTotal", pesoTotal);
                cmd.Parameters.AddWithValue("@idRecepcion", lb_id.Text);
                cmd.Parameters.AddWithValue("fechaRecepcion", dtp_Recepcion.Value);



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



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            limpiezas.limpiarContenedor(gb_Informacion);
            lb_id.Text = string.Empty;
            bt_Eliminar.Enabled = false;
            bt_Guardar.Enabled = true;
            bt_Modificar.Enabled = false;
        }

        private void dgv_Recepcion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id.Text = dgv_Recepcion.CurrentRow.Cells[0].Value.ToString();
            dtp_Recepcion.Value = Convert.ToDateTime(dgv_Recepcion.CurrentRow.Cells[1].Value);
            cmb_Huerto.SelectedValue = Convert.ToInt32(dgv_Recepcion.CurrentRow.Cells[7].Value);
            cmb_Madera.SelectedValue = Convert.ToInt32(dgv_Recepcion.CurrentRow.Cells[8].Value);
            txt_individual.Text = dgv_Recepcion.CurrentRow.Cells[4].Value.ToString();
            txt_cantidad.Text = dgv_Recepcion.CurrentRow.Cells[5].Value.ToString();

            bt_Eliminar.Enabled = true;
            bt_Modificar.Enabled = true;
            bt_Guardar.Enabled = false;
        }

        private void txt_individual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.numeroDecimal(sender, e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.numeroEntero(sender, e);
        }
    }
}
