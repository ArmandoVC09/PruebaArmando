namespace Ejercicio.Formularios.Catalogos
{
    partial class frm_PresentacionPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PresentacionPedidos));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            bt_Guardar = new ToolStripButton();
            bt_Eliminar = new ToolStripButton();
            bt_Regresar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            gb_Informacion = new GroupBox();
            label4 = new Label();
            txt_Nombre = new TextBox();
            label1 = new Label();
            dgv_Presentacion = new DataGridView();
            lb_id = new Label();
            toolStrip1.SuspendLayout();
            gb_Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Presentacion).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_Guardar, bt_Eliminar, bt_Regresar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(538, 59);
            toolStrip1.TabIndex = 15;
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
            // gb_Informacion
            // 
            gb_Informacion.Controls.Add(label4);
            gb_Informacion.Controls.Add(txt_Nombre);
            gb_Informacion.Controls.Add(label1);
            gb_Informacion.Location = new Point(26, 62);
            gb_Informacion.Name = "gb_Informacion";
            gb_Informacion.Size = new Size(478, 93);
            gb_Informacion.TabIndex = 17;
            gb_Informacion.TabStop = false;
            gb_Informacion.Text = "Presentacion de Pedidos";
            // 
            // label4
            // 
            label4.Location = new Point(14, 24);
            label4.Name = "label4";
            label4.Size = new Size(435, 20);
            label4.TabIndex = 17;
            label4.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(14, 49);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(435, 27);
            txt_Nombre.TabIndex = 12;
            txt_Nombre.KeyPress += txt_Nombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // dgv_Presentacion
            // 
            dgv_Presentacion.AllowUserToAddRows = false;
            dgv_Presentacion.AllowUserToDeleteRows = false;
            dgv_Presentacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_Presentacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Presentacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_Presentacion.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_Presentacion.GridColor = SystemColors.Control;
            dgv_Presentacion.Location = new Point(26, 172);
            dgv_Presentacion.Name = "dgv_Presentacion";
            dgv_Presentacion.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_Presentacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_Presentacion.RowHeadersWidth = 51;
            dgv_Presentacion.Size = new Size(478, 177);
            dgv_Presentacion.TabIndex = 16;
            dgv_Presentacion.CellDoubleClick += dgv_Presentacion_CellDoubleClick;
            // 
            // lb_id
            // 
            lb_id.Location = new Point(510, 62);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(26, 26);
            lb_id.TabIndex = 26;
            lb_id.Text = "id";
            lb_id.Visible = false;
            // 
            // frm_PresentacionPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 372);
            ControlBox = false;
            Controls.Add(lb_id);
            Controls.Add(toolStrip1);
            Controls.Add(gb_Informacion);
            Controls.Add(dgv_Presentacion);
            Name = "frm_PresentacionPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presentación de pedidos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gb_Informacion.ResumeLayout(false);
            gb_Informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Presentacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton bt_Guardar;
        private ToolStripButton bt_Eliminar;
        private ToolStripButton bt_Regresar;
        private GroupBox gb_Informacion;
        private Label label4;
        private TextBox txt_Nombre;
        private Label label1;
        private DataGridView dgv_Presentacion;
        private Label lb_id;
        private ToolStripButton toolStripButton1;
    }
}