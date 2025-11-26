using EntradaDiario.BLL.Interfaces;

namespace EntradaDiario.WForm {
	public partial class Form1 : Form {
		private readonly IDiarioServicio _repositorio;
		private List<Entities.EntradaDiario> _entradas;

		public Form1(IDiarioServicio repositorio) {
			InitializeComponent();			
			_repositorio = repositorio;

			CargarEntradas();
		}

		private void CargarEntradas() {
			_entradas = _repositorio.ObtenerTodasLasEntradas();
			lstEntradas.DataSource = null;
			lstEntradas.DataSource = _entradas;
			lstEntradas.DisplayMember = "Titulo";
		}

		private void btnGuardar_Click(object sender, EventArgs e) {
			EntradaDiario.Entities.EntradaDiario nuevaEntrada = new() {

				Fecha = dtpFechaNueva.Value.Date,

				Titulo = txtTituloNuevo.Text,

				Contenido = txtContenidoNuevo.Text

			};

			_repositorio.AgregarEntrada(nuevaEntrada);

			MessageBox.Show("Entrada guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Limpiar los campos después de guardar

			dtpFechaNueva.Value = DateTime.Now.Date;

			txtTituloNuevo.Clear();

			txtContenidoNuevo.Clear();

			// Recargar la lista de entradas

			CargarEntradas();
		}

		private void lstEntradas_SelectedIndexChanged(object sender, EventArgs e) {
			// Cuando se selecciona un elemento en la lista, ocultar el detalle anterior
			txtDetalleEntrada.Visible = false;
			lblDetalle.Visible = false;
		}

		private void btnVerDetalle_Click(object sender, EventArgs e) {
			if (lstEntradas.SelectedItem != null) {

				EntradaDiario.Entities.EntradaDiario entradaSeleccionada = (EntradaDiario.Entities.EntradaDiario)lstEntradas.SelectedItem;

				EntradaDiario.Entities.EntradaDiario detalleEntrada = _repositorio.ObtenerEntradaPorId(entradaSeleccionada.Id);

				if (detalleEntrada != null) {

					lblDetalle.Visible = true;

					txtDetalleEntrada.Visible = true;

					txtDetalleEntrada.Text = detalleEntrada.Contenido;

				} else {

					MessageBox.Show("No se pudo cargar el detalle de la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			} else {

				MessageBox.Show("Por favor, selecciona una entrada para ver el detalle.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}
	}
}