namespace JuanApp.Formularios.Entrada
{
    partial class FormularioEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEntrada));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            txtNroDePesada = new TextBox();
            lblNroDePesada = new Label();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreDeProducto = new TextBox();
            lblNombreDeProducto = new Label();
            txtTexContenido = new TextBox();
            lblTexContenido = new Label();
            lblNeto = new Label();
            numericUpDownNeto = new NumericUpDown();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(649, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de entradas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 467);
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
            btnGuardar.Location = new Point(629, 381);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 78);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNroDePesada
            // 
            txtNroDePesada.Location = new Point(12, 179);
            txtNroDePesada.Name = "txtNroDePesada";
            txtNroDePesada.Size = new Size(232, 27);
            txtNroDePesada.TabIndex = 14;
            txtNroDePesada.KeyPress += txtNroDePesada_KeyPress;
            // 
            // lblNroDePesada
            // 
            lblNroDePesada.AutoSize = true;
            lblNroDePesada.Font = new Font("Segoe UI", 12F);
            lblNroDePesada.ForeColor = SystemColors.Window;
            lblNroDePesada.Location = new Point(12, 148);
            lblNroDePesada.Name = "lblNroDePesada";
            lblNroDePesada.Size = new Size(155, 28);
            lblNroDePesada.TabIndex = 13;
            lblNroDePesada.Text = "Nº de pesada (*)";
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Location = new Point(12, 253);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(232, 27);
            txtCodigoDeProducto.TabIndex = 16;
            txtCodigoDeProducto.KeyPress += txtCodigoDeProducto_KeyPress;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            lblCodigoDeProducto.ForeColor = SystemColors.Window;
            lblCodigoDeProducto.Location = new Point(12, 222);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(221, 28);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto  (*)";
            // 
            // txtNombreDeProducto
            // 
            txtNombreDeProducto.Location = new Point(12, 341);
            txtNombreDeProducto.Name = "txtNombreDeProducto";
            txtNombreDeProducto.Size = new Size(232, 27);
            txtNombreDeProducto.TabIndex = 18;
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Font = new Font("Segoe UI", 12F);
            lblNombreDeProducto.ForeColor = SystemColors.Window;
            lblNombreDeProducto.Location = new Point(12, 310);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(229, 28);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Nombre de producto  (*)";
            // 
            // txtTexContenido
            // 
            txtTexContenido.Location = new Point(477, 179);
            txtTexContenido.Name = "txtTexContenido";
            txtTexContenido.Size = new Size(232, 27);
            txtTexContenido.TabIndex = 20;
            txtTexContenido.KeyPress += txtTexContenido_KeyPress;
            // 
            // lblTexContenido
            // 
            lblTexContenido.AutoSize = true;
            lblTexContenido.Font = new Font("Segoe UI", 12F);
            lblTexContenido.ForeColor = SystemColors.Window;
            lblTexContenido.Location = new Point(477, 148);
            lblTexContenido.Name = "lblTexContenido";
            lblTexContenido.Size = new Size(333, 28);
            lblTexContenido.TabIndex = 19;
            lblTexContenido.Text = "Tex Contenido (Cant. de unidades) (*)";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNeto.ForeColor = SystemColors.Window;
            lblNeto.Location = new Point(477, 222);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(81, 28);
            lblNeto.TabIndex = 21;
            lblNeto.Text = "Neto (*)";
            // 
            // numericUpDownNeto
            // 
            numericUpDownNeto.DecimalPlaces = 2;
            numericUpDownNeto.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownNeto.Location = new Point(477, 253);
            numericUpDownNeto.Name = "numericUpDownNeto";
            numericUpDownNeto.Size = new Size(232, 27);
            numericUpDownNeto.TabIndex = 22;
            numericUpDownNeto.KeyPress += numericUpDownNeto_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 431);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 24;
            label1.Text = "(*) Requerido";
            // 
            // FormularioEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(821, 493);
            Controls.Add(label1);
            Controls.Add(numericUpDownNeto);
            Controls.Add(lblNeto);
            Controls.Add(txtTexContenido);
            Controls.Add(lblTexContenido);
            Controls.Add(txtNombreDeProducto);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(txtNroDePesada);
            Controls.Add(lblNroDePesada);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            MaximizeBox = false;
            Name = "FormularioEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de entradas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeto).EndInit();
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
        private TextBox txtNroDePesada;
        private Label lblNroDePesada;
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreDeProducto;
        private Label lblNombreDeProducto;
        private TextBox txtTexContenido;
        private Label lblTexContenido;
        private Label lblNeto;
        private NumericUpDown numericUpDownNeto;
        private Label label1;
    }
}
