namespace SegundoParcial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Empleado = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Iniciarseccion = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cajacontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Empleado
            // 
            this.Empleado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Empleado.Location = new System.Drawing.Point(105, 95);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(93, 33);
            this.Empleado.TabIndex = 0;
            this.Empleado.Text = "Empleado";
            this.Empleado.Click += new System.EventHandler(this.Empleado_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Contraseña.Location = new System.Drawing.Point(108, 152);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(100, 28);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña";
            // 
            // Iniciarseccion
            // 
            this.Iniciarseccion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Iniciarseccion.Location = new System.Drawing.Point(327, 192);
            this.Iniciarseccion.Name = "Iniciarseccion";
            this.Iniciarseccion.Size = new System.Drawing.Size(148, 36);
            this.Iniciarseccion.TabIndex = 2;
            this.Iniciarseccion.Text = "Iniciar Seccion";
            this.Iniciarseccion.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // cajacontraseña
            // 
            this.cajacontraseña.Location = new System.Drawing.Point(239, 153);
            this.cajacontraseña.Name = "cajacontraseña";
            this.cajacontraseña.Size = new System.Drawing.Size(175, 23);
            this.cajacontraseña.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 385);
            this.Controls.Add(this.cajacontraseña);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Iniciarseccion);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Empleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Button Iniciarseccion;
        private System.Windows.Forms.TextBox cajacontraseña;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}