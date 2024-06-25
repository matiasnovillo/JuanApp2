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
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlFiltersAndSearchBar = new Panel();
            panel3 = new Panel();
            PanelColourVarios = new Panel();
            label24 = new Label();
            PanelColourCobranza = new Panel();
            label23 = new Label();
            PanelColourGastos = new Panel();
            label11 = new Label();
            PanelColourPagoAProveedores = new Panel();
            label12 = new Label();
            button2 = new Button();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnPagoAProveedores = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label20 = new Label();
            label21 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox5 = new TextBox();
            label22 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            btnExportarAExcel = new Button();
            label9 = new Label();
            cmbTipoDeMovimiento = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
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
            ColorDialogForVarios = new ColorDialog();
            ColorDialogForPagoAProveedores = new ColorDialog();
            ColorDialogForGastos = new ColorDialog();
            ColorDialogForCobranza = new ColorDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFicha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).BeginInit();
            pnlFiltersAndSearchBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            pnlFiltersAndSearchBar.Controls.Add(panel3);
            pnlFiltersAndSearchBar.Controls.Add(label10);
            pnlFiltersAndSearchBar.Controls.Add(panel1);
            pnlFiltersAndSearchBar.Controls.Add(label4);
            pnlFiltersAndSearchBar.Controls.Add(btnExportarAExcel);
            pnlFiltersAndSearchBar.Controls.Add(label9);
            pnlFiltersAndSearchBar.Controls.Add(cmbTipoDeMovimiento);
            pnlFiltersAndSearchBar.Controls.Add(label8);
            pnlFiltersAndSearchBar.Controls.Add(label7);
            pnlFiltersAndSearchBar.Controls.Add(label6);
            pnlFiltersAndSearchBar.Controls.Add(label5);
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
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btnPagoProveedor);
            panel3.Controls.Add(btnCobranza);
            panel3.Controls.Add(btnVario);
            panel3.Controls.Add(btnGasto);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(PanelColourVarios);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(PanelColourCobranza);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(PanelColourGastos);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(PanelColourPagoAProveedores);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnPagoAProveedores);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label22);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.Goldenrod;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 530);
            panel3.TabIndex = 42;
            // 
            // PanelColourVarios
            // 
            PanelColourVarios.BackColor = Color.White;
            PanelColourVarios.Location = new Point(751, 151);
            PanelColourVarios.Name = "PanelColourVarios";
            PanelColourVarios.Size = new Size(162, 31);
            PanelColourVarios.TabIndex = 38;
            PanelColourVarios.MouseClick += PanelColourVarios_MouseClick;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.8F);
            label24.ForeColor = SystemColors.Window;
            label24.Location = new Point(1387, 123);
            label24.Name = "label24";
            label24.Size = new Size(193, 25);
            label24.TabIndex = 45;
            label24.Text = "Color para COBRANZA";
            // 
            // PanelColourCobranza
            // 
            PanelColourCobranza.BackColor = Color.White;
            PanelColourCobranza.Location = new Point(1387, 151);
            PanelColourCobranza.Name = "PanelColourCobranza";
            PanelColourCobranza.Size = new Size(193, 31);
            PanelColourCobranza.TabIndex = 44;
            PanelColourCobranza.MouseClick += PanelColourCobranza_MouseClick;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.8F);
            label23.ForeColor = SystemColors.Window;
            label23.Location = new Point(1215, 123);
            label23.Name = "label23";
            label23.Size = new Size(166, 25);
            label23.TabIndex = 43;
            label23.Text = "Color para GASTOS";
            // 
            // PanelColourGastos
            // 
            PanelColourGastos.BackColor = Color.White;
            PanelColourGastos.Location = new Point(1215, 151);
            PanelColourGastos.Name = "PanelColourGastos";
            PanelColourGastos.Size = new Size(166, 31);
            PanelColourGastos.TabIndex = 42;
            PanelColourGastos.MouseClick += PanelColourGastos_MouseClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(919, 123);
            label11.Name = "label11";
            label11.Size = new Size(290, 25);
            label11.TabIndex = 41;
            label11.Text = "Color para PAGO A PROVEEDORES";
            // 
            // PanelColourPagoAProveedores
            // 
            PanelColourPagoAProveedores.BackColor = Color.White;
            PanelColourPagoAProveedores.Location = new Point(919, 151);
            PanelColourPagoAProveedores.Name = "PanelColourPagoAProveedores";
            PanelColourPagoAProveedores.Size = new Size(290, 31);
            PanelColourPagoAProveedores.TabIndex = 40;
            PanelColourPagoAProveedores.MouseClick += PanelColourPagoAProveedores_MouseClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(751, 123);
            label12.Name = "label12";
            label12.Size = new Size(162, 25);
            label12.TabIndex = 39;
            label12.Text = "Color para VARIOS";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(1408, 379);
            button2.Name = "button2";
            button2.Size = new Size(189, 69);
            button2.TabIndex = 37;
            button2.Text = "EXPORTAR A EXCEL";
            button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(603, 206);
            label13.Name = "label13";
            label13.Size = new Size(173, 25);
            label13.TabIndex = 36;
            label13.Text = "Tipo de movimiento";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(603, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 36);
            comboBox1.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Window;
            label14.Location = new Point(658, 298);
            label14.Name = "label14";
            label14.Size = new Size(72, 25);
            label14.TabIndex = 34;
            label14.Text = "Cheque";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Window;
            label15.Location = new Point(444, 298);
            label15.Name = "label15";
            label15.Size = new Size(60, 25);
            label15.TabIndex = 33;
            label15.Text = "Banco";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Window;
            label16.Location = new Point(226, 298);
            label16.Name = "label16";
            label16.Size = new Size(74, 25);
            label16.TabIndex = 32;
            label16.Text = "Efectivo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Window;
            label17.Location = new Point(12, 298);
            label17.Name = "label17";
            label17.Size = new Size(98, 25);
            label17.TabIndex = 31;
            label17.Text = "Saldo total";
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.ForeColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(660, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 31);
            textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.ForeColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(444, 326);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 31);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F);
            textBox3.ForeColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(228, 326);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 31);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.8F);
            textBox4.ForeColor = SystemColors.ControlLightLight;
            textBox4.Location = new Point(12, 326);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 31);
            textBox4.TabIndex = 22;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F);
            label18.ForeColor = SystemColors.Window;
            label18.Location = new Point(384, 123);
            label18.Name = "label18";
            label18.Size = new Size(107, 25);
            label18.TabIndex = 20;
            label18.Text = "Fecha de fin";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F);
            label19.ForeColor = SystemColors.Window;
            label19.Location = new Point(12, 123);
            label19.Name = "label19";
            label19.Size = new Size(128, 25);
            label19.TabIndex = 19;
            label19.Text = "Fecha de inicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker1.Location = new Point(384, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 31);
            dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker2.Location = new Point(12, 151);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(319, 31);
            dateTimePicker2.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Window;
            label20.Location = new Point(12, 19);
            label20.Name = "label20";
            label20.Size = new Size(1110, 81);
            label20.TabIndex = 3;
            label20.Text = "Consulta de ficha de movimiento de caja";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Window;
            label21.Location = new Point(1686, 58);
            label21.Name = "label21";
            label21.Size = new Size(193, 28);
            label21.TabIndex = 16;
            label21.Text = "Registros por página";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(1686, 89);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 234);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(532, 31);
            textBox5.TabIndex = 10;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.Window;
            label22.Location = new Point(12, 206);
            label22.Name = "label22";
            label22.Size = new Size(482, 25);
            label22.TabIndex = 9;
            label22.Text = "Barra de búsqueda (Busque por descripción y/o proveedor)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(919, 123);
            label10.Name = "label10";
            label10.Size = new Size(290, 25);
            label10.TabIndex = 41;
            label10.Text = "Color para PAGO A PROVEEDORES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(919, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 31);
            panel1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(751, 123);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 39;
            label4.Text = "Color para VARIOS";
            // 
            // btnExportarAExcel
            // 
            btnExportarAExcel.BackColor = Color.Black;
            btnExportarAExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExportarAExcel.ForeColor = SystemColors.Window;
            btnExportarAExcel.Location = new Point(1408, 379);
            btnExportarAExcel.Name = "btnExportarAExcel";
            btnExportarAExcel.Size = new Size(189, 69);
            btnExportarAExcel.TabIndex = 37;
            btnExportarAExcel.Text = "EXPORTAR A EXCEL";
            btnExportarAExcel.UseVisualStyleBackColor = false;
            btnExportarAExcel.Click += btnExportarAExcel_Click;
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
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1647, 379);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 69);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button btnBuscar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private ComboBox cmbTipoDeMovimiento;
        private Button btnExportarAExcel;
        private Label label4;
        private Panel PanelColourVarios;
        private ColorDialog ColorDialogForVarios;
        private Panel panel3;
        private Label label24;
        private Panel PanelColourCobranza;
        private Label label23;
        private Panel PanelColourGastos;
        private Label label11;
        private Panel PanelColourPagoAProveedores;
        private Label label12;
        private Button button2;
        private Label label13;
        private ComboBox comboBox1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button btnPagoAProveedores;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label18;
        private Label label19;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label20;
        private Label label21;
        private NumericUpDown numericUpDown1;
        private TextBox textBox5;
        private Label label22;
        private Label label10;
        private Panel panel1;
        private ColorDialog ColorDialogForPagoAProveedores;
        private ColorDialog ColorDialogForGastos;
        private ColorDialog ColorDialogForCobranza;
    }
}