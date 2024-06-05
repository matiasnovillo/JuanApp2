namespace JuanApp.Formularios.Entrada
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
            txtReferencia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtUnidad = new NumericUpDown();
            label6 = new Label();
            txtKilogramo = new NumericUpDown();
            label7 = new Label();
            txtPrecio = new NumericUpDown();
            label8 = new Label();
            txtSubtotal = new NumericUpDown();
            label9 = new Label();
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
            label2.Location = new Point(29, 157);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 25;
            label2.Text = "Fecha *";
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerFecha.Location = new Point(29, 188);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(311, 31);
            DateTimePickerFecha.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 253);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 27;
            label3.Text = "Días de pago *";
            // 
            // txtDiaDePago
            // 
            txtDiaDePago.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaDePago.Location = new Point(29, 284);
            txtDiaDePago.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtDiaDePago.Name = "txtDiaDePago";
            txtDiaDePago.Size = new Size(180, 31);
            txtDiaDePago.TabIndex = 28;
            // 
            // txtReferencia
            // 
            txtReferencia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferencia.Location = new Point(29, 384);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(311, 31);
            txtReferencia.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 353);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 30;
            label4.Text = "Referencia *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(406, 157);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 32;
            label5.Text = "Descripción *";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(406, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 31);
            textBox1.TabIndex = 31;
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidad.Location = new Point(406, 284);
            txtUnidad.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(180, 31);
            txtUnidad.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(406, 253);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 33;
            label6.Text = "Unidades *";
            // 
            // txtKilogramo
            // 
            txtKilogramo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKilogramo.Location = new Point(406, 384);
            txtKilogramo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtKilogramo.Name = "txtKilogramo";
            txtKilogramo.Size = new Size(180, 31);
            txtKilogramo.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(406, 353);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 35;
            label7.Text = "Kilogramos *";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(406, 481);
            txtPrecio.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(180, 31);
            txtPrecio.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(406, 450);
            label8.Name = "label8";
            label8.Size = new Size(79, 28);
            label8.TabIndex = 37;
            label8.Text = "Precio *";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(406, 587);
            txtSubtotal.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(180, 31);
            txtSubtotal.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(406, 556);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 39;
            label9.Text = "Subtotal *";
            // 
            // FormularioCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(821, 743);
            Controls.Add(txtSubtotal);
            Controls.Add(label9);
            Controls.Add(txtPrecio);
            Controls.Add(label8);
            Controls.Add(txtKilogramo);
            Controls.Add(label7);
            Controls.Add(txtUnidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txtReferencia);
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
        private TextBox txtReferencia;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private NumericUpDown txtUnidad;
        private Label label6;
        private NumericUpDown txtKilogramo;
        private Label label7;
        private NumericUpDown txtPrecio;
        private Label label8;
        private NumericUpDown txtSubtotal;
        private Label label9;
    }
}
