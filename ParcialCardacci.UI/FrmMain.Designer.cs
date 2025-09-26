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
            gbDatosCliente = new GroupBox();
            label5 = new Label();
            txtValorCuota = new TextBox();
            cmbTipoCliente = new ComboBox();
            label4 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            btnGuardar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtValorMembresia = new TextBox();
            btnAsignarMembresia = new Button();
            label6 = new Label();
            txtCodigoMembresia = new TextBox();
            groupBox2 = new GroupBox();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            dgvClientes = new DataGridView();
            dgvMembresias = new DataGridView();
            btnEliminarMembresia = new Button();
            gbDatosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).BeginInit();
            SuspendLayout();
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
            gbDatosCliente.Controls.Add(btnGuardar);
            gbDatosCliente.Controls.Add(label2);
            gbDatosCliente.Controls.Add(txtNombre);
            gbDatosCliente.Controls.Add(label1);
            gbDatosCliente.ForeColor = Color.WhiteSmoke;
            gbDatosCliente.Location = new Point(12, 12);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(325, 223);
            gbDatosCliente.TabIndex = 1;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "Datos del Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 98);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor de Cuota";
            // 
            // txtValorCuota
            // 
            txtValorCuota.Location = new Point(197, 116);
            txtValorCuota.Name = "txtValorCuota";
            txtValorCuota.Size = new Size(100, 23);
            txtValorCuota.TabIndex = 9;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new Point(6, 170);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(291, 23);
            cmbTipoCliente.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 152);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
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
            // txtApellido
            // 
            txtApellido.Location = new Point(197, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(126, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 20);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Agregrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtValorMembresia);
            groupBox1.Controls.Add(btnAsignarMembresia);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCodigoMembresia);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(12, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 144);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Membresia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 73);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 15;
            label7.Text = "descuento";
            // 
            // txtValorMembresia
            // 
            txtValorMembresia.Location = new Point(6, 91);
            txtValorMembresia.Name = "txtValorMembresia";
            txtValorMembresia.Size = new Size(179, 23);
            txtValorMembresia.TabIndex = 14;
            // 
            // btnAsignarMembresia
            // 
            btnAsignarMembresia.ForeColor = Color.Black;
            btnAsignarMembresia.Location = new Point(197, 111);
            btnAsignarMembresia.Name = "btnAsignarMembresia";
            btnAsignarMembresia.Size = new Size(122, 27);
            btnAsignarMembresia.TabIndex = 13;
            btnAsignarMembresia.Text = "Asignar";
            btnAsignarMembresia.UseVisualStyleBackColor = true;
            btnAsignarMembresia.Click += btnAsignarMembresia_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 12;
            label6.Text = "CodigoMembresia";
            // 
            // txtCodigoMembresia
            // 
            txtCodigoMembresia.Location = new Point(6, 46);
            txtCodigoMembresia.Name = "txtCodigoMembresia";
            txtCodigoMembresia.Size = new Size(179, 23);
            txtCodigoMembresia.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(12, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 181);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Membresia";
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.ForeColor = Color.Black;
            btnModificarCliente.Location = new Point(343, 241);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(193, 43);
            btnModificarCliente.TabIndex = 13;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.ForeColor = Color.Black;
            btnEliminarCliente.Location = new Point(551, 241);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(193, 43);
            btnEliminarCliente.TabIndex = 14;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(343, 18);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(695, 217);
            dgvClientes.TabIndex = 0;
            // 
            // dgvMembresias
            // 
            dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresias.Location = new Point(343, 314);
            dgvMembresias.Name = "dgvMembresias";
            dgvMembresias.Size = new Size(695, 161);
            dgvMembresias.TabIndex = 15;
            // 
            // btnEliminarMembresia
            // 
            btnEliminarMembresia.ForeColor = Color.Black;
            btnEliminarMembresia.Location = new Point(343, 481);
            btnEliminarMembresia.Name = "btnEliminarMembresia";
            btnEliminarMembresia.Size = new Size(193, 43);
            btnEliminarMembresia.TabIndex = 16;
            btnEliminarMembresia.Text = "Eliminar";
            btnEliminarMembresia.UseVisualStyleBackColor = true;
            btnEliminarMembresia.Click += btnEliminarMembresia_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1050, 755);
            Controls.Add(btnEliminarMembresia);
            Controls.Add(dgvMembresias);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbDatosCliente);
            Controls.Add(dgvClientes);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Label label6;
        private TextBox txtCodigoMembresia;
        private DataGridView dgvClientes;
        private DataGridView dgvMembresias;
        private Button btnAsignarMembresia;
        private Label label7;
        private TextBox txtValorMembresia;
        private Button btnEliminarMembresia;
    }
}
