namespace JuanApp.Formularios.Herramientas.Remito
{
    partial class FormularioRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRemito));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblCodigoDeProducto = new Label();
            lblNombreDeProducto = new Label();
            DateTimePickerFechaDeEmision = new DateTimePicker();
            NumericUpDownKilosTotales = new NumericUpDown();
            NumericUpDownPrecioTotal = new NumericUpDown();
            label1 = new Label();
            NumericUpDownSubtotalTotal = new NumericUpDown();
            label2 = new Label();
            txtCodigoCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNombreCliente = new TextBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownKilosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrecioTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSubtotalTotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(595, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de remito";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Window;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(644, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { dropDownButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(644, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // dropDownButton
            // 
            dropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dropDownButton.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            dropDownButton.Image = (Image)resources.GetObject("dropDownButton.Image");
            dropDownButton.ImageTransparentColor = Color.Magenta;
            dropDownButton.Name = "dropDownButton";
            dropDownButton.Size = new Size(34, 24);
            dropDownButton.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(482, 410);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 86);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            lblCodigoDeProducto.ForeColor = SystemColors.Window;
            lblCodigoDeProducto.Location = new Point(12, 146);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(162, 28);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Fecha de emisión";
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Font = new Font("Segoe UI", 12F);
            lblNombreDeProducto.ForeColor = SystemColors.Window;
            lblNombreDeProducto.Location = new Point(373, 146);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(118, 28);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Kilos totales";
            // 
            // DateTimePickerFechaDeEmision
            // 
            DateTimePickerFechaDeEmision.Location = new Point(12, 177);
            DateTimePickerFechaDeEmision.Name = "DateTimePickerFechaDeEmision";
            DateTimePickerFechaDeEmision.Size = new Size(250, 27);
            DateTimePickerFechaDeEmision.TabIndex = 19;
            // 
            // NumericUpDownKilosTotales
            // 
            NumericUpDownKilosTotales.DecimalPlaces = 2;
            NumericUpDownKilosTotales.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownKilosTotales.Location = new Point(373, 177);
            NumericUpDownKilosTotales.Name = "NumericUpDownKilosTotales";
            NumericUpDownKilosTotales.Size = new Size(250, 27);
            NumericUpDownKilosTotales.TabIndex = 20;
            // 
            // NumericUpDownPrecioTotal
            // 
            NumericUpDownPrecioTotal.DecimalPlaces = 2;
            NumericUpDownPrecioTotal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownPrecioTotal.Location = new Point(373, 257);
            NumericUpDownPrecioTotal.Name = "NumericUpDownPrecioTotal";
            NumericUpDownPrecioTotal.Size = new Size(250, 27);
            NumericUpDownPrecioTotal.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(373, 226);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 21;
            label1.Text = "Precio total";
            // 
            // NumericUpDownSubtotalTotal
            // 
            NumericUpDownSubtotalTotal.DecimalPlaces = 2;
            NumericUpDownSubtotalTotal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownSubtotalTotal.Location = new Point(373, 340);
            NumericUpDownSubtotalTotal.Name = "NumericUpDownSubtotalTotal";
            NumericUpDownSubtotalTotal.Size = new Size(250, 27);
            NumericUpDownSubtotalTotal.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(373, 309);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 23;
            label2.Text = "Subtotal total";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 257);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(250, 27);
            txtCodigoCliente.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 26;
            label3.Text = "Codigo de cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(12, 309);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 28;
            label4.Text = "Nombre de cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 340);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(250, 27);
            txtNombreCliente.TabIndex = 27;
            // 
            // FormularioRemito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(644, 525);
            Controls.Add(label4);
            Controls.Add(txtNombreCliente);
            Controls.Add(label3);
            Controls.Add(txtCodigoCliente);
            Controls.Add(NumericUpDownSubtotalTotal);
            Controls.Add(label2);
            Controls.Add(NumericUpDownPrecioTotal);
            Controls.Add(label1);
            Controls.Add(NumericUpDownKilosTotales);
            Controls.Add(DateTimePickerFechaDeEmision);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioRemito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de remitos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownKilosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrecioTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSubtotalTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dropDownButton;
        private Button btnGuardar;
        private ToolStripMenuItem menuItemMain;
        private Label lblCodigoDeProducto;
        private Label lblNombreDeProducto;
        private DateTimePicker DateTimePickerFechaDeEmision;
        private NumericUpDown NumericUpDownKilosTotales;
        private NumericUpDown NumericUpDownPrecioTotal;
        private Label label1;
        private NumericUpDown NumericUpDownSubtotalTotal;
        private Label label2;
        private TextBox txtCodigoCliente;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCliente;
    }
}
