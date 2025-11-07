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

			try {
				return _context.Contacts.ToList();
			} catch (Exception) {

				throw;
			}
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

			try {
				_context.Contacts.Add(contact);
				_context.SaveChanges();
				return true;
			} catch (Exception ex) {
				throw;			
			}
		}

		public List<Contact> Search(string text) {
			try {
				return _context.Contacts.Where(c => c.Name.Contains(text)).ToList();
			} catch (Exception) {

				throw;
			}
		}
	}
}
