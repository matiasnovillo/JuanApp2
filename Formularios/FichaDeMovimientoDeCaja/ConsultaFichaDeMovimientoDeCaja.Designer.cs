namespace JuanApp2.Formularios.FichaDeMovimientoDeCaja
{
    partial class ConsultaFichaDeMovimientoDeCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFichaDeMovimientoDeCaja));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewFicha = new DataGridView();
            lblTitulo = new Label();
            txtBuscar = new TextBox();
            lblRegistrosPorPagina = new Label();
            pnlFiltersAndSearchBar = new Panel();
            panel3 = new Panel();
            txtRegistrosPorPagina = new NumericUpDown();
            txtSaldoTotal = new TextBox();
            btnPagoProveedor = new Button();
            btnCobranza = new Button();
            btnVario = new Button();
            btnGasto = new Button();
            btnBuscar = new Button();
            PanelColor = new Panel();
            lblColorVarios = new Label();
            btnPagoAProveedores = new Button();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            btnExportarAExcel = new Button();
            cmbTipoDeMovimiento = new ComboBox();
            lblBarraBusqueda = new Label();
            lblSaldoTotal = new Label();
            DateTimePickerFechaFin = new DateTimePicker();
            DateTimePickerFechaInicio = new DateTimePicker();
            ColorDialogForVarios = new ColorDialog();
            ColorDialogForPagoAProveedores = new ColorDialog();
            ColorDialogForGastos = new ColorDialog();
            ColorDialogForCobranza = new ColorDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFicha).BeginInit();
            pnlFiltersAndSearchBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRegistrosPorPagina).BeginInit();
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
            // DataGridViewFicha
            // 
            DataGridViewFicha.AllowUserToAddRows = false;
            DataGridViewFicha.AllowUserToDeleteRows = false;
            DataGridViewFicha.BackgroundColor = Color.Black;
            DataGridViewFicha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFicha.Dock = DockStyle.Bottom;
            DataGridViewFicha.GridColor = Color.FromArgb(41, 48, 57);
            DataGridViewFicha.Location = new Point(0, 557);
            DataGridViewFicha.Name = "DataGridViewFicha";
            DataGridViewFicha.ReadOnly = true;
            DataGridViewFicha.RowHeadersWidth = 51;
            DataGridViewFicha.Size = new Size(1924, 472);
            DataGridViewFicha.TabIndex = 2;
            DataGridViewFicha.CellClick += DataGridViewFicha_CellClick;
            DataGridViewFicha.CellContentClick += DataGridViewEntrada_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1110, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de ficha de movimiento de caja";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(12, 234);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 31);
            txtBuscar.TabIndex = 10;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblRegistrosPorPagina
            // 
            lblRegistrosPorPagina.AutoSize = true;
            lblRegistrosPorPagina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrosPorPagina.ForeColor = SystemColors.Window;
            lblRegistrosPorPagina.Location = new Point(1686, 58);
            lblRegistrosPorPagina.Name = "lblRegistrosPorPagina";
            lblRegistrosPorPagina.Size = new Size(193, 28);
            lblRegistrosPorPagina.TabIndex = 16;
            lblRegistrosPorPagina.Text = "Registros por página";
            // 
            // pnlFiltersAndSearchBar
            // 
            pnlFiltersAndSearchBar.BackColor = Color.Black;
            pnlFiltersAndSearchBar.Controls.Add(panel3);
            pnlFiltersAndSearchBar.Dock = DockStyle.Fill;
            pnlFiltersAndSearchBar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlFiltersAndSearchBar.ForeColor = Color.Goldenrod;
            pnlFiltersAndSearchBar.Location = new Point(0, 27);
            pnlFiltersAndSearchBar.Name = "pnlFiltersAndSearchBar";
            pnlFiltersAndSearchBar.Size = new Size(1924, 530);
            pnlFiltersAndSearchBar.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(txtRegistrosPorPagina);
            panel3.Controls.Add(txtSaldoTotal);
            panel3.Controls.Add(btnPagoProveedor);
            panel3.Controls.Add(btnCobranza);
            panel3.Controls.Add(btnVario);
            panel3.Controls.Add(btnGasto);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(PanelColor);
            panel3.Controls.Add(lblColorVarios);
            panel3.Controls.Add(btnPagoAProveedores);
            panel3.Controls.Add(lblFechaFin);
            panel3.Controls.Add(lblFechaInicio);
            panel3.Controls.Add(btnExportarAExcel);
            panel3.Controls.Add(cmbTipoDeMovimiento);
            panel3.Controls.Add(lblBarraBusqueda);
            panel3.Controls.Add(lblSaldoTotal);
            panel3.Controls.Add(DateTimePickerFechaFin);
            panel3.Controls.Add(DateTimePickerFechaInicio);
            panel3.Controls.Add(lblTitulo);
            panel3.Controls.Add(lblRegistrosPorPagina);
            panel3.Controls.Add(txtBuscar);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.Goldenrod;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 530);
            panel3.TabIndex = 42;
            // 
            // txtRegistrosPorPagina
            // 
            txtRegistrosPorPagina.Location = new Point(1686, 89);
            txtRegistrosPorPagina.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtRegistrosPorPagina.Name = "txtRegistrosPorPagina";
            txtRegistrosPorPagina.Size = new Size(193, 38);
            txtRegistrosPorPagina.TabIndex = 47;
            // 
            // txtSaldoTotal
            // 
            txtSaldoTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaldoTotal.ForeColor = SystemColors.ControlLightLight;
            txtSaldoTotal.Location = new Point(12, 313);
            txtSaldoTotal.Name = "txtSaldoTotal";
            txtSaldoTotal.Size = new Size(210, 43);
            txtSaldoTotal.TabIndex = 22;
            // 
            // btnPagoProveedor
            // 
            btnPagoProveedor.BackColor = Color.Black;
            btnPagoProveedor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPagoProveedor.ForeColor = SystemColors.Window;
            btnPagoProveedor.Location = new Point(12, 379);
            btnPagoProveedor.Name = "btnPagoProveedor";
            btnPagoProveedor.Size = new Size(189, 69);
            btnPagoProveedor.TabIndex = 27;
            btnPagoProveedor.Text = "PAGO PROVEEDORES";
            btnPagoProveedor.UseVisualStyleBackColor = false;
            btnPagoProveedor.Click += btnPagoProveedor_Click;
            // 
            // btnCobranza
            // 
            btnCobranza.BackColor = Color.Black;
            btnCobranza.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCobranza.ForeColor = SystemColors.Window;
            btnCobranza.Location = new Point(226, 379);
            btnCobranza.Name = "btnCobranza";
            btnCobranza.Size = new Size(189, 69);
            btnCobranza.TabIndex = 26;
            btnCobranza.Text = "COBRANZA";
            btnCobranza.UseVisualStyleBackColor = false;
            btnCobranza.Click += btnCobranza_Click;
            // 
            // btnVario
            // 
            btnVario.BackColor = Color.Black;
            btnVario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVario.ForeColor = SystemColors.Window;
            btnVario.Location = new Point(444, 379);
            btnVario.Name = "btnVario";
            btnVario.Size = new Size(189, 69);
            btnVario.TabIndex = 29;
            btnVario.Text = "VARIOS";
            btnVario.UseVisualStyleBackColor = false;
            btnVario.Click += btnVario_Click;
            // 
            // btnGasto
            // 
            btnGasto.BackColor = Color.Black;
            btnGasto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGasto.ForeColor = SystemColors.Window;
            btnGasto.Location = new Point(658, 379);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(189, 69);
            btnGasto.TabIndex = 28;
            btnGasto.Text = "GASTOS";
            btnGasto.UseVisualStyleBackColor = false;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1690, 379);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 69);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
            // 
            // PanelColor
            // 
            PanelColor.BackColor = Color.White;
            PanelColor.Location = new Point(748, 151);
            PanelColor.Name = "PanelColor";
            PanelColor.Size = new Size(122, 31);
            PanelColor.TabIndex = 38;
            PanelColor.MouseClick += PanelColourVarios_MouseClick;
            // 
            // lblColorVarios
            // 
            lblColorVarios.AutoSize = true;
            lblColorVarios.Font = new Font("Segoe UI", 10.8F);
            lblColorVarios.ForeColor = SystemColors.Window;
            lblColorVarios.Location = new Point(748, 123);
            lblColorVarios.Name = "lblColorVarios";
            lblColorVarios.Size = new Size(55, 25);
            lblColorVarios.TabIndex = 39;
            lblColorVarios.Text = "Color";
            // 
            // btnPagoAProveedores
            // 
            btnPagoAProveedores.BackColor = Color.Black;
            btnPagoAProveedores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPagoAProveedores.ForeColor = SystemColors.Window;
            btnPagoAProveedores.Location = new Point(12, 379);
            btnPagoAProveedores.Name = "btnPagoAProveedores";
            btnPagoAProveedores.Size = new Size(189, 69);
            btnPagoAProveedores.TabIndex = 27;
            btnPagoAProveedores.Text = "PAGO PROVEEDORES";
            btnPagoAProveedores.UseVisualStyleBackColor = false;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10.8F);
            lblFechaFin.ForeColor = SystemColors.Window;
            lblFechaFin.Location = new Point(384, 123);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(107, 25);
            lblFechaFin.TabIndex = 20;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10.8F);
            lblFechaInicio.ForeColor = SystemColors.Window;
            lblFechaInicio.Location = new Point(12, 123);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(128, 25);
            lblFechaInicio.TabIndex = 19;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // btnExportarAExcel
            // 
            btnExportarAExcel.BackColor = Color.Black;
            btnExportarAExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExportarAExcel.ForeColor = SystemColors.Window;
            btnExportarAExcel.Location = new Point(1472, 379);
            btnExportarAExcel.Name = "btnExportarAExcel";
            btnExportarAExcel.Size = new Size(189, 69);
            btnExportarAExcel.TabIndex = 37;
            btnExportarAExcel.Text = "EXPORTAR A EXCEL";
            btnExportarAExcel.UseVisualStyleBackColor = false;
            btnExportarAExcel.Click += btnExportarAExcel_Click;
            // 
            // cmbTipoDeMovimiento
            // 
            cmbTipoDeMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeMovimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoDeMovimiento.FormattingEnabled = true;
            cmbTipoDeMovimiento.Location = new Point(603, 234);
            cmbTipoDeMovimiento.Name = "cmbTipoDeMovimiento";
            cmbTipoDeMovimiento.Size = new Size(267, 36);
            cmbTipoDeMovimiento.TabIndex = 35;
            cmbTipoDeMovimiento.SelectedIndexChanged += cmbTipoDeMovimiento_SelectedIndexChanged;
            // 
            // lblBarraBusqueda
            // 
            lblBarraBusqueda.AutoSize = true;
            lblBarraBusqueda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraBusqueda.ForeColor = SystemColors.Window;
            lblBarraBusqueda.Location = new Point(12, 206);
            lblBarraBusqueda.Name = "lblBarraBusqueda";
            lblBarraBusqueda.Size = new Size(482, 25);
            lblBarraBusqueda.TabIndex = 9;
            lblBarraBusqueda.Text = "Barra de búsqueda (Busque por descripción y/o proveedor)";
            // 
            // lblSaldoTotal
            // 
            lblSaldoTotal.AutoSize = true;
            lblSaldoTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldoTotal.ForeColor = SystemColors.Window;
            lblSaldoTotal.Location = new Point(12, 285);
            lblSaldoTotal.Name = "lblSaldoTotal";
            lblSaldoTotal.Size = new Size(98, 25);
            lblSaldoTotal.TabIndex = 31;
            lblSaldoTotal.Text = "Saldo total";
            // 
            // DateTimePickerFechaFin
            // 
            DateTimePickerFechaFin.Font = new Font("Segoe UI", 10.8F);
            DateTimePickerFechaFin.Location = new Point(384, 151);
            DateTimePickerFechaFin.Name = "DateTimePickerFechaFin";
            DateTimePickerFechaFin.Size = new Size(319, 31);
            DateTimePickerFechaFin.TabIndex = 18;
            // 
            // DateTimePickerFechaInicio
            // 
            DateTimePickerFechaInicio.Font = new Font("Segoe UI", 10.8F);
            DateTimePickerFechaInicio.Location = new Point(12, 151);
            DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio";
            DateTimePickerFechaInicio.Size = new Size(319, 31);
            DateTimePickerFechaInicio.TabIndex = 17;
            // 
            // ConsultaFichaDeMovimientoDeCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlFiltersAndSearchBar);
            Controls.Add(DataGridViewFicha);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ConsultaFichaDeMovimientoDeCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de ficha de movimiento de caja";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFicha).EndInit();
            pnlFiltersAndSearchBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtRegistrosPorPagina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewFicha;
        private Label lblTitulo;
        private TextBox txtBuscar;
        private Label lblRegistrosPorPagina;
        private Panel pnlFiltersAndSearchBar;
        private Label label3;
        private DateTimePicker DateTimePickerFechaFin;
        private DateTimePicker DateTimePickerFechaInicio;
        private Button btnGasto;
        private Button btnVario;
        private Button btnCobranza;
        private Button btnPagoProveedor;
        private TextBox txtSaldoTotal;
        private Button btnBuscar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblSaldoTotal;
        private Label label9;
        private ComboBox cmbTipoDeMovimiento;
        private Button btnExportarAExcel;
        private Label label4;
        private Panel PanelColor;
        private ColorDialog ColorDialogForVarios;
        private Panel panel3;
        private Label label11;
        private Label label12;
        private Button button2;
        private Label label13;
        private ComboBox comboBox1;
        private Button btnPagoAProveedores;
        private Label lblFechaFin;
        private Label label19;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox5;
        private Label label10;
        private Panel panel1;
        private ColorDialog ColorDialogForPagoAProveedores;
        private ColorDialog ColorDialogForGastos;
        private ColorDialog ColorDialogForCobranza;
        private Label lblColorVarios;
        private Label lblFechaInicio;
        private Label lblBarraBusqueda;
        private NumericUpDown txtRegistrosPorPagina;
    }
}