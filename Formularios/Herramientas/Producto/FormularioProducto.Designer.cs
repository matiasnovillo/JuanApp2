namespace JuanApp.Formularios.Herramientas.Producto
{
    partial class FormularioProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProducto));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreDeProducto = new TextBox();
            lblNombreDeProducto = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(664, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de producto";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 331);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(832, 26);
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
            toolStrip1.Size = new Size(832, 27);
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
            btnGuardar.Location = new Point(665, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 81);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            txtCodigoDeProducto.Location = new Point(12, 163);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(285, 34);
            txtCodigoDeProducto.TabIndex = 16;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Font = new Font("Segoe UI", 12F);
            lblCodigoDeProducto.ForeColor = SystemColors.Window;
            lblCodigoDeProducto.Location = new Point(12, 132);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(191, 28);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto";
            // 
            // txtNombreDeProducto
            // 
            txtNombreDeProducto.Font = new Font("Segoe UI", 12F);
            txtNombreDeProducto.Location = new Point(12, 242);
            txtNombreDeProducto.Name = "txtNombreDeProducto";
            txtNombreDeProducto.Size = new Size(285, 34);
            txtNombreDeProducto.TabIndex = 18;
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Font = new Font("Segoe UI", 12F);
            lblNombreDeProducto.ForeColor = SystemColors.Window;
            lblNombreDeProducto.Location = new Point(12, 211);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(199, 28);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Nombre de producto";
            // 
            // FormularioProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(832, 357);
            Controls.Add(txtNombreDeProducto);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            Name = "FormularioProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de productos";
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
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreDeProducto;
        private Label lblNombreDeProducto;
    }
}
