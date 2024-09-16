namespace Ejemplo1
{
    partial class Frm1
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
            txt1 = new TextBox();
            lbl1 = new Label();
            txt2 = new TextBox();
            btnSumar = new Button();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnSumar);
            grpInput.Controls.Add(txt2);
            grpInput.Controls.Add(lbl1);
            grpInput.Controls.Add(txt1);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(174, 91);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            // 
            // txt1
            // 
            txt1.Location = new Point(9, 17);
            txt1.Name = "txt1";
            txt1.Size = new Size(55, 27);
            txt1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(78, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(19, 20);
            lbl1.TabIndex = 1;
            lbl1.Text = "+";
            // 
            // txt2
            // 
            txt2.Location = new Point(111, 17);
            txt2.Name = "txt2";
            txt2.Size = new Size(55, 27);
            txt2.TabIndex = 2;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(40, 50);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 29);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 114);
            Controls.Add(grpInput);
            Name = "Frm1";
            Text = "Ejemplo 1";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txt1;
        private Button btnSumar;
        private TextBox txt2;
        private Label lbl1;
    }
}
