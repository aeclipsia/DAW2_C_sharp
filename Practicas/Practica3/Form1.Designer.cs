namespace Practica3
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
            lblDNI = new Label();
            groupBox1 = new GroupBox();
            txtDNI = new TextBox();
            btnValidar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(22, 35);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnValidar);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 111);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validar DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(66, 32);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(147, 27);
            txtDNI.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(70, 65);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(94, 29);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 136);
            Controls.Add(groupBox1);
            Name = "frm1";
            Text = "Práctica 3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDNI;
        private GroupBox groupBox1;
        private Button btnValidar;
        private TextBox txtDNI;
    }
}
