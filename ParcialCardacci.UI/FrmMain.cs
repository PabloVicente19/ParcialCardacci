using ParcialCardacci.UI.Dominio;

namespace ParcialCardacci.UI
{
    public partial class FrmMain : Form
    {
        private List<Cliente> _listaDeClientes;
        public FrmMain()
        {
            InitializeComponent();
            _listaDeClientes = new List<Cliente>();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            CargarDataGridViewConDatos(dgvClientes, _listaDeClientes);
        }


        // Funcionalidades de la UI
        private void SetearColumnasEnDataGridView(DataGridView dgv)
        {
            List<(string NombreDeLaColumna, string TextoCabecera, string recurso)> columnas = new()
            {
                ("ClienteId", "Codigo Cliente", "ClienteID"),
                ("Nombre", "Nombre", "Nombre"),
                ("Apellido", "Apellido", "Apellido"),
                ("Dni", "DNI", "Dni")
            };
        }
        private void CargarDataGridViewConDatos(DataGridView dgv, object datos)
        {
            if(dgv.Columns.Count == 0) SetearColumnasEnDataGridView(dgv);
            dgv.DataSource = null;
            dgv.DataSource = datos;
            dgv.ClearSelection();
        }




    }
}
