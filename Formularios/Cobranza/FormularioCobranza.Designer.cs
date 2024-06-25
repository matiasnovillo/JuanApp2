namespace JuanApp2.Formularios.Cobranza
{
    partial class FormularioCobranza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCobranza));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            label1 = new Label();
            cmbCobrador = new ComboBox();
            label2 = new Label();
            txtDineroBanco = new NumericUpDown();
            lblDineroBanco = new Label();
            lblDineroCheque = new Label();
            txtDineroCheque = new NumericUpDown();
            lblDineroEfectivo = new Label();
            txtDineroEfectivo = new NumericUpDown();
            lblDineroTotal = new Label();
            txtDineroTotal = new NumericUpDown();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDineroBanco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroCheque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroEfectivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroTotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(663, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de cobranza";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 596);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(736, 26);
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
            toolStrip1.Size = new Size(736, 27);
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
            btnGuardar.Location = new Point(528, 500);
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
            label1.Location = new Point(12, 550);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 24;
            label1.Text = "(*) Requerido";
            // 
            // cmbCobrador
            // 
            cmbCobrador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCobrador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCobrador.FormattingEnabled = true;
            cmbCobrador.Location = new Point(29, 177);
            cmbCobrador.Name = "cmbCobrador";
            cmbCobrador.Size = new Size(307, 36);
            cmbCobrador.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 146);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 26;
            label2.Text = "Cobrador *";
            // 
            // txtDineroBanco
            // 
            txtDineroBanco.DecimalPlaces = 2;
            txtDineroBanco.Font = new Font("Segoe UI", 12F);
            txtDineroBanco.Location = new Point(29, 271);
            txtDineroBanco.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            txtDineroBanco.Name = "txtDineroBanco";
            txtDineroBanco.Size = new Size(307, 34);
            txtDineroBanco.TabIndex = 27;
            txtDineroBanco.KeyPress += txtDineroBanco_KeyPress;
            // 
            // lblDineroBanco
            // 
            lblDineroBanco.AutoSize = true;
            lblDineroBanco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDineroBanco.ForeColor = Color.White;
            lblDineroBanco.Location = new Point(29, 240);
            lblDineroBanco.Name = "lblDineroBanco";
            lblDineroBanco.Size = new Size(156, 28);
            lblDineroBanco.TabIndex = 28;
            lblDineroBanco.Text = "Dinero en banco";
            // 
            // lblDineroCheque
            // 
            lblDineroCheque.AutoSize = true;
            lblDineroCheque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDineroCheque.ForeColor = Color.White;
            lblDineroCheque.Location = new Point(29, 337);
            lblDineroCheque.Name = "lblDineroCheque";
            lblDineroCheque.Size = new Size(165, 28);
            lblDineroCheque.TabIndex = 30;
            lblDineroCheque.Text = "Dinero en cheque";
            // 
            // txtDineroCheque
            // 
            txtDineroCheque.DecimalPlaces = 2;
            txtDineroCheque.Font = new Font("Segoe UI", 12F);
            txtDineroCheque.Location = new Point(29, 368);
            txtDineroCheque.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            txtDineroCheque.Name = "txtDineroCheque";
            txtDineroCheque.Size = new Size(307, 34);
            txtDineroCheque.TabIndex = 29;
            txtDineroCheque.KeyPress += txtDineroCheque_KeyPress;
            // 
            // lblDineroEfectivo
            // 
            lblDineroEfectivo.AutoSize = true;
            lblDineroEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDineroEfectivo.ForeColor = Color.White;
            lblDineroEfectivo.Location = new Point(29, 427);
            lblDineroEfectivo.Name = "lblDineroEfectivo";
            lblDineroEfectivo.Size = new Size(171, 28);
            lblDineroEfectivo.TabIndex = 32;
            lblDineroEfectivo.Text = "Dinero en efectivo";
            // 
            // txtDineroEfectivo
            // 
            txtDineroEfectivo.DecimalPlaces = 2;
            txtDineroEfectivo.Font = new Font("Segoe UI", 12F);
            txtDineroEfectivo.Location = new Point(29, 458);
            txtDineroEfectivo.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            txtDineroEfectivo.Name = "txtDineroEfectivo";
            txtDineroEfectivo.Size = new Size(307, 34);
            txtDineroEfectivo.TabIndex = 31;
            txtDineroEfectivo.KeyPress += txtDineroEfectivo_KeyPress;
            // 
            // lblDineroTotal
            // 
            lblDineroTotal.AutoSize = true;
            lblDineroTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDineroTotal.ForeColor = Color.White;
            lblDineroTotal.Location = new Point(401, 146);
            lblDineroTotal.Name = "lblDineroTotal";
            lblDineroTotal.Size = new Size(117, 28);
            lblDineroTotal.TabIndex = 34;
            lblDineroTotal.Text = "Dinero total";
            // 
            // txtDineroTotal
            // 
            txtDineroTotal.DecimalPlaces = 2;
            txtDineroTotal.Font = new Font("Segoe UI", 12F);
            txtDineroTotal.Location = new Point(401, 177);
            txtDineroTotal.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            txtDineroTotal.Name = "txtDineroTotal";
            txtDineroTotal.Size = new Size(307, 34);
            txtDineroTotal.TabIndex = 33;
            // 
            // FormularioCobranza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(736, 622);
            Controls.Add(lblDineroTotal);
            Controls.Add(txtDineroTotal);
            Controls.Add(lblDineroEfectivo);
            Controls.Add(txtDineroEfectivo);
            Controls.Add(lblDineroCheque);
            Controls.Add(txtDineroCheque);
            Controls.Add(lblDineroBanco);
            Controls.Add(txtDineroBanco);
            Controls.Add(label2);
            Controls.Add(cmbCobrador);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            MaximizeBox = false;
            Name = "FormularioCobranza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de cobranza";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDineroBanco).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroCheque).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroEfectivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDineroTotal).EndInit();
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
        private ComboBox cmbCobrador;
        private Label label2;
        private NumericUpDown txtDineroBanco;
        private Label lblDineroBanco;
        private Label lblDineroCheque;
        private NumericUpDown txtDineroCheque;
        private Label lblDineroEfectivo;
        private NumericUpDown txtDineroEfectivo;
        private Label lblDineroTotal;
        private NumericUpDown txtDineroTotal;
    }
}
