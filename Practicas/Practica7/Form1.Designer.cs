namespace Practica7
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
            txtFac1 = new TextBox();
            txtFac2 = new TextBox();
            radBtnSuma = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            txtRes = new TextBox();
            grpOp = new GroupBox();
            lblFac1 = new Label();
            lblFac2 = new Label();
            lblRes = new Label();
            grpOp.SuspendLayout();
            SuspendLayout();
            // 
            // txtFac1
            // 
            txtFac1.Location = new Point(26, 55);
            txtFac1.Name = "txtFac1";
            txtFac1.Size = new Size(100, 23);
            txtFac1.TabIndex = 0;
            // 
            // txtFac2
            // 
            txtFac2.Location = new Point(26, 102);
            txtFac2.Name = "txtFac2";
            txtFac2.Size = new Size(100, 23);
            txtFac2.TabIndex = 1;
            // 
            // radBtnSuma
            // 
            radBtnSuma.AutoSize = true;
            radBtnSuma.Location = new Point(17, 22);
            radBtnSuma.Name = "radBtnSuma";
            radBtnSuma.Size = new Size(55, 19);
            radBtnSuma.TabIndex = 2;
            radBtnSuma.TabStop = true;
            radBtnSuma.Text = "Suma";
            radBtnSuma.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Resta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Producto";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "División";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtRes
            // 
            txtRes.Location = new Point(358, 79);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(100, 23);
            txtRes.TabIndex = 6;
            // 
            // grpOp
            // 
            grpOp.Controls.Add(radBtnSuma);
            grpOp.Controls.Add(radioButton2);
            grpOp.Controls.Add(radioButton4);
            grpOp.Controls.Add(radioButton3);
            grpOp.Location = new Point(143, 19);
            grpOp.Name = "grpOp";
            grpOp.Size = new Size(200, 142);
            grpOp.TabIndex = 7;
            grpOp.TabStop = false;
            grpOp.Text = "Operaciones Básicas";
            // 
            // lblFac1
            // 
            lblFac1.AutoSize = true;
            lblFac1.Location = new Point(26, 37);
            lblFac1.Name = "lblFac1";
            lblFac1.Size = new Size(49, 15);
            lblFac1.TabIndex = 8;
            lblFac1.Text = "Factor 1";
            // 
            // lblFac2
            // 
            lblFac2.AutoSize = true;
            lblFac2.Location = new Point(26, 84);
            lblFac2.Name = "lblFac2";
            lblFac2.Size = new Size(49, 15);
            lblFac2.TabIndex = 9;
            lblFac2.Text = "Factor 2";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(358, 61);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(59, 15);
            lblRes.TabIndex = 10;
            lblRes.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 181);
            Controls.Add(lblRes);
            Controls.Add(lblFac2);
            Controls.Add(lblFac1);
            Controls.Add(grpOp);
            Controls.Add(txtRes);
            Controls.Add(txtFac2);
            Controls.Add(txtFac1);
            Name = "Form1";
            Text = "Form1";
            grpOp.ResumeLayout(false);
            grpOp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFac1;
        private TextBox txtFac2;
        private RadioButton radBtnSuma;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox txtRes;
        private GroupBox grpOp;
        private Label lblFac1;
        private Label lblFac2;
        private Label lblRes;
    }
}
