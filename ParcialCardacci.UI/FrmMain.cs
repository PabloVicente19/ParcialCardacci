using ParcialCardacci.UI.Dominio;

namespace ParcialCardacci.UI
{
    public partial class FrmMain : Form
    {
        private List<Cliente> _listaDeClientes;
        private List<Membresia> _listaDeMembresias;
        private Cliente _cliente;
        private string[] _tiposDeClientes = { "Principiante", "Intermedio", "Avanzado" };

        public FrmMain()
        {
            InitializeComponent();
            _listaDeClientes = new List<Cliente>();
            _listaDeMembresias = new List<Membresia>();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            CargarComboBoxConDatos(cmbTipoCliente, _tiposDeClientes);
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            _cliente = ObtenerClienteSeleccionado();
            CargarDatosDelCliente(ObtenerClienteSeleccionado());
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            _cliente = ObtenerClienteSeleccionado();
            EliminarCliente(_cliente);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (_cliente == null || _cliente.ClienteId == 0)
            {
                AgregarNuevoCliente();
                LimpiarCamposDeTexto();
            }
            else
            {
                ModificarCliente(_cliente);
                LimpiarCamposDeTexto();
            }
        }
        private void btnAsignarMembresia_Click(object sender, EventArgs e)
        {
            _cliente = ObtenerClienteSeleccionado();
            AsignarMembresia();
        }
        private void btnEliminarMembresia_Click(object sender, EventArgs e)
        {
            EliminarMembresia(ObtenerMembresiaSeleccionada());
        }



        // Funcionalidades de UI
        private void SetearColumnasEnDataGridView(DataGridView dgv)
        {
            DataGridViewTextBoxColumn[] columnas = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() { Name = "ClienteId", HeaderText = "Codigo Cliente", DataPropertyName = "ClienteId", ReadOnly = true },
                new DataGridViewTextBoxColumn() { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre", ReadOnly = true },
                new DataGridViewTextBoxColumn() { Name = "Apellido", HeaderText = "Apellido", DataPropertyName = "Apellido", ReadOnly = true },
                new DataGridViewTextBoxColumn() { Name = "Dni", HeaderText = "DNI", DataPropertyName = "Dni", ReadOnly = true },
                new DataGridViewTextBoxColumn() { Name = "Cuota", HeaderText = "Cuota", DataPropertyName = "Cuota", ReadOnly = true }
            };
            dgv.Columns.AddRange(columnas);
        }
        private void CargarDataGridViewConDatos(DataGridView dgv, object datos)
        {
            dgv.AutoGenerateColumns = false;
            if (dgv.Columns.Count == 0) SetearColumnasEnDataGridView(dgv);
            dgv.DataSource = null;
            dgv.DataSource = datos;
            //dgv.ClearSelection();
        }
        private void CargarComboBoxConDatos(ComboBox cmb, string[] datos)
        {
            cmb.DataSource = null;
            cmb.DataSource = datos;
            cmb.SelectedIndex = 0;
        }
        private void LimpiarCamposDeTexto()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            cmbTipoCliente.SelectedIndex = 0;
        }
        private void CargarDatosDelCliente(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDni.Text = cliente.Dni;
        }
        private bool EsFilaSeleccionada(DataGridView dgv) => dgv.CurrentRow != null;
        private Cliente ObtenerClienteSeleccionado()
        {
            if (!EsFilaSeleccionada(dgvClientes)) return null;
            return dgvClientes.CurrentRow.DataBoundItem as Cliente;
        }
        private Membresia ObtenerMembresiaSeleccionada()
        {
            if (!EsFilaSeleccionada(dgvMembresias)) return null;
            return dgvMembresias.CurrentRow.DataBoundItem as Membresia;
        }

        // Funcionalidades de Cliente
        private Cliente GenerarNuevoCliente()
        {
            _cliente = GenerarTipoDeCliente();
            _cliente.Nombre = txtNombre.Text;
            _cliente.Apellido = txtApellido.Text;
            _cliente.Dni = txtDni.Text;
            _cliente.Cuota = double.Parse(txtValorCuota.Text);
            return _cliente;
        }
        private Cliente ModificarDatosDeCliente(Cliente cliente)
        {
            Cliente clienteSeleccionado = _listaDeClientes.Find(cliente => cliente.ClienteId == cliente.ClienteId);
            clienteSeleccionado.Nombre = txtNombre.Text;
            clienteSeleccionado.Apellido = txtApellido.Text;
            clienteSeleccionado.Dni = txtDni.Text;
            return clienteSeleccionado;
        }
        private Cliente GenerarTipoDeCliente()
        {
            int index = cmbTipoCliente.SelectedIndex;
            if (index == 0) return new ClientePrincipiante();
            else if (index == 1) return new ClienteIntermedio();
            else if (index == 2) return new ClienteAvanzado();
            return null;
        }
        private void AgregarNuevoCliente()
        {
            _cliente = GenerarNuevoCliente();
            _listaDeClientes.Add(_cliente);
            CargarDataGridViewConDatos(dgvClientes, _listaDeClientes);
            _cliente = null;
        }
        private void ModificarCliente(Cliente clienteSeleccionado)
        {
            _cliente = ModificarDatosDeCliente(clienteSeleccionado);
            CargarDataGridViewConDatos(dgvClientes, _listaDeClientes);
            _cliente = null;
        }
        private void EliminarCliente(Cliente clienteSeleccionado)
        {
            if (clienteSeleccionado == null) return;
            _listaDeClientes.Remove(clienteSeleccionado);
            CargarDataGridViewConDatos(dgvClientes, _listaDeClientes);
            _cliente = null;
        }

        // Funcionalidades de Membresia
        private Membresia GenerarMembresia()
        {
            string codigoMembresia = txtCodigoMembresia.Text;
            short descuento = short.Parse(txtValorMembresia.Text);
            DateTime fechaInicio = DateTime.Now.Date;

            Membresia membresia = new Membresia(codigoMembresia, descuento, fechaInicio);
            return membresia;
        }
        private void AsignarMembresia()
        {
            Membresia membresia = GenerarMembresia();
            _cliente.AsignarMembresia(membresia);
            _listaDeMembresias.Add(membresia);
            dgvMembresias.DataSource = null;
            dgvMembresias.DataSource = _listaDeMembresias;
        }
        private void EliminarMembresia(Membresia membresiaSeleccionada)
        {
            Membresia membresia = _listaDeMembresias.Find(membresia => membresia.Codigo == membresiaSeleccionada.Codigo);
            if (membresia == null) return;
            _cliente.EliminarMembresia();
            _listaDeMembresias.Remove(membresia);
            dgvMembresias.DataSource = null;
            dgvMembresias.DataSource = _listaDeMembresias;
        }

        // Validaciones
        private bool EsMembresiaValida(string codigoMembresia)
        {
            if (string.IsNullOrEmpty(codigoMembresia) || codigoMembresia.Length < 15)
                return false;
            if (!char.IsLetter(codigoMembresia[0]) || !char.IsLetter(codigoMembresia[1]))
                return false;
            if (!char.IsDigit(codigoMembresia[2]) || !char.IsLetter(codigoMembresia[3]))
                return false;
            if (codigoMembresia[4] != '_')
                return false;
            string fecha = codigoMembresia.Substring(5, 10);

            if (!DateTime.TryParseExact(
                fecha,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime fechaValida))
                return false;

            return fechaValida.Date == DateTime.Now.Date;
        }

        
    }
}
