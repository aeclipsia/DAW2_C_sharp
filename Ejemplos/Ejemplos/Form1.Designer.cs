namespace Ejemplos
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
            fileSystemWatcher1 = new FileSystemWatcher();
            grpPos = new GroupBox();
            btnPos = new Button();
            txtY = new TextBox();
            txtX = new TextBox();
            lblY = new Label();
            lblX = new Label();
            grpColor = new GroupBox();
            btnColor = new Button();
            txtB = new TextBox();
            txtG = new TextBox();
            txtR = new TextBox();
            lblBlue = new Label();
            lblGrn = new Label();
            lblRed = new Label();
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
            grpPos.Location = new Point(17, 16);
            grpPos.Margin = new Padding(3, 4, 3, 4);
            grpPos.Name = "grpPos";
            grpPos.Padding = new Padding(3, 4, 3, 4);
            grpPos.Size = new Size(171, 171);
            grpPos.TabIndex = 0;
            grpPos.TabStop = false;
            grpPos.Text = "Posición";
            // 
            // btnPos
            // 
            btnPos.Location = new Point(16, 115);
            btnPos.Margin = new Padding(3, 4, 3, 4);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(141, 36);
            btnPos.TabIndex = 2;
            btnPos.Text = "Cambiar Posición";
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += btnPos_Click;
            // 
            // txtY
            // 
            txtY.Location = new Point(37, 76);
            txtY.Margin = new Padding(3, 4, 3, 4);
            txtY.Name = "txtY";
            txtY.Size = new Size(114, 27);
            txtY.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(37, 35);
            txtX.Margin = new Padding(3, 4, 3, 4);
            txtX.Name = "txtX";
            txtX.Size = new Size(114, 27);
            txtX.TabIndex = 2;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(10, 80);
            lblY.Name = "lblY";
            lblY.Size = new Size(20, 20);
            lblY.TabIndex = 1;
            lblY.Text = "Y:";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(10, 39);
            lblX.Name = "lblX";
            lblX.Size = new Size(21, 20);
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
            grpColor.Location = new Point(205, 16);
            grpColor.Margin = new Padding(3, 4, 3, 4);
            grpColor.Name = "grpColor";
            grpColor.Padding = new Padding(3, 4, 3, 4);
            grpColor.Size = new Size(229, 171);
            grpColor.TabIndex = 1;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(38, 115);
            btnColor.Margin = new Padding(3, 4, 3, 4);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(154, 36);
            btnColor.TabIndex = 6;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(163, 69);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(58, 27);
            txtB.TabIndex = 5;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtG
            // 
            txtG.Location = new Point(89, 69);
            txtG.Margin = new Padding(3, 4, 3, 4);
            txtG.Name = "txtG";
            txtG.Size = new Size(58, 27);
            txtG.TabIndex = 4;
            txtG.TextChanged += txtG_TextChanged;
            // 
            // txtR
            // 
            txtR.Location = new Point(7, 69);
            txtR.Margin = new Padding(3, 4, 3, 4);
            txtR.Name = "txtR";
            txtR.Size = new Size(58, 27);
            txtR.TabIndex = 3;
            txtR.TextChanged += txtR_TextChanged;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(163, 45);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(41, 20);
            lblBlue.TabIndex = 2;
            lblBlue.Text = "Blue:";
            // 
            // lblGrn
            // 
            lblGrn.AutoSize = true;
            lblGrn.Location = new Point(89, 45);
            lblGrn.Name = "lblGrn";
            lblGrn.Size = new Size(51, 20);
            lblGrn.TabIndex = 1;
            lblGrn.Text = "Green:";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(7, 45);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(38, 20);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red:";
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Location = new Point(105, 136);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(207, 103);
            lblDisplay.TabIndex = 2;
            lblDisplay.Text = "¡Hola Mundo!";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDisplay
            // 
            grpDisplay.Controls.Add(lblDisplay);
            grpDisplay.Location = new Point(17, 207);
            grpDisplay.Margin = new Padding(3, 4, 3, 4);
            grpDisplay.Name = "grpDisplay";
            grpDisplay.Padding = new Padding(3, 4, 3, 4);
            grpDisplay.Size = new Size(416, 377);
            grpDisplay.TabIndex = 3;
            grpDisplay.TabStop = false;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 600);
            Controls.Add(grpDisplay);
            Controls.Add(grpColor);
            Controls.Add(grpPos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm1";
            Text = "Ejemplo 2";
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
