namespace JuanApp.Formularios.Entrada
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
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlFiltersAndSearchBar = new Panel();
            label9 = new Label();
            cmbTipoDeMovimiento = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            btnGasto = new Button();
            btnVario = new Button();
            btnCobranza = new Button();
            btnPagoProveedor = new Button();
            txtSaldoCheque = new TextBox();
            txtSaldoBanco = new TextBox();
            txtSaldoEfectivo = new TextBox();
            txtSaldoTotal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DateTimePickerFechaFin = new DateTimePicker();
            DateTimePickerFechaInicio = new DateTimePicker();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFicha).BeginInit();
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
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 206);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(482, 25);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por descripción y/o proveedor)";
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
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownRegistrosPorPagina.Location = new Point(1686, 89);
            numericUpDownRegistrosPorPagina.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownRegistrosPorPagina.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Name = "numericUpDownRegistrosPorPagina";
            numericUpDownRegistrosPorPagina.Size = new Size(150, 31);
            numericUpDownRegistrosPorPagina.TabIndex = 15;
            numericUpDownRegistrosPorPagina.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(1686, 58);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 16;
            label1.Text = "Registros por página";
            // 
            // pnlFiltersAndSearchBar
            // 
            pnlFiltersAndSearchBar.BackColor = Color.Black;
            pnlFiltersAndSearchBar.Controls.Add(label9);
            pnlFiltersAndSearchBar.Controls.Add(cmbTipoDeMovimiento);
            pnlFiltersAndSearchBar.Controls.Add(label8);
            pnlFiltersAndSearchBar.Controls.Add(label7);
            pnlFiltersAndSearchBar.Controls.Add(label6);
            pnlFiltersAndSearchBar.Controls.Add(label5);
            pnlFiltersAndSearchBar.Controls.Add(button1);
            pnlFiltersAndSearchBar.Controls.Add(btnGasto);
            pnlFiltersAndSearchBar.Controls.Add(btnVario);
            pnlFiltersAndSearchBar.Controls.Add(btnCobranza);
            pnlFiltersAndSearchBar.Controls.Add(btnPagoProveedor);
            pnlFiltersAndSearchBar.Controls.Add(txtSaldoCheque);
            pnlFiltersAndSearchBar.Controls.Add(txtSaldoBanco);
            pnlFiltersAndSearchBar.Controls.Add(txtSaldoEfectivo);
            pnlFiltersAndSearchBar.Controls.Add(txtSaldoTotal);
            pnlFiltersAndSearchBar.Controls.Add(label3);
            pnlFiltersAndSearchBar.Controls.Add(label2);
            pnlFiltersAndSearchBar.Controls.Add(DateTimePickerFechaFin);
            pnlFiltersAndSearchBar.Controls.Add(DateTimePickerFechaInicio);
            pnlFiltersAndSearchBar.Controls.Add(lblTitulo);
            pnlFiltersAndSearchBar.Controls.Add(label1);
            pnlFiltersAndSearchBar.Controls.Add(numericUpDownRegistrosPorPagina);
            pnlFiltersAndSearchBar.Controls.Add(txtBuscar);
            pnlFiltersAndSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlFiltersAndSearchBar.Dock = DockStyle.Fill;
            pnlFiltersAndSearchBar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlFiltersAndSearchBar.ForeColor = Color.Goldenrod;
            pnlFiltersAndSearchBar.Location = new Point(0, 27);
            pnlFiltersAndSearchBar.Name = "pnlFiltersAndSearchBar";
            pnlFiltersAndSearchBar.Size = new Size(1924, 530);
            pnlFiltersAndSearchBar.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(603, 206);
            label9.Name = "label9";
            label9.Size = new Size(173, 25);
            label9.TabIndex = 36;
            label9.Text = "Tipo de movimiento";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(658, 298);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 34;
            label8.Text = "Cheque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(444, 298);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 33;
            label7.Text = "Banco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(226, 298);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 32;
            label6.Text = "Efectivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 31;
            label5.Text = "Saldo total";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1647, 379);
            button1.Name = "button1";
            button1.Size = new Size(189, 69);
            button1.TabIndex = 30;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // txtSaldoCheque
            // 
            txtSaldoCheque.Font = new Font("Segoe UI", 10.8F);
            txtSaldoCheque.ForeColor = SystemColors.ControlLightLight;
            txtSaldoCheque.Location = new Point(660, 326);
            txtSaldoCheque.Name = "txtSaldoCheque";
            txtSaldoCheque.Size = new Size(210, 31);
            txtSaldoCheque.TabIndex = 25;
            // 
            // txtSaldoBanco
            // 
            txtSaldoBanco.Font = new Font("Segoe UI", 10.8F);
            txtSaldoBanco.ForeColor = SystemColors.ControlLightLight;
            txtSaldoBanco.Location = new Point(444, 326);
            txtSaldoBanco.Name = "txtSaldoBanco";
            txtSaldoBanco.Size = new Size(210, 31);
            txtSaldoBanco.TabIndex = 24;
            // 
            // txtSaldoEfectivo
            // 
            txtSaldoEfectivo.Font = new Font("Segoe UI", 10.8F);
            txtSaldoEfectivo.ForeColor = SystemColors.ControlLightLight;
            txtSaldoEfectivo.Location = new Point(228, 326);
            txtSaldoEfectivo.Name = "txtSaldoEfectivo";
            txtSaldoEfectivo.Size = new Size(210, 31);
            txtSaldoEfectivo.TabIndex = 23;
            // 
            // txtSaldoTotal
            // 
            txtSaldoTotal.Font = new Font("Segoe UI", 10.8F);
            txtSaldoTotal.ForeColor = SystemColors.ControlLightLight;
            txtSaldoTotal.Location = new Point(12, 326);
            txtSaldoTotal.Name = "txtSaldoTotal";
            txtSaldoTotal.Size = new Size(210, 31);
            txtSaldoTotal.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(384, 123);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 20;
            label3.Text = "Fecha de fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 19;
            label2.Text = "Fecha de inicio";
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
        private DataGridView DataGridViewFicha;
        private Label lblTitulo;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
        private Panel pnlFiltersAndSearchBar;
        private Label label3;
        private Label label2;
        private DateTimePicker DateTimePickerFechaFin;
        private DateTimePicker DateTimePickerFechaInicio;
        private Button btnGasto;
        private Button btnVario;
        private Button btnCobranza;
        private Button btnPagoProveedor;
        private TextBox txtSaldoCheque;
        private TextBox txtSaldoBanco;
        private TextBox txtSaldoEfectivo;
        private TextBox txtSaldoTotal;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private ComboBox cmbTipoDeMovimiento;
    }
}