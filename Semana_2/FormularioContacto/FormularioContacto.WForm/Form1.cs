using FormularioContacto.BLL;
using FormularioContacto.Entities;
using System.Data;
using System.Windows.Forms;

namespace FormularioContacto.WForm {
	public partial class Form1 : Form {
		private readonly IContactService _contactService;

		public Form1(IContactService contactService) {
			_contactService = contactService;
			InitializeComponent();
		}

		private void registrarToolStripMenuItem_Click(object sender, EventArgs e) {

			string message;

			try {
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
			DataTable contacts = _contactService.GetAll();
			DgvContacts.DataSource = contacts;

			DgvContacts.Columns[0].HeaderText = "Id del contacto";
			DgvContacts.Columns[1].HeaderText = "Nombre del contacto";
			DgvContacts.Columns[2].HeaderText = "Correo electrónico";
			DgvContacts.Columns[3].HeaderText = "Teléfono del contacto";

			Clean();
		}

		private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) {
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
			int row = DgvContacts.CurrentCell.RowIndex;

			txtContactId.Text = DgvContacts[0, row].Value.ToString();
			txtName.Text = DgvContacts[1, row].Value.ToString();
			txtEmail.Text = DgvContacts[2, row].Value.ToString();
			txtPhoneNumber.Text = DgvContacts[3, row].Value.ToString();
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e) {
			DataTable contacts = _contactService.Search(txtSearch.Text);
			DgvContacts.DataSource = contacts;
		}
	}
}
