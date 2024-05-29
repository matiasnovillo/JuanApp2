namespace JuanApp.Formularios.Entrada
{
    partial class FormularioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCliente));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            txtCodigoDeCliente = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreDeCliente = new TextBox();
            lblNombreDeProducto = new Label();
            txtDomicilio = new TextBox();
            label1 = new Label();
            txtLocalidad = new TextBox();
            label2 = new Label();
            txtCUIT = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCodigoPostal = new TextBox();
            label5 = new Label();
            txtProvincia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(16, 50);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(595, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de cliente";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 699);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(819, 26);
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
            toolStrip1.Size = new Size(819, 27);
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
            btnGuardar.Location = new Point(633, 613);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 82);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCodigoDeCliente
            // 
            txtCodigoDeCliente.Location = new Point(16, 163);
            txtCodigoDeCliente.Margin = new Padding(4);
            txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            txtCodigoDeCliente.Size = new Size(318, 34);
            txtCodigoDeCliente.TabIndex = 16;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.ForeColor = SystemColors.Window;
            lblCodigoDeProducto.Location = new Point(16, 131);
            lblCodigoDeProducto.Margin = new Padding(4, 0, 4, 0);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(191, 28);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de cliente (*)";
            // 
            // txtNombreDeCliente
            // 
            txtNombreDeCliente.Location = new Point(16, 263);
            txtNombreDeCliente.Margin = new Padding(4);
            txtNombreDeCliente.Name = "txtNombreDeCliente";
            txtNombreDeCliente.Size = new Size(318, 34);
            txtNombreDeCliente.TabIndex = 18;
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.ForeColor = SystemColors.Window;
            lblNombreDeProducto.Location = new Point(16, 230);
            lblNombreDeProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(199, 28);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Nombre de cliente (*)";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(16, 372);
            txtDomicilio.Margin = new Padding(4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(318, 34);
            txtDomicilio.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(16, 340);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 19;
            label1.Text = "Domicilio";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(16, 475);
            txtLocalidad.Margin = new Padding(4);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(318, 34);
            txtLocalidad.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(16, 443);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 21;
            label2.Text = "Localidad";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(16, 583);
            txtCUIT.Margin = new Padding(4);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(318, 34);
            txtCUIT.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(16, 551);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 23;
            label3.Text = "CUIT";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(388, 163);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(318, 34);
            txtTelefono.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(388, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 25;
            label4.Text = "Teléfono";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(388, 263);
            txtCodigoPostal.Margin = new Padding(4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(318, 34);
            txtCodigoPostal.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(388, 230);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 27;
            label5.Text = "Código postal";
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(388, 372);
            txtProvincia.Margin = new Padding(4);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(318, 34);
            txtProvincia.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(388, 340);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 29;
            label6.Text = "Provincia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(16, 667);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 31;
            label7.Text = "(*) Requerido";
            // 
            // FormularioCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(819, 725);
            Controls.Add(label7);
            Controls.Add(txtProvincia);
            Controls.Add(label6);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCUIT);
            Controls.Add(label3);
            Controls.Add(txtLocalidad);
            Controls.Add(label2);
            Controls.Add(txtDomicilio);
            Controls.Add(label1);
            Controls.Add(txtNombreDeCliente);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(txtCodigoDeCliente);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Goldenrod;
            Margin = new Padding(4);
            Name = "FormularioCliente";
            Text = "Formulario de clientes";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private TextBox txtCodigoDeCliente;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreDeCliente;
        private Label lblNombreDeProducto;
        private TextBox txtDomicilio;
        private Label label1;
        private TextBox txtLocalidad;
        private Label label2;
        private TextBox txtCUIT;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCodigoPostal;
        private Label label5;
        private TextBox txtProvincia;
        private Label label6;
        private Label label7;
    }
}
