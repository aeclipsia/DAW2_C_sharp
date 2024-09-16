namespace Ejemplos
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
            fileSystemWatcher1 = new FileSystemWatcher();
            grpPos = new GroupBox();
            btnPos = new Button();
            txtY = new TextBox();
            txtX = new TextBox();
            lblY = new Label();
            lblX = new Label();
            grpColor = new GroupBox();
            txtB = new TextBox();
            txtG = new TextBox();
            txtR = new TextBox();
            lblBlue = new Label();
            lblGrn = new Label();
            lblRed = new Label();
            btnColor = new Button();
            lblDisplay = new Label();
            grpDisplay = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            grpPos.SuspendLayout();
            grpColor.SuspendLayout();
            grpDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // grpPos
            // 
            grpPos.Controls.Add(btnPos);
            grpPos.Controls.Add(txtY);
            grpPos.Controls.Add(txtX);
            grpPos.Controls.Add(lblY);
            grpPos.Controls.Add(lblX);
            grpPos.Location = new Point(15, 12);
            grpPos.Name = "grpPos";
            grpPos.Size = new Size(150, 128);
            grpPos.TabIndex = 0;
            grpPos.TabStop = false;
            grpPos.Text = "Posición";
            // 
            // btnPos
            // 
            btnPos.Location = new Point(14, 86);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(123, 27);
            btnPos.TabIndex = 2;
            btnPos.Text = "Cambiar Posición";
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += btnPos_Click;
            // 
            // txtY
            // 
            txtY.Location = new Point(32, 57);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(32, 26);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 2;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(9, 60);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 15);
            lblY.TabIndex = 1;
            lblY.Text = "Y:";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(9, 29);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 15);
            lblX.TabIndex = 0;
            lblX.Text = "X:";
            // 
            // grpColor
            // 
            grpColor.Controls.Add(btnColor);
            grpColor.Controls.Add(txtB);
            grpColor.Controls.Add(txtG);
            grpColor.Controls.Add(txtR);
            grpColor.Controls.Add(lblBlue);
            grpColor.Controls.Add(lblGrn);
            grpColor.Controls.Add(lblRed);
            grpColor.Location = new Point(179, 12);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(200, 128);
            grpColor.TabIndex = 1;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // txtB
            // 
            txtB.Location = new Point(143, 52);
            txtB.Name = "txtB";
            txtB.Size = new Size(51, 23);
            txtB.TabIndex = 5;
            // 
            // txtG
            // 
            txtG.Location = new Point(78, 52);
            txtG.Name = "txtG";
            txtG.Size = new Size(51, 23);
            txtG.TabIndex = 4;
            // 
            // txtR
            // 
            txtR.Location = new Point(6, 52);
            txtR.Name = "txtR";
            txtR.Size = new Size(51, 23);
            txtR.TabIndex = 3;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(143, 34);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(33, 15);
            lblBlue.TabIndex = 2;
            lblBlue.Text = "Blue:";
            // 
            // lblGrn
            // 
            lblGrn.AutoSize = true;
            lblGrn.Location = new Point(78, 34);
            lblGrn.Name = "lblGrn";
            lblGrn.Size = new Size(41, 15);
            lblGrn.TabIndex = 1;
            lblGrn.Text = "Green:";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(6, 34);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(30, 15);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red:";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(33, 86);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(135, 27);
            btnColor.TabIndex = 6;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Location = new Point(92, 102);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(181, 78);
            lblDisplay.TabIndex = 2;
            lblDisplay.Text = "¡Hola Mundo!";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDisplay
            // 
            grpDisplay.Controls.Add(lblDisplay);
            grpDisplay.Location = new Point(15, 155);
            grpDisplay.Name = "grpDisplay";
            grpDisplay.Size = new Size(364, 283);
            grpDisplay.TabIndex = 3;
            grpDisplay.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(grpDisplay);
            Controls.Add(grpColor);
            Controls.Add(grpPos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            grpPos.ResumeLayout(false);
            grpPos.PerformLayout();
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox grpColor;
        private GroupBox grpPos;
        private Label lblX;
        private TextBox txtB;
        private TextBox txtG;
        private TextBox txtR;
        private Label lblBlue;
        private Label lblGrn;
        private Label lblRed;
        private TextBox txtY;
        private TextBox txtX;
        private Label lblY;
        private Button btnPos;
        private GroupBox grpDisplay;
        private Label lblDisplay;
        private Button btnColor;
    }
}
