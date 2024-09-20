namespace OrientadoAObjetos
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
            txtTel = new TextBox();
            lblTel = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            lstbxRes = new ListBox();
            btnAdd = new Button();
            grpList = new GroupBox();
            grpBtn = new GroupBox();
            btnBuscar = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            txtPais = new TextBox();
            lblPais = new Label();
            chkErasmus = new CheckBox();
            grpDatos.SuspendLayout();
            grpList.SuspendLayout();
            grpBtn.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkErasmus);
            grpDatos.Controls.Add(txtPais);
            grpDatos.Controls.Add(lblPais);
            grpDatos.Controls.Add(txtTel);
            grpDatos.Controls.Add(lblTel);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtDNI);
            grpDatos.Controls.Add(lblDNI);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(375, 147);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos Alumno";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(95, 77);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(126, 23);
            txtTel.TabIndex = 3;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(22, 80);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(53, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(95, 49);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(126, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(24, 52);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI";
            // 
            // lstbxRes
            // 
            lstbxRes.FormattingEnabled = true;
            lstbxRes.ItemHeight = 15;
            lstbxRes.Location = new Point(6, 20);
            lstbxRes.Name = "lstbxRes";
            lstbxRes.Size = new Size(178, 124);
            lstbxRes.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(lstbxRes);
            grpList.Location = new Point(393, 12);
            grpList.Name = "grpList";
            grpList.Size = new Size(191, 147);
            grpList.TabIndex = 7;
            grpList.TabStop = false;
            grpList.Text = "Listado de Alumnos";
            // 
            // grpBtn
            // 
            grpBtn.Controls.Add(btnBuscar);
            grpBtn.Controls.Add(btnDel);
            grpBtn.Controls.Add(btnEdit);
            grpBtn.Controls.Add(btnAdd);
            grpBtn.Location = new Point(12, 160);
            grpBtn.Name = "grpBtn";
            grpBtn.Size = new Size(482, 60);
            grpBtn.TabIndex = 8;
            grpBtn.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(183, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(267, 19);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 8;
            btnDel.Text = "Borrar";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(99, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtPais
            // 
            txtPais.Enabled = false;
            txtPais.Location = new Point(95, 105);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(126, 23);
            txtPais.TabIndex = 9;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(22, 108);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 10;
            lblPais.Text = "Pais";
            // 
            // chkErasmus
            // 
            chkErasmus.AutoSize = true;
            chkErasmus.Location = new Point(267, 24);
            chkErasmus.Name = "chkErasmus";
            chkErasmus.Size = new Size(70, 19);
            chkErasmus.TabIndex = 11;
            chkErasmus.Text = "Erasmus";
            chkErasmus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 232);
            Controls.Add(grpBtn);
            Controls.Add(grpList);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Form1";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpList.ResumeLayout(false);
            grpBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private ListBox lstbxRes;
        private Button btnAdd;
        private GroupBox grpList;
        private GroupBox grpBtn;
        private Button btnDel;
        private Button btnEdit;
        private Button btnBuscar;
        private CheckBox chkErasmus;
        private TextBox txtPais;
        private Label lblPais;
    }
}
