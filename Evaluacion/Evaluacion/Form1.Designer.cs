namespace Evaluacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnMPromedio = new System.Windows.Forms.Button();
            this.btnMMejores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrimerLugar = new System.Windows.Forms.Label();
            this.lblTercerLugar = new System.Windows.Forms.Label();
            this.lblSegundoLugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una nota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNotas
            // 
            this.tbNotas.Location = new System.Drawing.Point(175, 42);
            this.tbNotas.Name = "tbNotas";
            this.tbNotas.Size = new System.Drawing.Size(72, 22);
            this.tbNotas.TabIndex = 1;
            this.tbNotas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promedio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(253, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 39);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 6;
            // 
            // btnMPromedio
            // 
            this.btnMPromedio.Location = new System.Drawing.Point(334, 86);
            this.btnMPromedio.Name = "btnMPromedio";
            this.btnMPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnMPromedio.TabIndex = 7;
            this.btnMPromedio.Text = "Mostrar";
            this.btnMPromedio.UseVisualStyleBackColor = true;
            this.btnMPromedio.Click += new System.EventHandler(this.btnMPromedio_Click);
            // 
            // btnMMejores
            // 
            this.btnMMejores.Location = new System.Drawing.Point(494, 125);
            this.btnMMejores.Name = "btnMMejores";
            this.btnMMejores.Size = new System.Drawing.Size(75, 23);
            this.btnMMejores.TabIndex = 10;
            this.btnMMejores.Text = "Mostrar";
            this.btnMMejores.UseVisualStyleBackColor = true;
            this.btnMMejores.Click += new System.EventHandler(this.btnMMejores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Podio";
            // 
            // lblPrimerLugar
            // 
            this.lblPrimerLugar.AutoSize = true;
            this.lblPrimerLugar.Location = new System.Drawing.Point(174, 128);
            this.lblPrimerLugar.Name = "lblPrimerLugar";
            this.lblPrimerLugar.Size = new System.Drawing.Size(14, 16);
            this.lblPrimerLugar.TabIndex = 11;
            this.lblPrimerLugar.Text = "1";
            this.lblPrimerLugar.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTercerLugar
            // 
            this.lblTercerLugar.AutoSize = true;
            this.lblTercerLugar.Location = new System.Drawing.Point(385, 128);
            this.lblTercerLugar.Name = "lblTercerLugar";
            this.lblTercerLugar.Size = new System.Drawing.Size(14, 16);
            this.lblTercerLugar.TabIndex = 12;
            this.lblTercerLugar.Text = "3";
            // 
            // lblSegundoLugar
            // 
            this.lblSegundoLugar.AutoSize = true;
            this.lblSegundoLugar.Location = new System.Drawing.Point(278, 128);
            this.lblSegundoLugar.Name = "lblSegundoLugar";
            this.lblSegundoLugar.Size = new System.Drawing.Size(14, 16);
            this.lblSegundoLugar.TabIndex = 13;
            this.lblSegundoLugar.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSegundoLugar);
            this.Controls.Add(this.lblTercerLugar);
            this.Controls.Add(this.lblPrimerLugar);
            this.Controls.Add(this.btnMMejores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMPromedio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNotas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnMPromedio;
        private System.Windows.Forms.Button btnMMejores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrimerLugar;
        private System.Windows.Forms.Label lblTercerLugar;
        private System.Windows.Forms.Label lblSegundoLugar;
    }
}

