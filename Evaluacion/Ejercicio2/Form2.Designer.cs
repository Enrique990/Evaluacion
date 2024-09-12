namespace Ejercicio2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarNombre;
        private System.Windows.Forms.Button btnMostrarNombres;
        private System.Windows.Forms.ListBox lstNombres;

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarNombre = new System.Windows.Forms.Button();
            this.btnMostrarNombres = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(1033, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregarNombre
            // 
            this.btnAgregarNombre.Location = new System.Drawing.Point(16, 47);
            this.btnAgregarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarNombre.Name = "btnAgregarNombre";
            this.btnAgregarNombre.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarNombre.TabIndex = 1;
            this.btnAgregarNombre.Text = "Agregar";
            this.btnAgregarNombre.UseVisualStyleBackColor = true;
            this.btnAgregarNombre.Click += new System.EventHandler(this.btnAgregarNombre_Click);
            // 
            // btnMostrarNombres
            // 
            this.btnMostrarNombres.Location = new System.Drawing.Point(124, 47);
            this.btnMostrarNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarNombres.Name = "btnMostrarNombres";
            this.btnMostrarNombres.Size = new System.Drawing.Size(100, 28);
            this.btnMostrarNombres.TabIndex = 2;
            this.btnMostrarNombres.Text = "Mostrar";
            this.btnMostrarNombres.UseVisualStyleBackColor = true;
            this.btnMostrarNombres.Click += new System.EventHandler(this.btnMostrarNombres_Click);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 16;
            this.lstNombres.Location = new System.Drawing.Point(16, 82);
            this.lstNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(1033, 452);
            this.lstNombres.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.btnMostrarNombres);
            this.Controls.Add(this.btnAgregarNombre);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

