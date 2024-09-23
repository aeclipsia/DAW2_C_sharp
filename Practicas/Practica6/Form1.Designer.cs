namespace Practica6
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
            lblAcertada = new Label();
            txtAcertada = new TextBox();
            txtFallada = new TextBox();
            lblFallada = new Label();
            txtBlanco = new TextBox();
            lblBlanco = new Label();
            btnCalc = new Button();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnCalc);
            grpDatos.Controls.Add(txtBlanco);
            grpDatos.Controls.Add(lblBlanco);
            grpDatos.Controls.Add(txtFallada);
            grpDatos.Controls.Add(lblFallada);
            grpDatos.Controls.Add(txtAcertada);
            grpDatos.Controls.Add(lblAcertada);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(204, 177);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblAcertada
            // 
            lblAcertada.AutoSize = true;
            lblAcertada.Location = new Point(13, 37);
            lblAcertada.Name = "lblAcertada";
            lblAcertada.Size = new Size(54, 15);
            lblAcertada.TabIndex = 0;
            lblAcertada.Text = "Acertada";
            // 
            // txtAcertada
            // 
            txtAcertada.Location = new Point(84, 34);
            txtAcertada.Name = "txtAcertada";
            txtAcertada.Size = new Size(100, 23);
            txtAcertada.TabIndex = 1;
            // 
            // txtFallada
            // 
            txtFallada.Location = new Point(84, 68);
            txtFallada.Name = "txtFallada";
            txtFallada.Size = new Size(100, 23);
            txtFallada.TabIndex = 3;
            // 
            // lblFallada
            // 
            lblFallada.AutoSize = true;
            lblFallada.Location = new Point(13, 71);
            lblFallada.Name = "lblFallada";
            lblFallada.Size = new Size(44, 15);
            lblFallada.TabIndex = 2;
            lblFallada.Text = "Fallada";
            // 
            // txtBlanco
            // 
            txtBlanco.Location = new Point(84, 102);
            txtBlanco.Name = "txtBlanco";
            txtBlanco.Size = new Size(100, 23);
            txtBlanco.TabIndex = 5;
            // 
            // lblBlanco
            // 
            lblBlanco.AutoSize = true;
            lblBlanco.Location = new Point(13, 105);
            lblBlanco.Name = "lblBlanco";
            lblBlanco.Size = new Size(59, 15);
            lblBlanco.TabIndex = 4;
            lblBlanco.Text = "En blanco";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(109, 138);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 200);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Form1";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtBlanco;
        private Label lblBlanco;
        private TextBox txtFallada;
        private Label lblFallada;
        private TextBox txtAcertada;
        private Label lblAcertada;
        private Button btnCalc;
    }
}
