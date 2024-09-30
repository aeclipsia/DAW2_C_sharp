namespace Quesos
{
    partial class frmAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpType = new GroupBox();
            radBtnImp = new RadioButton();
            radBtnArt = new RadioButton();
            radBtnNormal = new RadioButton();
            pictureBox1 = new PictureBox();
            grpDatos = new GroupBox();
            grpOrigen = new GroupBox();
            lblMarca = new Label();
            lblFab = new Label();
            lblLote = new Label();
            lblPeso = new Label();
            lblCad = new Label();
            txtCad = new DateTimePicker();
            txtMarca = new TextBox();
            txtFab = new TextBox();
            txtLote = new TextBox();
            txtPeso = new TextBox();
            textBox1 = new TextBox();
            lblDen = new Label();
            textBox2 = new TextBox();
            lblProc = new Label();
            btnAcc = new Button();
            grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpDatos.SuspendLayout();
            grpOrigen.SuspendLayout();
            SuspendLayout();
            // 
            // grpType
            // 
            grpType.Controls.Add(radBtnImp);
            grpType.Controls.Add(radBtnArt);
            grpType.Controls.Add(radBtnNormal);
            grpType.Location = new Point(12, 12);
            grpType.Name = "grpType";
            grpType.Size = new Size(150, 105);
            grpType.TabIndex = 0;
            grpType.TabStop = false;
            grpType.Text = "Tipo de queso";
            // 
            // radBtnImp
            // 
            radBtnImp.AutoSize = true;
            radBtnImp.Location = new Point(6, 72);
            radBtnImp.Name = "radBtnImp";
            radBtnImp.Size = new Size(90, 19);
            radBtnImp.TabIndex = 2;
            radBtnImp.TabStop = true;
            radBtnImp.Text = "Importación";
            radBtnImp.UseVisualStyleBackColor = true;
            // 
            // radBtnArt
            // 
            radBtnArt.AutoSize = true;
            radBtnArt.Location = new Point(6, 47);
            radBtnArt.Name = "radBtnArt";
            radBtnArt.Size = new Size(71, 19);
            radBtnArt.TabIndex = 1;
            radBtnArt.TabStop = true;
            radBtnArt.Text = "Artesana";
            radBtnArt.UseVisualStyleBackColor = true;
            // 
            // radBtnNormal
            // 
            radBtnNormal.AutoSize = true;
            radBtnNormal.Location = new Point(6, 22);
            radBtnNormal.Name = "radBtnNormal";
            radBtnNormal.Size = new Size(65, 19);
            radBtnNormal.TabIndex = 0;
            radBtnNormal.TabStop = true;
            radBtnNormal.Text = "Normal";
            radBtnNormal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtPeso);
            grpDatos.Controls.Add(txtLote);
            grpDatos.Controls.Add(txtFab);
            grpDatos.Controls.Add(txtMarca);
            grpDatos.Controls.Add(txtCad);
            grpDatos.Controls.Add(lblCad);
            grpDatos.Controls.Add(lblPeso);
            grpDatos.Controls.Add(lblLote);
            grpDatos.Controls.Add(lblFab);
            grpDatos.Controls.Add(lblMarca);
            grpDatos.Location = new Point(168, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(333, 182);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // grpOrigen
            // 
            grpOrigen.Controls.Add(textBox2);
            grpOrigen.Controls.Add(lblProc);
            grpOrigen.Controls.Add(textBox1);
            grpOrigen.Controls.Add(lblDen);
            grpOrigen.Location = new Point(168, 200);
            grpOrigen.Name = "grpOrigen";
            grpOrigen.Size = new Size(333, 73);
            grpOrigen.TabIndex = 3;
            grpOrigen.TabStop = false;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(23, 23);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblFab
            // 
            lblFab.AutoSize = true;
            lblFab.Location = new Point(23, 54);
            lblFab.Name = "lblFab";
            lblFab.Size = new Size(62, 15);
            lblFab.TabIndex = 1;
            lblFab.Text = "Fabricante";
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.Location = new Point(23, 85);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(30, 15);
            lblLote.TabIndex = 2;
            lblLote.Text = "Lote";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(23, 116);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso";
            // 
            // lblCad
            // 
            lblCad.AutoSize = true;
            lblCad.Location = new Point(23, 146);
            lblCad.Name = "lblCad";
            lblCad.Size = new Size(64, 15);
            lblCad.TabIndex = 4;
            lblCad.Text = "Caducidad";
            // 
            // txtCad
            // 
            txtCad.Location = new Point(93, 142);
            txtCad.Name = "txtCad";
            txtCad.Size = new Size(216, 23);
            txtCad.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(93, 20);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(216, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtFab
            // 
            txtFab.Location = new Point(93, 51);
            txtFab.Name = "txtFab";
            txtFab.Size = new Size(216, 23);
            txtFab.TabIndex = 7;
            // 
            // txtLote
            // 
            txtLote.Location = new Point(93, 82);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(216, 23);
            txtLote.TabIndex = 8;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(93, 113);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(216, 23);
            txtPeso.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 11;
            // 
            // lblDen
            // 
            lblDen.AutoSize = true;
            lblDen.Location = new Point(23, 19);
            lblDen.Name = "lblDen";
            lblDen.Size = new Size(124, 15);
            lblDen.TabIndex = 10;
            lblDen.Text = "Denominación Origen";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 13;
            // 
            // lblProc
            // 
            lblProc.AutoSize = true;
            lblProc.Location = new Point(23, 48);
            lblProc.Name = "lblProc";
            lblProc.Size = new Size(72, 15);
            lblProc.TabIndex = 12;
            lblProc.Text = "Procedencia";
            // 
            // btnAcc
            // 
            btnAcc.Location = new Point(218, 282);
            btnAcc.Name = "btnAcc";
            btnAcc.Size = new Size(75, 23);
            btnAcc.TabIndex = 4;
            btnAcc.Text = "Aceptar";
            btnAcc.UseVisualStyleBackColor = true;
            btnAcc.Click += this.btnAcc_Click;
            // 
            // frmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 314);
            Controls.Add(btnAcc);
            Controls.Add(grpOrigen);
            Controls.Add(grpDatos);
            Controls.Add(pictureBox1);
            Controls.Add(grpType);
            Name = "frmAlta";
            Text = "Alta quesos partida nueva";
            grpType.ResumeLayout(false);
            grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpOrigen.ResumeLayout(false);
            grpOrigen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpType;
        private RadioButton radBtnImp;
        private RadioButton radBtnArt;
        private RadioButton radBtnNormal;
        private PictureBox pictureBox1;
        private GroupBox grpDatos;
        private GroupBox grpOrigen;
        private TextBox txtPeso;
        private TextBox txtLote;
        private TextBox txtFab;
        private TextBox txtMarca;
        private DateTimePicker txtCad;
        private Label lblCad;
        private Label lblPeso;
        private Label lblLote;
        private Label lblFab;
        private Label lblMarca;
        private TextBox textBox2;
        private Label lblProc;
        private TextBox textBox1;
        private Label lblDen;
        private Button btnAcc;
    }
}