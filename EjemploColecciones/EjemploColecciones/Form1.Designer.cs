namespace EjemploColecciones
{
    partial class frmBase
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
            lstPaises = new ListBox();
            grp1 = new GroupBox();
            grpDatos = new GroupBox();
            btnEdit = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            txtSaludo = new TextBox();
            lblSaludo = new Label();
            txtPais = new TextBox();
            lblPais = new Label();
            grp1.SuspendLayout();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 15;
            lstPaises.Location = new Point(6, 22);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(120, 169);
            lstPaises.TabIndex = 0;
            lstPaises.SelectedIndexChanged += lstPaises_SelectedIndexChanged;
            // 
            // grp1
            // 
            grp1.Controls.Add(lstPaises);
            grp1.Location = new Point(12, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(163, 197);
            grp1.TabIndex = 1;
            grp1.TabStop = false;
            grp1.Text = "Lista de paises";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnEdit);
            grpDatos.Controls.Add(btnRemove);
            grpDatos.Controls.Add(btnAdd);
            grpDatos.Controls.Add(txtSaludo);
            grpDatos.Controls.Add(lblSaludo);
            grpDatos.Controls.Add(txtPais);
            grpDatos.Controls.Add(lblPais);
            grpDatos.Location = new Point(181, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(247, 197);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(160, 133);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(79, 133);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSaludo
            // 
            txtSaludo.Location = new Point(105, 78);
            txtSaludo.Name = "txtSaludo";
            txtSaludo.Size = new Size(100, 23);
            txtSaludo.TabIndex = 3;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(41, 81);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(43, 15);
            lblSaludo.TabIndex = 2;
            lblSaludo.Text = "Saludo";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(105, 33);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(100, 23);
            txtPais.TabIndex = 1;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(41, 36);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 0;
            lblPais.Text = "Pais";
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 215);
            Controls.Add(grpDatos);
            Controls.Add(grp1);
            Name = "frmBase";
            Text = "Practica 2";
            grp1.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPaises;
        private GroupBox grp1;
        private GroupBox grpDatos;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtSaludo;
        private Label lblSaludo;
        private TextBox txtPais;
        private Label lblPais;
    }
}
