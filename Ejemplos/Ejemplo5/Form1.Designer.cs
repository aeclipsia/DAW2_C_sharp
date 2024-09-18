namespace Ejemplo5
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
            lblActual = new Label();
            txtInput = new TextBox();
            grpPlus = new GroupBox();
            txtPlus = new TextBox();
            btnPlus = new Button();
            radYear = new RadioButton();
            radMos = new RadioButton();
            radDay = new RadioButton();
            btnWeek = new Button();
            grpPlus.SuspendLayout();
            SuspendLayout();
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Font = new Font("Segoe UI", 9F);
            lblActual.Location = new Point(12, 15);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(160, 15);
            lblActual.TabIndex = 0;
            lblActual.Text = "Fecha actual (DD/MM/YYYY)";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 33);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(189, 23);
            txtInput.TabIndex = 1;
            // 
            // grpPlus
            // 
            grpPlus.Controls.Add(txtPlus);
            grpPlus.Controls.Add(btnPlus);
            grpPlus.Controls.Add(radYear);
            grpPlus.Controls.Add(radMos);
            grpPlus.Controls.Add(radDay);
            grpPlus.Location = new Point(12, 62);
            grpPlus.Name = "grpPlus";
            grpPlus.Size = new Size(282, 95);
            grpPlus.TabIndex = 2;
            grpPlus.TabStop = false;
            grpPlus.Text = "Incrementar fecha";
            // 
            // txtPlus
            // 
            txtPlus.Location = new Point(121, 24);
            txtPlus.Name = "txtPlus";
            txtPlus.Size = new Size(131, 23);
            txtPlus.TabIndex = 4;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(143, 53);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(87, 23);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "Incrementar";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // radYear
            // 
            radYear.AutoSize = true;
            radYear.Location = new Point(6, 66);
            radYear.Name = "radYear";
            radYear.Size = new Size(52, 19);
            radYear.TabIndex = 2;
            radYear.Text = "Años";
            radYear.UseVisualStyleBackColor = true;
            // 
            // radMos
            // 
            radMos.AutoSize = true;
            radMos.Location = new Point(6, 41);
            radMos.Name = "radMos";
            radMos.Size = new Size(58, 19);
            radMos.TabIndex = 1;
            radMos.Text = "Meses";
            radMos.UseVisualStyleBackColor = true;
            // 
            // radDay
            // 
            radDay.AutoSize = true;
            radDay.Checked = true;
            radDay.Location = new Point(6, 16);
            radDay.Name = "radDay";
            radDay.Size = new Size(47, 19);
            radDay.TabIndex = 0;
            radDay.TabStop = true;
            radDay.Text = "Días";
            radDay.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(207, 33);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(87, 23);
            btnWeek.TabIndex = 5;
            btnWeek.Text = "Mostrar";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 169);
            Controls.Add(btnWeek);
            Controls.Add(grpPlus);
            Controls.Add(txtInput);
            Controls.Add(lblActual);
            Name = "frm1";
            Text = "Día y Fecha";
            grpPlus.ResumeLayout(false);
            grpPlus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActual;
        private TextBox txtInput;
        private GroupBox grpPlus;
        private RadioButton radDay;
        private TextBox txtPlus;
        private Button btnPlus;
        private RadioButton radYear;
        private RadioButton radMos;
        private Button btnWeek;
    }
}
