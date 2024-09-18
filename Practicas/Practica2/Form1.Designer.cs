namespace Practica2
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
            lblW = new Label();
            lblT = new Label();
            lblL = new Label();
            txtW = new TextBox();
            txtT = new TextBox();
            txtL = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblW
            // 
            lblW.AutoSize = true;
            lblW.Location = new Point(40, 39);
            lblW.Name = "lblW";
            lblW.Size = new Size(55, 15);
            lblW.TabIndex = 0;
            lblW.Text = "Ganadas:";
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.Location = new Point(40, 65);
            lblT.Name = "lblT";
            lblT.Size = new Size(68, 15);
            lblT.TabIndex = 1;
            lblT.Text = "Empatadas:";
            // 
            // lblL
            // 
            lblL.AutoSize = true;
            lblL.Location = new Point(40, 96);
            lblL.Name = "lblL";
            lblL.Size = new Size(55, 15);
            lblL.TabIndex = 2;
            lblL.Text = "Perdidas:";
            // 
            // txtW
            // 
            txtW.Location = new Point(131, 36);
            txtW.Name = "txtW";
            txtW.Size = new Size(100, 23);
            txtW.TabIndex = 3;
            // 
            // txtT
            // 
            txtT.Location = new Point(131, 65);
            txtT.Name = "txtT";
            txtT.Size = new Size(100, 23);
            txtT.TabIndex = 4;
            // 
            // txtL
            // 
            txtL.Location = new Point(131, 96);
            txtL.Name = "txtL";
            txtL.Size = new Size(100, 23);
            txtL.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(98, 129);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 164);
            Controls.Add(btnAceptar);
            Controls.Add(txtL);
            Controls.Add(txtT);
            Controls.Add(txtW);
            Controls.Add(lblL);
            Controls.Add(lblT);
            Controls.Add(lblW);
            Name = "frm1";
            Text = "Práctica 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblW;
        private Label lblT;
        private Label lblL;
        private TextBox txtW;
        private TextBox txtT;
        private TextBox txtL;
        private Button btnAceptar;
    }
}
