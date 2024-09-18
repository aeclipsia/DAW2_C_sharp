namespace Practica1
{
    partial class frm1
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
            btnAceptar = new Button();
            txtSalario = new TextBox();
            txtHoras = new TextBox();
            lblSalario = new Label();
            lblHora = new Label();
            txtResultado = new TextBox();
            lblResultado = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnAceptar);
            grpDatos.Controls.Add(txtSalario);
            grpDatos.Controls.Add(txtHoras);
            grpDatos.Controls.Add(lblSalario);
            grpDatos.Controls.Add(lblHora);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(232, 115);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(146, 77);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Calcular";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(121, 48);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 3;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(121, 16);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 2;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(12, 48);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(90, 15);
            lblSalario.TabIndex = 1;
            lblSalario.Text = "Salario por hora";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(12, 19);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(95, 15);
            lblHora.TabIndex = 0;
            lblHora.Text = "Horas trabajadas";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(133, 133);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(24, 136);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Salario total:";
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 172);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(grpDatos);
            Name = "frm1";
            Text = "Práctica 1";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtResultado;
        private TextBox txtSalario;
        private TextBox txtHoras;
        private Label lblSalario;
        private Label lblHora;
        private Button btnAceptar;
        private Label lblResultado;
    }
}
