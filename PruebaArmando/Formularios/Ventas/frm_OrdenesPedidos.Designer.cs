namespace Ejercicio.Formularios.Ventas
{
    partial class frm_OrdenesPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrdenesPedidos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            bt_Guardar = new ToolStripButton();
            bt_Modificar = new ToolStripButton();
            bt_Eliminar = new ToolStripButton();
            bt_Regresar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            dgv_Ordenes = new DataGridView();
            gb_Informacion = new GroupBox();
            dtp_Entrega = new DateTimePicker();
            label6 = new Label();
            dtp_Creacion = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            txt_Cantidad = new TextBox();
            cmb_Presentacion = new ComboBox();
            cmb_Cliente = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            lb_id = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Ordenes).BeginInit();
            gb_Informacion.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_Guardar, bt_Modificar, bt_Eliminar, bt_Regresar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(947, 59);
            toolStrip1.TabIndex = 18;
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
            // dgv_Ordenes
            // 
            dgv_Ordenes.AllowUserToAddRows = false;
            dgv_Ordenes.AllowUserToDeleteRows = false;
            dgv_Ordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Ordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Ordenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Ordenes.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Ordenes.GridColor = SystemColors.Control;
            dgv_Ordenes.Location = new Point(12, 271);
            dgv_Ordenes.Name = "dgv_Ordenes";
            dgv_Ordenes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Ordenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Ordenes.RowHeadersWidth = 51;
            dgv_Ordenes.Size = new Size(920, 177);
            dgv_Ordenes.TabIndex = 19;
            dgv_Ordenes.CellDoubleClick += dgv_Ordenes_CellDoubleClick;
            // 
            // gb_Informacion
            // 
            gb_Informacion.Controls.Add(dtp_Entrega);
            gb_Informacion.Controls.Add(label6);
            gb_Informacion.Controls.Add(dtp_Creacion);
            gb_Informacion.Controls.Add(label5);
            gb_Informacion.Controls.Add(label3);
            gb_Informacion.Controls.Add(txt_Cantidad);
            gb_Informacion.Controls.Add(cmb_Presentacion);
            gb_Informacion.Controls.Add(cmb_Cliente);
            gb_Informacion.Controls.Add(label2);
            gb_Informacion.Controls.Add(label4);
            gb_Informacion.Controls.Add(label1);
            gb_Informacion.Location = new Point(12, 79);
            gb_Informacion.Name = "gb_Informacion";
            gb_Informacion.Size = new Size(920, 186);
            gb_Informacion.TabIndex = 20;
            gb_Informacion.TabStop = false;
            gb_Informacion.Text = "Órdenes de Pedidos";
            // 
            // dtp_Entrega
            // 
            dtp_Entrega.Format = DateTimePickerFormat.Short;
            dtp_Entrega.Location = new Point(388, 65);
            dtp_Entrega.Name = "dtp_Entrega";
            dtp_Entrega.Size = new Size(131, 27);
            dtp_Entrega.TabIndex = 30;
            // 
            // label6
            // 
            label6.Location = new Point(387, 33);
            label6.Name = "label6";
            label6.Size = new Size(251, 20);
            label6.TabIndex = 29;
            label6.Text = "Fecha de entrega del pedido";
            // 
            // dtp_Creacion
            // 
            dtp_Creacion.Format = DateTimePickerFormat.Short;
            dtp_Creacion.Location = new Point(6, 65);
            dtp_Creacion.Name = "dtp_Creacion";
            dtp_Creacion.Size = new Size(131, 27);
            dtp_Creacion.TabIndex = 28;
            // 
            // label5
            // 
            label5.Location = new Point(5, 32);
            label5.Name = "label5";
            label5.Size = new Size(251, 20);
            label5.TabIndex = 27;
            label5.Text = "Fecha de creación del pedido";
            // 
            // label3
            // 
            label3.Location = new Point(736, 102);
            label3.Name = "label3";
            label3.Size = new Size(435, 20);
            label3.TabIndex = 26;
            label3.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(736, 134);
            txt_Cantidad.MaxLength = 4;
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(135, 27);
            txt_Cantidad.TabIndex = 25;
            txt_Cantidad.KeyPress += txt_Cantidad_KeyPress;
            // 
            // cmb_Presentacion
            // 
            cmb_Presentacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Presentacion.FormattingEnabled = true;
            cmb_Presentacion.Location = new Point(388, 135);
            cmb_Presentacion.Name = "cmb_Presentacion";
            cmb_Presentacion.Size = new Size(248, 28);
            cmb_Presentacion.TabIndex = 22;
            // 
            // cmb_Cliente
            // 
            cmb_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Cliente.FormattingEnabled = true;
            cmb_Cliente.Location = new Point(5, 136);
            cmb_Cliente.Name = "cmb_Cliente";
            cmb_Cliente.Size = new Size(263, 28);
            cmb_Cliente.TabIndex = 20;
            // 
            // label2
            // 
            label2.Location = new Point(5, 107);
            label2.Name = "label2";
            label2.Size = new Size(263, 20);
            label2.TabIndex = 19;
            label2.Text = "Cliente";
            // 
            // label4
            // 
            label4.Location = new Point(387, 102);
            label4.Name = "label4";
            label4.Size = new Size(239, 20);
            label4.TabIndex = 17;
            label4.Text = "Tipo de presentación del pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // lb_id
            // 
            lb_id.Location = new Point(890, 59);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(26, 26);
            lb_id.TabIndex = 21;
            lb_id.Text = "id";
            lb_id.Visible = false;
            // 
            // frm_OrdenesPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 471);
            Controls.Add(lb_id);
            Controls.Add(toolStrip1);
            Controls.Add(dgv_Ordenes);
            Controls.Add(gb_Informacion);
            Name = "frm_OrdenesPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Órdenes de Pedidos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Ordenes).EndInit();
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
        private DataGridView dgv_Ordenes;
        private GroupBox gb_Informacion;
        private ComboBox cmb_Cliente;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label lb_id;
        private ComboBox cmb_Presentacion;
        private Label label3;
        private TextBox txt_Cantidad;
        private DateTimePicker dtp_Entrega;
        private Label label6;
        private DateTimePicker dtp_Creacion;
        private Label label5;
        private ToolStripButton toolStripButton1;
    }
}