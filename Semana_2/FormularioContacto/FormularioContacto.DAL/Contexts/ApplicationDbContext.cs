
using FormularioContacto.Entities;
using Microsoft.EntityFrameworkCore;

namespace FormularioContacto.DAL.Contexts {
	public class ApplicationDbContext : DbContext{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
		
		}

		public DbSet<Contact> Contacts { get; set; }
	}
}