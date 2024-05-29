namespace JuanApp.Formularios.Herramientas
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnShowHideTabla = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            lblTitulo = new Label();
            DataGridViewStock = new DataGridView();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pnlSearchBar = new Panel();
            txtNroTotalDeProductos = new TextBox();
            label1 = new Label();
            txtNetoTotal = new TextBox();
            lblNeto = new Label();
            btnGenerarExcel = new Button();
            lblBarraDeBusqueda = new Label();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, btnShowHideTabla });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1028, 27);
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
            // btnShowHideTabla
            // 
            btnShowHideTabla.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnShowHideTabla.Image = (Image)resources.GetObject("btnShowHideTabla.Image");
            btnShowHideTabla.ImageTransparentColor = Color.Magenta;
            btnShowHideTabla.Name = "btnShowHideTabla";
            btnShowHideTabla.Size = new Size(48, 24);
            btnShowHideTabla.Text = "Tabla";
            btnShowHideTabla.Click += btnShowHideTabla_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1028, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(502, 81);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Consulta de stock";
            // 
            // DataGridViewStock
            // 
            DataGridViewStock.AllowUserToAddRows = false;
            DataGridViewStock.AllowUserToDeleteRows = false;
            DataGridViewStock.AllowUserToOrderColumns = true;
            DataGridViewStock.BackgroundColor = Color.Black;
            DataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewStock.Dock = DockStyle.Bottom;
            DataGridViewStock.Location = new Point(0, 526);
            DataGridViewStock.Name = "DataGridViewStock";
            DataGridViewStock.ReadOnly = true;
            DataGridViewStock.RowHeadersWidth = 51;
            DataGridViewStock.Size = new Size(1028, 503);
            DataGridViewStock.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 163);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 12;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(843, 309);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(173, 82);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.Black;
            pnlSearchBar.Controls.Add(txtNroTotalDeProductos);
            pnlSearchBar.Controls.Add(label1);
            pnlSearchBar.Controls.Add(txtNetoTotal);
            pnlSearchBar.Controls.Add(lblNeto);
            pnlSearchBar.Controls.Add(btnGenerarExcel);
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Dock = DockStyle.Fill;
            pnlSearchBar.Location = new Point(0, 27);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1028, 499);
            pnlSearchBar.TabIndex = 16;
            // 
            // txtNroTotalDeProductos
            // 
            txtNroTotalDeProductos.Location = new Point(12, 244);
            txtNroTotalDeProductos.Name = "txtNroTotalDeProductos";
            txtNroTotalDeProductos.ReadOnly = true;
            txtNroTotalDeProductos.Size = new Size(194, 27);
            txtNroTotalDeProductos.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 213);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 24;
            label1.Text = "TOTAL de productos:";
            // 
            // txtNetoTotal
            // 
            txtNetoTotal.Location = new Point(229, 244);
            txtNetoTotal.Name = "txtNetoTotal";
            txtNetoTotal.ReadOnly = true;
            txtNetoTotal.Size = new Size(194, 27);
            txtNetoTotal.TabIndex = 23;
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Font = new Font("Segoe UI", 12F);
            lblNeto.ForeColor = SystemColors.Window;
            lblNeto.Location = new Point(229, 213);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(119, 28);
            lblNeto.TabIndex = 22;
            lblNeto.Text = "Neto TOTAL:";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.Black;
            btnGenerarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarExcel.ForeColor = SystemColors.Window;
            btnGenerarExcel.Location = new Point(12, 309);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(194, 82);
            btnGenerarExcel.TabIndex = 16;
            btnGenerarExcel.Text = "GENERAR EXCEL";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 12F);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 132);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(772, 28);
            lblBarraDeBusqueda.TabIndex = 11;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por Nº de pesaje, nombre de producto o cód. de producto)";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 1055);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewStock);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Stock";
            Text = "Stock";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Label lblTitulo;
        private DataGridView DataGridViewStock;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel pnlSearchBar;
        private ToolStripButton btnShowHideTabla;
        private Button btnGenerarExcel;
        private TextBox txtNetoTotal;
        private Label lblNeto;
        private Label lblBarraDeBusqueda;
        private TextBox txtNroTotalDeProductos;
        private Label label1;
    }
}