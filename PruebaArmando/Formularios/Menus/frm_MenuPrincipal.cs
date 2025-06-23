using Ejercicio.Formularios.Catalogos;
using Ejercicio.Formularios.Compras;
using Ejercicio.Formularios.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio.Formularios.Menus
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Recepcion frm_Recepcion = new frm_Recepcion();
            frm_Recepcion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_Catalogo.Visible = true;
            p_Ventas.Visible = false;
            p_Compras.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_Catalogo.Visible = false;
            p_Ventas.Visible = false;
            p_Compras.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p_Catalogo.Visible = false;
            p_Ventas.Visible = true;
            p_Compras.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_PresentacionPedidos frm_PresentacionPedidos = new frm_PresentacionPedidos();
            frm_PresentacionPedidos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Clientes frm_Clientes = new frm_Clientes();
            frm_Clientes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_Proveedores frm_Proveedores = new frm_Proveedores();
            frm_Proveedores.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Huertos huertos = new Huertos();
            huertos.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_OrdenesPedidos frm_ordenespedidos = new frm_OrdenesPedidos();
            frm_ordenespedidos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
