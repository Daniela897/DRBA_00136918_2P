using System.ComponentModel;

namespace SegundoParcial
{
    partial class Creaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Producto = new System.Windows.Forms.TabPage();
            this.Direccion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Negocio = new System.Windows.Forms.TabPage();
            this.Orden = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Producto.SuspendLayout();
            this.Direccion.SuspendLayout();
            this.Negocio.SuspendLayout();
            this.Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Producto);
            this.tabControl1.Controls.Add(this.Direccion);
            this.tabControl1.Controls.Add(this.Negocio);
            this.tabControl1.Controls.Add(this.Orden);
            this.tabControl1.Location = new System.Drawing.Point(1, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.Controls.Add(this.label2);
            this.Producto.Controls.Add(this.textBox1);
            this.Producto.Controls.Add(this.button2);
            this.Producto.Controls.Add(this.button1);
            this.Producto.Controls.Add(this.dataGridView1);
            this.Producto.Location = new System.Drawing.Point(4, 24);
            this.Producto.Name = "Producto";
            this.Producto.Padding = new System.Windows.Forms.Padding(3);
            this.Producto.Size = new System.Drawing.Size(597, 305);
            this.Producto.TabIndex = 0;
            this.Producto.Text = "Producto";
            this.Producto.UseVisualStyleBackColor = true;
            // 
            // Direccion
            // 
            this.Direccion.Controls.Add(this.button4);
            this.Direccion.Controls.Add(this.dataGridView2);
            this.Direccion.Controls.Add(this.button3);
            this.Direccion.Controls.Add(this.textBox2);
            this.Direccion.Controls.Add(this.label3);
            this.Direccion.Location = new System.Drawing.Point(4, 24);
            this.Direccion.Name = "Direccion";
            this.Direccion.Padding = new System.Windows.Forms.Padding(3);
            this.Direccion.Size = new System.Drawing.Size(597, 305);
            this.Direccion.TabIndex = 1;
            this.Direccion.Text = "Direccion";
            this.Direccion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Negocio
            // 
            this.Negocio.Controls.Add(this.button6);
            this.Negocio.Controls.Add(this.dataGridView3);
            this.Negocio.Controls.Add(this.button5);
            this.Negocio.Controls.Add(this.textBox3);
            this.Negocio.Controls.Add(this.label4);
            this.Negocio.Location = new System.Drawing.Point(4, 24);
            this.Negocio.Name = "Negocio";
            this.Negocio.Size = new System.Drawing.Size(597, 305);
            this.Negocio.TabIndex = 2;
            this.Negocio.Text = "Negocio";
            this.Negocio.UseVisualStyleBackColor = true;
            // 
            // Orden
            // 
            this.Orden.Controls.Add(this.button8);
            this.Orden.Controls.Add(this.dataGridView4);
            this.Orden.Controls.Add(this.button7);
            this.Orden.Controls.Add(this.textBox4);
            this.Orden.Controls.Add(this.label5);
            this.Orden.Location = new System.Drawing.Point(4, 24);
            this.Orden.Name = "Orden";
            this.Orden.Size = new System.Drawing.Size(597, 305);
            this.Orden.TabIndex = 3;
            this.Orden.Text = "Orden";
            this.Orden.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Crear Producto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 23);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Crear Direccion";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(588, 139);
            this.dataGridView2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "Actualizar Direccion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Negocio";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 23);
            this.textBox3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Crear Negocio";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 83);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(588, 139);
            this.dataGridView3.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(337, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "Actualizar Negocio";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Orden";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 23);
            this.textBox4.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(382, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "Crear Orden ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(4, 83);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(588, 139);
            this.dataGridView4.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(319, 247);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 38);
            this.button8.TabIndex = 11;
            this.button8.Text = "Actualizar Orden";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Creaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Creaciones";
            this.Text = "Creaciones";
            this.tabControl1.ResumeLayout(false);
            this.Producto.ResumeLayout(false);
            this.Producto.PerformLayout();
            this.Direccion.ResumeLayout(false);
            this.Direccion.PerformLayout();
            this.Negocio.ResumeLayout(false);
            this.Negocio.PerformLayout();
            this.Orden.ResumeLayout(false);
            this.Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Producto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Orden;
        private System.Windows.Forms.TabPage Negocio;
        private System.Windows.Forms.TabPage Direccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button8;
    }
}