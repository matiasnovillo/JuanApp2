namespace JuanApp.Formularios.Entrada
{
    partial class ConsultaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProveedor));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewCobrador = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlFiltersAndSearchBar = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCobrador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).BeginInit();
            pnlFiltersAndSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1257, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1257, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewCobrador
            // 
            DataGridViewCobrador.AllowUserToAddRows = false;
            DataGridViewCobrador.AllowUserToDeleteRows = false;
            DataGridViewCobrador.BackgroundColor = Color.Black;
            DataGridViewCobrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCobrador.Dock = DockStyle.Bottom;
            DataGridViewCobrador.GridColor = Color.FromArgb(41, 48, 57);
            DataGridViewCobrador.Location = new Point(0, 459);
            DataGridViewCobrador.Name = "DataGridViewCobrador";
            DataGridViewCobrador.ReadOnly = true;
            DataGridViewCobrador.RowHeadersWidth = 51;
            DataGridViewCobrador.Size = new Size(1257, 570);
            DataGridViewCobrador.TabIndex = 2;
            DataGridViewCobrador.CellContentClick += DataGridViewEntrada_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(661, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de cobradores";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1043, 228);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 84);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 251);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(419, 23);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por nombre de cobrador)";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 274);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 38);
            txtBuscar.TabIndex = 10;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(829, 228);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 84);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Location = new Point(12, 184);
            numericUpDownRegistrosPorPagina.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownRegistrosPorPagina.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Name = "numericUpDownRegistrosPorPagina";
            numericUpDownRegistrosPorPagina.Size = new Size(150, 38);
            numericUpDownRegistrosPorPagina.TabIndex = 15;
            numericUpDownRegistrosPorPagina.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 16;
            label1.Text = "Registros por página";
            // 
            // pnlFiltersAndSearchBar
            // 
            pnlFiltersAndSearchBar.BackColor = Color.Black;
            pnlFiltersAndSearchBar.Controls.Add(lblTitulo);
            pnlFiltersAndSearchBar.Controls.Add(label1);
            pnlFiltersAndSearchBar.Controls.Add(btnBuscar);
            pnlFiltersAndSearchBar.Controls.Add(numericUpDownRegistrosPorPagina);
            pnlFiltersAndSearchBar.Controls.Add(btnAgregar);
            pnlFiltersAndSearchBar.Controls.Add(txtBuscar);
            pnlFiltersAndSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlFiltersAndSearchBar.Dock = DockStyle.Fill;
            pnlFiltersAndSearchBar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlFiltersAndSearchBar.ForeColor = Color.Goldenrod;
            pnlFiltersAndSearchBar.Location = new Point(0, 27);
            pnlFiltersAndSearchBar.Name = "pnlFiltersAndSearchBar";
            pnlFiltersAndSearchBar.Size = new Size(1257, 432);
            pnlFiltersAndSearchBar.TabIndex = 17;
            // 
            // ConsultaCobrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 1055);
            Controls.Add(pnlFiltersAndSearchBar);
            Controls.Add(DataGridViewCobrador);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ConsultaCobrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de entradas - Pesajes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCobrador).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).EndInit();
            pnlFiltersAndSearchBar.ResumeLayout(false);
            pnlFiltersAndSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewCobrador;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
        private Panel pnlFiltersAndSearchBar;
    }
}