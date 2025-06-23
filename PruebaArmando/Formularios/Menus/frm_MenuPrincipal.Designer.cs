namespace Ejercicio.Formularios.Menus
{
    partial class frm_MenuPrincipal
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
            panel1 = new Panel();
            button10 = new Button();
            p_Ventas = new Panel();
            button9 = new Button();
            button3 = new Button();
            p_Compras = new Panel();
            button8 = new Button();
            button2 = new Button();
            p_Catalogo = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            p_Ventas.SuspendLayout();
            p_Compras.SuspendLayout();
            p_Catalogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button10);
            panel1.Controls.Add(p_Ventas);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(p_Compras);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(p_Catalogo);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 192, 192);
            button10.Dock = DockStyle.Bottom;
            button10.Location = new Point(0, 421);
            button10.Name = "button10";
            button10.Size = new Size(250, 29);
            button10.TabIndex = 6;
            button10.Text = "SALIR";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // p_Ventas
            // 
            p_Ventas.Controls.Add(button9);
            p_Ventas.Dock = DockStyle.Top;
            p_Ventas.Location = new Point(0, 314);
            p_Ventas.Name = "p_Ventas";
            p_Ventas.Size = new Size(250, 45);
            p_Ventas.TabIndex = 5;
            p_Ventas.Visible = false;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Size = new Size(250, 29);
            button9.TabIndex = 0;
            button9.Text = "Ordenes de pedidos";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 271);
            button3.Name = "button3";
            button3.Size = new Size(250, 43);
            button3.TabIndex = 4;
            button3.Text = "VENTAS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // p_Compras
            // 
            p_Compras.Controls.Add(button8);
            p_Compras.Dock = DockStyle.Top;
            p_Compras.Location = new Point(0, 229);
            p_Compras.Name = "p_Compras";
            p_Compras.Size = new Size(250, 42);
            p_Compras.TabIndex = 3;
            p_Compras.Visible = false;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Location = new Point(0, 0);
            button8.Name = "button8";
            button8.Size = new Size(250, 29);
            button8.TabIndex = 0;
            button8.Text = "Recepciones";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 177);
            button2.Name = "button2";
            button2.Size = new Size(250, 52);
            button2.TabIndex = 2;
            button2.Text = "COMPRAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // p_Catalogo
            // 
            p_Catalogo.Controls.Add(button7);
            p_Catalogo.Controls.Add(button6);
            p_Catalogo.Controls.Add(button5);
            p_Catalogo.Controls.Add(button4);
            p_Catalogo.Dock = DockStyle.Top;
            p_Catalogo.Location = new Point(0, 52);
            p_Catalogo.Name = "p_Catalogo";
            p_Catalogo.Size = new Size(250, 125);
            p_Catalogo.TabIndex = 1;
            p_Catalogo.Visible = false;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 87);
            button7.Name = "button7";
            button7.Size = new Size(250, 29);
            button7.TabIndex = 3;
            button7.Text = "Huertas";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 58);
            button6.Name = "button6";
            button6.Size = new Size(250, 29);
            button6.TabIndex = 2;
            button6.Text = "Proveedores";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 29);
            button5.Name = "button5";
            button5.Size = new Size(250, 29);
            button5.TabIndex = 1;
            button5.Text = "Clientes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(250, 29);
            button4.TabIndex = 0;
            button4.Text = "Presentaciones de pedido";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 52);
            button1.TabIndex = 0;
            button1.Text = "CATÁLOGOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "frm_MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            p_Ventas.ResumeLayout(false);
            p_Compras.ResumeLayout(false);
            p_Catalogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel p_Ventas;
        private Button button3;
        private Panel p_Compras;
        private Button button2;
        private Panel p_Catalogo;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button10;
    }
}