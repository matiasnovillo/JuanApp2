namespace JuanApp2.Formularios.Proveedor
{
    partial class FormularioProveedorIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProveedorIngreso));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            label1 = new Label();
            lblImporte = new Label();
            txtImporte = new NumericUpDown();
            DateTimePickerFecha = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
            optHaber = new RadioButton();
            optDebe = new RadioButton();
            cmbProveedor = new ComboBox();
            label3 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImporte).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(617, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de ingreso";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 716);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(644, 26);
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
            btnGuardar.Location = new Point(452, 635);
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
            label1.Location = new Point(29, 685);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 24;
            label1.Text = "(*) Requerido";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImporte.ForeColor = Color.White;
            lblImporte.Location = new Point(29, 544);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(95, 28);
            lblImporte.TabIndex = 34;
            lblImporte.Text = "Importe *";
            // 
            // txtImporte
            // 
            txtImporte.DecimalPlaces = 2;
            txtImporte.Font = new Font("Segoe UI", 12F);
            txtImporte.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtImporte.Location = new Point(29, 575);
            txtImporte.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(307, 34);
            txtImporte.TabIndex = 33;
            txtImporte.KeyPress += txtDineroTotal_KeyPress;
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerFecha.Location = new Point(29, 268);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(307, 34);
            DateTimePickerFecha.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 237);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 36;
            label2.Text = "Fecha *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 436);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 37;
            label7.Text = "Descripción *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(29, 467);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(307, 34);
            txtDescripcion.TabIndex = 38;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // optHaber
            // 
            optHaber.AutoSize = true;
            optHaber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optHaber.ForeColor = Color.White;
            optHaber.Location = new Point(29, 177);
            optHaber.Name = "optHaber";
            optHaber.Size = new Size(86, 32);
            optHaber.TabIndex = 39;
            optHaber.TabStop = true;
            optHaber.Text = "Haber";
            optHaber.UseVisualStyleBackColor = true;
            // 
            // optDebe
            // 
            optDebe.AutoSize = true;
            optDebe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optDebe.ForeColor = Color.White;
            optDebe.Location = new Point(152, 179);
            optDebe.Name = "optDebe";
            optDebe.Size = new Size(79, 32);
            optDebe.TabIndex = 40;
            optDebe.TabStop = true;
            optDebe.Text = "Debe";
            optDebe.UseVisualStyleBackColor = true;
            // 
            // cmbProveedor
            // 
            cmbProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(29, 366);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(307, 36);
            cmbProveedor.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 335);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 42;
            label3.Text = "Proveedor *";
            // 
            // FormularioProveedorIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(644, 742);
            Controls.Add(label3);
            Controls.Add(cmbProveedor);
            Controls.Add(optDebe);
            Controls.Add(optHaber);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(DateTimePickerFecha);
            Controls.Add(lblImporte);
            Controls.Add(txtImporte);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            MaximizeBox = false;
            Name = "FormularioProveedorIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de ingreso a proveedores";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImporte).EndInit();
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
        private Label lblImporte;
        private NumericUpDown txtImporte;
        private DateTimePicker DateTimePickerFecha;
        private Label label2;
        private Label label7;
        private TextBox txtDescripcion;
        private RadioButton optHaber;
        private RadioButton optDebe;
        private ComboBox cmbProveedor;
        private Label label3;
    }
}
