using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrefijoTelefono {
	public partial class Form1 : Form {

		private string connectionString = "Data Source=JEAN_HOLGUIN;Initial Catalog=PrefijoTelefono;Integrated Security=True";

		public Form1() {
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = true;
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Opcional: Cargar datos al iniciar el formulario
			CargarDatosContactos();
		}

		private void CargarDatosContactos(string prefijoTelefono = null) {
			// Usamos 'using' para asegurar que los recursos (conexión, comando, lector) se cierren y liberen correctamente.
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				try {
					connection.Open(); // Abrir la conexión a la base de datos

					// Crear un comando para ejecutar el procedimiento almacenado
					using (SqlCommand command = new SqlCommand("sprodObtenerTlfno", connection)) {
						command.CommandType = CommandType.StoredProcedure; // Indicar que es un procedimiento almacenado

						// Si se proporciona un prefijo, añadirlo como parámetro al procedimiento almacenado
						if (prefijoTelefono != null) {
							command.Parameters.AddWithValue("@prefijo", prefijoTelefono);
						} else {
							// Si no hay prefijo, el procedimiento almacenado usará su valor por defecto (NULL)
							// o puedes añadir un parámetro DBNull.Value explícitamente:
							command.Parameters.AddWithValue("@prefijo", DBNull.Value);
						}

						// Crear un adaptador de datos para llenar un DataTable
						using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
							DataTable dataTable = new DataTable(); // Crear una tabla de datos
							adapter.Fill(dataTable); // Llenar la tabla de datos con los resultados del comando

							// Asignar la tabla de datos como la fuente de datos del DataGridView
							dataGridView1.DataSource = dataTable;
						}
					}
				} catch (Exception ex) {
					// Manejo de errores: Mostrar un mensaje al usuario si algo sale mal
					MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Evento Click del botón "Cargar Contactos" (asegúrate de tener un botón llamado 'btnCargarContactos' en tu formulario)
		private void btnCargarContactos_Click(object sender, EventArgs e) {
			CargarDatosContactos(); // Llamar al método para cargar todos los contactos
		}

		// Evento Click del botón "Buscar por Prefijo" (asegúrate de tener un botón llamado 'btnBuscarPrefijo' y un TextBox 'txtPrefijo' en tu formulario)
		private void btnBuscarPrefijo_Click(object sender, EventArgs e) {
			// Obtener el prefijo del TextBox
			string prefijo = txtPrefijo.Text.Trim();
			CargarDatosContactos(prefijo); // Cargar contactos filtrados por el prefijo
		}
	}
}
