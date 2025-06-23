namespace Ejercicio.Formularios.Catalogos
{
    partial class frm_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            toolStrip1 = new ToolStrip();
            bt_Guardar = new ToolStripButton();
            bt_Modificar = new ToolStripButton();
            bt_Eliminar = new ToolStripButton();
            bt_Regresar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            dgv_Clientes = new DataGridView();
            gb_Informacion = new GroupBox();
            lb_id = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_ApellidoMaterno = new TextBox();
            txt_ApellidoPaterno = new TextBox();
            label2 = new Label();
            txt_Rfc = new TextBox();
            label1 = new Label();
            txt_Nombre = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).BeginInit();
            gb_Informacion.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_Guardar, bt_Modificar, bt_Eliminar, bt_Regresar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(821, 59);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // bt_Guardar
            // 
            bt_Guardar.Image = (Image)resources.GetObject("bt_Guardar.Image");
            bt_Guardar.ImageAlign = ContentAlignment.TopCenter;
            bt_Guardar.ImageScaling = ToolStripItemImageScaling.None;
            bt_Guardar.ImageTransparentColor = Color.Magenta;
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.Size = new Size(66, 56);
            bt_Guardar.Text = "Guardar";
            bt_Guardar.TextAlign = ContentAlignment.BottomCenter;
            bt_Guardar.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Guardar.Click += bt_Guardar_Click;
            // 
            // bt_Modificar
            // 
            bt_Modificar.Enabled = false;
            bt_Modificar.Image = (Image)resources.GetObject("bt_Modificar.Image");
            bt_Modificar.ImageAlign = ContentAlignment.TopCenter;
            bt_Modificar.ImageScaling = ToolStripItemImageScaling.None;
            bt_Modificar.ImageTransparentColor = Color.Magenta;
            bt_Modificar.Name = "bt_Modificar";
            bt_Modificar.Size = new Size(77, 56);
            bt_Modificar.Text = "Modificar";
            bt_Modificar.TextAlign = ContentAlignment.BottomCenter;
            bt_Modificar.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Modificar.Click += bt_Modificar_Click;
            // 
            // bt_Eliminar
            // 
            bt_Eliminar.Enabled = false;
            bt_Eliminar.Image = (Image)resources.GetObject("bt_Eliminar.Image");
            bt_Eliminar.ImageAlign = ContentAlignment.TopCenter;
            bt_Eliminar.ImageScaling = ToolStripItemImageScaling.None;
            bt_Eliminar.ImageTransparentColor = Color.Magenta;
            bt_Eliminar.Name = "bt_Eliminar";
            bt_Eliminar.Size = new Size(67, 56);
            bt_Eliminar.Text = "Eliminar";
            bt_Eliminar.TextAlign = ContentAlignment.BottomCenter;
            bt_Eliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Eliminar.Click += bt_Eliminar_Click;
            // 
            // bt_Regresar
            // 
            bt_Regresar.Alignment = ToolStripItemAlignment.Right;
            bt_Regresar.Image = (Image)resources.GetObject("bt_Regresar.Image");
            bt_Regresar.ImageAlign = ContentAlignment.TopCenter;
            bt_Regresar.ImageScaling = ToolStripItemImageScaling.None;
            bt_Regresar.ImageTransparentColor = Color.Magenta;
            bt_Regresar.Name = "bt_Regresar";
            bt_Regresar.Size = new Size(71, 56);
            bt_Regresar.Text = "Regresar";
            bt_Regresar.TextAlign = ContentAlignment.BottomCenter;
            bt_Regresar.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_Regresar.Click += bt_Regresar_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageAlign = ContentAlignment.TopCenter;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(63, 56);
            toolStripButton1.Text = "Limpiar";
            toolStripButton1.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // dgv_Clientes
            // 
            dgv_Clientes.AllowUserToAddRows = false;
            dgv_Clientes.AllowUserToDeleteRows = false;
            dgv_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Clientes.Location = new Point(21, 175);
            dgv_Clientes.Name = "dgv_Clientes";
            dgv_Clientes.ReadOnly = true;
            dgv_Clientes.RowHeadersVisible = false;
            dgv_Clientes.RowHeadersWidth = 51;
            dgv_Clientes.Size = new Size(788, 177);
            dgv_Clientes.TabIndex = 10;
            dgv_Clientes.TabStop = false;
            dgv_Clientes.CellDoubleClick += dgv_Clientes_CellDoubleClick;
            // 
            // gb_Informacion
            // 
            gb_Informacion.Controls.Add(lb_id);
            gb_Informacion.Controls.Add(label4);
            gb_Informacion.Controls.Add(label3);
            gb_Informacion.Controls.Add(txt_ApellidoMaterno);
            gb_Informacion.Controls.Add(txt_ApellidoPaterno);
            gb_Informacion.Controls.Add(label2);
            gb_Informacion.Controls.Add(txt_Rfc);
            gb_Informacion.Controls.Add(label1);
            gb_Informacion.Controls.Add(txt_Nombre);
            gb_Informacion.Location = new Point(21, 65);
            gb_Informacion.Name = "gb_Informacion";
            gb_Informacion.Size = new Size(788, 104);
            gb_Informacion.TabIndex = 11;
            gb_Informacion.TabStop = false;
            gb_Informacion.Enter += gb_Informacion_Enter;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(588, -6);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(22, 20);
            lb_id.TabIndex = 18;
            lb_id.Text = "id";
            lb_id.Visible = false;
            lb_id.Click += lb_id_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 22);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 17;
            label4.Text = "RFC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 22);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 16;
            label3.Text = "Apellido Materno\r\n";
            // 
            // txt_ApellidoMaterno
            // 
            txt_ApellidoMaterno.Location = new Point(438, 59);
            txt_ApellidoMaterno.MaxLength = 30;
            txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            txt_ApellidoMaterno.Size = new Size(178, 27);
            txt_ApellidoMaterno.TabIndex = 3;
            txt_ApellidoMaterno.KeyPress += txt_ApellidoMaterno_KeyPress;
            // 
            // txt_ApellidoPaterno
            // 
            txt_ApellidoPaterno.Location = new Point(247, 59);
            txt_ApellidoPaterno.MaxLength = 30;
            txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            txt_ApellidoPaterno.Size = new Size(165, 27);
            txt_ApellidoPaterno.TabIndex = 2;
            txt_ApellidoPaterno.KeyPress += txt_ApellidoPaterno_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 22);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 13;
            label2.Text = "Apellido Paterno";
            // 
            // txt_Rfc
            // 
            txt_Rfc.Location = new Point(643, 59);
            txt_Rfc.MaxLength = 13;
            txt_Rfc.Name = "txt_Rfc";
            txt_Rfc.Size = new Size(125, 27);
            txt_Rfc.TabIndex = 4;
            txt_Rfc.KeyPress += txt_Rfc_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(6, 59);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(203, 27);
            txt_Nombre.TabIndex = 1;
            txt_Nombre.KeyPress += txt_Nombre_KeyPress;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 361);
            ControlBox = false;
            Controls.Add(gb_Informacion);
            Controls.Add(dgv_Clientes);
            Controls.Add(toolStrip1);
            Name = "frm_Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).EndInit();
            gb_Informacion.ResumeLayout(false);
            gb_Informacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton bt_Guardar;
        private ToolStripButton bt_Modificar;
        private ToolStripButton bt_Eliminar;
        private ToolStripButton bt_Regresar;
        private DataGridView dgv_Clientes;
        private GroupBox gb_Informacion;
        private Label label4;
        private Label label3;
        private TextBox txt_ApellidoMaterno;
        private TextBox txt_ApellidoPaterno;
        private Label label2;
        private TextBox txt_Rfc;
        private Label label1;
        private TextBox txt_Nombre;
        private Label lb_id;
        private ToolStripButton toolStripButton1;
    }
}