namespace Ejercicio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(292, 219);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(94, 29);
            btAceptar.TabIndex = 3;
            btAceptar.Text = "Acceder";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 103);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(51, 136);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(370, 27);
            txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(51, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(370, 27);
            txtUsuario.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(126, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 182);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 306);
            Controls.Add(groupBox1);
            Controls.Add(btAceptar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btAceptar;
        private Label label1;
        private Label label2;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private GroupBox groupBox1;
    }
}
