namespace JuanApp2.Formularios.Proveedor
{
    partial class ConsultaProveedorCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProveedorCustom));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewCompra = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlFiltersAndSearchBar = new Panel();
            PanelColourIngreso = new Panel();
            label5 = new Label();
            btnIngresar = new Button();
            PanelColourPagoAProveedores = new Panel();
            label8 = new Label();
            PanelColourCompra = new Panel();
            label12 = new Label();
            btnExportarAExcel = new Button();
            label7 = new Label();
            cmbProveedor = new ComboBox();
            label4 = new Label();
            txtSaldoTotal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DateTimePickerFechaFin = new DateTimePicker();
            DateTimePickerFechaInicio = new DateTimePicker();
            btnAgregarCompra = new Button();
            ColorDialogForCompra = new ColorDialog();
            ColorDialogForPagoAProveedores = new ColorDialog();
            ColorDialogForIngreso = new ColorDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCompra).BeginInit();
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
            toolStrip1.Size = new Size(1924, 27);
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
            statusStrip1.Size = new Size(1924, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewCompra
            // 
            DataGridViewCompra.AllowUserToAddRows = false;
            DataGridViewCompra.AllowUserToDeleteRows = false;
            DataGridViewCompra.BackgroundColor = Color.Black;
            DataGridViewCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCompra.Dock = DockStyle.Bottom;
            DataGridViewCompra.GridColor = Color.FromArgb(41, 48, 57);
            DataGridViewCompra.Location = new Point(0, 580);
            DataGridViewCompra.Name = "DataGridViewCompra";
            DataGridViewCompra.ReadOnly = true;
            DataGridViewCompra.RowHeadersWidth = 51;
            DataGridViewCompra.Size = new Size(1924, 449);
            DataGridViewCompra.TabIndex = 2;
            DataGridViewCompra.CellClick += DataGridViewCompra_CellClick;
            DataGridViewCompra.CellContentClick += DataGridViewEntrada_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(693, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de proveedores";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1723, 342);
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
            lblBarraDeBusqueda.Size = new Size(428, 23);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por nombre de proveedor)";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 274);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 38);
            txtBuscar.TabIndex = 10;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Location = new Point(1686, 86);
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
            label1.Location = new Point(1686, 42);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 16;
            label1.Text = "Registros por página";
            // 
            // pnlFiltersAndSearchBar
            // 
            pnlFiltersAndSearchBar.BackColor = Color.Black;
            pnlFiltersAndSearchBar.Controls.Add(PanelColourIngreso);
            pnlFiltersAndSearchBar.Controls.Add(label5);
            pnlFiltersAndSearchBar.Controls.Add(btnIngresar);
            pnlFiltersAndSearchBar.Controls.Add(PanelColourPagoAProveedores);
            pnlFiltersAndSearchBar.Controls.Add(label8);
            pnlFiltersAndSearchBar.Controls.Add(PanelColourCompra);
            pnlFiltersAndSearchBar.Controls.Add(label12);
            pnlFiltersAndSearchBar.Controls.Add(btnExportarAExcel);
            pnlFiltersAndSearchBar.Controls.Add(label7);
            pnlFiltersAndSearchBar.Controls.Add(cmbProveedor);
            pnlFiltersAndSearchBar.Controls.Add(label4);
            pnlFiltersAndSearchBar.Controls.Add(txtSaldoTotal);
            pnlFiltersAndSearchBar.Controls.Add(label3);
            pnlFiltersAndSearchBar.Controls.Add(label2);
            pnlFiltersAndSearchBar.Controls.Add(DateTimePickerFechaFin);
            pnlFiltersAndSearchBar.Controls.Add(DateTimePickerFechaInicio);
            pnlFiltersAndSearchBar.Controls.Add(btnAgregarCompra);
            pnlFiltersAndSearchBar.Controls.Add(lblTitulo);
            pnlFiltersAndSearchBar.Controls.Add(label1);
            pnlFiltersAndSearchBar.Controls.Add(btnBuscar);
            pnlFiltersAndSearchBar.Controls.Add(numericUpDownRegistrosPorPagina);
            pnlFiltersAndSearchBar.Controls.Add(txtBuscar);
            pnlFiltersAndSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlFiltersAndSearchBar.Dock = DockStyle.Fill;
            pnlFiltersAndSearchBar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlFiltersAndSearchBar.ForeColor = Color.Goldenrod;
            pnlFiltersAndSearchBar.Location = new Point(0, 27);
            pnlFiltersAndSearchBar.Name = "pnlFiltersAndSearchBar";
            pnlFiltersAndSearchBar.Size = new Size(1924, 553);
            pnlFiltersAndSearchBar.TabIndex = 17;
            // 
            // PanelColourIngreso
            // 
            PanelColourIngreso.BackColor = Color.Yellow;
            PanelColourIngreso.Location = new Point(1347, 160);
            PanelColourIngreso.Name = "PanelColourIngreso";
            PanelColourIngreso.Size = new Size(193, 31);
            PanelColourIngreso.TabIndex = 45;
            PanelColourIngreso.Click += PanelColourIngreso_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(1347, 132);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 46;
            label5.Text = "Color para INGRESO";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Black;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = SystemColors.Window;
            btnIngresar.Location = new Point(1275, 342);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(189, 84);
            btnIngresar.TabIndex = 44;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // PanelColourPagoAProveedores
            // 
            PanelColourPagoAProveedores.BackColor = Color.IndianRed;
            PanelColourPagoAProveedores.Location = new Point(1051, 160);
            PanelColourPagoAProveedores.Name = "PanelColourPagoAProveedores";
            PanelColourPagoAProveedores.Size = new Size(290, 31);
            PanelColourPagoAProveedores.TabIndex = 42;
            PanelColourPagoAProveedores.MouseClick += PanelColourPagoAProveedores_MouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(1051, 132);
            label8.Name = "label8";
            label8.Size = new Size(290, 25);
            label8.TabIndex = 43;
            label8.Text = "Color para PAGO A PROVEEDORES";
            // 
            // PanelColourCompra
            // 
            PanelColourCompra.BackColor = Color.FromArgb(128, 255, 128);
            PanelColourCompra.Location = new Point(871, 160);
            PanelColourCompra.Name = "PanelColourCompra";
            PanelColourCompra.Size = new Size(174, 31);
            PanelColourCompra.TabIndex = 40;
            PanelColourCompra.MouseClick += PanelColourCobranza_MouseClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(871, 132);
            label12.Name = "label12";
            label12.Size = new Size(174, 25);
            label12.TabIndex = 41;
            label12.Text = "Color para COMPRA";
            // 
            // btnExportarAExcel
            // 
            btnExportarAExcel.BackColor = Color.Black;
            btnExportarAExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExportarAExcel.ForeColor = SystemColors.Window;
            btnExportarAExcel.Location = new Point(1048, 342);
            btnExportarAExcel.Name = "btnExportarAExcel";
            btnExportarAExcel.Size = new Size(189, 84);
            btnExportarAExcel.TabIndex = 30;
            btnExportarAExcel.Text = "EXPORTAR A EXCEL";
            btnExportarAExcel.UseVisualStyleBackColor = false;
            btnExportarAExcel.Click += btnExportarAExcel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(570, 240);
            label7.Name = "label7";
            label7.Size = new Size(118, 31);
            label7.TabIndex = 29;
            label7.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(570, 274);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(253, 39);
            cmbProveedor.TabIndex = 28;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(3, 354);
            label4.Name = "label4";
            label4.Size = new Size(124, 31);
            label4.TabIndex = 25;
            label4.Text = "Saldo total";
            // 
            // txtSaldoTotal
            // 
            txtSaldoTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaldoTotal.ForeColor = SystemColors.ControlLightLight;
            txtSaldoTotal.Location = new Point(12, 388);
            txtSaldoTotal.Name = "txtSaldoTotal";
            txtSaldoTotal.ReadOnly = true;
            txtSaldoTotal.Size = new Size(253, 43);
            txtSaldoTotal.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(442, 126);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 21;
            label3.Text = "Fecha de fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 20;
            label2.Text = "Fecha de inicio";
            // 
            // DateTimePickerFechaFin
            // 
            DateTimePickerFechaFin.Location = new Point(442, 160);
            DateTimePickerFechaFin.Name = "DateTimePickerFechaFin";
            DateTimePickerFechaFin.Size = new Size(363, 38);
            DateTimePickerFechaFin.TabIndex = 19;
            // 
            // DateTimePickerFechaInicio
            // 
            DateTimePickerFechaInicio.Location = new Point(12, 160);
            DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio";
            DateTimePickerFechaInicio.Size = new Size(363, 38);
            DateTimePickerFechaInicio.TabIndex = 18;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.BackColor = Color.Black;
            btnAgregarCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarCompra.ForeColor = SystemColors.Window;
            btnAgregarCompra.Location = new Point(1498, 342);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(189, 84);
            btnAgregarCompra.TabIndex = 17;
            btnAgregarCompra.Text = "COMPRAR";
            btnAgregarCompra.UseVisualStyleBackColor = false;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // ConsultaProveedorCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlFiltersAndSearchBar);
            Controls.Add(DataGridViewCompra);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ConsultaProveedorCustom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de proveedores";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCompra).EndInit();
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
        private DataGridView DataGridViewCompra;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
        private Panel pnlFiltersAndSearchBar;
        private Button btnAgregarCompra;
        private Label label3;
        private Label label2;
        private DateTimePicker DateTimePickerFechaFin;
        private DateTimePicker DateTimePickerFechaInicio;
        private Label label4;
        private TextBox txtSaldoTotal;
        private Label label7;
        private ComboBox cmbProveedor;
        private Button btnExportarAExcel;
        private Panel PanelColourPagoAProveedores;
        private Label label8;
        private Panel PanelColourCompra;
        private Label label12;
        private ColorDialog ColorDialogForCompra;
        private ColorDialog ColorDialogForPagoAProveedores;
        private Button btnIngresar;
        private Panel PanelColourIngreso;
        private Label label5;
        private ColorDialog ColorDialogForIngreso;
    }
}