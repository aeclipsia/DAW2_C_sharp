namespace Practica2
{
    partial class frmMain
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
            lblNombre = new Label();
            lblApellidos = new Label();
            lblEdad = new Label();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtEdad = new TextBox();
            txtDNI = new TextBox();
            txtProg = new TextBox();
            btnAdd = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(44, 50);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(44, 81);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(44, 112);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(111, 47);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(111, 78);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(111, 109);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 7;
            // 
            // txtProg
            // 
            txtProg.Location = new Point(77, 167);
            txtProg.Name = "txtProg";
            txtProg.ReadOnly = true;
            txtProg.Size = new Size(100, 23);
            txtProg.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(135, 138);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 10;
            btnView.Text = "Visualizar";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 201);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(txtProg);
            Controls.Add(txtDNI);
            Controls.Add(txtEdad);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblEdad);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Name = "frmMain";
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellidos;
        private Label lblEdad;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtEdad;
        private TextBox txtDNI;
        private TextBox txtProg;
        private Button btnAdd;
        private Button btnView;
    }
}
