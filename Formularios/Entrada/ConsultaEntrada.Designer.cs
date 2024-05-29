namespace JuanApp.Formularios.Entrada
{
    partial class ConsultaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEntrada));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewEntrada = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblFechaInicio = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            dateTimePickerFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            lblNeto = new Label();
            txtNetoTotal = new TextBox();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            pnlFiltersAndSearchBar = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEntrada).BeginInit();
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
            // DataGridViewEntrada
            // 
            DataGridViewEntrada.AllowUserToAddRows = false;
            DataGridViewEntrada.AllowUserToDeleteRows = false;
            DataGridViewEntrada.BackgroundColor = Color.Black;
            DataGridViewEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEntrada.Dock = DockStyle.Bottom;
            DataGridViewEntrada.GridColor = Color.FromArgb(41, 48, 57);
            DataGridViewEntrada.Location = new Point(0, 615);
            DataGridViewEntrada.Name = "DataGridViewEntrada";
            DataGridViewEntrada.ReadOnly = true;
            DataGridViewEntrada.RowHeadersWidth = 51;
            DataGridViewEntrada.Size = new Size(1257, 414);
            DataGridViewEntrada.TabIndex = 2;
            DataGridViewEntrada.CellContentClick += DataGridViewEntrada_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(592, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de entradas";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(924, 349);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 84);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = SystemColors.Window;
            lblFechaInicio.Location = new Point(12, 154);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(166, 31);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(12, 188);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(250, 38);
            dateTimePickerFechaInicio.TabIndex = 6;
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Location = new Point(294, 188);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(250, 38);
            dateTimePickerFechaFin.TabIndex = 8;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = SystemColors.Window;
            lblFechaFin.Location = new Point(294, 154);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(137, 31);
            lblFechaFin.TabIndex = 7;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 251);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(677, 23);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por Nº de pesaje, nombre de producto o cód. de producto)";
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
            btnAgregar.Location = new Point(710, 349);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 84);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.ForeColor = SystemColors.Window;
            lblNeto.Location = new Point(12, 363);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(138, 31);
            lblNeto.TabIndex = 12;
            lblNeto.Text = "Neto TOTAL:";
            // 
            // txtNetoTotal
            // 
            txtNetoTotal.Location = new Point(12, 395);
            txtNetoTotal.Name = "txtNetoTotal";
            txtNetoTotal.ReadOnly = true;
            txtNetoTotal.Size = new Size(194, 38);
            txtNetoTotal.TabIndex = 13;
            // 
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Location = new Point(564, 188);
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
            label1.Location = new Point(564, 154);
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
            pnlFiltersAndSearchBar.Controls.Add(lblFechaInicio);
            pnlFiltersAndSearchBar.Controls.Add(txtNetoTotal);
            pnlFiltersAndSearchBar.Controls.Add(dateTimePickerFechaInicio);
            pnlFiltersAndSearchBar.Controls.Add(lblNeto);
            pnlFiltersAndSearchBar.Controls.Add(lblFechaFin);
            pnlFiltersAndSearchBar.Controls.Add(btnAgregar);
            pnlFiltersAndSearchBar.Controls.Add(dateTimePickerFechaFin);
            pnlFiltersAndSearchBar.Controls.Add(txtBuscar);
            pnlFiltersAndSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlFiltersAndSearchBar.Dock = DockStyle.Fill;
            pnlFiltersAndSearchBar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlFiltersAndSearchBar.ForeColor = Color.Goldenrod;
            pnlFiltersAndSearchBar.Location = new Point(0, 27);
            pnlFiltersAndSearchBar.Name = "pnlFiltersAndSearchBar";
            pnlFiltersAndSearchBar.Size = new Size(1257, 588);
            pnlFiltersAndSearchBar.TabIndex = 17;
            // 
            // ConsultaEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 1055);
            Controls.Add(pnlFiltersAndSearchBar);
            Controls.Add(DataGridViewEntrada);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ConsultaEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de entradas - Pesajes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEntrada).EndInit();
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
        private DataGridView DataGridViewEntrada;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblFechaInicio;
        private DateTimePicker dateTimePickerFechaInicio;
        private DateTimePicker dateTimePickerFechaFin;
        private Label lblFechaFin;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Label lblNeto;
        private TextBox txtNetoTotal;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
        private Panel pnlFiltersAndSearchBar;
    }
}