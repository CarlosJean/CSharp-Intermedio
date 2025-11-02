using FormularioContacto.DAL.Contexts;
using FormularioContacto.DAL.Interfaces;
using FormularioContacto.Entities;

namespace FormularioContacto.DAL.Repositories {
	public class ContactsRepository : IContactsRepository {
		private readonly ApplicationDbContext _context;

		public ContactsRepository(ApplicationDbContext applicationDbContext) {
			_context = applicationDbContext;
		}

		public bool DeleteContact(int contactId) {
			var contact = _context.Contacts.Find(contactId);

			if (contact == null) {
				return false;
			}

			_context.Contacts.Remove(contact);
			_context.SaveChanges();

			return true;
		}

		public List<Contact> GetAll() {
			return _context.Contacts.ToList();
		}

		public bool ModifyContact(Contact contact) {


			var foundContact = _context.Contacts.Find(contact.ContactId);

			if (foundContact == null) {
				return false;
			}

			foundContact.Name = contact.Name;
			foundContact.Email = contact.Email;
			foundContact.PhoneNumber = contact.PhoneNumber;

			_context.SaveChanges();

			return true;
		}

		public bool SaveContact(Contact contact) {
			_context.Contacts.Add(contact);
			_context.SaveChanges();
			return true;
		}

		public List<Contact> Search(string text) {
			return _context.Contacts.Where(c => c.Name.Contains(text)).ToList();
		}
	}
}
