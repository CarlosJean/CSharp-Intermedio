using FormularioContacto.Entities;

namespace FormularioContacto.DAL.Interfaces {
	public interface IContactsRepository {
		bool SaveContact(Contact contact);
		bool ModifyContact(Contact contact);
		List<Contact> GetAll();
		bool DeleteContact(int contactId);
		List<Contact> Search(string text);
	}
}