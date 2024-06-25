namespace JuanApp2.Formularios.Proveedor
{
    partial class FormularioCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCompra));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            DateTimePickerFecha = new DateTimePicker();
            label3 = new Label();
            txtDiaDePago = new NumericUpDown();
            label5 = new Label();
            txtDescripcion = new TextBox();
            txtUnidad = new NumericUpDown();
            lblUnidades = new Label();
            txtKilogramo = new NumericUpDown();
            lblKilogramos = new Label();
            txtPrecio = new NumericUpDown();
            lblPrecio = new Label();
            txtSubtotal = new NumericUpDown();
            lblSubtotal = new Label();
            cmbProveedor = new ComboBox();
            label10 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiaDePago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKilogramo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSubtotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(623, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de compra";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 717);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(821, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = SystemColors.Window;
            statusLabel.ForeColor = Color.Black;
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
            toolStrip1.Size = new Size(821, 27);
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
            btnGuardar.Location = new Point(629, 636);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 78);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 686);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 24;
            label1.Text = "(*) Requerido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 257);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 25;
            label2.Text = "Fecha *";
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerFecha.Location = new Point(23, 288);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(311, 31);
            DateTimePickerFecha.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 353);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 27;
            label3.Text = "Días de pago *";
            // 
            // txtDiaDePago
            // 
            txtDiaDePago.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaDePago.Location = new Point(23, 384);
            txtDiaDePago.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtDiaDePago.Name = "txtDiaDePago";
            txtDiaDePago.Size = new Size(180, 31);
            txtDiaDePago.TabIndex = 28;
            txtDiaDePago.KeyPress += txtDiaDePago_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 458);
            label5.Name = "label5";
            label5.Size = new Size(432, 28);
            label5.TabIndex = 32;
            label5.Text = "Descripción * (Ingrese tropa o tipo de producto)";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(23, 489);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(311, 31);
            txtDescripcion.TabIndex = 31;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidad.Location = new Point(552, 188);
            txtUnidad.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(180, 31);
            txtUnidad.TabIndex = 34;
            txtUnidad.KeyPress += txtUnidad_KeyPress;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidades.ForeColor = Color.White;
            lblUnidades.Location = new Point(552, 157);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(107, 28);
            lblUnidades.TabIndex = 33;
            lblUnidades.Text = "Unidades *";
            // 
            // txtKilogramo
            // 
            txtKilogramo.DecimalPlaces = 2;
            txtKilogramo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKilogramo.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtKilogramo.Location = new Point(552, 284);
            txtKilogramo.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            txtKilogramo.Name = "txtKilogramo";
            txtKilogramo.Size = new Size(180, 31);
            txtKilogramo.TabIndex = 36;
            txtKilogramo.KeyPress += txtKilogramo_KeyPress;
            // 
            // lblKilogramos
            // 
            lblKilogramos.AutoSize = true;
            lblKilogramos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKilogramos.ForeColor = Color.White;
            lblKilogramos.Location = new Point(552, 253);
            lblKilogramos.Name = "lblKilogramos";
            lblKilogramos.Size = new Size(125, 28);
            lblKilogramos.TabIndex = 35;
            lblKilogramos.Text = "Kilogramos *";
            // 
            // txtPrecio
            // 
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtPrecio.Location = new Point(552, 384);
            txtPrecio.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(180, 31);
            txtPrecio.TabIndex = 38;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(552, 353);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 28);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "Precio *";
            // 
            // txtSubtotal
            // 
            txtSubtotal.DecimalPlaces = 2;
            txtSubtotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtSubtotal.Location = new Point(552, 480);
            txtSubtotal.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(180, 31);
            txtSubtotal.TabIndex = 40;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(552, 449);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(100, 28);
            lblSubtotal.TabIndex = 39;
            lblSubtotal.Text = "Subtotal *";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(23, 188);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(311, 28);
            cmbProveedor.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(23, 157);
            label10.Name = "label10";
            label10.Size = new Size(116, 28);
            label10.TabIndex = 44;
            label10.Text = "Proveedor *";
            // 
            // FormularioCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(821, 743);
            Controls.Add(label10);
            Controls.Add(cmbProveedor);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtKilogramo);
            Controls.Add(lblKilogramos);
            Controls.Add(txtUnidad);
            Controls.Add(lblUnidades);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(txtDiaDePago);
            Controls.Add(label3);
            Controls.Add(DateTimePickerFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            MaximizeBox = false;
            Name = "FormularioCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de compra";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiaDePago).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKilogramo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSubtotal).EndInit();
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
        private Label label1;
        private Label label2;
        private DateTimePicker DateTimePickerFecha;
        private Label label3;
        private NumericUpDown txtDiaDePago;
        private Label label5;
        private TextBox txtDescripcion;
        private NumericUpDown txtUnidad;
        private Label lblUnidades;
        private NumericUpDown txtKilogramo;
        private Label lblKilogramos;
        private NumericUpDown txtPrecio;
        private Label lblPrecio;
        private NumericUpDown txtSubtotal;
        private Label lblSubtotal;
        private ComboBox cmbProveedor;
        private Label label10;
    }
}
