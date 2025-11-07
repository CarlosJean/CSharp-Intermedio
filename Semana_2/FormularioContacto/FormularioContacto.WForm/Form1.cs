using FormularioContacto.BLL;
using FormularioContacto.Entities;
using System.Data;
using System.Windows.Forms;

namespace FormularioContacto.WForm {
	public partial class Form1 : Form {
		private readonly IContactService _contactService;

		private bool formIsValid = false;

		public Form1(IContactService contactService) {
			_contactService = contactService;
			InitializeComponent();
		}

		private void registrarToolStripMenuItem_Click(object sender, EventArgs e) {

			string message;

			try {

				if (!formIsValid) {
					MessageBox.Show("El formulario no es válido, verifique y reintentelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return; 				
				}

				Contact contact = new() {
					Name = txtName.Text,
					Email = txtEmail.Text,
					PhoneNumber = txtPhoneNumber.Text,
				};
				message = _contactService.Save(contact);
				MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RefreshDataGrid();

			} catch (Exception ex) {
				message = ex.Message;
				MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			RefreshDataGrid();
		}

		private void modificarToolStripMenuItem_Click(object sender, EventArgs e) {

			string message;
			try {

				if (!formIsValid) {
					MessageBox.Show("El formulario no es válido, verifique y reintentelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult result = MessageBox.Show("¿Está seguro/a que desea modificar este contacto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes) {

					Contact contact = new() {
						ContactId = Convert.ToInt32(txtContactId.Text),
						Name = txtName.Text,
						Email = txtEmail.Text,
						PhoneNumber = txtPhoneNumber.Text,
					};

					message = _contactService.Update(contact);

					MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

					RefreshDataGrid();
				}
			} catch (Exception ex) {

				message = ex.Message;
				MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RefreshDataGrid() {

			try {
				DataTable contacts = _contactService.GetAll();
				DgvContacts.DataSource = contacts;

				DgvContacts.Columns[0].HeaderText = "Id del contacto";
				DgvContacts.Columns[1].HeaderText = "Nombre del contacto";
				DgvContacts.Columns[2].HeaderText = "Correo electrónico";
				DgvContacts.Columns[3].HeaderText = "Teléfono del contacto";

				Clean();
			} catch (Exception) {

				MessageBox.Show("Ocurrió un error, por favor reintentelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) {

			if (txtContactId.Text == string.Empty) return;

			DialogResult result = MessageBox.Show("¿Está seguro/a que desea remover el contacto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes) {			

				int contactId = Convert.ToInt32(txtContactId.Text);

				_contactService.Delete(contactId);

				MessageBox.Show("Contacto removido satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RefreshDataGrid();
			}
		}

		private void Clean() {
			txtContactId.Clear();
			txtName.Clear();
			txtEmail.Clear();
			txtPhoneNumber.Clear();
			txtSearch.Clear();
		}

		private void nuevoToolStripMenuItem_Click(object sender, EventArgs e) {
			Clean();
		}

		private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e) {

			try {
				int row = DgvContacts.CurrentCell.RowIndex;

				txtContactId.Text = DgvContacts[0, row].Value.ToString();
				txtName.Text = DgvContacts[1, row].Value.ToString();
				txtEmail.Text = DgvContacts[2, row].Value.ToString();
				txtPhoneNumber.Text = DgvContacts[3, row].Value.ToString();

			} catch (Exception) {

				MessageBox.Show("Ocurrió un error de sistema. Por favor reintentelo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e) {
			try {
				DataTable contacts = _contactService.Search(txtSearch.Text);
				DgvContacts.DataSource = contacts;

			} catch (Exception) {
				MessageBox.Show("Ocurrió un error de sistema. Por favor reintentelo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmContacts_Onvalidating(object sender, System.ComponentModel.CancelEventArgs e) {
			TextBox txt = (TextBox)sender;

			if (txt.Text != string.Empty) {
				this.formIsValid = true;
				return;
			}

			this.formIsValid = false;
			errorProvider1.SetError(txt, "Este campo es requerido, por favor rellenarlo.");
		}

		private void FrmContacts_Validated(object sender, EventArgs e) {
			this.formIsValid = true;
		}

	}
}