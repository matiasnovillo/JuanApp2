namespace JuanApp.Formularios.Entrada
{
    partial class FormularioGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGasto));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            label1 = new Label();
            txtDineroBanco = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            txtDineroCheque = new NumericUpDown();
            label5 = new Label();
            txtDineroEfectivo = new NumericUpDown();
            label6 = new Label();
            txtDineroTotal = new NumericUpDown();
            DateTimePickerFecha = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
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
            lblTitulo.Size = new Size(592, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de gastos";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 680);
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
            btnGuardar.Location = new Point(629, 590);
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
            label1.Location = new Point(12, 640);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 24;
            label1.Text = "(*) Requerido";
            // 
            // txtDineroBanco
            // 
            txtDineroBanco.Font = new Font("Segoe UI", 12F);
            txtDineroBanco.Location = new Point(29, 360);
            txtDineroBanco.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtDineroBanco.Name = "txtDineroBanco";
            txtDineroBanco.Size = new Size(307, 34);
            txtDineroBanco.TabIndex = 27;
            txtDineroBanco.KeyPress += txtDineroBanco_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 329);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 28;
            label3.Text = "Dinero en banco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 426);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 30;
            label4.Text = "Dinero en cheque";
            // 
            // txtDineroCheque
            // 
            txtDineroCheque.Font = new Font("Segoe UI", 12F);
            txtDineroCheque.Location = new Point(29, 457);
            txtDineroCheque.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtDineroCheque.Name = "txtDineroCheque";
            txtDineroCheque.Size = new Size(307, 34);
            txtDineroCheque.TabIndex = 29;
            txtDineroCheque.KeyPress += txtDineroCheque_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 516);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 32;
            label5.Text = "Dinero en efectivo";
            // 
            // txtDineroEfectivo
            // 
            txtDineroEfectivo.Font = new Font("Segoe UI", 12F);
            txtDineroEfectivo.Location = new Point(29, 547);
            txtDineroEfectivo.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtDineroEfectivo.Name = "txtDineroEfectivo";
            txtDineroEfectivo.Size = new Size(307, 34);
            txtDineroEfectivo.TabIndex = 31;
            txtDineroEfectivo.KeyPress += txtDineroEfectivo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(401, 146);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 34;
            label6.Text = "Dinero total";
            // 
            // txtDineroTotal
            // 
            txtDineroTotal.Font = new Font("Segoe UI", 12F);
            txtDineroTotal.Location = new Point(401, 177);
            txtDineroTotal.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtDineroTotal.Name = "txtDineroTotal";
            txtDineroTotal.Size = new Size(307, 34);
            txtDineroTotal.TabIndex = 33;
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerFecha.Location = new Point(29, 177);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(307, 34);
            DateTimePickerFecha.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 146);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 36;
            label2.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 242);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 37;
            label7.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(29, 273);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(307, 34);
            txtDescripcion.TabIndex = 38;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // FormularioGasto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(821, 706);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(DateTimePickerFecha);
            Controls.Add(label6);
            Controls.Add(txtDineroTotal);
            Controls.Add(label5);
            Controls.Add(txtDineroEfectivo);
            Controls.Add(label4);
            Controls.Add(txtDineroCheque);
            Controls.Add(label3);
            Controls.Add(txtDineroBanco);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            ForeColor = Color.Goldenrod;
            MaximizeBox = false;
            Name = "FormularioGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de gastos";
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
        private NumericUpDown txtDineroBanco;
        private Label label3;
        private Label label4;
        private NumericUpDown txtDineroCheque;
        private Label label5;
        private NumericUpDown txtDineroEfectivo;
        private Label label6;
        private NumericUpDown txtDineroTotal;
        private DateTimePicker DateTimePickerFecha;
        private Label label2;
        private Label label7;
        private TextBox txtDescripcion;
    }
}
