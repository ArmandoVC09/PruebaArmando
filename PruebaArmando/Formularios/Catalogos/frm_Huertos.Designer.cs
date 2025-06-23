namespace Ejercicio.Formularios.Catalogos
{
    partial class Huertos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huertos));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            bt_Guardar = new ToolStripButton();
            bt_Modificar = new ToolStripButton();
            bt_Eliminar = new ToolStripButton();
            bt_Regresar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            gb_Informacion = new GroupBox();
            lb_id = new Label();
            button1 = new Button();
            cmb_Proveedor = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            txt_Nombre = new TextBox();
            label1 = new Label();
            dgv_Huertos = new DataGridView();
            toolStrip1.SuspendLayout();
            gb_Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Huertos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_Guardar, bt_Modificar, bt_Eliminar, bt_Regresar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(603, 59);
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
            // gb_Informacion
            // 
            gb_Informacion.Controls.Add(lb_id);
            gb_Informacion.Controls.Add(button1);
            gb_Informacion.Controls.Add(cmb_Proveedor);
            gb_Informacion.Controls.Add(label2);
            gb_Informacion.Controls.Add(label4);
            gb_Informacion.Controls.Add(txt_Nombre);
            gb_Informacion.Controls.Add(label1);
            gb_Informacion.Location = new Point(12, 62);
            gb_Informacion.Name = "gb_Informacion";
            gb_Informacion.Size = new Size(585, 167);
            gb_Informacion.TabIndex = 17;
            gb_Informacion.TabStop = false;
            gb_Informacion.Text = "Huertos";
            // 
            // lb_id
            // 
            lb_id.Location = new Point(553, -14);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(26, 26);
            lb_id.TabIndex = 26;
            lb_id.Text = "id";
            lb_id.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(465, 113);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cmb_Proveedor
            // 
            cmb_Proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Proveedor.FormattingEnabled = true;
            cmb_Proveedor.Location = new Point(14, 113);
            cmb_Proveedor.Name = "cmb_Proveedor";
            cmb_Proveedor.Size = new Size(435, 28);
            cmb_Proveedor.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(435, 20);
            label2.TabIndex = 19;
            label2.Text = "Proveedor";
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
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(435, 27);
            txt_Nombre.TabIndex = 1;
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
            // dgv_Huertos
            // 
            dgv_Huertos.AllowUserToAddRows = false;
            dgv_Huertos.AllowUserToDeleteRows = false;
            dgv_Huertos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Huertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Huertos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Huertos.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Huertos.GridColor = SystemColors.Control;
            dgv_Huertos.Location = new Point(12, 235);
            dgv_Huertos.Name = "dgv_Huertos";
            dgv_Huertos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Huertos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Huertos.RowHeadersWidth = 51;
            dgv_Huertos.Size = new Size(585, 177);
            dgv_Huertos.TabIndex = 4;
            dgv_Huertos.CellDoubleClick += dgv_Huertos_CellDoubleClick;
            // 
            // Huertos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 418);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(gb_Informacion);
            Controls.Add(dgv_Huertos);
            Name = "Huertos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Huertos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gb_Informacion.ResumeLayout(false);
            gb_Informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Huertos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton bt_Guardar;
        private ToolStripButton bt_Modificar;
        private ToolStripButton bt_Eliminar;
        private ToolStripButton bt_Regresar;
        private GroupBox gb_Informacion;
        private Label label2;
        private Label label4;
        private TextBox txt_Nombre;
        private Label label1;
        private DataGridView dgv_Huertos;
        private ComboBox cmb_Proveedor;
        private Button button1;
        private Label lb_id;
        private ToolStripButton toolStripButton1;
    }
}