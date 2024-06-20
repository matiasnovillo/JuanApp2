namespace JuanApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            ToolStripButtonAcercaDe = new ToolStripButton();
            panel1 = new Panel();
            label1 = new Label();
            btnProveedorMain = new Button();
            btnCobradores = new Button();
            btnProveedores = new Button();
            btnCompras = new Button();
            btnCobranza = new Button();
            btnCaja = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1924, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(89, 20);
            statusLabel.Text = "Información";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, ToolStripButtonAcercaDe });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1924, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(42, 24);
            toolStripButton2.Text = "Salir";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // ToolStripButtonAcercaDe
            // 
            ToolStripButtonAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonAcercaDe.Image = (Image)resources.GetObject("ToolStripButtonAcercaDe.Image");
            ToolStripButtonAcercaDe.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAcercaDe.Name = "ToolStripButtonAcercaDe";
            ToolStripButtonAcercaDe.Size = new Size(79, 24);
            ToolStripButtonAcercaDe.Text = "Acerca de";
            ToolStripButtonAcercaDe.Click += ToolStripButtonAcercaDe_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnProveedorMain);
            panel1.Controls.Add(btnCobradores);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnCobranza);
            panel1.Controls.Add(btnCaja);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1002);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(69, 630);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 14;
            label1.Text = "Configuración";
            // 
            // btnProveedorMain
            // 
            btnProveedorMain.BackColor = Color.Black;
            btnProveedorMain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProveedorMain.ForeColor = SystemColors.Window;
            btnProveedorMain.Location = new Point(353, 711);
            btnProveedorMain.Name = "btnProveedorMain";
            btnProveedorMain.Size = new Size(203, 148);
            btnProveedorMain.TabIndex = 13;
            btnProveedorMain.Text = "PROVEEDORES";
            btnProveedorMain.UseVisualStyleBackColor = false;
            btnProveedorMain.Click += btnProveedorMain_Click;
            // 
            // btnCobradores
            // 
            btnCobradores.BackColor = Color.Black;
            btnCobradores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCobradores.ForeColor = SystemColors.Window;
            btnCobradores.Location = new Point(69, 711);
            btnCobradores.Name = "btnCobradores";
            btnCobradores.Size = new Size(203, 148);
            btnCobradores.TabIndex = 12;
            btnCobradores.Text = "COBRADORES";
            btnCobradores.UseVisualStyleBackColor = false;
            btnCobradores.Click += btnCobradores_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.Black;
            btnProveedores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProveedores.ForeColor = SystemColors.Window;
            btnProveedores.Location = new Point(510, 307);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(203, 148);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.Black;
            btnCompras.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCompras.ForeColor = SystemColors.Window;
            btnCompras.Location = new Point(1128, 54);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(203, 148);
            btnCompras.TabIndex = 9;
            btnCompras.Text = "COMPRAS";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnCobranza
            // 
            btnCobranza.BackColor = Color.Black;
            btnCobranza.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCobranza.ForeColor = SystemColors.Window;
            btnCobranza.Location = new Point(819, 54);
            btnCobranza.Name = "btnCobranza";
            btnCobranza.Size = new Size(203, 148);
            btnCobranza.TabIndex = 8;
            btnCobranza.Text = "COBRANZA";
            btnCobranza.UseVisualStyleBackColor = false;
            btnCobranza.Click += btnCobranza_Click;
            // 
            // btnCaja
            // 
            btnCaja.BackColor = Color.Black;
            btnCaja.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCaja.ForeColor = SystemColors.Window;
            btnCaja.Location = new Point(510, 54);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(203, 148);
            btnCaja.TabIndex = 7;
            btnCaja.Text = "CAJA";
            btnCaja.UseVisualStyleBackColor = false;
            btnCaja.Click += btnCaja_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = JuanApp2.Properties.Resources.LogoDark;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(69, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "JuanApp";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton ToolStripButtonAcercaDe;
        private Button btnCaja;
        private Button btnProveedores;
        private Button btnCompras;
        private Button btnCobranza;
        private Button btnCobradores;
        private Button btnProveedorMain;
        private Label label1;
    }
}