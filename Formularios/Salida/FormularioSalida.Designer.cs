namespace JuanApp.Formularios.Salida
{
    partial class FormularioSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSalida));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblCodigoDeCliente = new Label();
            txtCodigoDeCliente = new TextBox();
            txtNombreDeCliente = new TextBox();
            lblNombreDeCliente = new Label();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreProducto = new TextBox();
            lblNombreProducto = new Label();
            lblKilosTotales = new Label();
            numericUpDownKilosTotales = new NumericUpDown();
            lblPrecio = new Label();
            numericUpDownPrecio = new NumericUpDown();
            lblSubtotal = new Label();
            numericUpDownSubtotal = new NumericUpDown();
            label2 = new Label();
            txtNroDePesada = new TextBox();
            lblNroDePesada = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(598, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de salidas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 800);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(741, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.ForeColor = SystemColors.Window;
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
            toolStrip1.Size = new Size(741, 27);
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
            btnGuardar.Location = new Point(561, 696);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(168, 94);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCodigoDeCliente
            // 
            lblCodigoDeCliente.AutoSize = true;
            lblCodigoDeCliente.Font = new Font("Segoe UI", 12F);
            lblCodigoDeCliente.ForeColor = SystemColors.Window;
            lblCodigoDeCliente.Location = new Point(12, 246);
            lblCodigoDeCliente.Name = "lblCodigoDeCliente";
            lblCodigoDeCliente.Size = new Size(191, 28);
            lblCodigoDeCliente.TabIndex = 6;
            lblCodigoDeCliente.Text = "Código de cliente (*)";
            // 
            // txtCodigoDeCliente
            // 
            txtCodigoDeCliente.Font = new Font("Segoe UI", 12F);
            txtCodigoDeCliente.Location = new Point(12, 277);
            txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            txtCodigoDeCliente.Size = new Size(232, 34);
            txtCodigoDeCliente.TabIndex = 1;
            txtCodigoDeCliente.KeyPress += txtCodigoDeCliente_KeyPress;
            // 
            // txtNombreDeCliente
            // 
            txtNombreDeCliente.Font = new Font("Segoe UI", 12F);
            txtNombreDeCliente.Location = new Point(12, 400);
            txtNombreDeCliente.Name = "txtNombreDeCliente";
            txtNombreDeCliente.Size = new Size(232, 34);
            txtNombreDeCliente.TabIndex = 2;
            // 
            // lblNombreDeCliente
            // 
            lblNombreDeCliente.AutoSize = true;
            lblNombreDeCliente.Font = new Font("Segoe UI", 12F);
            lblNombreDeCliente.ForeColor = SystemColors.Window;
            lblNombreDeCliente.Location = new Point(12, 369);
            lblNombreDeCliente.Name = "lblNombreDeCliente";
            lblNombreDeCliente.Size = new Size(199, 28);
            lblNombreDeCliente.TabIndex = 13;
            lblNombreDeCliente.Text = "Nombre de cliente (*)";
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            txtCodigoDeProducto.Location = new Point(12, 510);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(232, 34);
            txtCodigoDeProducto.TabIndex = 4;
            txtCodigoDeProducto.KeyPress += txtCodigoDeProducto_KeyPress;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            lblCodigoDeProducto.ForeColor = SystemColors.Window;
            lblCodigoDeProducto.Location = new Point(12, 479);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(216, 28);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto (*)";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 12F);
            txtNombreProducto.Location = new Point(12, 639);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(232, 34);
            txtNombreProducto.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F);
            lblNombreProducto.ForeColor = SystemColors.Window;
            lblNombreProducto.Location = new Point(12, 605);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(224, 28);
            lblNombreProducto.TabIndex = 17;
            lblNombreProducto.Text = "Nombre de producto (*)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Font = new Font("Segoe UI", 12F);
            lblKilosTotales.ForeColor = SystemColors.Window;
            lblKilosTotales.Location = new Point(429, 133);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(143, 28);
            lblKilosTotales.TabIndex = 19;
            lblKilosTotales.Text = "Kilos totales (*)";
            // 
            // numericUpDownKilosTotales
            // 
            numericUpDownKilosTotales.DecimalPlaces = 2;
            numericUpDownKilosTotales.Font = new Font("Segoe UI", 12F);
            numericUpDownKilosTotales.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownKilosTotales.Location = new Point(429, 157);
            numericUpDownKilosTotales.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownKilosTotales.Name = "numericUpDownKilosTotales";
            numericUpDownKilosTotales.Size = new Size(238, 34);
            numericUpDownKilosTotales.TabIndex = 6;
            numericUpDownKilosTotales.KeyPress += numericUpDownKilosTotales_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.ForeColor = SystemColors.Window;
            lblPrecio.Location = new Point(429, 246);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 23;
            lblPrecio.Text = "Precio";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Font = new Font("Segoe UI", 12F);
            numericUpDownPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecio.Location = new Point(429, 270);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(238, 34);
            numericUpDownPrecio.TabIndex = 7;
            numericUpDownPrecio.KeyPress += numericUpDownPrecio_KeyPress;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.ForeColor = SystemColors.Window;
            lblSubtotal.Location = new Point(429, 369);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(87, 28);
            lblSubtotal.TabIndex = 25;
            lblSubtotal.Text = "Subtotal";
            // 
            // numericUpDownSubtotal
            // 
            numericUpDownSubtotal.DecimalPlaces = 2;
            numericUpDownSubtotal.Font = new Font("Segoe UI", 12F);
            numericUpDownSubtotal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownSubtotal.Location = new Point(429, 393);
            numericUpDownSubtotal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownSubtotal.Name = "numericUpDownSubtotal";
            numericUpDownSubtotal.Size = new Size(238, 34);
            numericUpDownSubtotal.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 762);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 28;
            label2.Text = "(*) Requerido y mayor a 0";
            // 
            // txtNroDePesada
            // 
            txtNroDePesada.Font = new Font("Segoe UI", 12F);
            txtNroDePesada.Location = new Point(12, 164);
            txtNroDePesada.Name = "txtNroDePesada";
            txtNroDePesada.Size = new Size(232, 34);
            txtNroDePesada.TabIndex = 30;
            txtNroDePesada.KeyPress += txtNroDePesada_KeyPress;
            // 
            // lblNroDePesada
            // 
            lblNroDePesada.AutoSize = true;
            lblNroDePesada.Font = new Font("Segoe UI", 12F);
            lblNroDePesada.ForeColor = SystemColors.Window;
            lblNroDePesada.Location = new Point(12, 133);
            lblNroDePesada.Name = "lblNroDePesada";
            lblNroDePesada.Size = new Size(155, 28);
            lblNroDePesada.TabIndex = 29;
            lblNroDePesada.Text = "Nº de pesada (*)";
            // 
            // FormularioSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(741, 826);
            Controls.Add(txtNroDePesada);
            Controls.Add(lblNroDePesada);
            Controls.Add(label2);
            Controls.Add(numericUpDownSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(numericUpDownKilosTotales);
            Controls.Add(lblKilosTotales);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(txtNombreDeCliente);
            Controls.Add(lblNombreDeCliente);
            Controls.Add(txtCodigoDeCliente);
            Controls.Add(btnGuardar);
            Controls.Add(lblCodigoDeCliente);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioSalida";
            Text = "Formulario de salidas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).EndInit();
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
        private Label lblCodigoDeCliente;
        private TextBox txtCodigoDeCliente;
        private TextBox txtNombreDeCliente;
        private Label lblNombreDeCliente;
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreProducto;
        private Label lblNombreProducto;
        private Label lblKilosTotales;
        private NumericUpDown numericUpDownKilosTotales;
        private Label lblPrecio;
        private NumericUpDown numericUpDownPrecio;
        private Label lblSubtotal;
        private NumericUpDown numericUpDownSubtotal;
        private Label label2;
        private TextBox txtNroDePesada;
        private Label lblNroDePesada;
    }
}
