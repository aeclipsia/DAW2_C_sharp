namespace Hola_Mundo
{
    partial class FrmHola
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
            lblHola = new Label();
            btnDale = new Button();
            SuspendLayout();
            // 
            // lblHola
            // 
            lblHola.AutoSize = true;
            lblHola.Location = new Point(84, 32);
            lblHola.Name = "lblHola";
            lblHola.Size = new Size(72, 17);
            lblHola.TabIndex = 0;
            lblHola.Text = "Hola Mundo";
            lblHola.Click += label1_Click;
            // 
            // btnDale
            // 
            btnDale.Location = new Point(81, 83);
            btnDale.Name = "btnDale";
            btnDale.Size = new Size(75, 23);
            btnDale.TabIndex = 1;
            btnDale.Text = "¡dale!";
            btnDale.UseVisualStyleBackColor = true;
            btnDale.Click += btnDale_Click;
            // 
            // FrmHola
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 156);
            Controls.Add(btnDale);
            Controls.Add(lblHola);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Italic);
            Name = "FrmHola";
            Text = "Hola Mundo";
            Load += FrmHola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHola;
        private Button btnDale;
    }
}
