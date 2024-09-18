namespace Practica5
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
            txtEuros = new TextBox();
            lblEuros = new Label();
            lblPesetas = new Label();
            txtPesetas = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // txtEuros
            // 
            txtEuros.Location = new Point(86, 10);
            txtEuros.Name = "txtEuros";
            txtEuros.Size = new Size(125, 27);
            txtEuros.TabIndex = 0;
            // 
            // lblEuros
            // 
            lblEuros.AutoSize = true;
            lblEuros.Location = new Point(23, 13);
            lblEuros.Name = "lblEuros";
            lblEuros.Size = new Size(45, 20);
            lblEuros.TabIndex = 1;
            lblEuros.Text = "Euros";
            // 
            // lblPesetas
            // 
            lblPesetas.AutoSize = true;
            lblPesetas.Location = new Point(23, 63);
            lblPesetas.Name = "lblPesetas";
            lblPesetas.Size = new Size(57, 20);
            lblPesetas.TabIndex = 3;
            lblPesetas.Text = "Pesetas";
            // 
            // txtPesetas
            // 
            txtPesetas.Location = new Point(86, 60);
            txtPesetas.Name = "txtPesetas";
            txtPesetas.Size = new Size(125, 27);
            txtPesetas.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(70, 93);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convertir";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 132);
            Controls.Add(btnConvert);
            Controls.Add(lblPesetas);
            Controls.Add(txtPesetas);
            Controls.Add(lblEuros);
            Controls.Add(txtEuros);
            Name = "frm1";
            Text = "Práctica 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEuros;
        private Label lblEuros;
        private Label lblPesetas;
        private TextBox txtPesetas;
        private Button btnConvert;
    }
}
