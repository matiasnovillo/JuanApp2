namespace JuanApp.Formularios.Salida
{
    partial class ConsultaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSalida));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewSalida = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            btnGenerarPDF = new Button();
            txtBuscar = new TextBox();
            lblBarraDeBusqueda = new Label();
            dateTimePickerFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            btnGenerarExcel = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            lblKilosTotales = new Label();
            txtKilosRealesTotal = new TextBox();
            txtPrecioTotal = new TextBox();
            lblPrecioUnidadTotal = new Label();
            txtSubtotalTotal = new TextBox();
            lblSubtotalTotal = new Label();
            numericUpDownRegistros = new NumericUpDown();
            label2 = new Label();
            pnlSearchBar = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistros).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1267, 27);
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
            statusStrip1.Size = new Size(1267, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewSalida
            // 
            DataGridViewSalida.AllowUserToAddRows = false;
            DataGridViewSalida.AllowUserToDeleteRows = false;
            DataGridViewSalida.BackgroundColor = Color.Black;
            DataGridViewSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSalida.Dock = DockStyle.Bottom;
            DataGridViewSalida.Location = new Point(0, 662);
            DataGridViewSalida.Name = "DataGridViewSalida";
            DataGridViewSalida.ReadOnly = true;
            DataGridViewSalida.RowHeadersWidth = 51;
            DataGridViewSalida.Size = new Size(1267, 367);
            DataGridViewSalida.TabIndex = 2;
            DataGridViewSalida.CellContentClick += DataGridViewSalida_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(541, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de salidas";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(989, 457);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 83);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.Black;
            btnGenerarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerarPDF.ForeColor = SystemColors.Window;
            btnGenerarPDF.Location = new Point(12, 457);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(166, 83);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "GENERAR PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(12, 264);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(696, 34);
            txtBuscar.TabIndex = 16;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 12F);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 213);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(585, 28);
            lblBarraDeBusqueda.TabIndex = 15;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por cód. de cliente, cód. de producto, ";
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Font = new Font("Segoe UI", 12F);
            dateTimePickerFechaFin.Location = new Point(294, 166);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(250, 34);
            dateTimePickerFechaFin.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 12F);
            lblFechaFin.ForeColor = SystemColors.Window;
            lblFechaFin.Location = new Point(294, 135);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(116, 28);
            lblFechaFin.TabIndex = 13;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Font = new Font("Segoe UI", 12F);
            dateTimePickerFechaInicio.Location = new Point(12, 166);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(250, 34);
            dateTimePickerFechaInicio.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 12F);
            lblFechaInicio.ForeColor = SystemColors.Window;
            lblFechaInicio.Location = new Point(12, 135);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(141, 28);
            lblFechaInicio.TabIndex = 11;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.Black;
            btnGenerarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerarExcel.ForeColor = SystemColors.Window;
            btnGenerarExcel.Location = new Point(197, 457);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(196, 83);
            btnGenerarExcel.TabIndex = 17;
            btnGenerarExcel.Text = "GENERAR EXCEL";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(791, 457);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 83);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 233);
            label1.Name = "label1";
            label1.Size = new Size(501, 28);
            label1.TabIndex = 19;
            label1.Text = "nombre de cliente, nombre de producto o Nº de pesaje)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Font = new Font("Segoe UI", 12F);
            lblKilosTotales.ForeColor = SystemColors.Window;
            lblKilosTotales.Location = new Point(12, 320);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(193, 28);
            lblKilosTotales.TabIndex = 20;
            lblKilosTotales.Text = "Kilos reales TOTALES:";
            // 
            // txtKilosRealesTotal
            // 
            txtKilosRealesTotal.Font = new Font("Segoe UI", 12F);
            txtKilosRealesTotal.Location = new Point(12, 351);
            txtKilosRealesTotal.Name = "txtKilosRealesTotal";
            txtKilosRealesTotal.ReadOnly = true;
            txtKilosRealesTotal.Size = new Size(202, 34);
            txtKilosRealesTotal.TabIndex = 21;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Font = new Font("Segoe UI", 12F);
            txtPrecioTotal.Location = new Point(225, 351);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.ReadOnly = true;
            txtPrecioTotal.Size = new Size(202, 34);
            txtPrecioTotal.TabIndex = 23;
            // 
            // lblPrecioUnidadTotal
            // 
            lblPrecioUnidadTotal.AutoSize = true;
            lblPrecioUnidadTotal.Font = new Font("Segoe UI", 12F);
            lblPrecioUnidadTotal.ForeColor = SystemColors.Window;
            lblPrecioUnidadTotal.Location = new Point(225, 320);
            lblPrecioUnidadTotal.Name = "lblPrecioUnidadTotal";
            lblPrecioUnidadTotal.Size = new Size(129, 28);
            lblPrecioUnidadTotal.TabIndex = 22;
            lblPrecioUnidadTotal.Text = "Precio TOTAL:";
            // 
            // txtSubtotalTotal
            // 
            txtSubtotalTotal.Font = new Font("Segoe UI", 12F);
            txtSubtotalTotal.Location = new Point(435, 351);
            txtSubtotalTotal.Name = "txtSubtotalTotal";
            txtSubtotalTotal.ReadOnly = true;
            txtSubtotalTotal.Size = new Size(202, 34);
            txtSubtotalTotal.TabIndex = 25;
            // 
            // lblSubtotalTotal
            // 
            lblSubtotalTotal.AutoSize = true;
            lblSubtotalTotal.Font = new Font("Segoe UI", 12F);
            lblSubtotalTotal.ForeColor = SystemColors.Window;
            lblSubtotalTotal.Location = new Point(435, 320);
            lblSubtotalTotal.Name = "lblSubtotalTotal";
            lblSubtotalTotal.Size = new Size(150, 28);
            lblSubtotalTotal.TabIndex = 24;
            lblSubtotalTotal.Text = "Subtotal TOTAL:";
            // 
            // numericUpDownRegistros
            // 
            numericUpDownRegistros.Font = new Font("Segoe UI", 12F);
            numericUpDownRegistros.Location = new Point(572, 165);
            numericUpDownRegistros.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownRegistros.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistros.Name = "numericUpDownRegistros";
            numericUpDownRegistros.Size = new Size(136, 34);
            numericUpDownRegistros.TabIndex = 27;
            numericUpDownRegistros.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(572, 134);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 28;
            label2.Text = "Registros";
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.Black;
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(label2);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Controls.Add(numericUpDownRegistros);
            pnlSearchBar.Controls.Add(btnGenerarPDF);
            pnlSearchBar.Controls.Add(txtSubtotalTotal);
            pnlSearchBar.Controls.Add(lblFechaInicio);
            pnlSearchBar.Controls.Add(lblSubtotalTotal);
            pnlSearchBar.Controls.Add(dateTimePickerFechaInicio);
            pnlSearchBar.Controls.Add(txtPrecioTotal);
            pnlSearchBar.Controls.Add(lblFechaFin);
            pnlSearchBar.Controls.Add(lblPrecioUnidadTotal);
            pnlSearchBar.Controls.Add(dateTimePickerFechaFin);
            pnlSearchBar.Controls.Add(txtKilosRealesTotal);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Controls.Add(lblKilosTotales);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(label1);
            pnlSearchBar.Controls.Add(btnGenerarExcel);
            pnlSearchBar.Controls.Add(btnAgregar);
            pnlSearchBar.Dock = DockStyle.Fill;
            pnlSearchBar.Location = new Point(0, 27);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1267, 635);
            pnlSearchBar.TabIndex = 29;
            // 
            // ConsultaSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 1055);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewSalida);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaSalida";
            Text = "Consulta de salidas - Clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistros).EndInit();
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
        private DataGridView DataGridViewSalida;
        private Label lblTitulo;
        private Button btnBuscar;
        private Button btnGenerarPDF;
        private TextBox txtBuscar;
        private Label lblBarraDeBusqueda;
        private DateTimePicker dateTimePickerFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dateTimePickerFechaInicio;
        private Label lblFechaInicio;
        private Button btnGenerarExcel;
        private Button btnAgregar;
        private Label label1;
        private Label lblKilosTotales;
        private TextBox txtKilosRealesTotal;
        private TextBox txtPrecioTotal;
        private Label lblPrecioUnidadTotal;
        private TextBox txtSubtotalTotal;
        private Label lblSubtotalTotal;
        private NumericUpDown numericUpDownRegistros;
        private Label label2;
        private Panel pnlSearchBar;
    }
}