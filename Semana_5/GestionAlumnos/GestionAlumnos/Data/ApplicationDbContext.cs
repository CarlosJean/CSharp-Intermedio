using GestionAlumnos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionAlumnos.Data {
	public class ApplicationDbContext : DbContext {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
			
		}

		public DbSet<Alumno> Alumnos { get; set; }
		public DbSet<Carrera> Carreras { get; set; }
	}
}
