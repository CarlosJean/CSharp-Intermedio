using FormularioContacto.DAL.Interfaces;
using FormularioContacto.Entities;
using System.Data;

namespace FormularioContacto.BLL {
	public class ContactsService : IContactService {
		private readonly IContactsRepository _contactsRepository;

		public ContactsService(IContactsRepository contactsRepository) {
			_contactsRepository = contactsRepository;
		}

		public string Delete(int contactId) {
			try {
				_contactsRepository.DeleteContact(contactId);

				return "Contacto removido satisfactoriamente.";

			} catch (Exception) {

				throw;
			}
		}

		public DataTable GetAll() {
			List<Contact> contacts = _contactsRepository.GetAll();

			DataTable dtContacts = new DataTable();

			dtContacts.Columns.Add(new DataColumn { 
				ColumnName = "ID",
			});
			dtContacts.Columns.Add(new DataColumn { 
				ColumnName = "Name",
			});
			dtContacts.Columns.Add(new DataColumn { 
				ColumnName = "Email",
			});
			dtContacts.Columns.Add(new DataColumn { 
				ColumnName = "PhoneNumber",
			});

			

			foreach (var contact in contacts) {
				var row = dtContacts.NewRow();

				row["ID"] = contact.ContactId;
				row["Name"] = contact.Name;
				row["Email"] = contact.Email;
				row["PhoneNumber"] = contact.PhoneNumber;

				dtContacts.Rows.Add(row);
			}

			return dtContacts;
		}

		public string Save(Contact contact) {
			bool contactSaved = _contactsRepository.SaveContact(contact);

			if (!contactSaved) throw new Exception("Ocurrió un error al intentar guardar el contacto.");

			return "Contacto guardado satisfactoriamente.";
		}

		public DataTable Search(string text) {
			List<Contact> contacts = _contactsRepository.Search(text);

			DataTable dtContacts = new DataTable();

			dtContacts.Columns.Add(new DataColumn {
				ColumnName = "ID",
				Caption = "Id del contacto",
			});
			dtContacts.Columns.Add(new DataColumn {
				ColumnName = "Name",
				Caption = "Nombre del contacto",
			});
			dtContacts.Columns.Add(new DataColumn {
				ColumnName = "Email",
				Caption = "Correo Electrónico",
			});
			dtContacts.Columns.Add(new DataColumn {
				ColumnName = "PhoneNumber",
				Caption = "Teléfono",
			});

			foreach (var contact in contacts) {
				var row = dtContacts.NewRow();

				row["ID"] = contact.ContactId;
				row["Name"] = contact.Name;
				row["Email"] = contact.Email;
				row["PhoneNumber"] = contact.PhoneNumber;

				dtContacts.Rows.Add(row);
			}

			return dtContacts;
		}

		public string Update(Contact contact) {
			bool contactUpdated = _contactsRepository.ModifyContact(contact);

			if (!contactUpdated) throw new Exception("Ocurrió un error al intentar modificar el contacto.");

			return "Contacto actualizado satisfactoriamente.";
		}
	}
}
