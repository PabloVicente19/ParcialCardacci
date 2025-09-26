namespace ParcialCardacci.UI
{
    partial class FrmMain
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
            dgvClientes = new DataGridView();
            gbDatosCliente = new GroupBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbTipoCliente = new ComboBox();
            txtValorCuota = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(343, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(695, 217);
            dgvClientes.TabIndex = 0;
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.Controls.Add(label5);
            gbDatosCliente.Controls.Add(txtValorCuota);
            gbDatosCliente.Controls.Add(cmbTipoCliente);
            gbDatosCliente.Controls.Add(label4);
            gbDatosCliente.Controls.Add(txtDni);
            gbDatosCliente.Controls.Add(label3);
            gbDatosCliente.Controls.Add(txtApellido);
            gbDatosCliente.Controls.Add(label2);
            gbDatosCliente.Controls.Add(txtNombre);
            gbDatosCliente.Controls.Add(label1);
            gbDatosCliente.Controls.Add(btnGuardar);
            gbDatosCliente.ForeColor = Color.WhiteSmoke;
            gbDatosCliente.Location = new Point(12, 12);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(325, 433);
            gbDatosCliente.TabIndex = 1;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "Datos del Cliente";
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(65, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 43);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Agregrar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(197, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 39);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(6, 116);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(6, 181);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(291, 23);
            cmbTipoCliente.TabIndex = 8;
            // 
            // txtValorCuota
            // 
            txtValorCuota.Location = new Point(6, 240);
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.Size = new Size(100, 23);
            txtValorCuota.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 222);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor de Cuota";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1050, 755);
            Controls.Add(gbDatosCliente);
            Controls.Add(dgvClientes);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private GroupBox gbDatosCliente;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private Label label5;
        private TextBox txtValorCuota;
        private ComboBox cmbTipoCliente;
        private Label label4;
    }
}
