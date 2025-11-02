using FormularioContacto.Entities;
using System.Data;

namespace FormularioContacto.BLL {
	public interface IContactService {
		string Save(Contact contact);
		string Update(Contact contact);
		DataTable GetAll();
		string Delete(int contactId);
		DataTable Search(string text);
	}
}