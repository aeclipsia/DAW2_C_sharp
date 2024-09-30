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
            mnuMain = new MenuStrip();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            menuAlta = new ToolStripMenuItem();
            menuVender = new ToolStripMenuItem();
            menuMostrar = new ToolStripMenuItem();
            almacénToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem1 = new ToolStripMenuItem();
            revisarToolStripMenuItem = new ToolStripMenuItem();
            lblName = new Label();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { tiendaToolStripMenuItem, almacénToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(538, 24);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "Main Menu";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAlta, menuVender, menuMostrar });
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(54, 20);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // menuAlta
            // 
            menuAlta.Name = "menuAlta";
            menuAlta.Size = new Size(180, 22);
            menuAlta.Text = "Alta";
            menuAlta.Click += altaToolStripMenuItem_Click;
            // 
            // menuVender
            // 
            menuVender.Name = "menuVender";
            menuVender.Size = new Size(180, 22);
            menuVender.Text = "Vender";
            menuVender.Click += venderToolStripMenuItem_Click;
            // 
            // menuMostrar
            // 
            menuMostrar.Name = "menuMostrar";
            menuMostrar.Size = new Size(180, 22);
            menuMostrar.Text = "Mostrar";
            menuMostrar.Click += mostrarToolStripMenuItem_Click;
            // 
            // almacénToolStripMenuItem
            // 
            almacénToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem1, revisarToolStripMenuItem });
            almacénToolStripMenuItem.Name = "almacénToolStripMenuItem";
            almacénToolStripMenuItem.Size = new Size(66, 20);
            almacénToolStripMenuItem.Text = "Almacén";
            // 
            // mostrarToolStripMenuItem1
            // 
            mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            mostrarToolStripMenuItem1.Size = new Size(115, 22);
            mostrarToolStripMenuItem1.Text = "Mostrar";
            // 
            // revisarToolStripMenuItem
            // 
            revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            revisarToolStripMenuItem.Size = new Size(115, 22);
            revisarToolStripMenuItem.Text = "Revisar";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 64F);
            lblName.Location = new Point(13, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(513, 114);
            lblName.TabIndex = 1;
            lblName.Text = "Quesos Alex";
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 170);
            Controls.Add(lblName);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "frm1";
            Text = "Mi tienda";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem menuAlta;
        private ToolStripMenuItem menuVender;
        private ToolStripMenuItem almacénToolStripMenuItem;
        private ToolStripMenuItem menuMostrar;
        private ToolStripMenuItem mostrarToolStripMenuItem1;
        private ToolStripMenuItem revisarToolStripMenuItem;
        private Label lblName;
    }
}
