namespace Arrays_Funciones
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
            btnAceptar = new Button();
            txtInput = new TextBox();
            lblInput = new Label();
            grpRes = new GroupBox();
            btnVer = new Button();
            btnBorrar = new Button();
            btnCuad = new Button();
            lblRes5 = new Label();
            lblRes4 = new Label();
            lblRes3 = new Label();
            lblRes2 = new Label();
            lblRes1 = new Label();
            grpDatos.SuspendLayout();
            grpRes.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnAceptar);
            grpDatos.Controls.Add(txtInput);
            grpDatos.Controls.Add(lblInput);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(262, 88);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(96, 59);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(135, 30);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(6, 33);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(123, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Introduce un número:";
            // 
            // grpRes
            // 
            grpRes.Controls.Add(btnVer);
            grpRes.Controls.Add(btnBorrar);
            grpRes.Controls.Add(btnCuad);
            grpRes.Controls.Add(lblRes5);
            grpRes.Controls.Add(lblRes4);
            grpRes.Controls.Add(lblRes3);
            grpRes.Controls.Add(lblRes2);
            grpRes.Controls.Add(lblRes1);
            grpRes.Enabled = false;
            grpRes.Location = new Point(12, 106);
            grpRes.Name = "grpRes";
            grpRes.Size = new Size(262, 108);
            grpRes.TabIndex = 1;
            grpRes.TabStop = false;
            grpRes.Text = "Resultados";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(11, 79);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(94, 79);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCuad
            // 
            btnCuad.Location = new Point(177, 79);
            btnCuad.Name = "btnCuad";
            btnCuad.Size = new Size(75, 23);
            btnCuad.TabIndex = 3;
            btnCuad.Text = "Cuadrado";
            btnCuad.UseVisualStyleBackColor = true;
            btnCuad.Click += btnCuad_Click;
            // 
            // lblRes5
            // 
            lblRes5.BackColor = SystemColors.Window;
            lblRes5.BorderStyle = BorderStyle.Fixed3D;
            lblRes5.Location = new Point(219, 32);
            lblRes5.Name = "lblRes5";
            lblRes5.Size = new Size(40, 40);
            lblRes5.TabIndex = 4;
            lblRes5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes4
            // 
            lblRes4.BackColor = SystemColors.Window;
            lblRes4.BorderStyle = BorderStyle.Fixed3D;
            lblRes4.Location = new Point(165, 32);
            lblRes4.Name = "lblRes4";
            lblRes4.Size = new Size(40, 40);
            lblRes4.TabIndex = 3;
            lblRes4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes3
            // 
            lblRes3.BackColor = SystemColors.Window;
            lblRes3.BorderStyle = BorderStyle.Fixed3D;
            lblRes3.Location = new Point(111, 32);
            lblRes3.Name = "lblRes3";
            lblRes3.Size = new Size(40, 40);
            lblRes3.TabIndex = 2;
            lblRes3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes2
            // 
            lblRes2.BackColor = SystemColors.Window;
            lblRes2.BorderStyle = BorderStyle.Fixed3D;
            lblRes2.Location = new Point(57, 32);
            lblRes2.Name = "lblRes2";
            lblRes2.Size = new Size(40, 40);
            lblRes2.TabIndex = 1;
            lblRes2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes1
            // 
            lblRes1.BackColor = SystemColors.Window;
            lblRes1.BorderStyle = BorderStyle.Fixed3D;
            lblRes1.Location = new Point(3, 32);
            lblRes1.Name = "lblRes1";
            lblRes1.Size = new Size(40, 40);
            lblRes1.TabIndex = 0;
            lblRes1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 223);
            Controls.Add(grpRes);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Arrays y Funciones";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpRes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Button btnAceptar;
        private TextBox txtInput;
        private Label lblInput;
        private GroupBox grpRes;
        private Label lblRes1;
        private Button btnCuad;
        private Label lblRes5;
        private Label lblRes4;
        private Label lblRes3;
        private Label lblRes2;
        private Button btnVer;
        private Button btnBorrar;
    }
}
