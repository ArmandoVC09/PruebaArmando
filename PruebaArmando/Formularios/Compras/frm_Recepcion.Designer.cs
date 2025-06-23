namespace Ejercicio.Formularios.Compras
{
    partial class frm_Recepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Recepcion));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lb_id = new Label();
            dtp_Recepcion = new DateTimePicker();
            gb_Informacion = new GroupBox();
            label7 = new Label();
            txt_cantidad = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txt_individual = new TextBox();
            cmb_Madera = new ComboBox();
            cmb_Huerto = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            bt_Regresar = new ToolStripButton();
            bt_Eliminar = new ToolStripButton();
            bt_Modificar = new ToolStripButton();
            bt_Guardar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            dgv_Recepcion = new DataGridView();
            gb_Informacion.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recepcion).BeginInit();
            SuspendLayout();
            // 
            // lb_id
            // 
            lb_id.Location = new Point(720, 59);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(26, 26);
            lb_id.TabIndex = 25;
            lb_id.Text = "id";
            lb_id.Visible = false;
            // 
            // dtp_Recepcion
            // 
            dtp_Recepcion.Format = DateTimePickerFormat.Short;
            dtp_Recepcion.Location = new Point(6, 65);
            dtp_Recepcion.Name = "dtp_Recepcion";
            dtp_Recepcion.Size = new Size(131, 27);
            dtp_Recepcion.TabIndex = 1;
            // 
            // gb_Informacion
            // 
            gb_Informacion.Controls.Add(label7);
            gb_Informacion.Controls.Add(txt_cantidad);
            gb_Informacion.Controls.Add(dtp_Recepcion);
            gb_Informacion.Controls.Add(label5);
            gb_Informacion.Controls.Add(label3);
            gb_Informacion.Controls.Add(txt_individual);
            gb_Informacion.Controls.Add(cmb_Madera);
            gb_Informacion.Controls.Add(cmb_Huerto);
            gb_Informacion.Controls.Add(label2);
            gb_Informacion.Controls.Add(label4);
            gb_Informacion.Controls.Add(label1);
            gb_Informacion.Location = new Point(10, 80);
            gb_Informacion.Name = "gb_Informacion";
            gb_Informacion.Size = new Size(992, 186);
            gb_Informacion.TabIndex = 24;
            gb_Informacion.TabStop = false;
            gb_Informacion.Text = "Órdenes de Pedidos";
            // 
            // label7
            // 
            label7.Location = new Point(862, 113);
            label7.Name = "label7";
            label7.Size = new Size(180, 23);
            label7.TabIndex = 32;
            label7.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(862, 149);
            txt_cantidad.MaxLength = 4;
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(109, 27);
            txt_cantidad.TabIndex = 5;
            txt_cantidad.KeyPress += txt_cantidad_KeyPress;
            // 
            // label5
            // 
            label5.Location = new Point(5, 32);
            label5.Name = "label5";
            label5.Size = new Size(251, 20);
            label5.TabIndex = 27;
            label5.Text = "Fecha de Recepción";
            // 
            // label3
            // 
            label3.Location = new Point(736, 102);
            label3.Name = "label3";
            label3.Size = new Size(180, 47);
            label3.TabIndex = 26;
            label3.Text = "Peso promedio\r\nindividual (kg)";
            // 
            // txt_individual
            // 
            txt_individual.Location = new Point(736, 149);
            txt_individual.MaxLength = 6;
            txt_individual.Name = "txt_individual";
            txt_individual.Size = new Size(109, 27);
            txt_individual.TabIndex = 4;
            txt_individual.KeyPress += txt_individual_KeyPress;
            // 
            // cmb_Madera
            // 
            cmb_Madera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Madera.FormattingEnabled = true;
            cmb_Madera.Location = new Point(388, 150);
            cmb_Madera.Name = "cmb_Madera";
            cmb_Madera.Size = new Size(248, 28);
            cmb_Madera.TabIndex = 3;
            // 
            // cmb_Huerto
            // 
            cmb_Huerto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Huerto.FormattingEnabled = true;
            cmb_Huerto.Location = new Point(5, 151);
            cmb_Huerto.Name = "cmb_Huerto";
            cmb_Huerto.Size = new Size(263, 28);
            cmb_Huerto.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(5, 116);
            label2.Name = "label2";
            label2.Size = new Size(263, 20);
            label2.TabIndex = 19;
            label2.Text = "Huerto";
            // 
            // label4
            // 
            label4.Location = new Point(387, 112);
            label4.Name = "label4";
            label4.Size = new Size(239, 20);
            label4.TabIndex = 17;
            label4.Text = "Tipo de madera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_Guardar, bt_Modificar, bt_Eliminar, bt_Regresar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1015, 59);
            toolStrip1.TabIndex = 22;
            toolStrip1.Text = "toolStrip1";
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
            // dgv_Recepcion
            // 
            dgv_Recepcion.AllowUserToAddRows = false;
            dgv_Recepcion.AllowUserToDeleteRows = false;
            dgv_Recepcion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Recepcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Recepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Recepcion.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Recepcion.GridColor = SystemColors.Control;
            dgv_Recepcion.Location = new Point(10, 272);
            dgv_Recepcion.Name = "dgv_Recepcion";
            dgv_Recepcion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Recepcion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Recepcion.RowHeadersWidth = 51;
            dgv_Recepcion.Size = new Size(992, 177);
            dgv_Recepcion.TabIndex = 10;
            dgv_Recepcion.CellDoubleClick += dgv_Recepcion_CellDoubleClick;
            // 
            // frm_Recepcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 450);
            ControlBox = false;
            Controls.Add(lb_id);
            Controls.Add(gb_Informacion);
            Controls.Add(toolStrip1);
            Controls.Add(dgv_Recepcion);
            Name = "frm_Recepcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Recepcion";
            gb_Informacion.ResumeLayout(false);
            gb_Informacion.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recepcion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_id;
        private DateTimePicker dtp_Recepcion;
        private GroupBox gb_Informacion;
        private Label label5;
        private Label label3;
        private TextBox txt_individual;
        private ComboBox cmb_Madera;
        private ComboBox cmb_Huerto;
        private Label label2;
        private Label label4;
        private Label label1;
        private ToolStripButton bt_Regresar;
        private ToolStripButton bt_Eliminar;
        private ToolStripButton bt_Modificar;
        private ToolStripButton bt_Guardar;
        private ToolStrip toolStrip1;
        private DataGridView dgv_Recepcion;
        private ToolStripButton toolStripButton1;
        private Label label7;
        private TextBox txt_cantidad;
    }
}