namespace EjemplosTiposDatos
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
            grpDatos = new GroupBox();
            lblResultado = new Label();
            btnAceptar = new Button();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnAceptar);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(170, 179);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Tus Datos";
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(12, 203);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(170, 31);
            lblResultado.TabIndex = 7;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(37, 129);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 41);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(63, 100);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 103);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(63, 67);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(6, 70);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 243);
            Controls.Add(lblResultado);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Ejemplo tipos de datos";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDni;
        private Label lblDni;
        private Button btnAceptar;
        private TextBox txtEdad;
        private Label lblEdad;
        private Label lblResultado;
    }
}
