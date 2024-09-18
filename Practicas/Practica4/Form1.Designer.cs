namespace Practica4
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
            lblInput = new Label();
            lblOutput = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnF = new Button();
            btnC = new Button();
            lbl1 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInput.ForeColor = SystemColors.HotTrack;
            lblInput.Location = new Point(24, 29);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(228, 28);
            lblInput.TabIndex = 0;
            lblInput.Text = "Ingresa la temperatura";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOutput.ForeColor = SystemColors.HotTrack;
            lblOutput.Location = new Point(146, 67);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(106, 28);
            lblOutput.TabIndex = 1;
            lblOutput.Text = "Resultado";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(258, 33);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(149, 27);
            txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(258, 71);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(149, 27);
            txtOutput.TabIndex = 3;
            // 
            // btnF
            // 
            btnF.Location = new Point(110, 126);
            btnF.Name = "btnF";
            btnF.Size = new Size(94, 29);
            btnF.TabIndex = 4;
            btnF.Text = "Cº a F";
            btnF.UseVisualStyleBackColor = true;
            btnF.Click += btnF_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(226, 126);
            btnC.Name = "btnC";
            btnC.Size = new Size(94, 29);
            btnC.TabIndex = 5;
            btnC.Text = "F a Cº";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(24, 180);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(195, 20);
            lbl1.TabIndex = 6;
            lbl1.Text = "Presiona el botón adecuado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 211);
            label1.Name = "label1";
            label1.Size = new Size(343, 20);
            label1.TabIndex = 7;
            label1.Text = "F a Cº convierte de Farenheit a grados Centigrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 241);
            label2.Name = "label2";
            label2.Size = new Size(322, 20);
            label2.TabIndex = 8;
            label2.Text = "Cª a F convierte grados Centigrados a Farenheit";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.HotTrack;
            btnLimpiar.Location = new Point(110, 282);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.ForeColor = SystemColors.HotTrack;
            btnSalir.Location = new Point(226, 282);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 337);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(btnC);
            Controls.Add(btnF);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Name = "frm1";
            Text = "Práctica 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private Label lblOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnF;
        private Button btnC;
        private Label lbl1;
        private Label label1;
        private Label label2;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
