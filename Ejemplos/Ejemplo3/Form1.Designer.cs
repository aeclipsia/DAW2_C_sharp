namespace Ejemplo3
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
            grpInput = new GroupBox();
            btnCifrar = new Button();
            txtInput = new TextBox();
            txtShift = new TextBox();
            lblInput = new Label();
            lblShift = new Label();
            lblResult = new Label();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnCifrar);
            grpInput.Controls.Add(txtInput);
            grpInput.Controls.Add(txtShift);
            grpInput.Controls.Add(lblInput);
            grpInput.Controls.Add(lblShift);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(255, 118);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Cifrado César";
            // 
            // btnCifrar
            // 
            btnCifrar.Location = new Point(162, 38);
            btnCifrar.Name = "btnCifrar";
            btnCifrar.Size = new Size(75, 42);
            btnCifrar.TabIndex = 4;
            btnCifrar.Text = "Cifrar";
            btnCifrar.UseVisualStyleBackColor = true;
            btnCifrar.Click += btnCifrar_click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(6, 74);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(128, 23);
            txtInput.TabIndex = 3;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(103, 26);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(31, 23);
            txtShift.TabIndex = 2;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(6, 56);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(35, 15);
            lblInput.TabIndex = 1;
            lblInput.Text = "Texto";
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Location = new Point(6, 29);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(91, 15);
            lblShift.TabIndex = 0;
            lblShift.Text = "Desplazamiento";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(12, 147);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(255, 116);
            lblResult.TabIndex = 1;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 272);
            Controls.Add(lblResult);
            Controls.Add(grpInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm1";
            Text = "Cifrado";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblShift;
        private Button btnCifrar;
        private TextBox txtInput;
        private TextBox txtShift;
        private Label lblInput;
        private Label lblResult;
    }
}
